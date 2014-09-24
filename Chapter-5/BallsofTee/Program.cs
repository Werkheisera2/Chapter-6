using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BallsofTee
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] LilRayRay = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] BasedGod = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[,] grid = new int[12,6];
            int Kitty =0;
            int Things=0;
            while (Kitty <= LilRayRay.Length)
            {
                Console.Write(Kitty+" Enter the Player number: ");
                Things =Convert.ToInt32(Console.ReadLine());
                if (Things != 999)
                {
                    Console.Write("Enter the Bases: ");
                    BasedGod[Things] = Convert.ToInt32(Console.ReadLine());
                }

                Kitty++;

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Player Summary");
            Console.WriteLine("Player   Bases");
            Console.WriteLine("         Zero   One   Two   Three  Four");

            while (true)
            {
            
            }
        }
    }
}
