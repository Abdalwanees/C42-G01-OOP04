using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX01
{
    internal class Dog:IAnimal
    {
        // Implement the property
        public string Name { get; set; }

        // Implement the method
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
