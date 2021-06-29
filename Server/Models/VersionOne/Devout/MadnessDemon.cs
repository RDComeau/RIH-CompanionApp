﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Models.VersionOne.Devout
{
    public class MadnessDemon : BaseUnit
    {
        public override int cost { get; set; } = 0;
        public override int move { get; set; } = 5;
        public override int life { get; set; } = 11;
        public override int combat { get; set; } = 3;
        public override bool fly { get; set; } = Convert.ToBoolean(CanFly.No);
    }
}
