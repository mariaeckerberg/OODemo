using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemoCA
{
    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {

        }
        public void Bark()
        {
            Console.WriteLine("Bark!");
        }

        public override void Eat(IEdible edible)
        {
            Weight += 0.8 * edible.Weight;
        }

        public override string ToString()
        {
            return $"Dog {base.ToString()}";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woff!");
        }
    }
}
