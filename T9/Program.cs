using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int numberElem;
            if (int.TryParse(Console.ReadLine(), out numberElem) && numberElem > 0)
            {
                Console.WriteLine("Заполните первый массив: ");
                int[] arr1 = LocalMethods.GetNonRepeatingArr(numberElem);

                Console.WriteLine("Заполните второй массив: ");
                int[] arr2 = LocalMethods.GetNonRepeatingArr(numberElem);

                Console.WriteLine("Массив №1:");
                GlobalMethods.GlobalMethods.PrintArr(arr1);

                Console.WriteLine("\nМассив №2:");
                GlobalMethods.GlobalMethods.PrintArr(arr2);
                
                if (LocalMethods.IsSameArr(arr1,arr2) == false)
                {
                    Console.WriteLine("\nМассивы различны");
                }
                else
                {
                    Console.WriteLine("\nМассивы одинаковые");
                }
            }
            else
            {
                Console.WriteLine("Некорректно введено число элементов массива.");
            }
        }
    }
}
