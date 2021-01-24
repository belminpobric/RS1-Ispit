using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class RezultatiTakmicenja
    {
        public string SkolaDomacin { get; set; }
        public string Predmet { get; set; }
        public int Razred { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
        public List<Ucesnik> UcesniciRows { get; set; }
        public int TakmicenjeID { get; set; }
        public bool isZakljucano { get; set; }
        public class Ucesnik
        {
            public int UcesnikID { get; set; }
            public string Odjeljenje { get; set; }
            public int BrojUDnevniku { get; set; }
            public bool IsPristupio { get; set; }
            public int Bodovi { get; set; }
        }
    }
}
