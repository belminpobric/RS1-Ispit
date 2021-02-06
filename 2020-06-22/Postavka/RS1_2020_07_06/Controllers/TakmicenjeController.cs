using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1_2020_07_06.EntityModels;
using RS1_2020_07_06.ViewModels;
using RS1_Ispit_asp.net_core.EF;

namespace RS1_2020_07_06.Controllers
{
    public class TakmicenjeController : Controller
    {
        private readonly MojContext _context;

        public TakmicenjeController(MojContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PrikazSkolaVM vm = new PrikazSkolaVM
            {
                Skola = _context.Skola.Select(x => new SelectListItem
                {
                    Text = x.Naziv,
                    Value = x.Id.ToString()
                }).ToList()
            };
            return View(vm);
        }
        public IActionResult PrikazTakmicenja(PrikazSkolaVM prikazSkolaVM)
        {
            PrikazTakmicenjaVM vm = new PrikazTakmicenjaVM
            {
                SkolaID = prikazSkolaVM.SkolaID,
                Rows = _context.Takmicenje.Where(x => x.SkolaID == prikazSkolaVM.SkolaID).Select(i => new PrikazTakmicenjaVM.Row
                {
                    Datum = i.Datum,
                    Predmet = i.Predmet.Naziv,
                    Razred = i.Razred,
                    Skola = i.Skola.Naziv,
                    TakmicenjeID = i.Id
                }).ToList()
            };
            foreach(var row in vm.Rows)
            {
                var najbolji = _context.TakmicenjeUcesnik.Include(x => x.OdjeljenjeStavka.Ucenik)
                    .Include(x => x.OdjeljenjeStavka.Odjeljenje)
                    .Include(x => x.OdjeljenjeStavka.Odjeljenje.Skola)
                    .OrderByDescending(x => x.Bodovi)
                    .Where(x => x.TakmicenjeID == row.TakmicenjeID && x.IsPristupio == true)
                    .FirstOrDefault();
                if(najbolji != null)
                {
                    row.NajboljiUcesnik = najbolji.OdjeljenjeStavka.Odjeljenje.Skola.Naziv + "|" + najbolji.OdjeljenjeStavka.Odjeljenje.Oznaka + "|" + najbolji.OdjeljenjeStavka.Ucenik.ImePrezime;
                }
            }
            return PartialView("PrikazTakmicenja",vm);
        }
        public IActionResult Dodaj(int id)
        {
            DodajTakmicenjeVM vm = new DodajTakmicenjeVM
            {
                Predmet = _context.Predmet.GroupBy(x=>x.Naziv).Select(i=>i.First()).Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Naziv
                }).ToList(),
                Skola = _context.Skola.Where(x => x.Id == id).Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Naziv
                }).ToList(),
                Datum = DateTime.Today
            };
            return View(vm);
        }
        public IActionResult Snimi(DodajTakmicenjeVM dodajTakmicenjeVM)
        {
            Takmicenje tak = new Takmicenje
            {
                Datum = dodajTakmicenjeVM.Datum,
                IsZakljucano = false,
                PredmetID = dodajTakmicenjeVM.PredmetID,
                SkolaID = dodajTakmicenjeVM.SkolaID,
                Razred = _context.Predmet.Where(x=>x.Id==dodajTakmicenjeVM.PredmetID).Select(x=>x.Razred).FirstOrDefault()
            };
            _context.Add(tak);
            _context.SaveChanges();
            var ucenici = _context.DodjeljenPredmet.Where(x => x.PredmetId == dodajTakmicenjeVM.PredmetID && x.ZakljucnoKrajGodine == 5).Select(x => new TakmicenjeUcesnik
            {
                OdjeljenjeStavkaID = x.OdjeljenjeStavkaId,
                Bodovi = 0,
                IsPristupio = false,
                TakmicenjeID = tak.Id,
            }).ToList();
            foreach(var item in ucenici)
            {
                bool flag = _context.DodjeljenPredmet
                    .Where
                    (
                        i => i.OdjeljenjeStavkaId == item.OdjeljenjeStavkaID &&
                             i.OdjeljenjeStavka.Odjeljenje.Razred == tak.Razred
                    )
                    .Select
                    (
                        i => i.ZakljucnoKrajGodine
                    )
                    .Average() > 4;
                if (flag)
                {
                    var noviTakmicar = new TakmicenjeUcesnik()
                    {
                        TakmicenjeID = tak.Id,
                        IsPristupio = false,
                        Bodovi = 0,
                        OdjeljenjeStavkaID = item.OdjeljenjeStavkaID
                    };
                    _context.Add(noviTakmicar);
                    _context.SaveChanges();
                }

            }
            return Redirect("Index");
        }
        public IActionResult Rezultati(int id)
        {
            var takmicenje = _context.Takmicenje.Include(x=>x.Predmet).Include(x=>x.Skola).Where(x=>x.Id==id).Select(x=> new Takmicenje 
            { 
                SkolaID = x.SkolaID,
                Skola = x.Skola,
                Predmet = x.Predmet,
                Id = x.Id,
                Datum = x.Datum,
                IsZakljucano = x.IsZakljucano,
                PredmetID = x.PredmetID,
                Razred = x.Razred
            });
            RezultatiTakmicenjaVM vm = new RezultatiTakmicenjaVM
            {
                Datum = takmicenje.Select(x => x.Datum).FirstOrDefault(),
                Razred = takmicenje.Select(x => x.Razred).FirstOrDefault(),
                Predmet = takmicenje.Select(x => x.Predmet.Naziv).FirstOrDefault(),
                SkolaDomacin = takmicenje.Select(x => x.Skola.Naziv).FirstOrDefault(),
                SkolaID = takmicenje.Select(x => x.SkolaID).FirstOrDefault(),
                TakmicenjeID = id,
                Rows = _context.TakmicenjeUcesnik.Where(x => x.TakmicenjeID == id).Select(x => new RezultatiTakmicenjaVM.Row
                {
                    bodovi = x.Bodovi,
                    TakmicenjeID = id,
                    BrojUdnevniku = x.OdjeljenjeStavka.BrojUDnevniku,
                    IsPristupio = x.IsPristupio,
                    Odjeljenje = x.OdjeljenjeStavka.Odjeljenje.Oznaka,
                    UcesnikID = x.Id
                }).ToList()
            };
            return View(vm);
        }
        public IActionResult Pristupio(int id)
        {
            var ucesnik = _context.TakmicenjeUcesnik.Find(id);
            ucesnik.IsPristupio = !ucesnik.IsPristupio;
            _context.SaveChanges();
            return Redirect("/Takmicenje/Rezultati/"+ucesnik.TakmicenjeID);
        }
        public IActionResult DodajUcesnika(int id)
        {
            DodajUcesnikaVM vm = new DodajUcesnikaVM
            {
                Bodovi = _context.TakmicenjeUcesnik.Select(x => x.Bodovi).FirstOrDefault(),
                TakmicenjeID = id,
                Ucesnik = _context.TakmicenjeUcesnik.Select(x => new SelectListItem
                {
                    Text = x.OdjeljenjeStavka.Odjeljenje.Oznaka + "-" + x.OdjeljenjeStavka.Ucenik.ImePrezime + "-" + x.OdjeljenjeStavka.BrojUDnevniku,
                    Value = x.Id.ToString()
                }).ToList()
            };
            return PartialView("DodajUcesnika",vm);
        }
        public IActionResult SnimiUcesnika(DodajUcesnikaVM vm)
        {
            TakmicenjeUcesnik takmicenjeUcesnik = new TakmicenjeUcesnik
            {
                Bodovi = vm.Bodovi,
                IsPristupio = false,
                OdjeljenjeStavkaID = vm.UcesnikID,
                TakmicenjeID = vm.TakmicenjeID
            };
            _context.Add(takmicenjeUcesnik);
            _context.SaveChanges();
            return Redirect("/Takmicenje/Rezultati/"+vm.TakmicenjeID);
        }
    }
}
