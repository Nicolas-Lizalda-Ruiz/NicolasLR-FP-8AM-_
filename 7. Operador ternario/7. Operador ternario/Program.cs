using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Operador_ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador ternario
            //Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario. Una persona mayor de edad tiene 18 años o más). 

            /*
            int edad = 0;
            Console.WriteLine("Usuario, ingrese su edad:");
            edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine( edad >= 18 ? "Usuario, eres mayor de edad":"Usuario, eres menor de edad"  );
            */

            // Crear un algorítmo que permita ingresar 3 números enteros y mostrar por pantalla cual es el mayor

            float numero1 = 0;
            float numero2 = 0;
            float numero3 = 0;
            float mayor = 0;

            Console.WriteLine("A continuación podrá ingresar 3 números y se dirá cual es el mayor");

            Console.WriteLine("Ingrese el primero: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo: ");
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer: ");
            numero3 = float.Parse(Console.ReadLine());

            mayor = numero1 > numero2 
                ? 
                (numero1>numero3 ? numero1:numero3)
                :
                (numero2>numero3 ? numero2:numero3);

            Console.WriteLine("El numero mayor es el: " + mayor);
        }
    }
}
