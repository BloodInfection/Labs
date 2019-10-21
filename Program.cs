using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Биквадратное уравнение: a*x^4+b*x^2+c=0");
            Console.WriteLine("Введите a, b, c: ");

            string str_a = Console.ReadLine();
            double a = double.Parse(str_a); // ввели а

            string str_b = Console.ReadLine();
            double b = double.Parse(str_b); // ввели b

            string str_c = Console.ReadLine();
            double c = double.Parse(str_c); // ввели c

            Console.WriteLine($"Ваши числа: {a},{b},{c}.");
            double disc = (b * b - 4.0 * a * c);

            if (disc < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"D<0, Нет решения!");
                Console.ResetColor();
                Console.WriteLine();
            }

            else if (disc == 0)
            {
                Console.WriteLine("d=0");
                double y_1 = (-b) / (2 * a);
                if (y_1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"y={y_1}; Нет решения!");
                    Console.WriteLine();
                }
                else
                {
                    double x_1 = Math.Sqrt(y_1);
                    double x_2 = -(Math.Sqrt(y_1));
                    Console.WriteLine($"x1={x_1}; x2={x_2}.");
                }
            }
            else if (disc > 0)
            {
                Console.WriteLine("d>0");
                double disc_root = Math.Sqrt(b * b - 4.0 * a * c);
                double y1 = (-b + disc_root) / (2 * a);
                double y2 = (-b - disc_root) / (2 * a);
                Console.WriteLine($"{disc_root}, {y1},{y2}.");
                if (y1 < 0)
                    y1 = y1 * (-1);
                if (y2 < 0)
                    y2 = y2 * (-1);
                Console.WriteLine($"Корень из D:{disc_root}; Y1={y1}; Y2={y2}.");
                double x1 = Math.Sqrt(y1);
                double x2 = -(Math.Sqrt(y1));
                double x3 = Math.Sqrt(y2);
                double x4 = -(Math.Sqrt(y2));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1={x1}; x2={x2}; x3={x3}; x4={x4}.");
                Console.ResetColor();
            }







            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
