﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tama.Contract;
using TamaWeb.Models;

namespace TamaWeb.Spelregels
{
    public class Honger : Spelregel
    {
        public Honger()
        {
            Order = 0;
        }
        public override int Order { get; set; }
        public override void ExecuteSpelregel(Tamagotchi tamagotchi, int ticks)
        {
            tamagotchi.Hunger += ticks * 5;
        }
    }
}