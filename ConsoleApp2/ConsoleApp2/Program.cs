using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "this is first program";
            Console.WriteLine(phrase.IndexOf("program"));
            Console.WriteLine(phrase.Substring(phrase.IndexOf("first")));
            Console.WriteLine(Math.Pow(3,2));
            Communication("bhuvana");
            Console.WriteLine(phrase);
            int age =23;
            if (age <= 18)
            {
                Console.WriteLine(" not eligible to vote");
            } 
            else
            {
                Console.WriteLine("eligible to vote");
            }
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a  another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();

        }
        static void Communication(string name)
        {
            Console.WriteLine(" hello " + name);
       
        }
      
    }
}
