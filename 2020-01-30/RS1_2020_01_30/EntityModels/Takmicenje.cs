﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2020_01_30.EntityModels
{
    public class Takmicenje
    {
        public int Id { get; set; }
        public Skola Skola { get; set; }
        public int SkolaID { get; set; }
        public int Razred { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetID { get; set; }
        public DateTime Datum { get; set; }
        public bool IsZakljucano { get; set; }
    }
}
