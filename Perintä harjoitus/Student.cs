using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perintä_harjoitus
{
    class Student : Person
    {
        public string Id { get; set; }



        public Student()
        {
        }

        public Student(string firstName, string lastName, string id) 
             :base(firstName,lastName)

            {
                Id = id;
            }


            public void Studentmethod()
              {
            Console.WriteLine("Studen tries to study");
              }

        public override string ToString()
        {
            return base.ToString() + " " + Id;
        }










    }
}
