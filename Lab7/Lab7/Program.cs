using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            oCommander commander = new oCommander();
            Console.WriteLine(commander.PrintTeam());
            Console.WriteLine(commander.PrintBadgeForAllCashiers());
            Console.ReadKey();
        }
    }
}