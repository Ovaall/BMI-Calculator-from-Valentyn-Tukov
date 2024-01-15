
using System;
using System.Runtime.Intrinsics.X86;

namespace BmiCalculatorFromValentynTukov
{
   public class Program
    {
        /*
        static void BMIRanges()
        {
            Console.WriteLine(" \n The Body Mass Index has the next ranges:\n Less or equal to 18.5 - Underweight;\n From 18.6 to 24.9 weight is normal;\n From 25 to 29.9 - Overweight;\n More then 29.9 - Obesity;\n");
        }

         public static double BMI(double x, double y) 
        {
            return x / (y * y);
        }
        */
        

        static void Main(string[] args)
        {
            Console.WriteLine(" Thise is the Body Mass Index colculator. ");

            Console.WriteLine(" \n You may check your body index and get recommendation about your weight. ");

            Console.WriteLine(" \n Please, type your weight in kg. If your waight, for example, 75.2 kg, plese, tipe 75.2");

            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height in m. If your height, for example, 1 m 75 sm, please, type 1.75 ");

            double height = double.Parse(Console.ReadLine());

            double bmi = Utilites.BMI(weight, height);

            string bmi1 = bmi.ToString("0.00");

            double minW = Utilites.MinUsefulWeight(height);

            double maxW = Utilites.MaxUsefulWeight(height);

            if (bmi <= 18.5)
            {
                Console.WriteLine($" Your BNI= {bmi1}. You have Underweight.");

                Utilites.BMIRanges();

                Utilites.Recomendation(minW, maxW);
            }
            else if (bmi > 18.5 && bmi <= 24.9)
            {
                Console.WriteLine($" Your BNI= {bmi1}. Your weight is normal! Congratulate!");

                Utilites.BMIRanges();

                Utilites.Recomendation(minW, maxW);
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine($" Your BNI= {bmi1}. Your have Overweight!");

                Utilites.BMIRanges();

                Utilites.Recomendation(minW, maxW);
            }
            else
            {
                Console.WriteLine($" Your BNI= {bmi1}. You have Obesity!");

                Utilites.BMIRanges();

                Utilites.Recomendation(minW, maxW);
            }
                Console.ReadLine();
            }
        }
    }



