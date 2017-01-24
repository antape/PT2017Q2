using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
                    }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex tmp = new Complex(0,0);

            tmp.a = c1.a + c2.a;
            tmp.b = c1.b + c2.b;

            return tmp;
        }
        
        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, b);
        }
    }


    

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 4);
            Complex c2 = new Complex(2, 9); 
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine(c1 + c2);

            Console.ReadKey();
        }
    }
}
