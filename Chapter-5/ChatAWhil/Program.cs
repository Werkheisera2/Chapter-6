using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhil
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AreaGrandeCode = { 262, 414, 608, 715, 815, 920 };
            double[] FirmOldApe = {0.07,0.10,0.05,0.16,0.24,0.14};
            Console.WriteLine("Enter the waves of ye ocean *Ocean man take me by the hand lead me to the land, that you understand*");
            int OceanCode= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ye time wasted talkin to ye mother over ye cellular magic voice box");
            double wastedtime = Convert.ToDouble(Console.ReadLine());
            int OceanMan =0;
            while (OceanMan <= AreaGrandeCode.Length - 1)
            {
               if(OceanCode == AreaGrandeCode[OceanMan])
               {
                   Console.WriteLine("Ye Code is supreme, and ye loot will be prosper-is");
                   Console.WriteLine("Ye cost is "+(wastedtime*FirmOldApe[OceanMan]));
               }
               OceanMan++;
            }
        }
    }
}

