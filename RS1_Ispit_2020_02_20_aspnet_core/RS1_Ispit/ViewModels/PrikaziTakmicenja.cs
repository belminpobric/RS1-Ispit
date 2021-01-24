using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PrikaziTakmicenja
    {
        public List<Row> Rows { get; set; }
        public class Row
        {
            public int TakmicenjeID { get; set; }
            public string Skola { get; set; }
            public int Razred { get; set; }
            public DateTime Datum { get; set; }
            public string Predmet { get; set; }
            public int NajboljiUcesnikID { get; set; }
            public string NajboljiUcesnikSkola { get; set; }
            public string NajboljiUcesnikOdjeljenje { get; set; }
            public string NajboljiUcesnikImePrezime { get; set; }

        }
        public int sID { get; set; }
        public int pID { get; set; }
    }
}
