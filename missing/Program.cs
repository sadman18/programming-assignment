

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment missing = new Assignment();
                string input = Console.ReadLine();
                string[] arrayNumbers = input.Split(" ");
                int[] array = Array.ConvertAll(arrayNumbers, int.Parse);


                Console.WriteLine(missing.Missing(array));
                //Console.WriteLine($"binaryWay : {missing.findBinary(array)}"  );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");            }

           


        }
    }
    public class Assignment
    {

        public string Missing(int[] numbers)
        {
                int length = numbers.Length;

                // adding all array numbers
                int arrSum = numbers.Sum();

                int first = numbers[0];
                int last = numbers[length - 1];
                int n = (last-first)+1;
                // n(n+1)/2  here n is = the final number
                int totalSum = (n / 2) * (last+first);


                // missing number is the difference of both sum 
                int diff = totalSum - arrSum;
                return diff.ToString();

         }


    }
}

