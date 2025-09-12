using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_taller_de_programación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo que permita calcular el promedio de calificaciones, el algoritmo  le permitirá al usuario, introducir tantas calificaciones como así desee,  en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las  calificaciones capturadas previamente.

            //profe hola el código esta funcionando pero no se porque cuando los flotantes positivos se verifican en los condicionales siempre salen como mayores a cualquier positivo, es decir, si pongo 4.5 me dice que es mayor a 5, y si pongo 5.5 me dice que es mayor a digamos 10000 pero por parte de los negativos si funciona. Con los enteros funcionaría.

            float calificacionPuesta = 0f;
            char finalizador = ' ';
            int contadorDeCalificaciones = 0;
            float acumuladorCalificaciones = 0f;
            bool verificadorCalificación = true;

            Console.WriteLine("Bienvenido estudiante, ingresa tus calificaciones hasta que pongas 'X' cuando se te pida para finalizar y mostrar el promedio de todas");

            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Ingresa una calificación porfavor. Ten en cuenta que solo puedes poner un rango de 0.0 a 5.0, sinó, el sistema te dará un error: ");
                calificacionPuesta = float.Parse(Console.ReadLine());

                contadorDeCalificaciones++;
                Console.WriteLine("Has ingresado: " + contadorDeCalificaciones + " notas");

                do
                {
                    if (calificacionPuesta > 5f || calificacionPuesta < 0f)
                    {
                        verificadorCalificación = false;
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Ingresa un número válido entre 0.0 y 5.0. Vuelve a intentar porfavor y digita tú numero de nuevo: ");

                        calificacionPuesta = float.Parse(Console.ReadLine());

                        if (calificacionPuesta < 5f && calificacionPuesta > 0f)
                            verificadorCalificación = true;
                    }
                } while (verificadorCalificación == false);

                acumuladorCalificaciones += calificacionPuesta;

                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("Para finalizar con tu promedio. Digita 'X' Para ver el promedio o pon cualquier otra letra para poner mas notas.");
                finalizador = char.Parse(Console.ReadLine());

            } while (finalizador != 'X');

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Estudiante, tu promedio sería: {acumuladorCalificaciones / contadorDeCalificaciones}");
            Console.WriteLine("Con un total de notas digitadas de: " + contadorDeCalificaciones);
        }
    }
}
