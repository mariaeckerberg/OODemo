using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemoCA
{
    abstract class Animal : Object, IEdible
    {
        public Animal(double weight) : base()
        {
            Weight = weight;
        }
        public double Weight { get; protected set; }

        public virtual void Eat(IEdible edible)
        {
            Weight += edible.Weight;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}";
        }

        public abstract void MakeSound();

        //internal void Foo()
        //{

        //}

    }
}
