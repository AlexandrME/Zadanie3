using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Практика_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i,n;
            Console.WriteLine("Введите количество элементов массива:");
            n = int.Parse(Console.ReadLine());

            int[] M = new int[n];

            Console.WriteLine("Введите элементы массива:");
            for (i = 0; i < n; i++)
                M[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Неотрицательные элементы : ");
            for (i = 0; i < n; i++)
            {
                if (M[i] >= 0)
                    Console.WriteLine(M[i]);
            }

            Console.WriteLine("Индексы неотрицательных элементов: ");
            for (i = 0; i < n; i++)
            {
                if (M[i] >= 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey(); 
        }
    }
}
