using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorFromValentynTukov
{
    public class Utilites
    {



        public static void BMIRanges()
        {
            Console.WriteLine(" \n The Body Mass Index has the next ranges:\n Less or equal to 18.5 - Underweight;\n From 18.6 to 24.9 weight is normal;\n From 25 to 29.9 - Overweight;\n More then 29.9 - Obesity;\n");
        }

        public static double BMI(double x, double y)
        {
           double bmi =  x / (y * y);
           double _bmi = Math.Round(bmi, 2);
           return _bmi;

        }

        public static double MinUsefulWeight(double h)
        {
            double minWaight = h * h * 18.6;     // string bmi1 = bmi.ToString("0.00");
            double _minWaight = Math.Round(minWaight, 2);
            return _minWaight;
        }

        public static double MaxUsefulWeight(double hh)
        { 
            double maxWaight = hh * hh * 24.9;
            double _maxWaight = Math.Round(maxWaight, 2);
            return _maxWaight;
        }

        public static void Recomendation(double _minWaight, double _maxWaight)
        {
            Console.WriteLine($"!!!! Recomendations for you. Your optimal weight should be not less than {_minWaight} kg and not more than {_maxWaight} kg!");
            //24.9 = weight/height*height => weight = height * height * 24.9
        }


    }    
}
