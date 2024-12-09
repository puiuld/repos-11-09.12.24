using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Найти периметр треугольника, заданного координатами своих вершин. 
    /// (Определить функцию для расчета длины отрезка по координатам его вершин.)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = Input("x1=");
            int y1 = Input("y1=");
            int x2 = Input("x2=");
            int y2 = Input("y2=");
            int x3 = Input("x3=");
            int y3 = Input("y3=");
            double p = Perimeter(F(x1, y1, x2, y2), F(x2, y2, x3, y3), F(x3, y3, x1, y1));
            Console.WriteLine($"Периметр {Math.Pow(p, 1)}");
            Console.Read();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static double F(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static double Perimeter(double a, double b, double c)
        {
            return (a + b + c);
        }
    }
}

