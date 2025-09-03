using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.While_loops_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  El algoritmo debe escribir en pantalla: La cantidad de números introducidos que son mayores que 0 | La cantidad de números introducidos menores que 0 | La cantidad de números iguales a 0.

            float numeroIngresado = 0;          
            Char mostradorPantalla = ' ';
            int numeroIngresadoPositivos = 0;
            int numeroIngresadoNegatios = 0;
            int numeroIngresadoIgualA0 = 0;

            Console.WriteLine("Usuario, ingresa la cantidad de numeros que deseas. Mientras los ingresas se contará acumilativamente cuales son mayores a 0, iguales a 0 o menores a 0");
            Console.WriteLine("");

            while (mostradorPantalla != 'I')
            {
                Console.WriteLine("Usuario, ingresa un número: ");
                numeroIngresado = float.Parse(Console.ReadLine());

                if (numeroIngresado == 0)
                {
                    numeroIngresadoIgualA0++;
                }
                else if (numeroIngresado > 0)
                {
                    numeroIngresadoPositivos++;
                }
                else if (numeroIngresado < 0)
                {
                    numeroIngresadoNegatios++;
                }

                Console.WriteLine("La cantidad de numeros mayores a 0 son: " + numeroIngresadoPositivos);
                Console.WriteLine("La cantidad de numeros menores a 0 son: " + numeroIngresadoNegatios);
                Console.WriteLine("La cantidad de numeros iguales a 0 son: " + numeroIngresadoIgualA0);
                Console.WriteLine("");
                Console.WriteLine("Ingresa otro número");
                Console.WriteLine("");
            }
        }
    }
}
