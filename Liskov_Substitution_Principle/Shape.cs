using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    // Base class for geometric shapes
    class Shape
    {
        public virtual double Area()
        {
            return 0.0; // Default implementation for an unknown shape
        }
    }
}
