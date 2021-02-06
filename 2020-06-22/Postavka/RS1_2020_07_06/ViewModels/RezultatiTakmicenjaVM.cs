using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_07_06.ViewModels
{
    public class RezultatiTakmicenjaVM
    {
        public int SkolaID { get; set; }
        public string SkolaDomacin { get; set; }
        public string Predmet { get; set; }
        public int Razred { get; set; }
        public DateTime Datum { get; set; }
        public List<Row> Rows { get; set; }
        public int TakmicenjeID { get; set; }

        public class Row
        {
            public int UcesnikID { get; set; }
            public int TakmicenjeID { get; set; }
            public string Odjeljenje { get; set; }
            public int BrojUdnevniku { get; set; }
            public bool IsPristupio { get; set; }
            public int bodovi { get; set; }
        }
    }
}
