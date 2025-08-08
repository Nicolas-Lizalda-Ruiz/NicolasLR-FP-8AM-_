using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Condicionales_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Condicionales simples
            string nombrePersona1 = "";
            float sueldo = 0;

            Console.WriteLine("Ingrese su nombre, usuario: ");
            nombrePersona1 = Console.ReadLine(); //lo que se ponga en consola se lee como un string

            Console.WriteLine("Ingrese su sueldo, usuario; ");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine($"usuario {nombrePersona1}, tu sueldo es mayor a 3000, por ende, debes abonar impuestos.");
            }

            else
            {
                Console.WriteLine($"usuario {nombrePersona1}, tu sueldo es menor que 3000, por ende, no debes abonar impuestos");
            }
            */
            Console.WriteLine("----------------------------------------------");
            //2. Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. 

            float edad = 0;

            Console.WriteLine("Ingrese su edad antes de entrar al sitio: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("No estas permitido a entrar al sitio, eres menor de edad");
            }

            else if(edad > 18 && edad < 100)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }

            else
            {
                Console.WriteLine("ingresa una edad válida porfavor");
            }
        }
    }
}
