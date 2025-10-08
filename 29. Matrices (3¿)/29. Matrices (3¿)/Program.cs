using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Matrices__3__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // una matriz que tenga 20 columnas y 10 filas y se sume el contenido de cada columna

            int[,] matrizEnteros = new int [2, 4];
            int[] vectorEnteros = new int[matrizEnteros.GetLength(1)];
            Random randomDeEnteros = new Random();


            for (int i=0; i < matrizEnteros.GetLength(0); i++)
            {
                for (int j = 0; j < matrizEnteros.GetLength(1); j++)
                {
                    Console.WriteLine($"Usuario, ingresa un valor para la fila {i} en la columna {j}");
                    matrizEnteros[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizEnteros.GetLength(0); i++)
            {
                for (int j = 0; j < matrizEnteros.GetLength(1); j++)
                {
                    Console.Write($"{matrizEnteros[i,j]} |");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrizEnteros.GetLength(1); i++)
            {
                for (int j = 0; j < matrizEnteros.GetLength(0); j++)
                {
                    vectorEnteros[i] += matrizEnteros[j, i];
                }
            }

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.WriteLine($"La suma de la columna {i} es: {vectorEnteros[i]}");
            }
        }
    }
}
