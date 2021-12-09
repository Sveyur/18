using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] bracket = str.ToCharArray();
            int namber = 0;
            foreach (char b in bracket)
            {
                if (b == '(' || b == '<' || b == '[' || b == '{')
                {
                    namber++;
                }
                else if (b == ')' || b == '>' || b == ']' || b == '}')
                {
                    namber--;
                }
            }
            if (namber == 0)
            {
                Console.WriteLine("Скобки расставлены правильно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не правильно");
            }
            Console.ReadKey();
        }
    }
}
