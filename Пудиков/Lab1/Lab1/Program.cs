using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4,8,12,16,20};
            int min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    min = array[i + 1];
                }
            }
            int max = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    max = array[i + 1];
                }
            }
            Console.WriteLine(Nod(array,array.Length,max,min));
            Console.WriteLine(Nok(array, array.Length, max, min));
            Console.ReadKey();
        }

        static int Nod(int[] array,int size,int max, int min)
        {
            int nod = 0;
            for (int a = 0; a < size; a++)
            {
                for (int b = 1; b < size; b++)
                {
                    for (int i = 2; i < max; i++)
                    {
                        if (array[a] % i == 0 && array[b] % i == 0 && a != b)
                        {
                            if (i > nod && i <= min)
                            {
                                nod = i;
                            }

                        }
                    }
                }
            }
            return nod;
        }

        static int Nok(int[] array, int size, int max, int min)
        {
            int nok = 0;
            for (int a = 0; a < size; a++)
            {
                for (int b = 1; b < size; b++)
                {
                    if ((array[a] * array[b]) / SubNod(array[a], array[b],min) > nok)
                    {
                        nok = (array[a] * array[b]) / SubNod(array[a], array[b], min);
                    }
                }
            }
            return nok;
        }
        
        static int SubNod(int a, int b, int min)
        {
            int nod1 = 0;
            int high = 0;
            if (a > b)
            {
                high = a;
            }
            else
            {
                high = a;
            }
            for (int i = 2; i < high; i++)
            {
                if (a%i == 0 && b%i == 0)
                {
                    if (i > nod1 && i <= min)
                    {
                        nod1 = i;
                    }
                }
            }
            return nod1;
        }

    }
 }
        
   

    
