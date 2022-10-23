using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GlobalMethods.GlobalMethods.GetRandomArr(-100, 100, 20);

            GlobalMethods.GlobalMethods.PrintArr(arr);           
            
            Console.WriteLine();
            Console.WriteLine("Сумма неотрицательных эллементов массива:"+ LocalMethods.GetSumPositiv(arr));
            
        }
    }
}
