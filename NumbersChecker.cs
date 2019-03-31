using System;
using System.Collections.Generic;

namespace LCM_GCF
{
    public class NumbersChecker
    {
        public static List<int> CheckNumbers(string input)
        {
            var trim = input.Trim();

            var inputsList = trim.Split(',');

            var numbers = new List<int>();

            try
            {
                foreach (var number in inputsList)
                {
                    numbers.Add(Convert.ToInt32(number));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Your input was wrong! Try once again.");
                return null;
            }

            catch (Exception ex)
            {
                if (ex is ArgumentOutOfRangeException || ex is OverflowException)
                {
                    Console.WriteLine("Check your numbers once again. All numbers must not be negative and should be under 2,174,483,647.");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
                
            }

            return numbers;
        }
    }
}