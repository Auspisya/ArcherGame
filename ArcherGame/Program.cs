using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных
            int player1Score = 0;
            int player2Score = 0;

            // Приветствие
            Console.WriteLine("Добро пожаловать в игру *Лучник*!");
            Console.ReadKey();

            // Первый игрок делает 3 выстрела
            Console.WriteLine("Игрок 1 делает 3 выстрела!");
            Console.ReadKey();
            for (int i = 0; i < 3; i++)
            {
                int player1Throw = Throw();
                player1Score += player1Throw;
                Console.WriteLine("Выстрел {0}: {1}", i + 1, player1Throw);
                Console.ReadKey();
            }

            // Второй игрок делает 3 выстрела
            Console.WriteLine("Игрок 2 делает 3 выстрела!");
            Console.ReadKey();
            for (int i = 0; i < 3; i++)
            {
                int player2Throw = Throw();
                player2Score += player2Throw;
                Console.WriteLine("Выстрел {0}: {1}", i + 1, player2Throw);
                Console.ReadKey();
            }

            // Определение победителя
            Console.WriteLine("Счёт 1 игрока: {0}", player1Score);
            Console.ReadKey();
            Console.WriteLine("Счёт 2 игрока: {0}", player2Score);
            Console.ReadKey();
            if (player1Score > player2Score)
            {
                Console.WriteLine("Игрок 1 выигрывает!");
                Console.ReadKey();
            }
            else if (player1Score < player2Score)
            {
                Console.WriteLine("Игрок 2 выигрывает!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ничья!");
                Console.ReadKey();
            }
        }

        // Генерируем случайный счёт броска
        static int Throw()
        {
            Random random = new Random();
            return random.Next(0, 10);
        }
    }
}
