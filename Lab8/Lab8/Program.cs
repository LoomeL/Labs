using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryAF factoryAf = new FactoryAF();
            Console.WriteLine("Машин: " + factoryAf.Cars.Count +" Людей: "+ factoryAf.Customers.Count);

            factoryAf.SaleCar();
            factoryAf.SaleCar();
            factoryAf.SaleCar();
            
            int cusWithCars = 0;
            foreach (Customer factoryAfCustomer in factoryAf.Customers)
            {
                if (factoryAfCustomer.Car != null) cusWithCars++;
            }
            
            Console.WriteLine("Машин: " + factoryAf.Cars.Count +" Людей без тачки: " +
                              (factoryAf.Customers.Count - cusWithCars));
        }
    }
}