using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 5, 4, 3, 2, 1 };
            quicksort(array, 0, array.Length - 1);

            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
        }

        static void quicksort(int[] array,int start,int end)
        {
            if(start >= end)
            {
                return;
            }

            int pivot = partion(array,start,end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        }

        static int partion(int[] array,int start,int end)
        {
            int temp;
            int marker = start;
            for(int i = start;i <= end; i++)
            {
                if(array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }

            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;

            return marker;
        }
    }
}
