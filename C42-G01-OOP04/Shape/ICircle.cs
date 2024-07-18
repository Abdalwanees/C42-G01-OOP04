using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04.Shape
{
    internal interface ICircle : IShape
    {
        public double Radius { get; set; }
    }
}
