using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.While_loops_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. 

            int numeroElegido = 0;
            int acumuladorNumeroElegido = 0;
            bool verificacionNegativa = false;

            Console.WriteLine("Usuario, digita todos los números positivos que quieras. Cuando ingreses un número negativo se mostrará la suma total de todos incluyendo el negativo. No se permiten decimales.");
            Console.WriteLine("----------------------------");

            while (verificacionNegativa == false)
            {
                Console.WriteLine("Ingresa un número: ");
                numeroElegido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elegiste el: " + numeroElegido);
                Console.WriteLine("----------------------------");
                acumuladorNumeroElegido += numeroElegido;

                if (numeroElegido < 0)
                {
                    verificacionNegativa = true;
                }
            }

            Console.WriteLine("La suma de todos los números anteriores es: " + acumuladorNumeroElegido);
        }
    }
}

