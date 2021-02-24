using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1_2020_01_30.EF;
using RS1_2020_01_30.EntityModels;
using RS1_2020_01_30.ViewModels;

namespace RS1_2020_01_30.Controllers
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
            SkolePrikazVM vm = new SkolePrikazVM
            {
                Razred = _context.Odjeljenje.Select(x => new SelectListItem
                {
                    Text = x.Razred.ToString(),
                    Value = x.Razred.ToString()
                }).Distinct().ToList(),
                SkolaDomacin = _context.Skola.Select(x=> new SelectListItem
                {
                    Text = x.Naziv,
                    Value = x.Id.ToString()
                }).ToList()
            };
            return View(vm);
        }
        public IActionResult Odaberi(SkolePrikazVM skolePrikazVM)
        {

            TakmicenjePrikazVM vm = new TakmicenjePrikazVM
            {
                Rows = _context.Takmicenje.Where(x => x.SkolaID == skolePrikazVM.SkolaID).Select(i => new TakmicenjePrikazVM.Row
                {
                    BrojUcesnikaKojiNisuPristupili = _context.takmicenjeStavka.Where(c => c.TakmicenjeID == i.Id && c.IsPristupio == false).Count(),
                    Razred = i.Razred,
                    Datum = i.Datum,
                    Predmet = i.Predmet.Naziv,
                    TakmicenjeID = i.Id
                }).ToList(),
                Razred = skolePrikazVM.RazredID,
                Skola = _context.Skola.Where(x=>x.Id==skolePrikazVM.SkolaID).Select(i=>i.Naziv).FirstOrDefault(),
                SkolaID = skolePrikazVM.SkolaID
            };
            foreach(var item in vm.Rows)
            {
                var najucesnici = _context.takmicenjeStavka.Include(x => x.OdjeljenjeStavka.Odjeljenje)
                    .Include(i => i.OdjeljenjeStavka.Odjeljenje.Skola).Include(c => c.OdjeljenjeStavka.Ucenik).OrderByDescending(i => i.Bodovi).Where(x => x.TakmicenjeID == item.TakmicenjeID && x.IsPristupio == true).FirstOrDefault();
                if (najucesnici != null)
                {
                    item.NajUcesnik = najucesnici.OdjeljenjeStavka.Odjeljenje.Skola.Naziv + " " + najucesnici.OdjeljenjeStavka.Odjeljenje.Oznaka + " " + najucesnici.OdjeljenjeStavka.Ucenik.ImePrezime;
                }
            }
            return View(vm);
        }
        public IActionResult Dodaj(int id)
        {
            TakmicenjeDodajVM vm = new TakmicenjeDodajVM
            {
                Datum = DateTime.Today,
                Predmet = _context.Predmet.GroupBy(i=>i.Naziv).Select(a=>a.First()).Select(x => new SelectListItem
                {
                    Text = x.Naziv,
                    Value = x.Id.ToString()
                }).ToList(),
                Razred = _context.Odjeljenje.Select(x => new SelectListItem
                {
                    Text = x.Razred.ToString(),
                    Value = x.Razred.ToString()
                }).Distinct().ToList(),
                SkolaDomacin = _context.Skola.Where(x=>x.Id == id).Select(x=>x.Naziv).FirstOrDefault(),
                SkolaID = id
            };
            return View(vm);
        }
        public IActionResult Snimi(TakmicenjeDodajVM takmicenjeDodajVM)
        {
            Takmicenje tak = new Takmicenje
            {
                Datum = takmicenjeDodajVM.Datum,
                IsZakljucano = false,
                PredmetID = takmicenjeDodajVM.PredmetID,
                Razred = takmicenjeDodajVM.RazredID,
                SkolaID = takmicenjeDodajVM.SkolaID
            };
            _context.Add(tak);
            _context.SaveChanges();

            //var ucesnici = _context.DodjeljenPredmet.Include(i=>i.OdjeljenjeStavka).Include(i=>i.OdjeljenjeStavka.Odjeljenje).Where(x => x.ZakljucnoKrajGodine == 5).Select(i => new TakmicenjeStavka
            //{
            //    OdjeljenjeStavkaID = i.OdjeljenjeStavkaId,
            //    IsPristupio = false,
            //    Bodovi = 0,
            //    OdjeljenjeStavka = i.OdjeljenjeStavka
            //}).ToList();

            var ucesnici = _context.DodjeljenPredmet
                .Include(i => i.OdjeljenjeStavka)
                .ThenInclude(i => i.Odjeljenje)
               .Where
               (
                   i => i.Predmet.Id == takmicenjeDodajVM.PredmetID &&
                        i.ZakljucnoKrajGodine == 5
               )
               .Select
               (
                   i => new TakmicenjeStavka
                   {
                       OdjeljenjeStavkaID = i.OdjeljenjeStavkaId,
                       OdjeljenjeStavka = i.OdjeljenjeStavka,
                       IsPristupio = false,
                       Bodovi = 0
                   }
               )
               .ToList();

            var noviTakmicari = new List<TakmicenjeStavka>();
            foreach (var item in ucesnici)
            {
                var predmeti = _context.DodjeljenPredmet
                    .Include(i => i.OdjeljenjeStavka)
                    .ThenInclude(i => i.Odjeljenje)
                    .Where
                    (
                        i => i.OdjeljenjeStavkaId == item.OdjeljenjeStavkaID
                    )
                    .ToList();
                bool flag =
                    predmeti.Any() ?
                    predmeti.Select
                    (
                        i => i.ZakljucnoKrajGodine
                    )
                    .Average() > 4 :
                    false;
                

                if (flag)
                {
                    var NoviTakmicar = new TakmicenjeStavka()
                    {
                        TakmicenjeID = tak.Id,
                        OdjeljenjeStavkaID = item.OdjeljenjeStavkaID,
                        IsPristupio = false,
                        Bodovi = 0
                    };

                    noviTakmicari.Add(NoviTakmicar);
                   
                }
            }

            _context.AddRange(noviTakmicari);
            _context.SaveChanges();
            return Redirect("Index");
        }
        public IActionResult Rezultati(int id)
        {
            RezultatiTakmicenjaVM vm = new RezultatiTakmicenjaVM
            {
                Predmet = _context.Takmicenje.Where(x=>x.Id==id).Select(i=>i.Predmet.Naziv).FirstOrDefault(),
                SkolaID = _context.Takmicenje.Where(x => x.Id == id).Select(i => i.SkolaID).FirstOrDefault(),
                SkolaDomacin = _context.Takmicenje.Where(x => x.Id == id).Select(i => i.Skola.Naziv).FirstOrDefault(),
                Razred = _context.Takmicenje.Where(x => x.Id == id).Select(i => i.Razred).FirstOrDefault(),
                Datum = _context.Takmicenje.Where(x => x.Id == id).Select(i => i.Datum).FirstOrDefault(),
                TakmicenjeID = id,
                Rows = _context.takmicenjeStavka.Where(x => x.TakmicenjeID == id).Select(i => new RezultatiTakmicenjaVM.Row
                {
                    TakmicenjeID = id,
                    Bodovi = i.Bodovi,
                    BrojUdnevniku = i.OdjeljenjeStavka.BrojUDnevniku,
                    IsPristupio = i.IsPristupio,
                    Odjeljenje = i.OdjeljenjeStavka.Odjeljenje.Oznaka,
                    UcesnikID = i.Id
                }).ToList()

            };
            return View(vm);
        }
        public IActionResult Pristupio(int id)
        {
            var ucesnik = _context.takmicenjeStavka.Find(id);
            if (ucesnik.IsPristupio)
            {
                ucesnik.IsPristupio = false;
            }
            else
            {
                ucesnik.IsPristupio = true;
            }
            _context.SaveChanges();
            return Redirect("/Takmicenje/Rezultati/"+ucesnik.TakmicenjeID);
        }
    }
}
