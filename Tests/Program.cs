﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread t = new Thread(new ThreadStart(DoIt));
            //t.Start();
            DoIt();
        }

        static void DoIt()
        {
            while (true)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("*");
            }
        }
    }
}
