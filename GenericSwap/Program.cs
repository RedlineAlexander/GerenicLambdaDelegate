using System;

namespace GenericSwap
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 25;
            int y = 27;
            Swap<int>(ref  x, ref  y);
            Console.WriteLine($"One side of copy after swaping  x = {x} y = {y}");
            CountrSwaping<int>(ref x, ref y);
            Console.WriteLine($"Other side of copy after swaping x  = {x} y = {y}");


            string s1 = "Bi";
            string s2 = "Movie";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"One side of copy after swaping s1 = {s1} s2= {s2}");
            CountrSwaping<string>(ref s1, ref s2);
            Console.WriteLine($"Other side of copy after swaping s1 = {s1} y = {s2}");
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        public static void Swap<T>(ref T x, ref T y)
        {
           //T Temp;
          T  Temp = x;
            x = y;
            y = Temp;
        }
        public static void CountrSwaping<T>(ref T x, ref T y)
        {
            T Temp = x;
            y = x;
            x = Temp;
        }
    }
}
