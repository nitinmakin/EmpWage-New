using System;

namespace EmpWage_New
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int random = p.getRandomNo();
            if (random == 0)
            {
                Console.WriteLine("Emp is absent");
            }
            else if (random == 1)
            {
                Console.WriteLine("Emp is Present and he is part time emp");
                int monthlyWage = p.isPartTime();
                int day20Wage = p.getPartTime20DayWage();
                Console.WriteLine("Monthly wage of emp is " + monthlyWage);
                Console.WriteLine("20 day wage of emp is " + day20Wage);
            }
            else
            {
                Console.WriteLine("emp is present and he is full time emp");
                int monthlyWage = p.isFullTime();
                int day20Wage = p.getFullTime20DayWage();
                Console.WriteLine("Monthly wage of emp is " + monthlyWage);
                Console.WriteLine("20 day wage of emp is " + day20Wage);
            }
        }

        private int getRandomNo()
        {
            Random random = new Random();
            return random.Next(3);
        }

        private int isFullTime()
        {
            int workingHrs = 8;
            int payPerHrs = 50;
            int dailyWage = workingHrs * payPerHrs;
            int monthlyWage = dailyWage * 30;
            return monthlyWage;
        }
        private int isPartTime()
        {
            int workingHrs = 4;
            int payPerHrs = 50;
            int dailyWage = workingHrs * payPerHrs;
            int monthlyWage = dailyWage * 30;
            return monthlyWage;
        }

        private int getPartTime20DayWage()
        {
            int workingHrs = 4;
            int payPerHrs = 50;
            int dailyWage = workingHrs * payPerHrs;
            int monthlyWage = dailyWage * 20;
            return monthlyWage;
        }

        private int getFullTime20DayWage()
        {
            int workingHrs = 8;
            int payPerHrs = 50;
            int dailyWage = workingHrs * payPerHrs;
            int monthlyWage = dailyWage * 20;
            return monthlyWage;
        }
    }
}
