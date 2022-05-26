using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string you want to reverse: ");
            string stringToReverse = Console.ReadLine();
            Console.WriteLine("---------------------");

            char[] charArray = new char [stringToReverse.Length];
            char[] charArrayBackwards = new char [stringToReverse.Length];

            StringBuilder s = new StringBuilder();

            for (int i = 0; i < stringToReverse.Length; i++)
            {
                charArray[i] = stringToReverse[i];
                charArrayBackwards[i] = stringToReverse[stringToReverse.Length - 1 - i];
                s.Append(charArrayBackwards[i]);
            }

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
