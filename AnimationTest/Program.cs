using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // гасим курсор
            ConsoleKeyInfo k;

            // Координаты игрока
            int playerX = 15;
            int playerY = 15;
            char playerChar = 'X';

            // Координаты флага
            int flagX = 25;
            int flagY = 5;

            do
            {
                Console.Clear();

                Console.SetCursorPosition(flagX, flagY);
                Console.Write("F"); // флаг

                Console.SetCursorPosition(playerX, playerY);
                Console.Write(playerChar);
                // Анимация движения игрока
               // playerChar = playerChar == 'X' ? 'Y' : 'X';

                k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.UpArrow)
                    playerY--;
                else if (k.Key == ConsoleKey.DownArrow)
                    playerY++;
                else if (k.Key == ConsoleKey.LeftArrow)
                    playerX--;
                else if (k.Key == ConsoleKey.RightArrow)
                    playerX++;

                if (playerX == flagX && playerY == flagY)
                {
                    Console.Clear();
                    Console.WriteLine("EPIC WIN!");
                    break; // выходим из цикла do - while
                }

            } while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc

            Console.CursorVisible = true;
        }
    }
}
