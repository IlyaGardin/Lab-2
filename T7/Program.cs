using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalMethods;

namespace T7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int numberElem;
            if (int.TryParse(Console.ReadLine(), out numberElem) && numberElem>0)
            {
                int[] arr = GlobalMethods.GlobalMethods.GetRandomArr(0, 100, numberElem);

                Array.Sort(arr);
                Array.Reverse(arr);

                Console.WriteLine("Отсортированный массив");
                GlobalMethods.GlobalMethods.PrintArr(arr);
            }
            else
            {
                Console.WriteLine("Некорректно введено число элементов массива.");
            }
        }
    }
}
