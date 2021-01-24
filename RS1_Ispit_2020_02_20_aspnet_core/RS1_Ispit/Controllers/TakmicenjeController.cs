using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;

namespace RS1_Ispit_asp.net_core.Controllers
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
            PrikaziSkole prikaziTakmicenje = new PrikaziSkole
            {
                Predmeti = _context.Predmet.GroupBy(x => x.Naziv).Select(i => i.First()).Select(x => new SelectListItem
                {
                    Text = x.Naziv,
                    Value = x.Id.ToString()
                }).ToList(),
                Skole = _context.Skola.Select(x => new SelectListItem
                {
                    Text = x.Naziv,
                    Value = x.Id.ToString()
                }).ToList()
            };

            return View(prikaziTakmicenje);
        }
        public IActionResult Takmicenja(PrikaziSkole vm)
        {
            PrikaziTakmicenja prikaziTakmicenja = new PrikaziTakmicenja
            {
                Rows = _context.Takmicenja.Where(x => x.SkolaID == vm.SkolaID && x.PredmetID == vm.PredmetID).Select(x => new PrikaziTakmicenja.Row
                {
                    Datum = x.Datum,
                    Predmet = x.Predmet.Naziv,
                    Razred = x.Razred,
                    Skola = x.Skola.Naziv,
                    TakmicenjeID = x.Id

                }).ToList(),
                sID = vm.SkolaID,
                pID = vm.PredmetID
            };
            foreach (var item in prikaziTakmicenja.Rows)
            {
                var najbolji = _context.TakmicenjeUcesnici
                    .Include(x => x.OdjeljenjeStavka.Ucenik)
                    .Include(x => x.OdjeljenjeStavka.Odjeljenje.Skola)
                    .Include(x => x.OdjeljenjeStavka.Odjeljenje)
                    .OrderByDescending(x => x.Bodovi)
                    .Where(x => x.TakmicenjeID == item.TakmicenjeID)
                    .FirstOrDefault();
                if (najbolji != null)
                {
                    item.NajboljiUcesnikID = najbolji.OdjeljenjeStavka.Ucenik.Id;
                    item.NajboljiUcesnikImePrezime = najbolji.OdjeljenjeStavka.Ucenik.ImePrezime;
                    item.NajboljiUcesnikOdjeljenje = najbolji.OdjeljenjeStavka.Odjeljenje.Oznaka;
                    item.NajboljiUcesnikSkola = najbolji.OdjeljenjeStavka.Odjeljenje.Skola.Naziv;
                }
            }
            if (prikaziTakmicenja != null)
                return PartialView("Takmicenja", prikaziTakmicenja);
            return NotFound();
        }
        public IActionResult Dodaj(int id)
        {
            DodajTakmicenje vm = new DodajTakmicenje
            {
                Predmeti = _context.Predmet.GroupBy(x => x.Naziv).Select(i => i.First()).Select(x => new SelectListItem
                {
                    Text = x.Naziv,
                    Value = x.Id.ToString()
                }).ToList(),
                Skole = _context.Skola.Where(x => x.Id == id).Select(x => new SelectListItem
                {
                    Text = x.Naziv,
                    Value = x.Id.ToString()
                }).ToList(),
                Datum = DateTime.Now
            };
            return View(vm);
        }
        public IActionResult Snimi(DodajTakmicenje vm)
        {
            Takmicenje tak = new Takmicenje
            {
                Datum = vm.Datum,
                PredmetID = vm.PredmetID,
                SkolaID = vm.SkolaID,
                Razred = _context.Predmet.Where(x => x.Id == vm.PredmetID).Select(x => x.Razred).FirstOrDefault()
            };
            _context.Add(tak);
            _context.SaveChanges();
            var takmicari = _context.DodjeljenPredmet.Where(x => x.ZakljucnoKrajGodine > 3).Select(i => new TakmicenjeUcesnik
            {
                IsPristupio = false,
                OdjeljenjeStavkaID = i.OdjeljenjeStavkaId,
                Bodovi = 0
            }).ToList();
            var takmicenjeUcesnici = _context.TakmicenjeUcesnici.Select(x => new TakmicenjeUcesnik
            {
                Bodovi = x.Bodovi,
                Id = x.Id,
                IsPristupio = x.IsPristupio,
                OdjeljenjeStavkaID = x.OdjeljenjeStavkaID,
                TakmicenjeID = x.TakmicenjeID
            }).ToList();
            bool DaLiImaUcesnika = false;
            //provjera da li uopste ima ucesnika za takmicenje koje se dodaje
            foreach (var item in takmicenjeUcesnici)
            {
                if (item.TakmicenjeID == tak.Id)
                {
                    DaLiImaUcesnika = true;
                }
            }
            if (!DaLiImaUcesnika)
            {
                return Redirect("/Takmicenje/Index");
            }
            //dodaj najbolje ucesnike za dato takmicenje..
            foreach (var Takmicar in takmicari)
            {
                bool flag = _context.DodjeljenPredmet.Where
                    (
                    i => i.OdjeljenjeStavkaId == Takmicar.OdjeljenjeStavkaID &&
                    i.OdjeljenjeStavka.Odjeljenje.Razred == tak.Razred
                    ).Select(i => i.ZakljucnoKrajGodine).Average() > 3;
                if (flag)
                {
                    var noviTakmicar = new TakmicenjeUcesnik
                    {
                        TakmicenjeID = tak.Id,
                        IsPristupio = false,
                        Bodovi = 0,
                        OdjeljenjeStavkaID = Takmicar.OdjeljenjeStavkaID
                    };
                    _context.Add(noviTakmicar);
                    _context.SaveChanges();
                }
            }
            return Redirect("/Takmicenje/Index");
        }
        public IActionResult Rezultati(int id)
        {
            RezultatiTakmicenja vm = new RezultatiTakmicenja
            {
                Datum = _context.Takmicenja.Where(x => x.Id == id).Select(x => x.Datum).FirstOrDefault(),
                SkolaDomacin = _context.Takmicenja.Where(x => x.Id == id).Select(x => x.Skola.Naziv).FirstOrDefault(),
                Predmet = _context.Takmicenja.Where(x => x.Id == id).Select(x => x.Predmet.Naziv).FirstOrDefault(),
                Razred = _context.Takmicenja.Where(x => x.Id == id).Select(x => x.Razred).FirstOrDefault(),
                TakmicenjeID = id,
                isZakljucano = _context.Takmicenja.Where(x => x.Id == id).Select(x => x.IsZakljucano).FirstOrDefault(),
                UcesniciRows = _context.TakmicenjeUcesnici.Select(x => new RezultatiTakmicenja.Ucesnik
                {
                    Bodovi = x.Bodovi,
                    BrojUDnevniku = x.OdjeljenjeStavka.BrojUDnevniku,
                    IsPristupio = x.IsPristupio,
                    Odjeljenje = x.OdjeljenjeStavka.Odjeljenje.Oznaka,
                    UcesnikID = x.Id
                }).ToList()

            };
            return View(vm);
        }
        public IActionResult Pristupio(int id)
        {
            var ucesnik = _context.TakmicenjeUcesnici.Find(id);
            ucesnik.IsPristupio = !ucesnik.IsPristupio;
            _context.SaveChanges();
            return Redirect("/Takmicenje/Rezultati/" + ucesnik.TakmicenjeID);
        }
        public IActionResult DodajUcesnika(int id)
        {
            List<TakmicenjeUcesnik> ucesnici = _context.TakmicenjeUcesnici.Select(x => new TakmicenjeUcesnik
            {
                Bodovi = x.Bodovi,
                Id = x.Id,
                IsPristupio = x.IsPristupio,
                OdjeljenjeStavkaID = x.OdjeljenjeStavkaID,
                TakmicenjeID = x.TakmicenjeID
            }).ToList();
            foreach(var ucesnik in ucesnici)
            {
                if (ucesnik.TakmicenjeID == id)
                {
                    DodajUcesnika editUcesnika = new DodajUcesnika
                    {
                        Bodovi = ucesnik.Bodovi,
                        TakmicenjeID = ucesnik.TakmicenjeID,
                        UcesnikID = ucesnik.Id,
                        Ucesnik = _context.TakmicenjeUcesnici.Where(x=>x.Id == ucesnik.Id).Select(i=> new SelectListItem
                        {
                            Text = i.OdjeljenjeStavka.Ucenik.ImePrezime,
                            Value = i.Id.ToString()
                        }).ToList()
                    };
                    return PartialView("DodajUcesnika", editUcesnika);
                }
            }
            DodajUcesnika vm = new DodajUcesnika
            {
                Ucesnik = _context.OdjeljenjeStavka.Select(x => new SelectListItem
                {
                    Text = x.Odjeljenje.Oznaka + "-" + x.Ucenik.ImePrezime + "-" + x.BrojUDnevniku,
                    Value = x.Id.ToString()
                }).ToList(),
                TakmicenjeID = id,

            };
            return PartialView("DodajUcesnika", vm);


        }
        public IActionResult SnimiUcesnika(DodajUcesnika vm, int id)
        {
            TakmicenjeUcesnik takmicenjeUcesnik = new TakmicenjeUcesnik
            {
                TakmicenjeID = id,
                Bodovi = vm.Bodovi,
                OdjeljenjeStavkaID = _context.OdjeljenjeStavka.Where(x => x.Id == vm.UcesnikID).Select(x => x.Id).FirstOrDefault(),
                IsPristupio = false
            };
            _context.Add(takmicenjeUcesnik);
            _context.SaveChanges();
            return Redirect("/Takmicenje/Rezultati/" + id);
        }
        public IActionResult Zakljucaj(RezultatiTakmicenja vm, int id)
        {
            var takmicenje = _context.Takmicenja.Find(id);
            if (!takmicenje.IsZakljucano)
            {
                takmicenje.IsZakljucano = true;
                _context.SaveChanges();
            }
            return Redirect("/Takmicenje/Rezultati/" + id);
        }
    }
}
