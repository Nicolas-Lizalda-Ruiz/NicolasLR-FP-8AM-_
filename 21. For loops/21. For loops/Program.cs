using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que genera y suma los primeros 5 números enteros

            int acumulador = 0;

            for (int i = 0; i <= 5; i++)
            {
                acumulador += i;
            }

            Console.WriteLine("La suma de los primeros 5 números enteros es de: " + acumulador);
        }
    }
}
