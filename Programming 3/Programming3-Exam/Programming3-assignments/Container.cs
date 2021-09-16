using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    abstract class Container
    {
        private int maxWeight;

        public Container(int maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        private List<GameObject> content = new List<GameObject>();

        public void Add(GameObject gameObject)
        {
            content.Add(gameObject);
        }

        public int CalculateWeight()
        {
            int total = 0;
            foreach (GameObject gameObject in content)
            {
                total += gameObject.Weight;
            }
            return total;
        }
    }
}
