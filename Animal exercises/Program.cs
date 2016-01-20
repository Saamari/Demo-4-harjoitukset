using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Animal animal1 = new Dog();
            animal1.Talk(); // Wuw!
            Console.WriteLine("animal1 has {0} legs.", animal1.Legs); // animal1 has 4 legs.
            Console.WriteLine("animal1 type is {0}.", animal1.GetType()); // animal1 type is PolymorphismApplication.Dog
        }
    }
}
