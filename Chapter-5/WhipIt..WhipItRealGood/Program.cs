using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhipIt._.WhipItRealGood
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] TheDstances = {0,100,300,500};
            int[] PicketTwice = {25,40,55,70};
            Console.WriteLine("Enter the d-stance you travelled");
            int EnteredDstance = Convert.ToInt32(Console.ReadLine());
            int YoureAWiener = 0;
            int cost = 0;
            while (YoureAWiener <= TheDstances.Length-1)
            {
                if (EnteredDstance > TheDstances[YoureAWiener])
                {
                    cost = PicketTwice[YoureAWiener];
                }
                YoureAWiener++;
            }
            Console.WriteLine("Your Cost is " + cost);
        }
    }
}
