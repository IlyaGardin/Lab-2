using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class LocalMethods
    {
        public static void ShellSort(int[] arr)
        {
            int step = arr.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < arr.Length; i++)
                {
                    int value = arr[i];
                    for (j = i - step; (j >= 0) && (arr[j] > value); j -= step)
                    {
                        arr[j + step] = arr[j];
                    }
                        arr[j + step] = value;
                    
                }
                step /= 2;
            }

        }
        public static int GetMax(int[] arr)
        {
            int max = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static int GetMin(int[] arr)
        {
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }
    }
}
