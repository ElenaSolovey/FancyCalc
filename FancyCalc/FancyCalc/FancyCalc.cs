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
            if (expression == null)
                throw new ArgumentNullException();

            string[] words = expression.Split(new char[] { ' ', '+', '-', '*' }, StringSplitOptions.RemoveEmptyEntries);
            double a = Double.Parse(words[0]);
            double b = Double.Parse(words[1]);

            int indexOFChar1 = expression.IndexOf('+');
            int indexOFChar2 = expression.IndexOf('-');
            int indexOFChar3 = expression.IndexOf('*');
            if (indexOFChar1 > 0)
            {
                return Add(a, b);
            }
            else if (indexOFChar2 > 0)
            {
                return Subtract(a, b);
            }
            else if (indexOFChar3 > 0)
            {
                return Multiply(a, b);
            }
            else { 
            Console.Write("Error");
            return 0;
               }
         }
    }
}
