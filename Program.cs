using System.Text; // Соддержит Encoding

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8; // Это нужно для корректной работы debug консоли
            Console.OutputEncoding = Encoding.UTF8;
            var ran = new Random(); // В отличии от c++ и python, seed определяется автоматически, поэтому необязательно добавлять таймер сюда
            int number = ran.Next()%100;
            while (true){
                Console.WriteLine("Загадано число от 0 до 100, введите это число:");
                int attempts = 0;
                while (true)
                {
                    int guess = int.Parse(Console.ReadLine());
                    attempts++;
                    if (number < guess) Console.WriteLine("Заданное число меньше вашего");
                    else if (number > guess) Console.WriteLine("Заданное число больше вашего");
                    else
                    {
                        Console.WriteLine($"Вам получилось угадать число за {attempts} попыток");
                        break;
                    }    
                }
                string answer = "";
                while (!((List<string>) ["да", "нет"]).Contains(answer))
                {
                    Console.Write("Хотите сыграть еще раз(да/нет): ");
                    answer = Console.ReadLine();
                    if (answer == "нет") break;
                    else if (answer == "да") break;
                    else Console.WriteLine("Вы инвалид");
                }
                if (answer == "нет") break;
                else if (answer == "да")
                {
                    answer = "";
                    number = ran.Next()%100;
                }
            }

            Console.WriteLine("Нажмите enter, что-бы выйти из программы...");
            Console.ReadLine();
        }
    }
}
