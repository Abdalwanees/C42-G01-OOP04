using Demo.interfaceEX01;
using Demo.interfaceEX02;
using Demo.interfaceEX03;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Demo
{
    internal class Program
    {
        public static void GetTenNumbreSeriesByTwo(ISeries series)
        {
            if (series == null)
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

        public static void PrintArray(int[] arr, int num)
        {
            if (arr == null)
            {
                return;
            }
            Console.WriteLine($"HashCode = #{arr.GetHashCode()}");

            Console.Write($"Array0{num}= [");
            foreach (var item in arr)
            {
                Console.Write($" {item} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region 01 Animals Sound 
            //IAnimal myDog = new Dog { Name = "Buddy" };
            //IAnimal myCat = new Cat { Name = "Whiskers" };

            //Console.WriteLine($"Dog's name: {myDog.Name}");
            //myDog.MakeSound();  // Output: Woof!

            //Console.WriteLine($"Cat's name: {myCat.Name}");
            //myCat.MakeSound();  // Output: Meow!
            #endregion

            #region Arithmetic Series
            ////Get Series By Two
            //ISeries series = new SeriesByTwo();
            //GetTenNumbreSeriesByTwo(series);
            ////Get Series By three
            //series = new SeriesByThree();
            //GetTenNumbreSeriesByTwo(series); 
            #endregion

            #region Implement Interface (Implicitly&Explicitly)
            #region Implicitly
            //IMovable car=new Car();
            //car.Forward();
            //car.Backword();
            //car.Right();
            //car.Left();
            #endregion

            #region Explicitly
            //IMovable myMovableAirplane = new Airplane();
            //IFlyable myFlyableAirplane = new Airplane();

            //Console.WriteLine("Airplane movements:");
            //myMovableAirplane.Forward();
            //myMovableAirplane.Backword();
            //myMovableAirplane.Left();
            //myMovableAirplane.Right();

            //Console.WriteLine("\nAirplane flying capabilities:");
            //myFlyableAirplane.TakeOff();
            //myFlyableAirplane.Fly();
            //myFlyableAirplane.Land();
            //myFlyableAirplane.Left();
            //myFlyableAirplane.Right(); 
            #endregion
            #endregion

            #region Deep Copy && Shallow Copy

            //// Initialize two arrays
            //int[] arr01 = { 1, 2, 3, 4 };
            //int[] arr02 = { 5, 6, 7, 8 };

            //// Print initial state of arrays
            //PrintArray(arr01, 1);
            //PrintArray(arr02, 2);

            #region Shallow Copy
            //// Shallow copy: arr01 now references the same array as arr02
            //arr01 = arr02;

            //// Print arrays after shallow copy
            //PrintArray(arr01, 1);
            //PrintArray(arr02, 2);

            //// Modify arr01, which also affects arr02 due to shallow copy
            //arr01[1] = 5;

            //// Print arrays after modification
            //PrintArray(arr01, 1);
            //PrintArray(arr02, 2);

            ////Before the shallow copy (arr01 = arr02), arr01 and arr02 have different contents and different hash codes.
            //// After the shallow copy, arr01 points to the same array as arr02, so they have the same hash code and content.
            ////Modifying arr01 affects arr02 because they reference the same array.

            #endregion

            #region Deep Copy
            //// Deep copy using Clone method
            //// The Clone method creates a new array object
            //// This new object has a different identity
            //// This new object has the same state (data) as the caller object
            //arr02 = (int[])arr01.Clone();

            //// Print arrays after deep copy
            //PrintArray(arr01, 1);
            //PrintArray(arr02, 2);

            //// Modify arr02 and arr01 independently
            //arr02[2] = 5;
            //arr01[2] = 7;

            //// Print arrays after modification
            //PrintArray(arr01, 1);
            //PrintArray(arr02, 2);

            ////The Clone method creates a new array object with the same data as the original array.
            ////The new array object has a different identity(hash code) from the original array.
            ////Changes to one array do not affect the other, ensuring their independence.
            #endregion

            #endregion
        }
    }
}
