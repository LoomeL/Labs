using System;
using System.Collections.Generic;

namespace Lab7
{
    public class oCommander : Commander
    {
        public new string PrintBadgeForAllCashiers()
        {
            List<string> strs = new List<string>();
            foreach (Employee employee in _allEmployees)
                if (employee is Cashier cashier) strs.Add(PrintBadge(cashier) + " " + cashier.Qualification);
            return String.Join("\n", strs);
        }
    }
}