using System;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            School school = new School();
            
            school.Reward(school.FindMinMaxEmployee());

            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalSeconds);

            Console.ReadKey();
        }
    }
}
