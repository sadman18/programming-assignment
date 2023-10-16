//TS: 6, fragment: "system"
//TS: 2, fragment: "Hello"
//TS: 4, fragment: "our"
//TS: 1, fragment: "Interstellar"
//TS: 3, fragment: "from"
//TS: 5, fragment: "solar"
//output:
//Interstellar Hello from our solar system

using System.Security.Cryptography.X509Certificates;

namespace space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"TS: 6, fragment: 'system'");
            string input = Console.ReadLine();
            string word1 = input.Split(",")[0].Split(" ")[1];
            string word2 = input.Split(",")[1].Trim().Split(" ")[1].Replace("'", "");

            while (true)
            {

            }

            string inputList = inputBusket(input);

            int num = int.Parse(word1);
            int temp = 0;


            string inputBusket(string input)
            {

                return string;
            }
            //if (num>temp)
            //{
            //    temp = num;
            //}

        }
    }
}