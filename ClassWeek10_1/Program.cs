using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWeek10_1
{
    enum UI : long { Name, Family, ShortName = 5, Age, Sex }
    class Program
    {
        static void Main(string[] args)
        {
            UI user1;
            for (user1 = UI.Name; user1 <= UI.Sex; user1++)
                Console.WriteLine("Элемент: \"{0}\", значение {1}", user1, (int)user1);

            Console.ReadLine();
        }
    }
}
