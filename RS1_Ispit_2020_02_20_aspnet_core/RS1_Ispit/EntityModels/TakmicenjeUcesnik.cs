﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class TakmicenjeUcesnik
    {
        public int Id { get; set; }
        public OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
        public bool IsPristupio { get; set; }
        public int Bodovi { get; set; }
        public Takmicenje Takmicenje { get; set; }
        public int TakmicenjeID { get; set; }
    }
}
