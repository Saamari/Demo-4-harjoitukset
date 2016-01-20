using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perintä_harjoitus
{
    class Person : Object
    {
        public string  FirstName {get; set;}
        public string LastName { get; set; }
        public string Ad { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Personmethod()
        {
            Console.WriteLine("Person does nothing ");
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Ad + " " + Age + " " + Phone + " ";
        }


    }

}
