using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2D = LocalMethods.GetRandomArr(0,100,3,3);
            
            LocalMethods.PrintArr(arr2D);

            Console.WriteLine("Сумма элементов массива, стоящих на четных позициях: " + LocalMethods.GetSummElemEvenPosition(arr2D));  
           
        }
    }
}
