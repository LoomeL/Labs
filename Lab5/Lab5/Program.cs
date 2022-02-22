using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(9);
            Console.WriteLine("Придумайте имя кошки:");
            cat.Name = Console.ReadLine();
            Console.WriteLine("Теперь вашу кошку зовут " + cat.Name);

            while (cat.Health > 0)
            {
                Console.WriteLine("Если вы хотите покормить кошку напишите \"покормить\"");
                Console.WriteLine("Если вы хотите наказать кошку напишите \"наказать\"");
                switch (Console.ReadLine())
                {
                    case "покормить":
                        cat.Feed(1);
                        break;
                    
                    case "наказать":
                        cat.Punish(1);
                        break;
                    
                    default:
                        continue;
                }
                
                Console.WriteLine("Цвет кошки " + cat.Color);
            }
            
            Console.WriteLine("Ваша кошка умерла");
        }
    }

    class Cat
    {
        private string _name;
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(_name)) _name = value;
            }
            get => _name;
        }

        public int Age { private set; get; }

        public int Health = 9;

        public string Color
        {
            get
            {
                if (Health > 0) return "Зеленый";
                return "Белый";
            }
        }

        public Cat(int age)
        {
            Age = age;
        }

        public void Feed(int foodCount)
        {
            Health += foodCount;
        }

        public void Punish(int punch)
        {
            Health -= punch;
        }
    }
}