using System;

namespace LCM_GCF
{
    class Program
    {
         static void Main(string[] args)
         {
             while (true)
             {
                 Console.Write("If you want to calculate Least Common Multiple, type L. If Greatest Common Factor, type G. To exit, type E: ");
                 var choice = Console.ReadLine();

                 if (choice != null && choice.ToLower() == "l")
                 {
                     Console.Write("Enter numbers divided by comas: ");
                     var input = Console.ReadLine();

                     var numbers = NumbersChecker.CheckNumbers(input);
                     
                     if (numbers == null)
                     {
                         continue;
                     }

                     Console.WriteLine("Least common multiple is " + LcmCalculator.CalculateLcm(numbers));
                 }

                 else if (choice != null && choice.ToLower() == "g")
                 {
                     Console.Write("Enter numbers divided by comas: ");
                     var input = Console.ReadLine();

                     var numbers = NumbersChecker.CheckNumbers(input);

                     if (numbers == null)
                     {
                         continue;
                     }

                    Console.WriteLine("Greatest common factor is " + GcfCalculator.CalculateGcf(numbers));
                 }

                 else if (choice != null && choice.ToLower() == "e")
                 {
                     break;
                 }
                 else
                 {
                     Console.WriteLine("You entered wrong letter.");
                 }
            }
         }
    }
}
