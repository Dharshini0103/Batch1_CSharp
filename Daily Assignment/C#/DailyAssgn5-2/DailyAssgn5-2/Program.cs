namespace DailyAssgn5_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            stringlength();
            stringreverse();
            stringsame();
        }
        //Write a program in C# to accept a word from the user and display the length of it.
        public static void stringlength()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine($"The length of the word is: {word.Length}");
        }
        //Write a program in C# to accept a word from the user and display the reverse of it. 
        public static void stringreverse()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);
            Console.WriteLine($"The reversed word is: {reversedWord}");
        }
        //Write a program in C# to accept two words from user and find out if they are same. 
        public static void stringsame()
        {
            Console.Write("Enter first word: ");
            string w1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string w2 = Console.ReadLine();

            if (w1.ToLower() == w2.ToLower())
                Console.WriteLine("Both words are same.");
            else
                Console.WriteLine("The words are different.");
        }

    }

}


