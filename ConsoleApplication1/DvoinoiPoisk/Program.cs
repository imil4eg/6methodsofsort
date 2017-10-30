using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvoinoiPoisk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 1,2,3,4,5,6,7,8,9 };
            int Pos;
            bool ResultOk;

            int First = 0;
            int Last = mass.Length - 1;
            int middle = (Last + First) / 2;

            Console.Write("Enter the value : ");
            int val = int.Parse(Console.ReadLine());

            for(;First < Last; First++)
            {
                if(val == mass[middle])
                {
                    Last = First;
                    First = middle;
                }
                else if(val > mass[middle])
                {
                    First = middle + 1;
                }
                else
                {
                    Last = middle + 1;
                }
            }

            Pos = First;
            ResultOk = false;

            if(Pos <= Last && val == mass[Pos])
            {
                ResultOk = true;
            }

            Console.WriteLine(Pos);
        }
    }
}
