﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample
{
    public class Worker
    {
        public bool isActive = true;
        public int x = 10;
        public int y = 10;
        public int dx = 0;
        public int dy = 0;
        public int timer = 1000;
        public void work()
        {
            while (isActive)
            {
                Thread.Sleep(timer);
                Console.CursorVisible = false;
                Console.Clear();
                x += dx;
                y += dy;
                Console.SetCursorPosition(x, y);
                Console.Write('*');
            }
        }
        public void stop()
        {
            isActive = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            Thread t = new Thread(new ThreadStart(w.work));
            t.Start();
            while (w.isActive)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.UpArrow)
                {
                    w.dx = 0;
                    w.dy = -1;
                }
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    w.dx = 0;
                    w.dy = 1;
                }
                else if (k.Key == ConsoleKey.RightArrow)
                {
                    w.dx = 1;
                    w.dy = 0;
                }
                else if (k.Key == ConsoleKey.LeftArrow)
                {
                    w.dx = -1;
                    w.dy = 0;
                }
                else if (k.Key == ConsoleKey.S)
                {
                    w.timer = (int)(w.timer * 0.7);
                }
                else if (k.Key == ConsoleKey.Escape) w.stop();
            }
            Console.WriteLine();
            Console.WriteLine("The end");
            Console.ReadKey();
        }
    }
}
