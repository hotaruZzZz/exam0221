using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串數字，並以逗號分隔: ");
            string s = Console.ReadLine();
            var n = s.Split(',');
            var odd = n.Where(x => int.Parse(x) % 2 != 0).OrderBy(x => int.Parse(x));
            var even = n.Where(x => int.Parse(x) % 2 == 0).OrderBy(x => int.Parse(x));
            Console.Write("奇數: ");
            Console.Write(string.Join(",",odd));
            Console.Write("\n偶數: ");
            Console.Write(string.Join(",",even));

            Console.ReadKey();
        }
    }
}
