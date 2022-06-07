using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("x3 = ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            int y3 = int.Parse(Console.ReadLine());
            Console.Write("x4 = ");
            int x4 = int.Parse(Console.ReadLine());
            Console.Write("y4 = ");
            int y4 = int.Parse(Console.ReadLine());
            Console.Write("x5 = ");
            int x5 = int.Parse(Console.ReadLine());
            Console.Write("y5 = ");
            int y5 = int.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            double d = Math.Sqrt(Math.Pow((x5 - x4), 2) + Math.Pow((y5 - y4), 2));
            double e = Math.Sqrt(Math.Pow((x1 - x5), 2) + Math.Pow((y1 - y5), 2));
            double[] array = { a, b, c, d, e };
            double min = array[0];
            double max = array[0];
            foreach (double i in array)
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }
            Console.WriteLine($"Наибольшая сторона = {max}");
            Console.WriteLine($"Наименьшая сторона = {min}");
        }
    }
}
