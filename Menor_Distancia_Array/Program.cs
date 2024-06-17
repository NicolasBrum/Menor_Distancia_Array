using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Menor_distancia_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numRandom = new Random();

            Console.Write("Digite o tamanho do array 1: ");
            int userResponse = int.Parse(Console.ReadLine());

            int[] arr1 = new int[userResponse];

            for (int a = 0; a < arr1.Length; a++)
            {
                arr1[a] = numRandom.Next(1, 10);
            }

            Console.WriteLine();

            Console.Write("Digite o tamanho do array 2: ");
            userResponse = int.Parse(Console.ReadLine());

            int[] arr2 = new int[userResponse];

            for (int a = 0; a < arr2.Length; a++)
            {
                arr2[a] = numRandom.Next(1, 10);
            }

            showArrays(arr1, arr2);
            Console.WriteLine();
            Console.WriteLine(getDistance(arr1, arr2));
        }

        static string getDistance(int[] array1, int[] array2)
        {
            int smallerDistance = int.MaxValue;
            int index1 = 0, index2 = 0;

            for (int a = 0; a < array1.Length; a++)
            {
                for (int b = 0; b < array2.Length; b++)
                {
                    int module = array1[a] - array2[b];
                    module = module < 0 ? module *= -1 : module *= 1;

                    if (module < smallerDistance)
                    {
                        smallerDistance = module;
                        index1 = a;
                        index2 = b;
                    }
                }
            }

            string word = $"Indice primeiro array: {index1}  Indice segundo array: {index2}\nMenor distancia: {smallerDistance}";

            return word;
        }

        static void showArrays(int[] array, int[] array2)
        {
            Console.Write("Array 1:");
            for (int a = 0; a < array.Length; a++)
            {
                Console.Write($"[{array[a]}]");
            }

            Console.WriteLine();

            Console.Write("Array 2:");
            for (int a = 0; a < array2.Length; a++)
            {
                Console.Write($"[{array2[a]}]");
            }
        }
    }
}
