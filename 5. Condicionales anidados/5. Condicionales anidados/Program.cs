using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Condicionales_anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un algoritmo que lea tres números A, B, C y visualice en pantalla el valor más grande. El usuario debe ingresar tres valores diferentes. 

            int A = 0;
            int B = 0;
            int C = 0;

            Console.WriteLine("Ingrese un primer número: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo número: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un tercer número: ");
            C = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                if (A > C)
                {
                    Console.WriteLine("El numero: " + A + " es el mayor de todos.");
                }

                else
                {
                    Console.WriteLine("El numero: " + B + " es el mayor de todos.");
                }
            }

            else
            {
                if (B > C)
                {
                    Console.WriteLine("El numero: " + B + " es el mayor de todos.");
                }

                else
                {
                    Console.WriteLine("El numero: " + C + " es el mayor de todos.");
                }
            }
        }
    }
}
