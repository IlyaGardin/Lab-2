using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMethods
{
    public static class GlobalMethods
    {
        public static int[] GetRandomArr(int minValue, int maxValue, int lengthArr)
        {
            Random random = new Random(); 

            int[] arr = new int[lengthArr];

            for (int i = 0; i < lengthArr; i++)
            {
                arr[i] = random.Next(minValue, maxValue);
            }

            return arr;
        }
        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
