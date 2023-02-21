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
            string s;
            Console.Write("請輸入一串數字，並以逗號分隔: ");
            s = Console.ReadLine();
            var n = s.Split(',');
            var odd = n.Where(x => int.Parse(x) % 2 != 0).OrderBy(x => x);
            var even = n.Where(x => int.Parse(x) % 2 == 0).OrderBy(x => x);
            Console.Write("奇數: ");
            foreach (var x in odd) Console.Write($"{x} ");
            Console.Write("\n偶數: ");
            foreach (var x in even) Console.Write($"{x} ");

            Console.ReadKey();
        }
    }
}
