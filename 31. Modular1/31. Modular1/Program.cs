using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _31.Modular1
{
    internal class Program
    {
        //Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.
        static void Main()
        {
            /*Console.WriteLine("Usuario, puedes crear una tabla del tamaño que quiera pero solo la puedes llenar de multiplos de 5.");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");*/

            int[,] multiplosDe5 = new int[LeerFilas(), LeerColumnas()];
            LlenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5);
        }

        static int LeerFilas()//Esta funcion lee la cantidad de filas para que cree su propia matriz
        {
            BorrarPantalla();
            Console.Write("Ingrese el número de filas para la tabla: ");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        static int LeerColumnas() //Esta funcion lee la cantidad de columnas para que cree su propia matriz
        {
            BorrarPantalla();
            Console.Write("Ingrese el número de columnas para la tabla: ");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

        static int[,] LlenarMatriz(int[,] matriz) //este modulo llena la matriz de multiplos de 5
        {
            int numero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        BorrarPantalla();
                        Console.Write("Digita un numero para ingresar en la matriz: ");
                        numero = int.Parse(Console.ReadLine());
                    } while ((VerificacionDeMultiplo5(numero) == false));
                    matriz[i, j] = numero;
                }
            }

            return matriz;
        }

        static bool VerificacionDeMultiplo5(int numero) //esta funcion verifica si un numero es multiplo de 5
        {
            if((numero%5 == 0) && (numero != 0))
            {
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ingresa un numero válido que sea multiplo de 5: ");
                return false;
            }
        }

        static void MostrarMatriz(int[,] matrizCualquiera) //procedimiento que recibe una matriz para mostrarla en pantalla
        {
            BorrarPantalla();
            for (int i = 0; i<matrizCualquiera.GetLength(0); i++)
            {
                for ( int j = 0; j<matrizCualquiera.GetLength (1); j++)
                {
                    Console.Write($"|  {matrizCualquiera[i,j]}  |");
                }
                Console.WriteLine();
            }
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

    }
}
