using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array1 = new int[5];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(10, 100);
            }
            Array.ForEach(array1, arr => Console.Write(arr + " "));

            int[] array2 = new int[array1.Length - 1];

            Array.Copy(array1, 1, array2, 0, array2.Length);
            Array.Reverse(array2);

            Console.WriteLine();
            Array.ForEach(array2, arr => Console.Write(arr + " "));

            Console.ReadKey();
        }
    }
}
