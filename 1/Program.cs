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
            string s;
            Console.Write("請輸入一串數字，並以逗號分隔: ");
            s = Console.ReadLine();
            var n = s.Split(',');
            var reverse = n.OrderByDescending(x => x);
            foreach ( var x in reverse) { Console.Write($"{x} "); }

            Console.ReadKey();
        }
    }
}
