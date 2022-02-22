using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class FactoryAF
    {
        public List<Car> Cars = new();
        public List<Customer> Customers = new List<Customer>();

        public FactoryAF()
        {
            AddCar(2);
            AddCar(1);
            AddCar(3);
            AddCar(5);
            
            Customers.Add(new Customer(){FIO = "Акимов Михаил Юрьевич"});
            Customers.Add(new Customer(){FIO = "Александров Даниил Михайлович"});
            Customers.Add(new Customer(){FIO = "Алехина Злата Григорьевна"});
            Customers.Add(new Customer(){FIO = "Лавров Степан Александрович"});
            Customers.Add(new Customer(){FIO = "Кузьмин Ян Русланович"});
            Customers.Add(new Customer(){FIO = "Макаров Олег Богданович"});
            Customers.Add(new Customer(){FIO = "Поляков Захар Богданович"});
            Customers.Add(new Customer(){FIO = "Смирнов Григорий Григорьевич"});
            Customers.Add(new Customer(){FIO = "Сорокин Владимир Даниилович"});
            Customers.Add(new Customer(){FIO = "Степанова Василиса Артёмовна"});
            Customers.Add(new Customer(){FIO = "Третьякова Мирослава Львовна"});
        }

        public void SaleCar()
        {
            if (Cars.Count != 0)
            {
                foreach (Customer customer in Customers)
                {
                    if (customer.Car != null) continue;
                    customer.Car = Cars.First();
                    break;
                }
                Cars.Remove(Cars.First());
            }
            else
            {
                Console.WriteLine("нет машин");
            }
        }

        public void AddCar(int Size)
        {
             Cars.Add(new Car(){ Engine = new Engine(){ Size = Size }});
        }
    }
}