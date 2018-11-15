using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    class Human : IHuman
    {
        private double height;
        private double weight;

        private double WeightIndex
        {
            get
            {
                return weight / Math.Pow(height, 2);
            }
        }

        public HumanState getWeightState()
        {
            double index = WeightIndex;
            if (index <= 16) return HumanState.STRONG_DEFICIT;
            else if ((index) > 16 && (index) <= 18.5) return HumanState.DEFICIT;
            else if ((index) > 18.5 && (index) < 24.99) return HumanState.NORMAL;
            else if ((index) > 25 && (index) < 30) return HumanState.OVERWEIGHT;
            else return HumanState.OBESITY;
        }

        public void setValues(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
        }

    }
}
