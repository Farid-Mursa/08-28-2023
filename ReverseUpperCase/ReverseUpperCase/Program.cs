namespace ReverseUpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type some word: ");
            string word = Console.ReadLine();
            char[] reversedWord = word.ToCharArray();
            Array.Reverse(reversedWord);
            string reversed = new(reversedWord);
            Console.WriteLine(reversed.ToUpper());
        }
    }
}