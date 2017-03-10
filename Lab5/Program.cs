using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
//using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
    /*
{
    // класс и его члены объявлены как public
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // стандартный конструктор без параметров
        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Person person = new Person("Tom", 29);
            Console.WriteLine("Объект создан");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Person));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Имя: {0} --- Возраст: {1}", newPerson.Name, newPerson.Age);
            }

            Console.ReadLine();
        }
    }
}

*/
{
     [Serializable]
    public class Complex
    {
        public int a, b;
        

        public Complex(int A, int B)
        {
            this.a = A;
            this.b = B;
        }
        public Complex( ) { }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex tmp = new Complex(0, 0);

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
            Complex c3 = c1 + c2;
            Console.WriteLine("Созданы объекты:");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3 + "Сумма двух чисел");


            XmlSerializer formatter = new XmlSerializer(typeof(Complex));
            using (FileStream fs = new FileStream("test1.xml", FileMode.Create))
            {
                formatter.Serialize(fs, c1);
               formatter.Serialize(fs, c2);
                //formatter.Serialize(fs, c3);

                Console.WriteLine("Сериализация прошла успешно, данные сохраненны в файл complex.xml");
            }

            
            
            Console.ReadKey();

            Console.WriteLine("Десериализация и чтение данных");

            using (FileStream fs = new FileStream("test1.xml", FileMode.Open))
            {
                Complex c1_2 = (Complex)formatter.Deserialize(fs);
                Complex c2_2 = (Complex)formatter.Deserialize(fs);
                //Complex c3_2 = (Complex)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine(c1_2);
                //Console.WriteLine(c2_2);
                //Console.WriteLine(c3_2);
            }


                    

            Console.ReadKey();
        }
    }
}

