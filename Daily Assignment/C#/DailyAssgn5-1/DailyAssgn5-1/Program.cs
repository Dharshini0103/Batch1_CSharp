namespace DailyAssgn5_1
{
    abstract class Furniture
    {
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Furniture.");
        }
    }

    class Chair : Furniture
    {
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("It is a chair with 4 legs.");
        }
    }

    class Bookshelf : Furniture
    {
        public override void DisplayDetails()
        {
            Console.WriteLine("It is a bookshelf contains 5 racks");
        }
        
    }
internal class Program
    {
        public static void Main(string[] args)
        {
            Furniture chair = new Chair();
            chair.DisplayDetails();

            Furniture bookshelf = new Bookshelf();
            bookshelf.DisplayDetails();

            //2.Property to convert from sec to hours
            Console.WriteLine();
            TimePeriod time = new TimePeriod();
            time.DisplayTime();
        }
    }
        
    
}
