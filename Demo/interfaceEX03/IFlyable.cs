using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX03
{
    internal interface IFlyable
    {
        public void TakeOff();
        public void Land();
        void Fly();
        public void Right();
        public void Left();
    }
}
