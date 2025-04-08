using System.Buffers.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using bean;

namespace Assignment_Banking_System
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Task1
            //Credit Score must be above 700.Annual Income must be at least $50,000.
            Task1_EligibilityForLoan();
            Console.WriteLine();
            //Task2
            Task2.Transactions();
            Console.WriteLine();
            //Task3
            Task3.Balance_Calculation();
            Console.WriteLine();
            //Task4
            Task4.account_balance();
            Console.WriteLine();
            //Task5
            Task5.PasswordCreation();
            Console.WriteLine();
            //Task6
            Task6.Transactions();
            Console.WriteLine();
            //Task7
            Task7.Task7Run();
            Console.WriteLine();
            //Task8
            Task8.Task8Run();
            Console.WriteLine();
            //Task9
            Task9.Task9Run();
            Console.WriteLine();
            //Task10
            Task10.Task10Run();
            Console.WriteLine();
            //Task11
            Task11.Task11Run();
            Console.WriteLine();
            //Task12
            Task12.Task12Run();
            Console.WriteLine();
            //Task13
            Task13.Task13Run();
            Console.WriteLine();
            //Task14
            DBUtil.GetDBConn();
            DBUtil.SelectData();
            DBUtil.InsertData();
            DBUtil.UpdateData();
        }
        //Task1
        public static void Task1_EligibilityForLoan()

        {
            //1.Write a program that takes the customer's credit score and annual income as input.
            Console.WriteLine("Task1");
            Console.WriteLine("Customer details:");
            Console.Write("Enter Credit Score: ");
            int Credit_Score = int.Parse(Console.ReadLine());
            Console.Write("Annual Income in $: ");
            double Income = double.Parse(Console.ReadLine());
            //2.Use conditional statements (if-else) to determine if the customer is eligible for a loan.
            if (Credit_Score > 700 && Income >= 50000)
            {
                //3.Display an appropriate message based on eligibility.
                Console.WriteLine("Customer is eligible for Loan");
            }
            else
            {
                Console.WriteLine("Customer is not eligible for Loan");
            }
        }
    }
}
