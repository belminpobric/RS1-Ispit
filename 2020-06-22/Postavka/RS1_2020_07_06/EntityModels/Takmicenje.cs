using RS1_Ispit_asp.net_core.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_07_06.EntityModels
{
    public class Takmicenje
    {
        public int Id { get; set; }
        public virtual Predmet Predmet { get; set; }
        public int PredmetID { get; set; }
        public virtual Skola Skola{ get; set; }
        public int SkolaID { get; set; }
        public DateTime Datum { get; set; }
        public bool IsZakljucano { get; set; }
        public int Razred { get; set; }
    }
}
