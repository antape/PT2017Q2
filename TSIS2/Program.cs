using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

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
            Worker[] w = new Worker[50];
            Worker2 d = new Worker2(15);
            d = new Worker2(15);




            for (int i = 0; i < 50;i++)
            {
                w[i] = new Worker(i*3);
                
            }

            Thread t = new Thread(w[0].work);
            Thread x = new Thread(d.work);
            t.Start();
            x.Start();


            //Thread[] t = new Thread[50];
            /*
            for (int i = 0; i < 50; i++)
            {
                
              //  t[i] = new Thread(w[i].work);
                //t[i].Start();
                
                double num = _random.NextDouble();
                w[i].timer = (int)(w[i].timer * num);
                
            }
        */
            /*
            for (int i = 0; i < 50; i++)
            {

                t[i].Start();
                double num = _random.NextDouble();
                w[i].timer = (int)(w[i].timer * num);

            }
            
            */


        }


        public class Worker
        {
            public bool isActive = true;
            public int flagY = 1;
            public int timer = 1000;
            public int left;
            
            public readonly static object locker = new object();
            public Worker(int l)
            {
                left = l;
            }

            public void work()
            {
                lock(locker)
                {
                    //k = Console.ReadKey(true);


                    while (true)
                    {

                        flagY++;


                        Console.SetCursorPosition(left, flagY - 1);
                        Console.Write(' ');
                        Console.SetCursorPosition(left, flagY);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 1);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 2);
                        Console.Write(RandomLetter.GetLetter());
                        Thread.Sleep(timer);


                        /*
                        flagY++;


                        Console.CursorLeft = left;
                        Console.CursorTop = flagY - 1;
                        Console.Write(' ');

                        Console.CursorTop = flagY;
                        Console.Write(RandomLetter.GetLetter());
                        Console.CursorTop = flagY+1;
                        Console.Write(RandomLetter.GetLetter());
                        Console.CursorTop = flagY+2;
                        Console.Write(RandomLetter.GetLetter());
                        /*
                        Console.SetCursorPosition(left, flagY);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 1);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 2);
                        Console.Write(RandomLetter.GetLetter());
                        
                        Thread.Sleep(timer);
                        */


                    }

                }

            }


            public void stop()
            {
                isActive = false;
            }
        }

        public class Worker2
        {
            public bool isActive = true;
            public int flagY = 1;
            public int timer = 1000;
            public int left;

            public readonly static object locker = new object();
            public Worker2(int l)
            {
                left = l;
            }

            public void work()
            {
                lock(locker)
                {
                    //k = Console.ReadKey(true);


                    while (true)
                    {

                        flagY++;


                        Console.SetCursorPosition(left, flagY - 1);
                        Console.Write(' ');
                        Console.SetCursorPosition(left, flagY);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 1);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 2);
                        Console.Write(RandomLetter.GetLetter());
                        Thread.Sleep(timer);


                        /*
                        flagY++;


                        Console.CursorLeft = left;
                        Console.CursorTop = flagY - 1;
                        Console.Write(' ');

                        Console.CursorTop = flagY;
                        Console.Write(RandomLetter.GetLetter());
                        Console.CursorTop = flagY+1;
                        Console.Write(RandomLetter.GetLetter());
                        Console.CursorTop = flagY+2;
                        Console.Write(RandomLetter.GetLetter());
                        /*
                        Console.SetCursorPosition(left, flagY);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 1);
                        Console.Write(RandomLetter.GetLetter());
                        Console.SetCursorPosition(left, flagY + 2);
                        Console.Write(RandomLetter.GetLetter());
                        
                        Thread.Sleep(timer);
                        */


                    }

                }

            }


            public void stop()
            {
                isActive = false;
            }
        }

    }
}
