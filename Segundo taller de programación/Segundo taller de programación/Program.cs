using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            /*
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

            */

            //Se requiere un algoritmo para mostrar por pantalla los divisores de un  número ingresado por teclado. Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/ b el residuo es 0, en C# utilizar el operador Mod para obtener el residuo de  una división de dos números.   Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3,  2, 1 que son los divisores del número 6.

            /*
            int numeroUsuario = 0;
            int divisor = 0;
            int contadorDeDivisionesEn0 = 0;

            Console.WriteLine("Usuario, ingresa un numero entero para ver sus divisores enteros.");
            numeroUsuario = int.Parse(Console.ReadLine());
            do
            {
                divisor++;
                if (numeroUsuario % divisor == 0)
                {
                    contadorDeDivisionesEn0++;
                    Console.WriteLine("Los divisores de el número " + numeroUsuario + " son: " + divisor);
                }

            } while (divisor < numeroUsuario);
            */

            //Dados dos números enteros ingresados por teclado: b que es la base y  e que es el exponente, se requiere calcular el resultado de la  potenciación. Ejemplo: b=2, e=5  25=2*2*2*2*2= 32  Mostrar por pantalla el resultado de la potenciación. Seguir pidiendo por teclado la base y el exponente y realizar la  potenciación correspondiente, hasta que el usuario ingrese por teclado  el carácter de escape ‘n’ 

            int numeroNormalIngresado = 0;
            int exponenteDelNumeroIngresado = 0;
            int contadorPotencia = 1;
            char escape = ' ';

            do
            {
                Console.WriteLine("Usuario, ingresa un número entero para elevarlo a una potencia. Primero el número:");
                numeroNormalIngresado = int.Parse(Console.ReadLine());
                Console.WriteLine("Digita la potencia del numero anterior");
                exponenteDelNumeroIngresado = int.Parse(Console.ReadLine());
                
                int numeroOriginal = numeroNormalIngresado;
                if (exponenteDelNumeroIngresado < 0)
                {
                    do
                    {
                        Console.WriteLine("Vuelve a digitar la potencia, no pueden ser numeros menores a 0");
                        contadorPotencia = int.Parse(Console.ReadLine());

                    } while (exponenteDelNumeroIngresado < 0);
                }

                if (exponenteDelNumeroIngresado == 0)
                {
                    numeroNormalIngresado = 1;
                    contadorPotencia = exponenteDelNumeroIngresado;
                }

                do
                {
                    contadorPotencia++;
                    numeroNormalIngresado *= numeroOriginal;
                    Console.WriteLine(Math.Sqrt(numeroNormalIngresado) + " * " + (numeroOriginal) + " = " + numeroNormalIngresado);

                } while (contadorPotencia < exponenteDelNumeroIngresado);

                Console.WriteLine($"El numero {numeroOriginal} elevado a una potencia de {exponenteDelNumeroIngresado} sería {numeroNormalIngresado}");

                Console.WriteLine("Para finalizar el programa digita 'n', de resto cualquier carácter para reiniciar");

                escape = char.Parse(Console.ReadLine());

            } while (escape != 'n');

        }
    }
}
