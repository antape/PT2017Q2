using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_task2
{
    class Cheese
    {
        public int weight;
        public string sort;
        public Cheese(int weight, string sort)
        {
            this.weight = weight;
            this.sort = sort;
        }
        

        public static Cheese operator +(Cheese c1, Cheese c2)
        {
            Cheese tmp = new Cheese(0, "temp");

            if (c1.sort == c2.sort)
            {
                tmp.weight = c1.weight + c2.weight;
                tmp.sort = c1.sort;

            }
            else
            {
                tmp.weight = c1.weight + c2.weight;
                tmp.sort = "UNKNOWN";
            }
            

            return tmp;
        }

        public override string ToString()
        {
            return string.Format("Weigth {0} | Sort {1}", weight, sort);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Cheese c1 = new Cheese(2, "Test_1");
            Cheese c2 = new Cheese(4, "Test_1");
            Cheese c3 = new Cheese(3, "Test_2");
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("Работа оператора суммы");


            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 + c3);

            Console.ReadKey();
        }
    }
}
