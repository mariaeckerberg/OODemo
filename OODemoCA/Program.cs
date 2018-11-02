using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemoCA
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            var animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog(10));

            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Eat(new Grass(1));
                Console.WriteLine(animal.Weight);
            }
        }
    }
}
