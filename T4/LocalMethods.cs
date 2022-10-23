using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    internal class LocalMethods
    {
        public static int[,] GetRandomArr(int minValue, int maxValue, int lengthArr1, int lengthArr2)
        {
            Random random = new Random();

            int[,] arr = new int[lengthArr1, lengthArr2];

            for (int i = 0; i < lengthArr1; i++)
            {
                for (int j = 0; j < lengthArr2; j++)
                {                    
                    arr[i, j] = random.Next(minValue, maxValue);                    
                }

            }

            return arr;
        }

        public static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                        Console.WriteLine(arr[i, j]);
                               
                }
                Console.WriteLine();
            }
        }

        public static int GetSummElemEvenPosition(int[,] arr)
        {
            int summelem = 0;
            int summindx = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summindx = i + j;
                    if (summindx % 2 == 0)
                    {

                        summelem += arr[i, j];
                    }
                }
            }
            return summelem;
        }
    }
}
