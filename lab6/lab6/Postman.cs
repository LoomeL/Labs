using System;

namespace lab6
{
    public class Postman : Employee
    {
        public override string WhatYouDo()
        {
            return "Разношу почту, не мешайте";
        }

        public override string WorkTime()
        {
            return (int)(DateTime.Today - DateOfEmployment).TotalDays / 30 / 12 + " лет";
        }
    }
}