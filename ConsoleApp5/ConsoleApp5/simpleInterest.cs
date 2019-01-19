using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class simpleInterest
    {
        double prin, rate, time, i, a;
        public simpleInterest(double aprin, double arate ,double atime )
        {
            prin = aprin;
            rate = arate;
            time = atime;

            i = (prin * rate * time) / 100;
            Console.WriteLine(i);
            a = (prin+ i);
            Console.WriteLine (a);
            
        }


    }
}
