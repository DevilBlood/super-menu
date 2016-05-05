using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор супер пупер проги:");
            Console.WriteLine("1 - Роботянка");
            Console.WriteLine("2 - Игра Угадай, сука, число");
            Console.WriteLine("3 - Жёсткий Топа");
            Console.WriteLine("4 - Марта - ловец");
            string myLanguage = Console.ReadLine();

            sw1(myLanguage);

            Console.ReadLine();
        }

        static void sw1(string s)
        {
            switch (s)
            {
                case "1":
                    Console.WriteLine("Вы выбрали Роботянку");
                    break;
                case "2":
                    Console.WriteLine("Вы выбрали игру от Альошки - Угадай, сука, число");
                    break;
                case "3":
                    Console.WriteLine("Вы выбрали очень жёстки вещи от Топы");
                    break;
                case "4":
                    Console.WriteLine("Вы выбрали Марту - ловца");
                    break;
                default:
                    Console.WriteLine("хуйня нейкая");
                    break;
            }
        }
    }
}