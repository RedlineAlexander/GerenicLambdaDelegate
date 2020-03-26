using System;

namespace GerenicLambdaDelegate
{

    public delegate T RedLineGenericDelegate<T>(T fix, T bug);
    class Program
    {
        static void Main(string[] args)
        {

            RedLineGenericDelegate<string> redlinestringdelegate = RedlineConcat;
            Console.WriteLine(RedlineConcat("HATE", "CARANTINOOOOOOOO!!!!"));
            RedLineGenericDelegate<int> redLinesumdelegate = RedLineSum;
            Console.WriteLine(RedLineSum(1, 2));
            RedLineGenericDelegate<int> redlinesubtractdelegate = RedlineSubtract;
            Console.WriteLine(RedlineSubtract(1, 2));
            RedLineGenericDelegate<int> redlinemultiplicationdelegate = RedlineMultiplication;
            Console.WriteLine(RedlineMultiplication(1, 2));
            RedLineGenericDelegate<double> redlinedivisiondelegate = RedlineDivision;
            Console.WriteLine(RedlineDivision(1, 2));






            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public static string RedlineConcat(string x, string y)
        {
            return x + y;
        }
        public static int RedLineSum(int x, int y)
        {
            return x + y;
        }
        public static int RedlineSubtract(int x, int y)
        {
            return x - y;
        }
        public static int RedlineMultiplication(int x, int y)
        {
            return x * y;
        }
        public static double RedlineDivision(double x, double y)
        {
            return (double)x / y;
        }
        }
}
