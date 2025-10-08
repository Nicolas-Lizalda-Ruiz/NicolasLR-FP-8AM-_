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
        static void Main(string[] args)
        {
            Console.WriteLine("Usuario, puedes crear una tabla del tamaño que quiera pero solo la puedes llenar de multiplos de 5.");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            int[,] multiplosDe5 = new int[LeerFilas(), LeerColumnas()];
        }

        static int[,] LLenarMatrizDeMP5(int[,] matriz)
        {

            return matriz;
        }

        static int LeerFilas()
        {
            Console.Write("Ingrese el número de filas para la tabla: ");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        static int LeerColumnas()
        {
            Console.Write("Ingrese el número de columnas para la tabla: ");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

        /*static bool VerificacionDeMultiplo()
        {

        }*/
    }
}
