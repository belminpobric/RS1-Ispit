using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_07_06.ViewModels
{
    public class PrikazTakmicenjaVM
    {
        public int SkolaID { get; set; }
        public List<Row> Rows { get; set; }
        public class Row
        {
            public int TakmicenjeID { get; set; }
            public string Skola { get; set; }
            public int Razred { get; set; }
            [DataType(DataType.Date)]
            public DateTime Datum { get; set; }
            public string Predmet { get; set; }
            public string NajboljiUcesnik { get; set; }
        }
    }
}
