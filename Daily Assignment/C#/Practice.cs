using System;

namespace CSharpcode
{ 
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Practice practice = new Practice();
            Swapping();
            Console.WriteLine();
            Pattern();
            Console.WriteLine();
            Days();
            Console.WriteLine();
            Arrays();
            Console.WriteLine();
            MinMax();
            Console.WriteLine();
            Marks();
            Console.WriteLine();
            CopyArray();
        }

        public static void Swapping()
        {
            //1.Swap two numbers
            Console.WriteLine("Before Swapping");
            Console.Write("Input1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3;
            n3 = n1;
            n1 = n2;
            n2 = n3;
            Console.WriteLine("After Swapping");
            Console.WriteLine($"Input1:{n1}");
            Console.WriteLine($"Input1:{n2}");

        }
        

        public static void Pattern()
        {
            //2.Pattern
            Console.WriteLine("Enter a Digit: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                        Console.Write("{0} ", n);
                    else
                        Console.Write("{0}", n);
                }
                Console.WriteLine();
            }
        }


        //3.Days
        enum Day{Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4,Thursday = 5, Friday = 6, Saturday = 7}
        public static void Days()
        {
            Console.WriteLine("Day number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equivalent Day: ");
            Console.WriteLine(Enum.GetName(typeof(Day), n));
        }

        public static void Arrays()
        {
            //1.Array-----a
            Console.WriteLine("No.of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //average
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                c = c + arr[i];
            }
            float avg = (float)c / n;
            Console.WriteLine("Average:{0}",avg);

        }

        public static void MinMax()
        {
            //1.Array--b
            Console.WriteLine("No.of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int s = arr[0];
            int d = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (s < arr[i])
                    s = arr[i];
                else
                {
                    if (d > arr[i])
                        d = arr[i];
                }

            }
            Console.WriteLine("Maximum value:{0},Minimum value:{1}", s, d);
        }


        public static void Marks()
        {
            //2.Array
            int[] arr = new int[10];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                s = s + arr[i];
            }
            Console.WriteLine("Total marks:{0}", s);
            float avg = (float)s / 10;
            Console.WriteLine("Average of marks:{0}", avg);
            Array.Sort(arr);
            Console.WriteLine("Minimum value:{0}", arr[0]);
            Console.WriteLine("Maximum value:{0}", arr[arr.Length - 1]);
            Console.WriteLine("Array in Ascending order:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("Array in Descending order:");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }


        public static void CopyArray()
        {
            //3.Copy elements from 1 array to other
            Console.WriteLine("No.of elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            Console.WriteLine("New array after copying");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);

            }

        }



















}
}
