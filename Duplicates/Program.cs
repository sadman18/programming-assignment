////using System.Text.RegularExpressions;
////using System.Xml.Schema;

////namespace Duplicates
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            StreamReader file = File.OpenText("words.txt");
////            string text = file.ReadToEnd().ToLower();

////            //Duplicates duplicates = new Duplicates();
////            string input = Console.ReadLine();
////            Regex regex = new Regex(@$"\b{input}\w+\b",RegexOptions.IgnoreCase);
////            MatchCollection matches = regex.Matches(text);
////            string duplicates = "";
////            foreach (Match match in matches)
////            {
////                if (!duplicates.Contains(match.Value))
////                {
////                    duplicates += match.Value;
////                    Console.WriteLine(duplicates);
////                }
////                else
////                {
////                    Console.WriteLine("hello");
////                }
////            }


////        }
////    }
////}

//using System;
//using System.IO;
//using System.Text.RegularExpressions;

//namespace Duplicates
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a word to find duplicates:");
//            string input = Console.ReadLine().ToLower();

//            try
//            {
//                StreamReader file = File.OpenText("words.txt");
//                string text = file.ReadToEnd().ToLower();

//                // Define a regular expression pattern to find the input word
//                string pattern = $@"\b{(input)}\w+\b";

//                // Find all matches of the input word using regex
//                MatchCollection matches = Regex.Matches(text, pattern);
//                string duplicates = "";

//                foreach (Match word in matches)
//                {
//                    if (!duplicates.Contains(word.Value))
//                    {
//                        duplicates += word.Value;
//                        Console.WriteLine(duplicates);

//                    }
//                    else { Console.WriteLine("NOT working"); }
//                    //if (word == input)
//                    //{
//                    //    Console.WriteLine("Duplicate found: " + word);
//                    //}
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("An error occurred: " + e.Message);
//            }
//        }
//    }
//}

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string inputSequence = "aa";
        string filePath = "words.txt";

        List<string> duplicates = FindDuplicatesWithPrefix(filePath, inputSequence);

        if (duplicates.Count > 0)
        {
            Console.WriteLine(string.Join(" ", duplicates));
        }
        else
        {
            Console.WriteLine("No duplicates found.");
        }
    }

    static List<string> FindDuplicatesWithPrefix(string filePath, string prefix)
    {
        List<string> duplicates = new List<string>();

        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    if (word.StartsWith(prefix))
                    {
                        duplicates.Add(word);
                    }
                }
            }
        }

        return duplicates;
    }
}
