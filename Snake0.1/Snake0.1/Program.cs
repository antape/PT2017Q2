using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake0._1
{

    class Level
    {
        public int tY, dY, rX, lX;

        public Level(int lX, int rX, int tY, int dY)
        {
            this.rX = rX;
            this.lX = lX;
            this.tY = tY;
            this.dY = dY;
        }

    }

    class Fruit
    {

        public int frX, frY, active;

        public Fruit(int frX, int frY, int active)
        {
            this.frX = frX;
            this.frY = frY;
            this.active = active;
        }
      

    }

   

    class Program
    {

        

        static void Main(string[] args)
        {

            

            Random rnd = new Random();
            //создаем уровень
            Level level = new Level(1, 30, 1, 20);

            

            

            //создаем фрукты
            Fruit[] fruit = new Fruit[3];
            int i = 0;
            while (i != fruit.Length)
            {
                fruit[i] = new Fruit(rnd.Next(1, 20), rnd.Next(1, 20), 0);
                i++;
            }
            
                

            Console.CursorVisible = false; // гасим курсор
            ConsoleKeyInfo k;

            // Координаты игрока
            int playerX = 15;
            int playerY = 15;
            char playerChar = '*';
            int points = 0;

            // Координаты флага
            int flagX = 25;
            int flagY = 5;
            int tmp = 0;

            do
            {
                Console.Clear();
                /*
                int t = 0;
                while (t != level.rX+1)
                {
                    Console.SetCursorPosition(t, 0);
                    Console.Write('+');
                    
                    t++;
                }*/


                

                Console.SetCursorPosition(0, 1);
                Console.Write(points);
                



                
                if (tmp == 0) { 
                Console.SetCursorPosition(flagX, flagY);
                Console.Write("F"); // флаг
                }

                i = 0;
                while (i != fruit.Length)
                {
                    if (fruit[i].active == 0)
                    {
                        Console.SetCursorPosition(fruit[i].frX, fruit[i].frY);
                        Console.Write("F"); // флаг
                    }
                    i++;
                }
               

                Console.SetCursorPosition(playerX, playerY);
                Console.Write(playerChar);
                // Анимация движения игрока
                // playerChar = playerChar == 'X' ? 'Y' : 'X';

                k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.UpArrow)
                {
                    playerY--;
                    if (playerY == level.tY - 1)
                        playerY = playerY + level.dY-1;

                }

                else if (k.Key == ConsoleKey.DownArrow)
                {
                    playerY++;
                    if (playerY == level.dY)
                        playerY = playerY - level.dY+1;
                }
                else if (k.Key == ConsoleKey.LeftArrow)
                {
                    playerX--;
                    if (playerX == level.lX - 1)
                        playerX = playerX + level.rX - level.lX;

                }

                else if (k.Key == ConsoleKey.RightArrow)
                {
                    playerX++;
                    if (playerX == level.rX)
                        playerX = playerX - level.rX + level.lX;

                }

                if (tmp == 0 && playerX == flagX && playerY == flagY)
                {
                        tmp = 1;
                        points++;
                }


                i = 0;
                while (i != fruit.Length)
                {
                    if (fruit[i].active == 0 && playerX == fruit[i].frX && playerY == fruit[i].frY)
                    {
                        fruit[i].active = 1;
                        points++;
                    }
                    i++;
                }


                

            } while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc

            Console.CursorVisible = true;
        }
    }
}
