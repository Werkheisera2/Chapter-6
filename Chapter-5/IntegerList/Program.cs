using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] List = { 245, 23543, 74665, 578568, 7 };
            int Loop=0;
            while(Loop<=List.Length-1){
                Console.WriteLine(List[Loop]);
                Loop++;
            }
            Console.WriteLine("");
            Loop= List.Length-1;
            while(Loop>=0){
                Console.WriteLine(List[Loop]);
                Loop--;
            }
 }
    }
}
