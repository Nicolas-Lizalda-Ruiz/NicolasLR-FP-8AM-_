using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_arreglos_bidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas.

            /*
            int filas = 0;
            int columnas = 0;

            Console.WriteLine("Usuario, podrás crear una tabla y al final se te mostrará la tabla con la primera y última fila intercambiada y la tabla original también. Empieza digitando la cantidad de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ahora digita la cantidad de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matrizIngresada = new int[filas, columnas];
            int[,] matrizInvertida = new int[filas, columnas];

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            for (int i=0; i < matrizIngresada.GetLength(0); i++)
            {
                for (int j=0; j < matrizIngresada.GetLength(1); j++)
                {
                    Console.WriteLine($"Usuario, digita un valor en la fila {i} en la columna {j}");
                    matrizIngresada[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i=0; i < matrizIngresada.GetLength(0); i++)
            {
                for (int j=0; j < matrizIngresada.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrizInvertida[0, j] = matrizIngresada[0, j];
                    }
                    else if (j == matrizIngresada.GetLength(1))
                    {
                        matrizInvertida[matrizIngresada.GetLength(0) - 1, j] = matrizIngresada[matrizIngresada.GetLength(1) - 1, j];
                    }
                    else
                    {
                        matrizInvertida[i, j] = matrizIngresada[i, j];
                    }

                }
   
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine("La tabla original sería:");
            for (int i = 0; i < matrizIngresada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizIngresada.GetLength(1); j++)
                {
                    Console.Write($"| {matrizIngresada[i,j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine("La tabla invertida sería:");
            for (int i = 0; i < matrizIngresada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizIngresada.GetLength(1); j++)
                {
                    Console.Write($"| {matrizInvertida[i, j]} |");
                }
                Console.WriteLine();
            }
            */

            //Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar posición de una "X"
            //El algoritmo debe permitir:
            // Usar la función Random para colocar las "X" en la matriz.
            // Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado.
            // Al final sacar un mensaje de éxito o error.Si el mensaje es de éxito mostrar la posición de la X en la matriz.Si el mensaje es de error, mostrar la matriz.

            string[,] matrizConX = new string[5,5];
            Random lasX = new Random();
            int cantidadDeX = 0;
            string[] filaConX = new string[3];
            string[] columnaConX = new string[3];
            int filaAdivinada = 0;
            int columnaAdivinada = 0;
            int intentosPosibles = 0;

            do
            {
                cantidadDeX = 0;
                for (int i = 0; i < matrizConX.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizConX.GetLength(1); j++)
                    {
                        matrizConX[i, j] = Convert.ToString(lasX.Next(1, 12));

                        if (matrizConX[i, j] == "11")
                        {
                            matrizConX[i, j] = "X";
                            cantidadDeX++;
                            filaConX[i] = matrizConX[i,j];
                            columnaConX[i] = matrizConX[i,j];
                        }
                    }
                }
            } while (cantidadDeX != 3);

            for (int i = 0; i < matrizConX.GetLength(0); i++)
            {
                for (int j = 0; j < matrizConX.GetLength(1); j++)
                {
                    if (intentosPosibles == 3)
                    {

                    }

                    Console.Write("Adivinar posicion en fila: ");
                    filaAdivinada = int.Parse(Console.ReadLine());
                    Console.Write("Adivinar posicion en columna: ");
                    columnaAdivinada = int.Parse(Console.ReadLine());

                    if (matrizConX[i,j] == matrizConX[filaAdivinada, columnaAdivinada])
                    {

                    }
                    else
                    {
                        intentosPosibles++;
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrizConX.GetLength(0); i++)
            {
                for (int j = 0; j < matrizConX.GetLength(1); j++)
                {
                    Console.Write($"| {matrizConX[i,j]} |");
                }
                Console.WriteLine();
            }


        }
            
    }
}
