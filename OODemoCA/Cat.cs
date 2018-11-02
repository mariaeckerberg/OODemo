using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemoCA
{
    class Cat : Animal
    {
        public Cat() : base(4.5)
        {

        }
        public void Purr()
        {
            Console.WriteLine("Purr...");
        }
        public void Purr(int volume)
        {
            Console.WriteLine($"Purring at a volume of {volume}...");
            //Foo();
        }

        public override string ToString()
        {
            return $"Cat {base.ToString()}";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
