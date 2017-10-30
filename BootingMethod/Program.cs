using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 56, 45, 89, 541, 4, 23, 5, 33, 54, 99 };
            int J, N = mas.Length, val, pos, i;
            for (J = 1; J < N; J++)
            {
                val = mas[J];
                pos = BinarySearch(mas, val);
                if (pos < J)
                {
                    for (i = J - 1; i >= pos; i--)
                    {
                        mas[i + 1] = mas[i];
                    }
                    mas[pos] = val;
                }
            }

            foreach (int j in mas)
            {
                Console.Write(j + " ");
            }
        }

        public static int BinarySearch(int[] arr, int val)
        {
            Array.Sort(arr);

            int right = arr.Length - 1;
            int left = 0;

            if (arr[left] > val) return -1;
            if (arr[right] < val) return -1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (val <= arr[mid]) right = mid;
                else if (val > arr[mid]) left = mid + 1;
            }

            if (val == arr[right]) return right;
            else return -1;

        }
    }
}
