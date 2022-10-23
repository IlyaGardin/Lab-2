using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9
{
    internal class LocalMethods
    {
        public static int[] GetNonRepeatingArr(int lengtharr)
        {
            int[] array = new int[lengtharr];
            int element;            
            for (int i = 0; i < lengtharr; i++)
            {
                Console.Write(i+1 + "-й элемент: ");
                if (int.TryParse(Console.ReadLine(), out element) == false)
                {
                    Console.WriteLine("\nВходные данные имели не подходящий символ.");
                    Console.WriteLine("Введите заново...\n");
                    i--;
                    continue;
                }
                array[i] = element;
            }
            return array;
        }

        public static bool IsSameArr(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
