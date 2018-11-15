using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public interface IHuman
    {
        void setValues(double height, double weight);
        HumanState getWeightState();
    }
}
