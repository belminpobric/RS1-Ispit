using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_07_06.ViewModels
{
    public class DodajTakmicenjeVM
    {
        public List<SelectListItem> Predmet { get; set; }
        public int PredmetID { get; set; }
        public List<SelectListItem> Skola { get; set; }
        public int SkolaID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
    }
}
