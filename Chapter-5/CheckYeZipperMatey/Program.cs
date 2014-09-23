using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckYeZipperMatey
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Zipper = { 61073, 91873, 31784, 77360, 61056, 86598, 18040, 18041, 18042, 18045};
            Console.WriteLine("Enter a zip code to send a cannonball directly into Miccio's Face YARGH!");
            int ZipperCode = Convert.ToInt32(Console.ReadLine());
            int ProstateExam = 0;
            while (ProstateExam<=Zipper.Length-1)
            {
                if (ZipperCode == Zipper[ProstateExam])
                {
                    Console.WriteLine("Yes you're zip code is supah cool homie");
                    //break;
                }
                ProstateExam++;
            }
        }
    }
}
