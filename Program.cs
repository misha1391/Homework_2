namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ran = new Random(); // В отличии от c++ и python, seed определяется автоматически, поэтому необязательно добавлять таймер сюда
            int number = ran.Next()%100;
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
        }
    }
}
