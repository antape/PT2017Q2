using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWeek9
{
    class CalcBrain
    {
        public double first;
        public double second;
        public double result;
        public string op;

        public void cals()
        {
            if (op == "+")
            {
                result = first + second;
                
            }

            if (op == "-")
            {
                result = first - second;
            }
        }

    }
}
