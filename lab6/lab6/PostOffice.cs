using System;
using System.Collections.Generic;

namespace lab6
{
    public class PostOffice
    {
        public List<Employee> us { get; set; } = new List<Employee>();

        public PostOffice()
        {
            us.Add(new Cashier() { Name = "Cashier1", DateOfEmployment = new DateTime(2021, 10, 1)});
            us.Add(new Cashier() { Name = "Cashier2", DateOfEmployment = new DateTime(2010, 4, 10)});
            us.Add(new Operator() { Name = "Operator1", DateOfEmployment = new DateTime(2020, 1, 1)});
            us.Add(new Operator() { Name = "Operator2", DateOfEmployment = new DateTime(2015, 10, 10)});
            us.Add(new Operator() { Name = "Operator3", DateOfEmployment = new DateTime(2017, 7, 1)});
            us.Add(new Postman() { Name = "Postman1", DateOfEmployment = new DateTime(2000, 9, 1)});
            us.Add(new Postman() { Name = "Postman2", DateOfEmployment = new DateTime(2003, 1, 1)});
            us.Add(new Postman() { Name = "Postman3", DateOfEmployment = new DateTime(2009, 4, 1)});
        }

        public string Poll()
        {
            string line = "";
            foreach (var e in us)
            {
                line += "\n " + $"А как вас зовут? {e.Say()}; " +
                        $"Что вы делаете? {e.WhatYouDo()}; " +
                        $"Как давно вы тут работаете? {e.WorkTime()}";
            }

            return line;
        }
    }
}