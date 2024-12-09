using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {/// <summary>
     /// Ввести три целых числа и вывести их в порядке возрастания значений.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Vvod("a=");
            int b = Vvod("b=");
            int c = Vvod("c=");
            Increasing(ref a, ref b, ref c);
            Console.WriteLine($"{a},{b},{c}");
            Console.ReadLine();
        }
        public static int Vvod(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Increasing(ref int a, ref int b, ref int c)
        {
            if (a < b) Swap(ref a, ref b);
            if (b < c) Swap(ref b, ref c);
            if (c < a) Swap(ref c, ref a);
            if (c < b) Swap(ref c, ref b);

        }
        public static void Swap(ref int a, ref int b)
        {
            int p = a;
            a = b;
            b = p;

        }
        
        


    }
}
