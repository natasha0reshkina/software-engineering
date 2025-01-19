namespace Семинар_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer() { Name = "Natasha"};
            var customer2 = new Customer() { Name = "Oleg" };
            var customer3 = new Customer() { Name = "Denis" };

            var customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            var factory = new FactoryAF(customers);

            for (int i = 0; i < 5; i++)
                factory.AddCar();

            Console.WriteLine("До");
            Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
            Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

            factory.SaleCar();

            Console.WriteLine("После");
            Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
            Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));
        }
    }
}