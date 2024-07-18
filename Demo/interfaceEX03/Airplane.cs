using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX03
{
    internal class Airplane : IMovable, IFlyable
    {
        // Explicitly implement IMovable methods
        void IMovable.Backword()
        {
            Console.WriteLine("The Airplane moves backward.");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("The Airplane moves forward.");
        }

        void IMovable.Left()
        {
            Console.WriteLine("The Airplane moves left.");
        }

        void IMovable.Right()
        {
            Console.WriteLine("The Airplane moves right.");
        }

        // Explicitly implement IFlyable methods
        void IFlyable.Fly()
        {
            Console.WriteLine("The Airplane flies.");
        }

        void IFlyable.Land()
        {
            Console.WriteLine("The Airplane lands.");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("The Airplane flies left.");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("The Airplane flies right.");
        }

        void IFlyable.TakeOff()
        {
            Console.WriteLine("The Airplane takes off.");
        }
    }
}
