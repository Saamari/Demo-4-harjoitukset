using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perintä_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Kirsi";
            person.LastName = " Kerubi";
            person.Age = 69;
            person.Ad = "Laamakatu 55";
            person.Phone = "0400777888";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi" , "Konsoli" , "D4056");
            teacher.Ad = "Muurarintie 44 B";
            teacher.Age = 88;
            teacher.Phone = "050677333";
            Console.WriteLine(teacher.ToString());

            Student student = new Student(" Sampsa ", "Kautto ", "K100");
            student.Ad = "Apinakatu 6";
            student.Age = 23;
            student.Phone = "0100 0100";
            Console.WriteLine(student.ToString());

            Console.WriteLine(" Press enter to continue ");
            Console.ReadLine();
            
        }
    }
}
