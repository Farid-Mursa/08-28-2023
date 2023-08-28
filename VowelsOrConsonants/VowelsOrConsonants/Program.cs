namespace VowelsOrConsonants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string : ");
            string str = Console.ReadLine();

            int vowel = 0;
            int cons = 0;
            string letters = "aeiouAEIOU";

            for (int i = 0; i < str.Length; i++)
            {

                if (letters.Contains(str[i]))
                {
                    vowel++;
                    continue;
                }
                else if (char.IsLetter(str[i]))
                {
                    cons++;
                }
            }
            Console.WriteLine("Number of vowels: " + vowel) ;
            Console.WriteLine("Number of consonants: " + cons);
        }
    }
    
}