using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            //string data
            string x1_s, y1_s, x2_s, y2_s; //потому что ReadLine() возвращает строку

            //int data
            int x1, y1, x2, y2; //потому что мы работаем с числами
            Console.WriteLine("Лабораторная работа 1. Вариант 3. Шушков Илья");

            //принимаем данные по первой точке
            Console.WriteLine("Введите координаты первой точки: ");
            Console.Write("x1 = ");
            x1_s = Console.ReadLine();
            while(!int.TryParse(x1_s, out x1))
            {
                Console.WriteLine("Неверно!");

                Console.Write("x1 = ");  x1_s = Console.ReadLine();
            }

            Console.WriteLine();

            Console.Write("y1 = ");
            y1_s = Console.ReadLine();
            while (!int.TryParse(y1_s, out y1))
            {
                Console.WriteLine("Неверно!");
                Console.Write("y1 = "); y1_s = Console.ReadLine();
            }

            //принимаем данные по второй точке
            Console.WriteLine("Введите координаты второй точки: ");
            Console.Write("x2 = ");
            x2_s = Console.ReadLine();
            while (!int.TryParse(x2_s, out x2))
            {
                Console.WriteLine("Неверно!");
                Console.Write("x2 = "); x2_s = Console.ReadLine();
            }

            Console.WriteLine();

            Console.Write("y2 = ");
            y2_s = Console.ReadLine();
            while (!int.TryParse(y2_s, out y2))
            {
                Console.WriteLine("Неверно!");
                Console.Write("y2 = "); y2_s = Console.ReadLine();
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("<INFO> Напоминаем Вам, что центр координат - точка 0, 0");
            Console.WriteLine("Некоторые точки образуют с центром координат прямоугольный треугольник, если сумма квадратов катетов равна квадрату гипотенузы.");
            Console.WriteLine("Вычислим длины всех сторон по формуле sqrt((x2-x1)^2 +(y2-y1)^2).");

            Console.ResetColor();
            Console.WriteLine();
            double a = Math.Sqrt(Math.Pow(x2 - 0, 2) + Math.Pow(y2 - 0, 2)); //от B(x2, y2) до (0, 0)
            double b = Math.Sqrt(Math.Pow(x1 - 0, 2) + Math.Pow(y1 - 0, 2)); //от A(x1, y1) до (0, 0)
            double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // от A до B

            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) && (!(a==b)))
            {
                Console.WriteLine("Образовался прямоугольный треугольник");
            } else
            {
                Console.WriteLine("Прямоугольный треугольник не образован");

            }

            Console.ReadLine();


        }
    }
}
