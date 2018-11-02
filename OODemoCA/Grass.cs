using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemoCA
{
    class Grass : IEdible
    {
        public Grass(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; set; }

    }
}
