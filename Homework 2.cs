static void Main(string[] args)
        {
            Console.Write("Введите начало интервала: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.Write("Конец интервала: ");
            int y = int.Parse(Console.ReadLine());

            Random rand = new Random();

            int A = rand.Next(x, y);
            int f = 0;

            while (f < 3)
            {      
                Console.WriteLine("Введите число");
                int B = int.Parse(Console.ReadLine());              
                
                if (B == A)
                {
                    Console.WriteLine("Вы угадали:" + B);
                    break;
                }
                   
                else if (B > A)
                {
                    Console.WriteLine("Ваше число больше");
                }
                else
                {
                    Console.WriteLine("Ваше число меньше");
                }
                
                f++;
                
                if (f == 1)
                {
                    Console.WriteLine("У вас осталось 2 попытки!");
                }
                else if (f == 2)
                {
                    Console.WriteLine("У вас осталась 1 попытка!");
                }
                else if (f == 3)
                {
                    Console.WriteLine("К сожалению вы проиграли, у вас закончились попытки!");
                }               
            }
        }
