using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadro(2,2);
            Console.ReadKey();
        }

        static int Quadro(int x, int y)
        {
            Console.WriteLine("Введите длину стороны: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int [] vert = new int [4];
            vert[0] = x - (a / 2);//координата х левых углов
            vert[1] = y + (a / 2);//координата y верхних углов
            vert[2] = x + (a / 2);//координата х правых углов
            vert[3] = y - (a / 2);//координата у нижних углов
            Console.WriteLine("Координаты верхнего левого угла: " + vert[0] + ";" + vert[1]);
            Console.WriteLine("Координаты верхнего правого угла: " + vert[2] + ";" + vert[1]);
            Console.WriteLine("Координаты нижнего левого угла: " + vert[0] + ";" + vert[3]);
            Console.WriteLine("Координаты нижнего правого угла: " + vert[2] + ";" + vert[3]);
            return 0;
        }

    }
}
