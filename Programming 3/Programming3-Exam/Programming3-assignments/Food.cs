using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    class Food : GameObject
    {
        public int Calories { get; set; }

        public Food(int weight, int calories)
            : base(weight)
        {
            this.Calories = calories;
        }
    }
}
