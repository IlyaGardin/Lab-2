using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GlobalMethods.GlobalMethods.GetRandomArr(-100, 100, 10);
            GlobalMethods.GlobalMethods.PrintArr(arr);
            
            arr = Array.FindAll(arr, LocalMethods.IsPositive).ToArray();
                Console.WriteLine("Массив без отрицательных чисел");
            GlobalMethods.GlobalMethods.PrintArr(arr);
        }
             
        
    }
}
