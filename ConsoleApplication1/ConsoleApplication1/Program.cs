using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 4, 5, 2, 7, 1, 9, 12 };

            bool ResultOk = false;

            Console.Write("Enter the value to find : ");
            int value = int.Parse(Console.ReadLine());

            for(int j = 0,pos = -1;j < mass.Length && pos == -1; j++)
            {
                if(mass[j] == value)
                {
                    pos = j;
                    ResultOk = true;
                }
            }
        }
    }
}
