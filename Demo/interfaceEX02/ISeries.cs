using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX02
{
    internal interface ISeries
    {
        //Signature For property
        public int current { get; set; }
        // Signature For Method
        public void GetNext();
        public void Reset()
        {
            current = 0;    
        }
    }
}
