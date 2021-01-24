using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PrikaziSkole
    {
        public List<SelectListItem> Skole { get; set; }
        public int SkolaID { get; set; }
        public List<SelectListItem> Predmeti { get; set; }
        public int PredmetID { get; set; }
        

    }
}
