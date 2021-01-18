//Каждый способ постарался обозначить комментарием, чтобы было проще разобраться
       
       static void Main(string[] args)     
        {
            Console.Write("(Способ 1) Введите число: ");   //Начало первого способа 
            int i = int.Parse(Console.ReadLine());
            for (int a = 1; a <= i; a++)
            {
                if (i % a == 0)
                    Console.Write("{0} ", a);
            }                                              //Конец первого способа

            Console.Write("\n(Способ 2) Введите число: "); //Начало второго способа
            int g = int.Parse(Console.ReadLine());
            int c = 1;
            while (c <= g)
            {
                if (g % c == 0)
                {
                    Console.Write("{0} ", c);
                }
                c++;
            }                                              //Конец второго способа

            Console.Write("\n(Способ 3) Введите число: "); //Начало третьего способа
            int m = int.Parse(Console.ReadLine());
            for (int b = 1; b <= m / b; b++)
            {
                if (m % b == 0)
                {
                    if (b != m / b)
                    {
                        Console.Write("{0} {1} ", b, m / b);
                    }
                    else 
                    { 
                        Console.Write("{0} ", b);
                    }
                }
            }                                            //Конец третьего способа
        }
    }
}
