//Jason Lohmer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
            num1 = 51;
            num2 = 785;
            num3 = 83;
            num4 = 98;

            double result = Add(num1, num2);
            Console.WriteLine($"{num1.ToString("N2")} + {num2} = {result}");
            double result2 = Subtract(num4, num3);
            Console.WriteLine($"{num4} - {num3} = {result2}");

            
            Console.ReadLine();
        
        }

        static public double Add(double val1, double val2)
        {
            var sum = val1 + val2;
            return sum;
        }

        static double Add(double[] values)
        {
            double sum = 0;
            int counter = 0;
            //while loop
            /* while (counter < values.Length)
            {
                sum += values[counter];
                counter++;
            } 
            */

            //For
            /* for (counter = 0; counter < values.Length; counter++)
            {
                sum += values[counter];
            }
            */
            //Foreach
            foreach (var item in values)
            {
                sum += item;
            }

            return sum;
        }
        static public double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }
    }
}
