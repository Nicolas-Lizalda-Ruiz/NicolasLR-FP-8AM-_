using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.While_loops_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.

            int rangoDeNumeros = 0;
            int separadorNumerosPar = 0;
            int contadorNumerosPar = 1;

            Console.WriteLine("Ingresa un número y se calculará cuantos pares hay dentro del rango de ese número.");
            Console.WriteLine("");

            Console.WriteLine("Ingresa el rando de números que quieras.");
            rangoDeNumeros = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            /*
            while (contadorNumerosPar <= rangoDeNumeros)
            {
                if ((contadorNumerosPar % 2) == 0)
                {
                    separadorNumerosPar++;
                }
                contadorNumerosPar++;
            }
            */

            while (contadorNumerosPar <= (rangoDeNumeros - 1))
            {
                contadorNumerosPar += 2;
                separadorNumerosPar++;
            } 

            Console.WriteLine("La cantidad de numeros pares en el de rango: " + rangoDeNumeros + " es de " + separadorNumerosPar);
            Console.WriteLine("");
        }

    }
}
