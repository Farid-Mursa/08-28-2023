namespace NumberOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write some sentence");
            string? inputString = Console.ReadLine();
            string[] words = inputString.Split(' ');
            int wordCount = words.Length;

            Console.WriteLine(wordCount);
        }
    }
}