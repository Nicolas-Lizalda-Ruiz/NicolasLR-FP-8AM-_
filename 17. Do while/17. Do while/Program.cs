using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que genere y calcule de los primeros # números enterosp ositivos

            /*

            int contador = 0;
            int acumulador = 0;
            int tamaño = 0;

            Console.WriteLine("Pon un número, todos los anteriores enteros positivos se sumarán hasta llegar a él");
            tamaño = int.Parse(Console.ReadLine());

            do
            {
                contador++;
                acumulador += contador;
            } while (contador < tamaño);

            Console.WriteLine($"La suma de los primeros {contador} números enteros positivos es de: {acumulador}"); */

            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            int numeroElegido = 0;
            int contadorHasta10 = 1;
            char volverAEmpezar = '¿';

            /*
            do
            {
                Console.WriteLine($"{numeroElegido} * {contadorHasta10} = {numeroElegido*contadorHasta10}");

                if (contadorHasta10 == 10)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Si quieres voler a elegir otro número para su tabla, digita cualquier letra. Si quieres finalizar el programa pon 'x'");
                    volverAEmpezar = char.Parse(Console.ReadLine());

                    if (volverAEmpezar != 'x')
                    {
                        contadorHasta10 = 1;
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Pon cualquier número positio entero y se mostrarán sus tablas de mutliplicar de x1 hasta x10. Al final se te pedira si quieres volver a poner otro número");
                        numeroElegido = int.Parse(Console.ReadLine());
                    }
                    else if (volverAEmpezar == 'x')
                    {
                        contadorHasta10 = 10;
                    }
                }

                contadorHasta10++;
            } while (contadorHasta10 <= 10);
            */

            do
            {
                Console.WriteLine("Pon cualquier número positio entero y se mostrarán sus tablas de mutliplicar de x1 hasta x10. Al final se te pedira si quieres volver a poner otro número");
                numeroElegido = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");

                do
                {
                    Console.WriteLine($"{numeroElegido} * {contadorHasta10} = {numeroElegido * contadorHasta10}");
                    contadorHasta10++;
                } while (contadorHasta10 <= 10);

                Console.WriteLine("Si quieres voler a elegir otro número para su tabla, digita cualquier letra. Si quieres finalizar el programa pon 'x'");
                volverAEmpezar = char.Parse(Console.ReadLine());
                contadorHasta10 = 1;

            } while (volverAEmpezar != 'x');

            Console.WriteLine("Has finalizado el programa");
        }
    }
}
