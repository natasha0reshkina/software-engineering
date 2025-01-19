namespace Семинар_1
{
    public class FactoryAF
    {
        public List<Car> Cars { get; private set; }

        public List<Customer> Customers { get; private set; }

        public FactoryAF(List<Customer> customers)
        {
            Customers = customers;
            Cars = [];
        }
        internal void AddCar()
        {
            var car = new Car { Number = Cars.Count + 1 };
            Cars.Add(car);
        }
        internal void SaleCar()
        {
            foreach (var customer in Customers)
            {
                customer.Car ??= Cars.LastOrDefault();

                if (customer.Car == null ) 
                    break;

                Cars.RemoveAt(Cars.Count - 1);  
            }

            Customers = Customers.Where(customers => customers.Car != null).ToList();
            Cars.Clear();
        }

    }
}
