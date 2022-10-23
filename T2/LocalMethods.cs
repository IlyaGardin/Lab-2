using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class LocalMethods
    {
        public static int[,,] GetRandomArr(int minValue, int maxValue, int lengthArr1, int lengthArr2, int lengthArr3)
        {
            Random random = new Random();

            int[,,] arr = new int[lengthArr1, lengthArr2, lengthArr3];

            for (int i = 0; i < lengthArr1; i++)
            {
                for (int j = 0; j < lengthArr2; j++)
                {
                    for (int k = 0; k < lengthArr3; k++)
                    {
                        arr[i, j, k] = random.Next(minValue, maxValue);
                    }
                }

            }

            return arr;
        }

        public static void ChangePositivArr(int [,,] arr )
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] < 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }

                }

            }            
        }
        public static void PrintArr(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine(arr[i, j, k]);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
