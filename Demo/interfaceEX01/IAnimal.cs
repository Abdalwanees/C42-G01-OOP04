﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX01
{
    internal interface IAnimal
    {
        string Name { get; set; }
        public void MakeSound();
    }
}
