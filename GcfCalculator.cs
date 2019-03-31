using System;
using System.Collections.Generic;

namespace LCM_GCF
{
    public class GcfCalculator
    {
        public static long CalculateGcf(List<int> numbers)
        {
            numbers.Sort();

            if (numbers.Count < 2)
            {
                Console.WriteLine("Error: You have to enter at least 2 numbers.");
                Console.ReadLine();
                Environment.Exit(1);
            }
            

            for (var i = 1; i < numbers.Count; i++)
            {
                //Checking if numbers are the same

                if (numbers[i] != numbers[i - 1])
                    break;

                if (i == numbers.Count - 1)
                {
                    //Returns any number if all are the same
                    return numbers[i];
                }
            }

            foreach (var number in numbers)
            {

                if (number < 1)
                {
                    Console.WriteLine("Error: All numbers must be greater than 1.");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }

            var divisors = new List<List<int>>();

            foreach (var number in numbers)
            {
                divisors.Add(new List<int>());
                var myList = divisors[divisors.Count - 1];
               
                for (var i = 1; i <= number; i++)
                {

                    if (number % i == 0)
                    {
                        myList.Add(i);
                    }


                }
            }


            
            var lastList = divisors[divisors.Count - 1];

            for (var i = lastList.Count - 1; i >= 0; i--)
            {
                var number = lastList[i];

                for (var f = 0; f < divisors.Count - 1; f++)
                {
                    if (!divisors[f].Contains(number))
                    {
                        break;
                    }


                    if (f == divisors.Count - 2)
                        return number;
                }

            }

            throw new System.Exception("Error 001. Code reached the end.");
        }
    }
}