using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_01_30.ViewModels
{
    public class SkolePrikazVM
    {
        public List<SelectListItem> SkolaDomacin { get; set; }
        public int SkolaID { get; set; }
        public List<SelectListItem> Razred { get; set; }
        public int RazredID { get; set; }
        public int TakmicenjeID { get; set; }
    }
}
