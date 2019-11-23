using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Филатова Анастасия ИУ5-35Б";
            double a;
            double b;
            double c;
            Console.WriteLine("Биквадратное уравнение: a*x^4+b*x^2+c=0");
            if (args.Length == 3)
            {
                Console.WriteLine("Ввод ");
                a = Double.Parse(args[0]);
                b = Double.Parse(args[1]);
                c = Double.Parse(args[2]);

            } else
            {
                double num;

                Console.WriteLine($"Введите а:");
                string str_a = Console.ReadLine();
                while (!double.TryParse(str_a, out num))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Неверный тип данных, повторите ввод:");
                    Console.ResetColor();
                    str_a = Console.ReadLine();
                }
                a = double.Parse(str_a); // ввели а


                Console.WriteLine($"Введите b:");
                string str_b = Console.ReadLine();
                while (!double.TryParse(str_b, out num))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Неверный тип данных, повторите ввод:");
                    Console.ResetColor();
                    str_b = Console.ReadLine();
                }
                b = double.Parse(str_b); // ввели b



                Console.WriteLine($"Введите c:");
                string str_c = Console.ReadLine();
                while (!double.TryParse(str_c, out num))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Неверный тип данных, повторите ввод:");
                    Console.ResetColor();
                    str_c = Console.ReadLine();
                }
                 c = double.Parse(str_c); // ввели c




            }

            
            Console.WriteLine($"Ваши числа: {a},{b},{c}.");

            if (a == 0)
            {
                double sqrt_x = -c / b;
                if (sqrt_x < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Квадрат равен отрицательному числу. Нет решения!");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                else if (sqrt_x == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x={sqrt_x}");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                else
                {
                    double x1 = Math.Sqrt(sqrt_x);
                    double x2 = -(Math.Sqrt(sqrt_x));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"x1={x1}; x2={x2}.");
                    Console.ResetColor();
                    Console.ReadLine();
                }

            }




            double disc = (b * b - 4.0 * a * c);

            if (disc < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"D<0, Нет решения!");
                Console.ResetColor();
                Console.ReadLine();


            }

            else if (disc == 0)
            {
                Console.WriteLine("d=0");
                double y_1 = (-b) / (2 * a);
                if (y_1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"y={y_1}; Нет решения!");
                    Console.ResetColor();
                    Console.ReadLine();
                }

                else
                {
                    double x_1 = Math.Sqrt(y_1);
                    double x_2 = -(Math.Sqrt(y_1));


                    if ((x_1 == x_2) & (x_1 == 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x={x_1}");
                        Console.ResetColor();
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"x1={x_1}; x2={x_2}.");
                        Console.ResetColor();
                        Console.ReadLine();
                    }
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
                Console.ReadLine();
            }







            Console.ReadLine();
            Console.ReadLine();
        }
    }
}










