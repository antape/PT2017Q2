using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабараторная работа #1, студент Джусупов Ануар\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание #1\nНапишите приложение для нахождения простого числа из заданного набора. Набор задается в виде входящей строки в переменную string[] args.");
            Console.ReadKey();
            
            Console.WriteLine("Количество цифр: {0}", args.Length);
            
            for (int i = 0; i < args.Length; i++){
                int tmp = 0;
                for (int k = 1; k <= int.Parse(args[i]); k++)
                {
                    if (int.Parse(args[i]) % k == 0)
                    {
                        tmp++; 
                    }
                }
                if (tmp == 2)
                {

                    Console.WriteLine("{0} Простое число", int.Parse(args[i]));
                }
                else { Console.WriteLine("{0} Не простое число", int.Parse(args[i])); }
            }


            Console.ReadKey();

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            
           Student s = new Student("Anuar", "Jussupov", 25, 3.0, 2);                  
           Console.WriteLine("Name: {0} \nSurname: {1} \nAge: {2} \nGPA: {3} \nCourse: {4}", s.name, s.surname, s.age, s.gpa, s.course);
            Console.WriteLine(s);


            Student[] s_t = new Student[2];
            
            for (int i = 0; i < s_t.Length; i++)
            {
                Console.WriteLine("\nStudent #{0}", i+1);
                  
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("GPA: ");
                double gpa = double.Parse(Console.ReadLine());
                Console.Write("Course: ");
                int course = int.Parse(Console.ReadLine());
                s_t[i] = new Student(name, surname, age, gpa, course);
                Console.WriteLine("Done... \n\n");
            }

            Console.WriteLine("\n Database"); 

            for (int i = 0; i < s_t.Length; i++)
            {
               Console.WriteLine("\n\nName: {0} \nSurname: {1} \nAge: {2} \nGPA: {3} \nCourse: {4}", s_t[i].name, s_t[i].surname, s_t[i].age, s_t[i].gpa, s_t[i].course);
            }
            
            Console.ReadKey();
        }
    }

    class Student
    {
        public string name;
        public string surname;
        public int age;
        public double gpa;
        public int course; 

        public Student(string _name, string _surname, int _age, double _gpa, int _course)
        {
            name = _name;
            surname = _surname;
            age = _age;
            gpa = _gpa;
            course = _course;  
        }

        public override string ToString()
        {
            // Необходимо вывести все данные, которые должен видеть пользователь при вызове меода Console.WriteLine(student);	
            return name + "\n" + surname + "\n" + age + "\n" + gpa + "\n" + course + "\n";

        }
            
        }

    }
