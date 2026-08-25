using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_______Merging_Branches_Using_Visual_Studio
{
    internal class Program
    {


        static int MultiplyFunction(int num1,int num2)
        {
            return num1 * num2;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Console.WriteLine("New Branch Created");

            Console.WriteLine(MultiplyFunction(1,66).ToString());
        }
    }
}
