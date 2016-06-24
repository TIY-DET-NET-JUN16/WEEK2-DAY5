using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4 };
            List<string> strings = new List<string>() { "one", "two", "three", "four" };

            WriteOutList<int>(ints);
            WriteOutList<string>(strings);

            WriteOutList<int>(ints);

            int myInt = 5;
            double myDoub = 5.5;
            string mystring = "somemthing";

            Console.WriteLine();

            WriteOutMyType<string>(mystring);
            WriteOutMyType<double>(myDoub);
            WriteOutMyType<int>(myInt);

            Console.ReadKey();
        }

        public static void WriteOutList<T>(List<T> myList)
        {
            foreach (T thing in myList)
            {
                Console.WriteLine(thing.ToString());
            }
        }

        public static void WriteOutMyType<T>(T thing)
        {
            Console.WriteLine("{0} is of Type {1}", thing.ToString(), thing.GetType());
        }
    }
}
