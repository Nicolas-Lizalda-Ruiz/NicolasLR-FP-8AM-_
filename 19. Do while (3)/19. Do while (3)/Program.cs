using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Do_while__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int cantidadHombres = 0;
            int cantidadMujeres = 0;
            int menorDeEdad = 0;
            int mayorDeEdad = 0;
            char generoDePersonas = ' ';

            int preguntasHechasEnTotal = 0;

            do
            {
                preguntasHechasEnTotal++;

                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"Estudiante #{preguntasHechasEnTotal}, porfavor ingresa tu edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------------------------------------------------------------------");

                Console.WriteLine($"Estudiante #{preguntasHechasEnTotal}, porfavor ingresa tu género. Debes poner 'H' para hombre o 'M' para mujer. Ponlo en mayúscula: ");
                generoDePersonas = char.Parse(Console.ReadLine());

                if (edad >= 18 && edad < 100)
                {
                    mayorDeEdad++;
                }
                else if (edad < 18 && edad > 5)
                {
                    menorDeEdad++;
                }
                else
                {
                    Console.WriteLine("Ingresa una edad válida porfavor. El sistema reinicia para tus datos");
                    preguntasHechasEnTotal--;
                }

                if (generoDePersonas == 'M')
                    cantidadMujeres++;
                else if (generoDePersonas == 'H')
                    cantidadHombres++;
                else
                {
                    Console.WriteLine("Ingresa un género válido porfavor, El sistema reinicia para tus datos");
                    if (edad >= 5 && edad <= 100)
                    {
                        preguntasHechasEnTotal--;
                    }

                }

            } while (preguntasHechasEnTotal < 3);

            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("La cantidad de mujeres es: " + cantidadMujeres);
            Console.WriteLine("La cantidad de Hombres es: " + cantidadHombres);
            Console.WriteLine("La cantidad de Mayores de edad es: " + mayorDeEdad);
            Console.WriteLine("La cantidad de Menores de edad es: " + menorDeEdad);

        }
    }
}
