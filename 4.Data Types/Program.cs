using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 10;
            bool isTall = true;
            double weight = 25.5;

            //Hi John you are 10 and your weight is 25.5
            Console.WriteLine("Hi " + name + " you are " + age + " and your weight is " + weight);
            Console.WriteLine("True or False you are tall: " +isTall);

            //freeze console
            Console.ReadLine();

        }
    }
}
