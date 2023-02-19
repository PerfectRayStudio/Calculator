using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc_By_Coderov;

namespace Library
{
    class Utils
    {
        public static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
        public static void UIHorizontalLine(int length)
        {
            
            for (int i = 0; i < length; i++)
            {
                TextColor(ConsoleColor.DarkCyan);
                Console.Write("-");
                Console.ResetColor();
            }
        }
        public static void LineColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        public static void Line(string text)
        {
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void TextColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            
        }
        
        public static void AdditionFraction()
        {   
            Console.Write("Enter the first fraction (in the form a/b): ");
            string[] fraction1 = Console.ReadLine().Split('/');
            int numerator1 = int.Parse(fraction1[0]);
            int denominator1 = int.Parse(fraction1[1]);
 
            Console.Write("Enter the second fraction (in the form a/b): ");
            string[] fraction2 = Console.ReadLine().Split('/');
            int numerator2 = int.Parse(fraction2[0]);
            int denominator2 = int.Parse(fraction2[1]);

            int numeratorResult = numerator1 * denominator2 + numerator2 * denominator1;
            int denominatorResult = denominator1 * denominator2;

            int gcd = GCD(numeratorResult, denominatorResult);
            numeratorResult /= gcd;
            denominatorResult /= gcd;

            TextColor(ConsoleColor.DarkCyan);
            Console.WriteLine($"\nThe sum of {numerator1}/{denominator1} and {numerator2}/{denominator2} is {numeratorResult}/{denominatorResult}\n");
            Console.ResetColor();
            Program.ReStart();
        }
        public static void AdditionInteger()
        {
            Console.Write("Enter first integer (in the form 52)\n");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer (in the form 35)\n");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;

            TextColor(ConsoleColor.Green);
            Console.WriteLine($"\nThe result: {result}\n");
            Console.ResetColor();
            Program.ReStart();
        }
        public static void SubtractionInteger()
        {
            Console.Write("Enter first integer (in the form 52)\n");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer (in the form 35)\n");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 - number2;

            TextColor(ConsoleColor.Green);
            Console.WriteLine($"\nThe result: {result}\n");
            Console.ResetColor();
            Program.ReStart();
        }
        public enum MathType
        {
            AdditionInteger,

            SubtractionInteger,

            AdditionFractions,

            SubtractionFractions,

            ShortenFraction
        }
    }
