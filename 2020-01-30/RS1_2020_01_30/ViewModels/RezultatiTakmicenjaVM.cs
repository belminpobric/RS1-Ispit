using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_01_30.ViewModels
{
    public class RezultatiTakmicenjaVM
    {
        public int TakmicenjeID { get; set; }
        public string SkolaDomacin { get; set; }
        public string Predmet { get; set; }
        public int SkolaID { get; set; }
        public int Razred { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
        public List<Row> Rows { get; set; }
        public class Row 
        {
            public int TakmicenjeID { get; set; }
            public int UcesnikID { get; set; }
            public string Odjeljenje { get; set; }
            public int BrojUdnevniku { get; set; }
            public bool IsPristupio { get; set; }
            public int Bodovi { get; set; }
        }
    }
}
