using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    abstract class GameObject
    {
        public int Weight { get; private set; }

        public GameObject(int weight)
        {
            this.Weight = weight;
        }
    }
}
