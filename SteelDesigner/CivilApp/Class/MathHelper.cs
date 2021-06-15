using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class
{
    class MathHelper
    {
        public static double Interpolate(double value, double firstInput, double secondInput, double firstOutput, double secondOutput)
        {
            string text = "";
            double percentage = (value - firstInput) / (secondInput - firstInput);
            text += percentage * 100 + "%" + "\r\n";
            

            //Console.WriteLine(percentage* 100 + "%" );
            double range = secondOutput - firstOutput;
            double difference = range * percentage;
            double result = firstOutput + range*percentage;
            //Console.WriteLine(firstOutput + "+" + difference + "=" + result);
            text += firstOutput + "+" + range +"*"+ percentage+ "=" + result + "\r\n";
            //Console.Write(text);
            return result;
        }

        public static double Round2dec(double number)
        {
            return Math.Round(number * 100) / 100;
        }

        public static double Round3dec(double number)
        {
            return Math.Round(number * 1000) / 1000;
        }
    }
}
