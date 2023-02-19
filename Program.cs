using System;
using Utils;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public void AdditionFraction(){
        // Prompt the user to enter the first fraction
            Console.Write("Enter the first fraction (in the form a/b): ");
            string[] fraction1 = Console.ReadLine().Split('/');
            int numerator1 = int.Parse(fraction1[0]);
            int denominator1 = int.Parse(fraction1[1]);

            // Prompt the user to enter the second fraction
            Console.Write("Enter the second fraction (in the form a/b): ");
            string[] fraction2 = Console.ReadLine().Split('/');
            int numerator2 = int.Parse(fraction2[0]);
            int denominator2 = int.Parse(fraction2[1]);

            // Add the fractions
            int numeratorResult = numerator1 * denominator2 + numerator2 * denominator1;
            int denominatorResult = denominator1 * denominator2;

            // Reduce the result fraction to lowest terms
            int gcd = Utils.GCD(numeratorResult, denominatorResult);
            numeratorResult /= gcd;
            denominatorResult /= gcd;

            // Output the result
            Console.WriteLine($"The sum of {numerator1}/{denominator1} and {numerator2}/{denominator2} is {numeratorResult}/{denominatorResult}");
        }
        
    }
}