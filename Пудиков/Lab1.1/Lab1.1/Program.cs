using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер числа: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibb(n));
            Console.ReadKey();
        }
        static int Fibb(int n)
        {
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n - 1];
        }
    }
}
