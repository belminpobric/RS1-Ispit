using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class DodajTakmicenje
    {
        public List<SelectListItem> Predmeti { get; set; }
        public int PredmetID { get; set; }
        public List<SelectListItem> Skole { get; set; }
        public int SkolaID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
    }
}
