using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    /// <summary>
    ///  Даны стороны двух треугольников.
    ///  Найти сумму их периметров и сумму их площадей.
    ///  (Определить вспомогательный метод для расчета периметра и площади треугольника по его сторонам.)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("AB=");
            int b = Input("BC=");
            int c = Input("AC=");
            int d = Input("DE=");
            int e = Input("EF=");
            int f = Input("FD=");
            Console.WriteLine($"Периметр первого треугольника={Perimetr(a, b, c)}   Площадь первого треугольника={Math.Round(Plow(a, b, c), 2)}");
            Console.WriteLine($"Периметр второго треугольника={Perimetr(d, e, f)}   Площадь второго треугольника={Math.Round(Plow(d, e, f), 2)}");
            Console.ReadLine();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Perimetr(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Plow(int a, int b, int c)
        {
            int p = a + b + c;
            return Math.Sqrt(p*(p - a)*(p - b) * (p - c));
        }
        
    }
}