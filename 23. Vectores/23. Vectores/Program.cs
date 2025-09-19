using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos unidimensionales
            //Vectores

            int[] numeros0 = new int[10]; // El vector numeros tiene 10 posiciones (0-9)

            string[] nombres = new string[5]; // El vector nombres tiene 5 posiciones (0-4)

            numeros0[0] = 10;
            numeros0[1] = 25;
            numeros0[2] = 4;
            numeros0[3] = 9999999;
            numeros0[4] = 1;
            numeros0[5] = 0;
            numeros0[6] = -69;
            numeros0[7] = 6742069;
            numeros0[8] = 2;
            numeros0[9] = 100;
            //numeros[10] = 1000; // genera un error xd, el indice 10 no existe

            int[] numeros1 = new int[] { 1, 2, 3, 4, 5, 101391391, -1};
            int[] numeros2 = { 5, 4, 3, 2, 1, 0, -6767 };
            //Se puede recorrer el vector para llenarlo de datos o para recuperar sus datos

            char[] letraUsuarios = new char[4];

            /*
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Usuario, ingresa un carácter en la posición {i+1}, de índice {i}: ");
                letraUsuarios[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < letraUsuarios.Length; i++)// (Una vriable de array).length devuelve el rango del vector
            {
                Console.WriteLine($"El dato almacenado en la posición {i+1}, con índice {i} es: {letraUsuarios[i]}");
            }
            */

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Usuario, ingresa un nombre en la posición {i + 1}, de índice {i}: ");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"El nombre en la posición {i+1}, de índice {i}, es: {nombres[i]}");
            }
        }
    }
}
