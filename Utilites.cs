using System;

using System;
using System.Runtime.Intrinsics.X86;

namespace BmiCalculatorFromValentynTukov
{
    public class Utilites
    {
        static void BMIRanges()
        {
            Console.WriteLine(" \n The Body Mass Index has the next ranges:\n Less or equal to 18.5 - Underweight;\n From 18.6 to 24.9 weight is normal;\n From 25 to 29.9 - Overweight;\n More then 29.9 - Obesity;\n");
        }

        public static double BMI(double x, double y)
        {
            return x / (y * y);
        }
    }
}
