using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    internal class LocalMethods
    {
        public static int[] GetIndexNumbers(int[] arr, int number)
        {
            int index = 0;
            int[] arrNumber = new int[CountNumberRequiredElem(arr,number)];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    arrNumber[index] = i;
                    index++;
                }

            }
            return arrNumber;
            
        }

        public static int CountNumberRequiredElem(int[] arr, int number)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    
                    counter++;
                }

            }
            return counter; 
        }
    }
}
