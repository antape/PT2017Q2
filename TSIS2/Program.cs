using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TSIS2
{
    class Program
    {

        static class RandomLetter
        {
            static Random _random = new Random();
            public static char GetLetter()
            {
                int num = _random.Next(0, 26); 
                char let = (char)('a' + num);
                return let;
            }
        }

        static void Main(string[] args)
        {
            Random _random = new Random();
            Worker w = new Worker();
            Thread t = new Thread(new ThreadStart(w.work));
            double num = _random.NextDouble();
            w.timer = (int)(w.timer * num);
            t.Start();

            
        }


        public class Worker
        {
            public bool isActive = true;
            public int flagY = 1;
            public int timer = 1000;
            ConsoleKeyInfo k;
            

            public void work()
            {
                k = Console.ReadKey(true);


                while (k.Key != ConsoleKey.Escape)
                {

                    flagY++;
                    

                    Console.SetCursorPosition(0, flagY - 1);
                    Console.Write(' ');
                    Console.SetCursorPosition(0, flagY);
                    Console.Write(RandomLetter.GetLetter());
                    Console.SetCursorPosition(0, flagY + 1);
                    Console.Write(RandomLetter.GetLetter());
                    Console.SetCursorPosition(0, flagY + 2);
                    Console.Write(RandomLetter.GetLetter());
                    Thread.Sleep(timer);

                    

                }
                
            }


            public void stop()
            {
                isActive = false;
            }
        }

       
    }
}
