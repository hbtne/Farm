﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.Business
{
    internal class Goat:Animal
    {
        public static int Quantity { get; set; }
        public static int MilkVolume { get; set; }

        public override string MakeSound() => "beeeeeeeeeeeee";
        public override int GiveMilk() => new Random().Next(0, 11);
        public override int GiveBirth() => new Random().Next(1, 3);
    }
}
