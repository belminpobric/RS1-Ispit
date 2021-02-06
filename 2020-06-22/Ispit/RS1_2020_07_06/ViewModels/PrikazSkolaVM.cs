using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_07_06.ViewModels
{
    public class PrikazSkolaVM
    {
        public List<SelectListItem> Skola { get; set; }
        public int SkolaID { get; set; }
    }
}
