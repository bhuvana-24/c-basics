using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class calculateInterest
    {
        public double principal;
        public double rate;
        public double time;
        public void calculate()
        {
            Console.WriteLine("Enter principal: ");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate: ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time: ");
            time = Convert.ToDouble(Console.ReadLine());

        }
            public double GetInterest()
        {
            return principal*rate*time;
        }
        public void Display()
        {
            Console.WriteLine("interest: {0}", GetInterest());
        }
    }



}
