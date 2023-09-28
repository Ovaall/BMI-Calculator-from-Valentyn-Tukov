
using System;
using System.Runtime.Intrinsics.X86;

namespace BmiCalculatorFromValentynTukov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Thise is the Body Mass Index colculator ");

            Console.WriteLine(" You may check your body index and get recommendation about your weight ");

            Console.WriteLine(" Please, type your weight in kg. ");

            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height in m. ");

            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            string bmi1 = bmi.ToString("0.00");

            if (bmi <= 18.5)
            {
                Console.WriteLine($" Your BNI= {bmi1}. You have Underweight.");
            }
            else if (bmi > 18.5 && bmi <= 24.9)
            {
                Console.WriteLine($" Your BNI= {bmi1}. Your weight is normal! Congratulate!");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine($" Your BNI= {bmi1}. Your have Overweight");
            }
            else
            {
                Console.WriteLine($" Your BNI= {bmi1}. You have Obesity.");
            }
                Console.ReadLine();
            }
        }
    }

