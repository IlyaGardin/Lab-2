using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int numberElem;
            if (int.TryParse(Console.ReadLine(), out numberElem) && numberElem>0)
            {
                int[] arr = GlobalMethods.GlobalMethods.GetRandomArr(0, 10, numberElem);
               
                Console.WriteLine("Исходный массив: ");
                GlobalMethods.GlobalMethods.PrintArr(arr);
                
                Console.WriteLine("Введите нужное число: ");
                int number;
                if (int.TryParse(Console.ReadLine(), out number) && number>=0 && number<=10)
                {
                    Console.WriteLine("Номера всех вхождений искомого числа:");
                    int[] ArrIndex = LocalMethods.GetIndexNumbers(arr, number);
                    GlobalMethods.GlobalMethods.PrintArr(ArrIndex);
                }
                else
                {
                    Console.WriteLine("Некорректно введено число.");
                }
            }
            else
            {
                Console.WriteLine("Некорректно введено число элементов массива.");
            }
        }
    }
}
