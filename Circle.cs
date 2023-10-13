using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5MorganWestinOop
{
    public class Circle
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float GetArea()
        {
            return MathF.PI * radius * radius;
        }

        public float GetCircumference()
        {
            return 2 * MathF.PI * radius;
        }

        public float GetVolumeAsSphere()
        {
            // Anta att detta är en sfär och beräkna volymen.
            return (4.0f / 3.0f) * MathF.PI * MathF.Pow(radius, 3);
        }
    }
}
