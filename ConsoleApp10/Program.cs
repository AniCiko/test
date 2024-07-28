using System;
using System.Collections;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Juli", 23);
            dict.Add("Envi", 24);
            dict.Add("Alesio", 19);
            dict.Add("Denis", 23);

            foreach(var item in dict)
            {
                Console.WriteLine($"Emri: {item.Key}, Mosha: {item.Value}");
            }
        }
    }
}