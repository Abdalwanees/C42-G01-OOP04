using Demo.interfaceEX01;
using Demo.interfaceEX02;
using Demo.interfaceEX03;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
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
        public static void PrintStringArray(string[] arr, int num)
        {
            if (arr == null)
            {
                return;
            }
            Console.WriteLine($"HashCode = #{arr.GetHashCode()}");

            Console.Write($"Array0{num}= [");
            foreach (var item in arr)
            {
                Console.Write($" '{item}' ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static void PrintStringBuilderArray(StringBuilder[] arr, int num)
        {
            if (arr == null)
            {
                return;
            }
            Console.WriteLine($"HashCode = #{arr.GetHashCode()}");

            Console.Write($"Array0{num}= [");
            foreach (var item in arr)
            {
                Console.Write($" '{item}' ");
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

            #region Deep Copy && Shallow Copy (Value Type)

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

            #region Deep Copy && Shallow Copy (Reference Type)
            //string[] Name01 = { "Ali", "Mona" };
            //string[] Name02 = { "Omran", "Mostafa" };
            //Console.WriteLine("Brfore any thing Shallow Copy");
            //PrintStringArray(Name01, 1);
            //PrintStringArray(Name02, 2);

            #region Shallow Copy (Reference Type) 
            //// Shallow Copy: Name02 now references the same array as Name01
            //Name02 = Name01;

            //Console.WriteLine("After Shallow Copy");
            //PrintStringArray(Name01, 1);
            //PrintStringArray(Name02, 2);

            //// Modify Name02, which also affects Name01 due to shallow copy
            //Name02[1] = "Bl7";

            //Console.WriteLine("After changing value");
            //PrintStringArray(Name01, 1);
            //PrintStringArray(Name02, 2);

            ////A shallow copy involves creating a new reference to the same object, without creating an independent copy of the object.
            ////Any changes to the object through any reference will affect all other references that point to the same object.
            ////In this example, modifying the array through Name02 also affects Name01 because they reference the same array object.
            #endregion

            #region Deep Copy (Reference Type)
            //// Deep copy using Clone method
            //// The Clone method creates a new array object
            //// This new object has a different identity
            //// This new object has the same state (data) as the caller object
            //Name02 = (string[])Name01.Clone();

            //Console.WriteLine("After Deep Copy");
            //PrintStringArray(Name01, 1);
            //PrintStringArray(Name02, 2);

            //// Modify Name02 and Name01 independently
            //Console.WriteLine("After changing any value");
            //Name02[1] = "Wanees";
            //Name01[0] = "hambpzo";

            //// Print arrays after modification
            //PrintStringArray(Name01, 1);
            //PrintStringArray(Name02, 2);

            ////The Clone method creates a new array object with the same data as the original array.
            ////The new array object has a different identity(hash code) from the original array.
            ////Changes to one array do not affect the other, ensuring their independence.
            #endregion
            #endregion

            #region Deep Copy && Shallow Copy (Mutable Type)
            //StringBuilder[] Name01 = new StringBuilder[1]; //create reference of string builider  
            ////Name01[0].Append("Omar"); (xxx)-->null reference excption
            //Name01[0] = new StringBuilder("Omar");
            //StringBuilder[] Name02 = new StringBuilder[1]; //create reference of string builider  
            //Console.WriteLine("Before Any thing");
            //PrintStringBuilderArray(Name01, 1);
            //PrintStringBuilderArray(Name02, 2);

            #region Shallow coppy (Mutable type)
            //// Shallow Copy: Name02 now references the same array as Name01
            //Name02 = Name01;

            //Console.WriteLine("After Shallow Copy");
            //PrintStringBuilderArray(Name01, 1);
            //PrintStringBuilderArray(Name02, 2);

            //// Modify Name02, which also affects Name01 due to shallow copy
            //Name02[0].Append(" Ahmed");

            //Console.WriteLine("After Changing Value");
            //PrintStringBuilderArray(Name01, 1);
            //PrintStringBuilderArray(Name02, 2);

            //// A shallow copy involves creating a new reference to the same object, without creating an independent copy of the object.
            ////Any changes to the mutable object's state (content) through any reference will affect all other references that point to the same object.
            ////In this example, modifying the StringBuilder content through Name02 also affects Name01 because they reference the same StringBuilder object.
            #endregion

            #region Deep Copy (Mutable type)
            //// Deep copy using Clone method
            //// The Clone method creates a new array object
            //// This new object has a different identity
            //// This new object has the same state (data) as the caller object
            //Name02 = (StringBuilder[])Name01.Clone();

            //Console.WriteLine("After Deep Copy");
            //PrintStringBuilderArray(Name01, 1);
            //PrintStringBuilderArray(Name02, 2);

            //// Modify Name02 independently
            //Name02[0].Append(" Osman");

            //Console.WriteLine("After Changing Value");
            //PrintStringBuilderArray(Name01, 1);
            //PrintStringBuilderArray(Name02, 2);
            #endregion

            #endregion
        }
    }
}
