using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[] arr = GlobalMethods.GlobalMethods.GetRandomArr(-100, 100, 10);
           
            Console.WriteLine("Исходный массив");
            GlobalMethods.GlobalMethods.PrintArr(arr);
           
            int[] NewArr = LocalMethods.GetDoubledArr(arr, 10);
            Console.WriteLine("Новый массив");
            
            GlobalMethods.GlobalMethods.PrintArr(NewArr);
        }
    }
}
