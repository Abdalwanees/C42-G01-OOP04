using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX03
{
    internal class Car : IMovable
    {
        public void Backword()
        {
            Console.WriteLine("The car moves backword.");
        }

        public void Forward()
        {
            Console.WriteLine("The car moves forward.");
        }

        public void Left()
        {
            Console.WriteLine("The car moves left.");
        }

        public void Right()
        {
            Console.WriteLine("The car moves right.");
        }
    }
}
