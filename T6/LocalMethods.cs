using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    internal class LocalMethods
    {
        public static int[] GetDoubledArr(int[] arr, int lengthArr)
        {
            int count = 0;
            for (int i = 0; i < lengthArr; i++)
            {                
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            int[] doubledArr = new int[lengthArr + count];
            
            int countI = 0;
            for (int i = 0; i < lengthArr; i++)
            {

                if (arr[i] > 0)
                {
                    doubledArr[i + countI] = arr[i];

                }
                else
                {
                    countI++;
                    doubledArr[i + countI - 1] = arr[i];
                    doubledArr[i + countI] = arr[i];

                }

            }
            return doubledArr;
        }
    }
}
