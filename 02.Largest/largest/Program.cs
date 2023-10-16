//input:
//10 68 75 7 21 12

//75682112187

//output:
//77568211210

//input:
//6 16 9
//output:
//9616
//namespace largest
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            string[] numbers = input.Split(" ");

//            foreach (var num in numbers)
//            {
//                int length =num.Length;
//                //string store = string.Empty;
//                int temp = 0;
//                int[] store1;
//                int[] store2;
//                //int digit1 = 0;
//                //int digit2 = 0;
//                if (int.TryParse(num, out int number)) 
//                {

//                    if (temp>number)
//                    {
//                        temp = number;
//                    }
//                    if (length == 2)
//                    {

//                        digit1 = number % 10;
//                        digit2 = number / 10;

//                        store += number;
//                    }
//                    else
//                    {
//                       number = number % 10;
//                        store += number;
//                    }

//                }
//                Console.WriteLine(store);

//            }

//        }
//    }
//}

using System;

class Program
{
    static void BubbleSort(string[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(arr[j], arr[j + 1]) > 0)
                {
                    // Swap arr[j] and arr[j + 1]
                    string temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, the array is sorted
            if (!swapped)
                break;
        }
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(" ");

        Console.WriteLine("Original Array:");
        foreach (string item in numbers)
        {
            Console.Write(item + " ");
        }

        BubbleSort(numbers);

        Console.WriteLine("\nSorted Array (using Bubble Sort):");
        foreach (string item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}
