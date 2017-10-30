using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortirovkaPuzirkom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 3, 2, 1, 5, 4, 8, 6, 7, 9, 0 };
            


            for(int i = 1;i < mass.Length; i++)
            {
                for(int j = i,f = 0;j >= 1 && f == 0; j--)
                {
                    if(mass[j - 1] > mass[j])
                    {
                        int val = mass[j - 1];
                        mass[j - 1] = mass[j];
                        mass[j] = val;
                    }
                    else
                    {
                        f = 1;
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
