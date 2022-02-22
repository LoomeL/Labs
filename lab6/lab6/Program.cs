using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            PostOffice po = new PostOffice();
            Console.WriteLine(po.Poll());
            Console.ReadKey();
        }
    }
}