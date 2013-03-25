using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd_Practicum3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het bedrag in euro's: ");
            int intInput = int.Parse(Console.ReadLine());

            int int500 = intInput / 500;
            int int500Rest = intInput - (int500 * 500);

            int int200 = int500Rest / 200;
            int int200Rest = int500Rest - (int200 * 200);

            int int100 = int200Rest / 100;
            int int100Rest = int200Rest - (int100 * 100);

            int int50 = int100Rest / 50;
            int int50Rest = int100Rest - (int50 * 50);

            int int20 = int50Rest / 20;
            int int20Rest = int50Rest - (int20 * 20);

            int int10 = int20Rest / 10;
            int int10Rest = int20Rest - (int10 * 10);

            int int5 = int10Rest / 5;
            int int5Rest = int10Rest - (int5 * 5);

            int int2 = int5Rest / 2;
            int int2Rest = int5Rest - (int2 * 2);

            int int1 = int2Rest / 1;


            Console.WriteLine("De opsplitsing naar de verschillende biljetten en munten is:" + Environment.NewLine);
            Console.WriteLine("Aantal 500 EUR biljetten: " + int500);
            Console.WriteLine("Aantal 200 EUR biljetten: " + int200);
            Console.WriteLine("Aantal 100 EUR biljetten: " + int100);
            Console.WriteLine("Aantal 50 EUR biljetten: " + int50);
            Console.WriteLine("Aantal 20 EUR biljetten: " + int20);
            Console.WriteLine("Aantal 10 EUR biljetten: " + int10);
            Console.WriteLine("Aantal 5 EUR biljetten: " + int5);
            Console.WriteLine("Aantal 2 EUR munten: " + int2);
            Console.WriteLine("Aantal 1 EUR munten: " + int1);
            Console.ReadLine();

        }
    }
}
