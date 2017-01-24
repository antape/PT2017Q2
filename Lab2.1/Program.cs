using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            FileStream file = new FileStream(@"D:\lab2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("1235 1455 1898 1423");
            sw.Write("5 9 3 0");
            sw.Close();
            file.Close();
           
            //считывания файла и занесение в массив
            string text = File.ReadAllText(@"D:\lab2.txt");
            Console.WriteLine("Файл lab2.txt создан\n\nСодержимое файла:\n{0}", text);
            string[] temp = text.Split(' ','\n');

            //скидываем все в лист
            List<int> numbers = new List<int>();
            List<int> prime = new List<int>();

            for (int i = 0; i < temp.Length; i++)
            {
                int tmp = 0;
                numbers.Add(int.Parse(temp[i]));
                for (int k = 1; k <= int.Parse(temp[i]); k++)
                {
                    if (int.Parse(temp[i]) % k == 0)
                    {
                        tmp++;
                    }
                }

                if (tmp == 2) prime.Add(int.Parse(temp[i]));


            }
            numbers.Sort(); //сортиреум
            prime.Sort();

            Console.WriteLine("\n\nMIN: {0}, MAX: {1}", numbers[0], numbers[numbers.Count() - 1]);
            Console.WriteLine("\n\nMIN: {0}, MAX: {1}", prime[0], prime[prime.Count() - 1]);
            Console.ReadKey();
        }
    }
}
