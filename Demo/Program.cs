using Demo.interfaceEX01;
using Demo.interfaceEX02;

namespace Demo
{
    internal class Program
    {
        public static void GetTenNumbreSeriesByTwo(ISeries series)
        {
            if (series==null)
            {
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.current}\t");
                series.GetNext();
            }
            // We Can Get Reset method form reference of interface to class from this interface 
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region 01 Animals Sound 
            IAnimal myDog = new Dog { Name = "Buddy" };
            IAnimal myCat = new Cat { Name = "Whiskers" };

            Console.WriteLine($"Dog's name: {myDog.Name}");
            myDog.MakeSound();  // Output: Woof!

            Console.WriteLine($"Cat's name: {myCat.Name}");
            myCat.MakeSound();  // Output: Meow!
            #endregion

            #region Arithmetic Series
            ////Get Series By Two
            //ISeries series = new SeriesByTwo();
            //GetTenNumbreSeriesByTwo(series);
            ////Get Series By three
            //series = new SeriesByThree();
            //GetTenNumbreSeriesByTwo(series); 
            #endregion


        }
    }
}
