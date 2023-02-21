using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串數字，並以逗號分隔: ");
            string s = Console.ReadLine();
            var n = s.Split(',');
            var reverse = n.OrderByDescending(x => Array.IndexOf(n, x));
            Console.WriteLine(string.Join(",",reverse));

            Console.ReadKey();
        }
    }
}
