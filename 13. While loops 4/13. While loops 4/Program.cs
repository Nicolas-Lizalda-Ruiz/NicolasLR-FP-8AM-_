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

            Console.WriteLine("Usuario, ingresa la cantidad de numeros que deseas. Podrás elegir los que quieras si pones y te muestra todos los numeros mayores a 0, iguales a 0 y menores a 0 y si ingresas cualqier letra al final cuando se pide se reinicia el programa pero si pones 'I' se finaliza el proceso");

            while (mostradorPantalla !=  'I')
            {
                Console.WriteLine("Usuario, ingresa un primer número: ");
                numeroIngresado = float.Parse(Console.ReadLine());

                if (numeroIngresado == 0)
                {
                    Console.WriteLine($"El numero {numeroIngresado} es igual a 0");
                    Console.WriteLine($"-----------------------------------------------------------");
                }
                else if (numeroIngresado > 1)
                {
                    Console.WriteLine($"El numero {numeroIngresado} es positivo");
                    Console.WriteLine($"-----------------------------------------------------------");
                }
                else if (numeroIngresado < 2)
                {
                    Console.WriteLine($"El numero {numeroIngresado} es negativo");
                    Console.WriteLine($"-----------------------------------------------------------");
                }
                Console.WriteLine($"Ingresa cualquier letra si quieres reinicar el programa. Si ingresas 'I' se finaliza");
                mostradorPantalla = char.Parse(Console.ReadLine());
                Console.WriteLine($"-----------------------------------------------------------");
            }
            Console.WriteLine($"Has finalizado el programa");
        }
    }
}
