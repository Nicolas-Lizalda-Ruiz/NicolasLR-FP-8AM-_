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

            /*
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
            */

            //Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio. Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes. Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, mostrar mensaje de error. | 9.5 - 10: Excelente | 8.5 - 9.4: Muy bien | 7.5 - 8.4: bien.
            /*
            float Calificación1 = 0f;
            float Calificación2 = 0f;
            float Calificación3 = 0f;
            float calificaciónFinal = 0f;

            Console.WriteLine("Estudiante, ingresa tus 3 notas para ver tu promedio. Acuerdate que tus notas van del 0 al 10, ni mas ni menos. El orden no importa. No pongas puntos en los decimales, pon comas");

            Console.WriteLine("Ingresa la primera");
            Calificación1 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la segunda");
            Calificación2 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la Tercera");
            Calificación3 = Single.Parse(Console.ReadLine());

            calificaciónFinal = (Calificación1 + Calificación2 + Calificación3) / 3f;

            if (calificaciónFinal > 9.4f && calificaciónFinal < 10.00001)
            {
                Console.WriteLine("Tu promedio es de: " + calificaciónFinal + ", El cual es excelente");
            }

            else if(calificaciónFinal > 8.5f && calificaciónFinal < 9.4f)
            {
                Console.WriteLine("Tu promedio es de: " + calificaciónFinal + ", El cual es muy bueno");
            }

            else if(calificaciónFinal > 7.4f && calificaciónFinal < 8.5f)
            {
                Console.WriteLine("Tu promedio es de: " + calificaciónFinal + ", El cual es muy bueno");
            }

            else if(calificaciónFinal < 7.4f)
            {
                Console.WriteLine("Tu promedio es de: " + calificaciónFinal + ", El cual es mal");
            }

            else
            {
                Console.WriteLine("Ingresa calificaciones válidas porfavor. Acuerdate que las calificaciones se ingresan de 0 a 10 mínimo y máximo respectivamente");
            }
            */
        }
    }
}
