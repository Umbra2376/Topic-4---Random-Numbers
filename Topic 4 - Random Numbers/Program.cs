using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            Random generator = new Random();
            int min, max;
            Console.WriteLine("Please give me a minimum value");
            while (!Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("This is an invalid input.");
                Console.WriteLine("Enter a proper value.");
            }
            Console.WriteLine("Please give me a maximum value");
            while (!Int32.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("This is an invalid input.");
                Console.WriteLine("Enter a proper value.");
            }
            max = max + 1;
            Console.WriteLine("");
            if (min > max)
            {
                Console.WriteLine("I think you made a mistake so I'll switch them for you and generate 5 numbers :)");
                for (int i = 0; i < 5; i++)
                {
                    int randomNum = generator.Next(max, min);
                    Console.Write(randomNum + "  ");
                }
            }
            else
            {
                Console.WriteLine($"Here are 5 random numbers between {min} and {max - 1}");
                for (int i = 0; i < 5; i++)
                {
                    int randomNum = generator.Next(min, max);
                    Console.Write(randomNum + "  ");
                }
            }

            //#2
            string response;
            int dice1, dice2, total;
            Random dice = new Random();
            Console.WriteLine("Do you want to roll two dice? Please type 'yes' or 'no'");
            response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                dice1 = dice.Next(1, 7);
                dice2 = dice.Next(1, 7);
                total = dice1 + dice2;
                Console.WriteLine($"The total of the two dice is: {total}");
            }
            else
            {
                Console.WriteLine("Ok, maybe next time");
            }

            //#3
            int decimalAmt;
            double randomNumber, maxAdd, minAdd;
            Console.WriteLine("Please give me a number of decimal places and I'll use the same min and max from before.");
            while (!Int32.TryParse(Console.ReadLine(), out decimalAmt))
            {
                Console.WriteLine("This is an invalid input.");
                Console.WriteLine("Enter a proper value.");
            }
            Console.WriteLine("If you want to make any decimal level adjustments to your earlier min value put it in here and I'll add it to the value.");
            while (!Double.TryParse(Console.ReadLine(), out minAdd))
            {
                Console.WriteLine("This is an invalid input.");
                Console.WriteLine("Enter a proper value.");
            }
            min = (int)minAdd + min;
            Console.WriteLine("If you want to make any decimal level adjustments to your earlier max value put it in here and I'll add it to the value.");
            while (!Double.TryParse(Console.ReadLine(), out maxAdd))
            {
                Console.WriteLine("This is an invalid input.");
                Console.WriteLine("Enter a proper value.");
            }
            max = (int)maxAdd + max;
            if (min > max)
            {
                Console.WriteLine("Here are 3 random numbers from the values you gave before)");
                for (double i = 0; i < 5; i++)
                {
                    randomNumber = generator.NextDouble() * (min - max) + max;
                    Console.WriteLine(Math.Round(randomNumber, decimalAmt));
                }
            }
            else
            {
                Console.WriteLine($"Here are 3 random numbers between {min} and {max - 1}");
                for (double i = 0; i < 5; i++)
                {
                    randomNumber = generator.NextDouble() * (max - min) + min;
                    Console.WriteLine(Math.Round(randomNumber, decimalAmt));
                }
            }
        }
    }
}