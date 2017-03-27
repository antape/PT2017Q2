using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab10
{
    public delegate void PrintDelegate();
   
    class Hello
    {
        public int a = 0;
        public int b = 0;

        public void summ()
        {
            
            Console.WriteLine(a+b);
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {

            Hello h = new Hello();
            PrintDelegate d;
            h.a = 10;
                h.b = 20;
            
            d = h.summ;
            Thread.Sleep(1000);
            d.Invoke();

            Console.ReadKey();
        }
    }
}
