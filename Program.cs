using System.Text; // Соддержит Encoding

namespace Homework_2
{
    class Randomise
    {
        // Ничего похожего на def __init_(): здесь не нужно, оно сразу все проходит
        private Random ran = new Random(); // Для каждого метода, поля нужно вручную приписывать public или private(По умолчанию private)
        public int Go()
        {
            return ran.Next()%100; // В отличии от c++ и python, seed определяется автоматически, поэтому необязательно добавлять таймер сюда
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8; // Это нужно для корректной работы debug консоли
            Console.OutputEncoding = Encoding.UTF8;

            var ran = new Randomise();
            int number = ran.Go();
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
                    if (attempts > 7)
                    {
                        Console.WriteLine($"Вам не получилось угадать число, заданное число {number}");
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
                    number = ran.Go();
                }
            }

            Console.WriteLine("Нажмите enter, что-бы выйти из программы...");
            Console.ReadLine();
        }
    }
}
