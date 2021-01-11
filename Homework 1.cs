using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c, i;
            double result;

            Console.WriteLine("Введите число 1");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            c = int.Parse(Console.ReadLine());

            int sum = 0;
            int oddvalue = 0;
            try
            {
                for (i = a; i <= c; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddvalue++;
                        sum += i;
                    }
                }
                result = sum / oddvalue;
                Console.WriteLine("Среднее арифметическое значение,в промежутке данных чисел: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0");
            }
        }
    }
}
