using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            
            DirectoryInfo ourDir = new DirectoryInfo(@"C:\Program Files");

            Console.WriteLine("Directory: {0}", ourDir.FullName); 

            foreach (FileInfo file in ourDir.GetFiles()) // file is iterator
            {
                Console.WriteLine("File: {0}", file.Name);
            }
            int n = 0;
            while (true)
            {
                Console.Clear();
                int i = 0;
                foreach (DirectoryInfo dir in ourDir.GetDirectories()) // dir is iterator
                {
                    i++;
                    if (i == n) Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Directory: {0} {1}", i, dir.Name); // Console.WriteLine("Directory: " + i + " " + dir.Name);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key.Equals(ConsoleKey.DownArrow) && n < ourDir.GetDirectories().Length) n++; //down
                if (k.Key.Equals(ConsoleKey.UpArrow) && n != 0) n--;  // up
                if (k.Key.Equals(ConsoleKey.Enter)) ourDir = ourDir.GetDirectories()[n - 1]; // open current directory
                if (k.Key.Equals(ConsoleKey.LeftArrow)) ourDir = ourDir.Parent;
            }


            */






            
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Program Files");
            
            FileInfo[] fileNames = dirInfo.GetFiles("*.*");


            //dirInfo = dirInfo.GetDirectories()[2];

            int n = 0;

            List<string> dir = new List<string>();
            dir.Add(@"C:\Program Files\CPUID");




            dirInfo = new DirectoryInfo(dir[0]);
            Console.WriteLine("Directory: {0}\n", dirInfo.FullName); 

            foreach (DirectoryInfo d in dirInfo.GetDirectories())
            {
                
                Console.WriteLine("--{0}", d.Name);
                

            }



            /*
            while (true)
            {
                Console.Clear();
                Console.WriteLine(dirInfo.Name);

                int i = 0;
               


                foreach (DirectoryInfo d in dirInfo.GetDirectories())
                {
                    i++;
                    if (i == n) Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("--{0}", d.Name);
                    Console.BackgroundColor = ConsoleColor.Black;

                }

                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key.Equals(ConsoleKey.DownArrow) && n < dirInfo.GetDirectories().Length) n++; //down
                if (k.Key.Equals(ConsoleKey.UpArrow) && n != 0) n--;  // up
                if (k.Key.Equals(ConsoleKey.Enter)) dirInfo = dirInfo.GetDirectories()[n - 1]; // open current directory
                if (k.Key.Equals(ConsoleKey.LeftArrow)) dirInfo = dirInfo.Parent;

            }
                /*
                foreach (FileInfo fi in fileNames)
                {
                    Console.WriteLine("-{0}", fi.Name);
                }
            }

            /*
            while (true)
            {
                Console.Clear();
                int i = 0;
                foreach (DirectoryInfo dir in ourDir.GetDirectories()) // dir is iterator
                {
                    i++;
                    if (i == n) Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Directory: {0} {1}", i, dir.Name); // Console.WriteLine("Directory: " + i + " " + dir.Name);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key.Equals(ConsoleKey.DownArrow) && n < ourDir.GetDirectories().Length) n++; //down
                if (k.Key.Equals(ConsoleKey.UpArrow) && n != 0) n--;  // up
                if (k.Key.Equals(ConsoleKey.Enter)) ourDir = ourDir.GetDirectories()[n - 1]; // open current directory
                if (k.Key.Equals(ConsoleKey.LeftArrow)) ourDir = ourDir.Parent;
            }

    */
            Console.ReadKey();
        }
    }
}
