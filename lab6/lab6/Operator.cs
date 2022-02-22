using System;

namespace lab6
{
    public class Operator : Employee
    {
        public override string WhatYouDo()
        {
            return "Ищу посылку";
        }

        public override string WorkTime()
        {
            return (int)(DateTime.Today - DateOfEmployment).TotalDays / 30 + " месяцев";
        }
    }
}