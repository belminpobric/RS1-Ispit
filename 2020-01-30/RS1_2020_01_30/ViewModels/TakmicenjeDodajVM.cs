using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_01_30.ViewModels
{
    public class TakmicenjeDodajVM
    {
        public string SkolaDomacin { get; set; }
        public List<SelectListItem> Predmet { get; set; }
        public int PredmetID { get; set; }
        public List<SelectListItem> Razred { get; set; }
        public int RazredID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
        public int SkolaID { get; set; }
    }
}
