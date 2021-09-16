using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    class Gem : GameObject
    {
        public int Value { get; set; }

        public Gem(int weight, int value)
            : base(weight)
        {
            this.Value = value;
        }
    }
}
