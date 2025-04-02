using System.Xml.Linq;

namespace DailyAssgn5_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1.String
            stringlength();
            stringreverse();
            stringsame();
            Console.WriteLine();
            //2.Inheritance(Class-student)
            int[] marks = new int[5];
            Student student=new Student("Dharshini", 5, 8, "ECE", "4B",marks);
            student.GetMarks();
            student.DisplayData();
            student.DisplayResult();
            Console.WriteLine();
            //3.Interface
            IStudent s1 = new Dayscholar(101, "Ram", 70000);
            IStudent s2 = new Resident(102, "Seeta", 60000, 20000);
            s1.ShowDetails();
            s2.ShowDetails();
            Console.WriteLine();
            //4.User defined Exception
            try
            {
                BankAccount account = new BankAccount(8000);
                account.TransferFunds(6000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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


