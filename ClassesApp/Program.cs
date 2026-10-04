namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car audi = new Car("A3", "Audi", false);
            //Car BMW = new Car("i7", "BMW", true);
            //Console.WriteLine("Enter the brand of the car:");
            //audi.Brand = Console.ReadLine();
            //Console.WriteLine("You entered: " + audi.Brand);

            //Customer rakesh = new Customer("Rakesh");
            //Console.WriteLine(AddNumbers(5, 10));
            //Console.WriteLine(AddNumbers(a: 5, 6));
            //Rectangle r1 = new Rectangle();
            //  r1.width = 5;
            //r1.height = 5;
            //Console.WriteLine("Area of rectangle: " + r1.Area);
            //Customer rajesh = new Customer("Rajesh","India","99999");
            //Console.WriteLine("Customer Name: " + rakesh.Name);
            //Customer myCustomer = new Customer();
            //Customer customer1 = new Customer();
            //Customer customer2 = new Customer("John Doe", "123 Main St", "555-1234");
            //customer2.Password = "securepassword";
            //customer1.getDetails();
            //customer2.getDetails();
            Rectangle r1 = new Rectangle("Red");
            Rectangle r2 = new Rectangle("Blue");
            r1.displayDetails();
            r2.displayDetails();
            //myCustomer.setDetails("John Doe", "123 Main St", "555-1234");
            //Customer myCustomer2 = new Customer("Yadav");
            //Console.WriteLine("Customer Name: " + myCustomer2.Name + " and he lives in " + myCustomer2.Address + " and his contact number is " + myCustomer2.ContactNumber);
            //Console.WriteLine("Customer Name: " + myCustomer.Name + " and he lives in " + myCustomer.Address + " and his contact number is " + myCustomer.ContactNumber);
            //Console.WriteLine("Customer Name: " + rakesh.Name + " and he lives in " + rakesh.Address + " and his contact number is " + rakesh.ContactNumber);
            //Console.WriteLine("Enter Customer Name: ");
            //myCustomer.Name = Console.ReadLine();
            //Console.WriteLine("Default Customer Name: " + myCustomer.Name); 
            //Console.ReadKey();

            //Car myAudi = new Car("Audi", "A3", false);
            //myAudi.drive();
            //Car myBMW = new Car("BMW", "i7", true);
            //myBMW.drive();
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
