using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkpoint checkpoint = new Checkpoint();
            Console.WriteLine("\nВ запасах КПП =>");
            Console.WriteLine("Масок: " + checkpoint.Mask + " единиц. Антисептик: " + checkpoint.Antiseptic + " единиц. \n");
            Console.WriteLine(checkpoint.VisitirsWantToISIT.Count + " посетителей хотят попасть в ИКИТ:");
            checkpoint.VisitirsWantToISIT.ForEach(x =>
            {
                Console.WriteLine(x.GetType().ToString().Split(".")[1] + ": " + x.Name);
            });
            Console.WriteLine();

            checkpoint.Check();
            Console.WriteLine("\n" + checkpoint.VisitirsWantToISIT.Count + " посетителей которых пустили в стены института:");
            
            checkpoint.VisitirsCanToISIT.ForEach(x =>
            {
                Console.WriteLine(x.GetType().ToString().Split(".")[1] + ": " + x.Name);
            });
            
            Console.WriteLine("\nНа КПП в запасах осталось =>");
            Console.WriteLine("Масок: " + checkpoint.Mask + " единиц. Антисептик: " + checkpoint.Antiseptic + " единиц.");
        }
    }
}