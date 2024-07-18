using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX02
{
    internal class SeriesByTwo : ISeries
    {
        public int current { get; set; }
        public void GetNext()
        {
            current += 2;

        }
    }
}
