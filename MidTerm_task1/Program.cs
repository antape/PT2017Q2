using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MidTerm_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\mid\midterm.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("2 12 92 152 143 99");
            sw.Close();
            file.Close();

            //считывания содержимое как string и через сплит заносим в массив типа string
            string text = File.ReadAllText(@"C:\mid\midterm.txt");
            Console.WriteLine("Файл midterm.txt создан\n\nСодержимое файла:\n{0}", text);
            string[] temp = text.Split(' ', '\n');

            
            for (int i = 0; i < temp.Length; i++)
            {
                int a = int.Parse(temp[i]); 
                if ((a % 10 == 2) && (a % 3 == 0))
                    Console.WriteLine(temp[i]);
            }
           
            Console.ReadKey();
        }
    }
}
