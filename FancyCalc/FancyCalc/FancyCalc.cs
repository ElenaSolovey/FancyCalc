using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(double a, double b)
        {
            //throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(double a, double b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(double a, double b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            throw new NotImplementedException();


        }
    }
}
