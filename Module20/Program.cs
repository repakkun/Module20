using System;
using System.Threading;

namespace Module20
{
    class Program
    {
        class User
        {
            public string Name { get; set; }
            public string Login { get; set; }
            public bool IsPremium { get; set; }

        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Введите имя");
            user.Name = Console.ReadLine();

            Console.WriteLine("Введите логин");
            user.Login = Console.ReadLine();

            Console.WriteLine("Премиум? да/нет");
            string answ = Console.ReadLine();
            switch (answ)
            {
                case "да":
                    user.IsPremium = true;
                    break;
                case "нет":
                    user.IsPremium = false;
                    break;
            }
            if (user.IsPremium)
            {
                Console.WriteLine($"Приветсвуем, {user.Name}");
            }
            else ShowAds();
        }
    }
}
