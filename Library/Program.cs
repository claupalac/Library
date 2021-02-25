using System;

namespace Library
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string aString = "perro";
            string subString = "Pe";
            
            
            Console.WriteLine(aString.Contains(subString));
            Console.WriteLine(aString.StartsWith(subString));
        }
    }
}