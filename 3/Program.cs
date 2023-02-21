using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a interger number: ");
            var n = Console.ReadLine();
            
            for(int i = 0 ; i < int.Parse(n); i++)
            {
                for(int j = 0, k= int.Parse(n)-i; j <= i; j++)
                {
                    Console.Write($"{k}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
