using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _4.Condicionales_compuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.*/

            /* string nombreDeUsuario = "";
             float sueldoDeUsuario = 0;

             Console.WriteLine("Usuario, ingrese su nombre porfavor: ");
             nombreDeUsuario = Console.ReadLine();

             Console.WriteLine($"{nombreDeUsuario}, ingrese su sueldo porfavor");
             sueldoDeUsuario = Int32.Parse(Console.ReadLine());

             if (sueldoDeUsuario >= 3000)
             {
                 Console.WriteLine($"{nombreDeUsuario}, debes abonar impuestos");
             }

             else
             {
                 Console.WriteLine($"{nombreDeUsuario}, no debes abonar impuestos");
             } */

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”.*/

            /*int edadUsuario = 0;

           Console.WriteLine("Usuario, ingrese su edad antes de entrar a este sito web: ");
           edadUsuario = Int32.Parse(Console.ReadLine());

           if (edadUsuario < 18)
           {
               Console.WriteLine("Eres menor de edad, no estas apto para el contenido de este sitio web");
           }

           else
           {
               Console.WriteLine("Bienvenido a mi sitio web");
           } */

            /*Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número.*/

            int numeroUno = 0;
            int numeroDos = 0;

            Console.WriteLine("ingrese un número. En caso de que este sea menor que el siguiente número se van a mostrar la suma entre los 2 y la resta entre los 2: ");
            numeroUno = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro número.En caso de que sea menor que el número anterior, se van a mostrar la multiplicación entre estos 2 números y la división: ");
            numeroDos = Int32.Parse(Console.ReadLine());

            int numeroMenor1 = numeroUno + numeroDos;
            int numeroMenor2 = numeroUno - numeroDos;
            int numeroMayor1 = numeroUno * numeroDos;
            int numeroMayor2 = numeroUno / numeroDos;


            if (numeroUno < numeroDos)
            {
                Console.WriteLine(numeroMenor1);
                Console.WriteLine(numeroMenor2);
            }

            else
            {
                Console.WriteLine(numeroMayor1);
                Console.WriteLine(numeroMayor2);
            }
        }
    }
}
