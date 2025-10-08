using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numerosMatriz = new int[2, 2];
            string[,] nombresMatriz = new string[3, 4]; //El rango es de 6 posiciones

            char[,] caracteresMatriz = new char[3, 3]; //el rango es de 9 posiciones

            numerosMatriz[0, 0] = 67;
            numerosMatriz[0, 1] = 69;
            numerosMatriz[1, 0] = 420;
            numerosMatriz[1, 1] = 70 - 1;
            // numerosMatriz[1, 2] = 99999; La columna "2" no existe.

            //otras formas de inicializar matrices serían
            string[,] apellidos =
            {
                {"charlie", "Juanito", "gero ya me conseguí el onirifalx" },//3
                {"xd", "lol", "67" },//3
                {"gwasaaa", "i-i", "o_o"}//3
            };

            //Ahora se recuperan los datos para procesarlos (recuperarlos para: mostrarlos, cambiarlos y eso)
            Console.WriteLine(apellidos[0, 2]);

            //Para recorrer una matriz se usa cualquier cilco pero es mas adecuado el ciclo

            /*
            for (int i = 0; i < 3; i++)//Para recorrer las filas
            {
                for (int j = 0; j < 3; j++)//para recorrer las columnas
                {
                    Console.WriteLine($"Ingresa un caracter en la fila {i} con columna {j}");
                    caracteresMatriz[i,j] = char.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < caracteresMatriz.GetLength(0); i++)//El .Getlength(0) devuele el número de filas
            {
                for (int j = 0; j < caracteresMatriz.GetLength(1); j++)//El .Getlength(1) devuelve el número de columnas
                {
                    Console.WriteLine($"El caracter en la fila {i} con clumna {j} es: " + caracteresMatriz[i,j]);
                }
            }

            //ahora en forma de tabla/matriz
            for (int i = 0; i < caracteresMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < caracteresMatriz.GetLength(1); j++)
                {
                    Console.Write($" {caracteresMatriz[i,j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("La cantidad de posiciones de la matriz carácteresMatriz es de: " + caracteresMatriz.Length);
            */

            int[,] matrizDeSolo10 = new int[4, 4];

            for(int i = 0; i < matrizDeSolo10.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDeSolo10.GetLength(1); j++)
                {
                    matrizDeSolo10[i, j] = 10;
                }
            }

            Console.WriteLine("Una matriz de solo el número 10 sería ");
            Console.WriteLine();

            for (int i = 0; i < matrizDeSolo10.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDeSolo10.GetLength(1); j++)
                {
                    Console.Write($" {matrizDeSolo10[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("La cantidad de posiciones de la matriz son: " + matrizDeSolo10.Length);

        }
    }
    
}
