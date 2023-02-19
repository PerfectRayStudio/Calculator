using System;
using Library;

namespace Calc_By_Coderov
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var InstanceClass = new Program();
            InstanceClass.Flow();
        }
        public void Flow()
        {
            Utils.UIHorizontalLine(50);
            Console.WriteLine($"\nChoose a mathematical action option:\n \n 1.{Utils.MathType.AdditionInteger} \n 2.{Utils.MathType.SubtractionInteger} \n 3.{Utils.MathType.AdditionFractions} \n 4.{Utils.MathType.SubtractionFractions} (Soon...) \n 5.{Utils.MathType.ShortenFraction} (Soon...)");

            Utils.UIHorizontalLine(50);

            Console.WriteLine("\n");
            Utils.Line("Enter the number of the desired section:");

            int element = int.Parse(Console.ReadLine());

            ChooseElement(element);
        }
        public static void ReStart()
        {
            var InstanceClass = new Program();
            InstanceClass.Flow();
        }

        public static void ChooseElement(int item)
            {
                switch (item)
                {
                    case 1:
                        Utils.LineColor(ConsoleColor.DarkGreen);
                        Utils.Line("You have chosen: Addition of numbers (integers)");
                        Utils.AdditionInteger();
                        break;
                    case 2:
                        Utils.LineColor(ConsoleColor.DarkGreen);
                        Utils.Line("You have chosen: Subtraction of numbers (integers)");
                        Utils.SubtractionInteger();
                        break;
                    case 3:
                        Utils.LineColor(ConsoleColor.DarkGreen);
                        Utils.Line("You have chosen: Addition Fractions");
                        Utils.AdditionFraction();
                        
                        break;
                    default:
                        Utils.LineColor(ConsoleColor.Red);
                        Utils.Line("Error: Unknown value");
                        
                        ReStart();
                        break;
                }
            }

        }
        
    }
