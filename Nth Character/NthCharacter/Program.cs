namespace NthCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = File.OpenText("words.txt");
            string reader = file.ReadLine();
            string words = "";
            while (reader != null)
            {
                words += reader;


            }
            Console.WriteLine(words);

        }
    }
}

