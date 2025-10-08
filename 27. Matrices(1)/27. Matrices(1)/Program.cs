using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Matrices_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            27. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.

            Requisitos del programa:
            Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3).
            Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).
            */

            int[,] Tabla1 = new int[2, 3];
            int[,] Tabla2 = new int[2, 3];
            int[,] tablaSuma = new int[2, 3];

            Console.WriteLine("Usuario, vas a llenar 2 tablas de números y al final se te mostrara la suma de los numeros de sus respectivas posiciones.");
            Console.WriteLine();
            Console.WriteLine("Empieza con el primero");
            Console.WriteLine("------------------------------------------------");

            for (int i = 0; i < Tabla1.GetLength(0); i++)
            {
                for (int j = 0; j < Tabla1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa un numero en la primera tabla. Este numero estará en la fila {i} y en la columna {j}.");
                    Tabla1[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Empieza con el segundo");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < Tabla2.GetLength(0); i++)
            {
                for (int j = 0; j < Tabla2.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa un numero en la segunda tabla. Este numero estará en la fila {i} y en la columna {j}.");
                    Tabla2[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablaSuma[i, j] = Tabla1[i, j] + Tabla2[i, j];
                }
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("La suma de las dos tablas es: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {tablaSuma[i, j]} |");
                }
                Console.WriteLine();
            }
        }
    }
}
