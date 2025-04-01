using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVirtual251.Figures
{
    internal class Circle
    {
        private float pi = 3.14f;
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float GetArea()
        {
            return pi * radius * radius;
        }

    }
}
