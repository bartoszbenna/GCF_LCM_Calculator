using System;
using System.Collections.Generic;

namespace LCM_GCF
{
    public class LcmCalculator
    {
        public static long CalculateLcm(List<int> numbers)
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

                if (numbers[i] != numbers[i-1])
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

            var multiplicationResult = 1;

            foreach (var number in numbers)
            {
                multiplicationResult = multiplicationResult * number;
            }

            for (var i = 1; i <= multiplicationResult; i++)
            {
                foreach (var number in numbers)
                {
                    if (i % number != 0)
                    {
                        break;
                    }


                    if (number == numbers[numbers.Count - 1])
                    {
                        return i;
                    }
                }
            }

            throw new Exception("Error 001");
            
        }
    }
}