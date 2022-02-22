using System;
using System.Collections.Generic;

namespace Lab7
{
    public class Commander
    {
        public List<Employee> _allEmployees = new List<Employee>();
        public List<Employee> _tomorrowEmployees = new List<Employee>();

        public Commander()
        {
            _allEmployees.Add(new Loader() {FirstName = "Марк", LastName = "Рыбаков"});
            _allEmployees.Add(new Loader() {FirstName = "Роман", LastName = "Федотов"});
            _allEmployees.Add(new Loader() {FirstName = "Илья", LastName = "Кузнецов"});
            _allEmployees.Add(new Cashier() {FirstName = "Анна", LastName = "Колесникова", Qualification = "старший кассир"});
            _allEmployees.Add(new Cashier() {FirstName = "Алиса", LastName = "Антонова", Qualification = "стажер"});
            _allEmployees.Add(new Cashier() {FirstName = "Екатерина", LastName = "Киреева", Qualification = "кассир"});
            _allEmployees.Add(new Cashier() {FirstName = "Арина", LastName = "Иванова", Qualification = "кассир"});
            _allEmployees.Add(new Cashier() {FirstName = "Софья", LastName = "Максимова", Qualification = "кассир"});
            
            _tomorrowEmployees.Add(_allEmployees[0]);
            _tomorrowEmployees.Add(_allEmployees[2]);
            _tomorrowEmployees.Add(_allEmployees[3]);
            _tomorrowEmployees.Add(_allEmployees[4]);
            _tomorrowEmployees.Add(_allEmployees[5]);
        }

        public string PrintTeam()
        {
            string emp = "Завтра на работу выходят: ";
            foreach (Employee tomorrowEmployee in _tomorrowEmployees)
            {
                emp += tomorrowEmployee.GetFullName();
                emp += ", ";
            }
            return emp.Remove(emp.Length - 2);
        }

        public string PrintBadge(Cashier cashier)
        {
            return cashier.GetFullName();
        }

        public string PrintBadgeForAllCashiers()
        {
            List<string> strs = new List<string>();
            foreach (Employee employee in _allEmployees)
                if (employee is Cashier cashier) strs.Add(PrintBadge(cashier));
            return String.Join("\n", strs);
        }
    }
}