using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c, s, k, i;
            double average;
            s = 0;
            k = 0;

            Console.WriteLine("Введите число a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число c");
            c = Convert.ToInt32(Console.ReadLine());

            try
            { 
                for (i = a; i <= c; i++)
                {
                    if (i % 2 != 0) 
                    { 
                        k++;
                        s += i;
                    }
                }
                average = s / k;
                Console.WriteLine("Ответ:" + average);
            }
                

            catch (DivideByZeroException)
            {
                Console.WriteLine("Нелзя делить на 0");
            }
        }
    }
}
