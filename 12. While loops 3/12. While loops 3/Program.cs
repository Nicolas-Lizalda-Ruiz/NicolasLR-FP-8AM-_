using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _12.While_loops_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.
            int acumulador = -1;
            int suma = 0;

            while (acumulador < 99)
            {
                acumulador = acumulador + 2;
                suma += acumulador;

                if (suma > 1)
                {
                    Console.WriteLine($"{suma - acumulador} + {acumulador} = {suma}");
                    Console.WriteLine("----------------------------------");
                }
            }

            Console.Write("La suma de todos los números impares hasta el 99 son: " + suma);
        }
    }
}
