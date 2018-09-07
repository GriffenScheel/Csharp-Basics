using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics { 

class Program
{
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            const double accelaration = 9.800;
            const String greeting = "Hello ";


            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            double mass = 14.6;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
           // char intregal = \u222B;
            String name = "Karen";

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            double force = mass * accelaration;

            Console.WriteLine("force=" + force);
            Console.WriteLine(distance + " is the distance.");

            if (lost == true && expensive == true)
            {
                Console.WriteLine("“I am really sorry! I will get the manager.");
            }
            else if (lost == true && expensive == false) {

                Console.WriteLine("Here is coupon for 10% off.");

            }
           // Console.WriteLine(intregal + "is an intergal.");
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i=" + i);
            }
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age =" + age);
                age++;
            }
            

            Console.WriteLine(greeting + name);
            Console.ReadKey();
        }
}
}
