using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1
            Console.WriteLine("Mata in tal 1");
            string tal1 = Console.ReadLine();
            int nbr1 = int.Parse(tal1);

            Console.WriteLine("Mata in tal 2");
            string tal2 = Console.ReadLine();
            int nbr2 = int.Parse(tal2);

            Console.WriteLine("summa:"  + (nbr1 + nbr2));
            Console.WriteLine("produkt:" + nbr1 * nbr2);
            Console.WriteLine("kvot:" + nbr1 / nbr2);

            //Övning2
            Console.WriteLine("Mata in ditt förnamn:");
            string FN = Console.ReadLine();

            Console.WriteLine("Mata in ditt efternamn:");
            string EN = Console.ReadLine();

            Console.WriteLine("Hej " + FN + " " + EN + "!");

            //Övning3
            Console.WriteLine("Mata in grader i Celsius");
            string C = Console.ReadLine();
            int celsi = int.Parse(C);
            Console.WriteLine("Det blir " + (1.8* celsi + 32) + " " + " farenheit");


            //övning4
            Console.Write("Mata in grader i celsisus");
            string C2 = Console.ReadLine();
            int celsius = int.Parse(C2);
            Console.Write("Det blir " + (1.8 * celsi + 32) + " " + " farenheit\n");


            //övning5 
            Console.WriteLine("Cirkelns radie");
            string cirkle = Console.ReadLine();
            double radie = double.Parse(cirkle);
            double pi = Math.PI;
            Console.WriteLine("area" + (pi * radie * radie));
            Console.WriteLine("omkrets" + (2 * pi * radie));
        }
    }
}
