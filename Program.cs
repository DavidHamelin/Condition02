using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, saisissez votre age :");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age < 120)
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc majeur !");
            }
            else if (age < 18 && age > 0)
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc mineur !");
            }
            else 
            {
                Console.WriteLine("Oops, il doit y avoir une erreur !");
            }
        }
    }
}
