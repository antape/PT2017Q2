using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CalcBrain
    {
        public double firstoperand = 0;
        public double secondoperand = 0;
        public double result;
        public string operations;

        public void calculate()
        {
            if (operations == "+")
            {
                result = firstoperand + secondoperand;
            }

            if (operations == "-")
            {
                result = firstoperand - secondoperand;
            }

            if (operations == "*")
            {
                result = firstoperand * secondoperand;
            }
            if (operations == "/")
            {
                result = firstoperand/secondoperand;
            }
            
        }

        public void wipe()
        {
            firstoperand = 0;
            secondoperand = 0;
            
        }

    }
}
