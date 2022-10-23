using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = GlobalMethods.GlobalMethods.GetRandomArr(0, 100, 10);

            Console.WriteLine("Максимальный эллемент:{0} ", LocalMethods.GetMax(arr)) ;
            
            Console.WriteLine("Минимальный эллемент: {0}", LocalMethods.GetMin(arr));

            LocalMethods.ShellSort(arr);

            GlobalMethods.GlobalMethods.PrintArr(arr);
            
        }
    }
}
