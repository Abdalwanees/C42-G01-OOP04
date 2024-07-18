using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaceEX01
{
    internal class Cat : IAnimal
    {
        public string Name { get; set ; }

        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
