using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class LocalMethods
    {
        public static int GetSumPositiv(int[] arr)
        {
            int sumPositiv = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    sumPositiv += arr[i];
                }
            }
            return sumPositiv;
        }
    }
}
