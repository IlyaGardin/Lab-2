using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalMethods;

namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [,,] arr3D = LocalMethods.GetRandomArr(-100, 100, 2, 2, 2);
            
            Console.WriteLine("Исходный массив:");
            LocalMethods.PrintArr(arr3D);

            LocalMethods.ChangePositivArr(arr3D);
           
            Console.WriteLine("Изменненый массив:");
            LocalMethods.PrintArr(arr3D);
            
        }
        
    }

}
