using System;
using System.Reflection.Metadata.Ecma335;

namespace lab6
{
    public class Cashier : Employee
    {
        public override string WhatYouDo()
        {
            return "Пополняю транспортные карты";
        }

        public override string WorkTime()
        {
            return (int)(DateTime.Today - DateOfEmployment).TotalDays + " дней";
        }
    }
}