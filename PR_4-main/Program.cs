using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "практиечская работа №4";// заголовок консоли
            double x, y, z; // объявление переменных
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11; // действия

            Console.WriteLine("здравствуйте");
            Console.Write("Введите x= ");// введение переменных
            x = Convert.ToDouble(Console.ReadLine());// явное приеведение к double
            Console.Write("Введите y= ");// введение переменных
            y = Convert.ToDouble(Console.ReadLine());

            // расчет выражения
            v1 = Math.Log10(x);// расчет десятичного логарифма
            v2 = Math.Pow(v1, 2);// возведение в степень
            v3 = Math.Exp(y);// расчет числа е
            v4 = 2 * y;
            v5 = Math.Sin(v4);// расчет синуса
            v6 = Math.Pow(v3, v5);
            v7 = v6 * v2;
            v8 = 3 * x;
            v9 = Math.Log10(v8);
            v10 = Math.Sqrt(y);// нахождение корня
            v11 = v9 + v10;

            z = v7 / v11;// вычисление результата

            // вывод результата
            Console.WriteLine("результат: z = {0: 0.###### }", z);
            Console.ReadKey();// задержка экрана консоли
        }
    }
}
