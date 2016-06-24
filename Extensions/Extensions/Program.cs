using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    //Import the namespace
    using StringExtentions;

    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is the string I want to do stuff with. And more stuff";
            Console.WriteLine(myString.ToUpper());

            Console.WriteLine(myString.WordCount());

            Console.ReadKey();
        }
    }
}

namespace StringExtentions
{
    //Extension methods must be defined in a public static class
    public static class StringExtention
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
