using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortirovkaViborom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 8,3,7,1,9,2,0,6,4,5};
            int val = 0;

            for(int i = 0;i < mass.Length - 1; i++)
            {
                for(int j = 0;j < mass.Length; j++)
                {
                    if(mass[j] > mass[i])
                    {
                        val = mass[i];
                        mass[i] = mass[j];
                        mass[j] = val;
                    }
                }
            }
            foreach(int i in mass)
            {
                Console.Write(i + " ");
            }
        }
    }
}
