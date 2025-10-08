using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Programacion_modular_con_procedimientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            args = new string[5]; //boff O_o
            MostrarUnMensaje();
            MostrarOtroMensaje("If quizzes are quizzical, then what are tests...");
            MostrarOtroMensaje("What do you call an american bee? a USB :V");
            Console.WriteLine($"La edad calculada es: {UnaOperacionSupongo()}");
            Console.WriteLine($"Tengo una edad de: {UnaOperacionSupongo(2025,2007)}");
        }

        //Modulo 1 - Procedimiento sin parámetros T_T
        static void MostrarUnMensaje()
        {
            Console.WriteLine("Xd i-i");
            MostrarOtroMensaje("What do you call a funny group of cows? A laughing stock!!");
        }

        //Modulo 2 - Procedimeintco con parámetros p_p
        static void MostrarOtroMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Modulo 3 - Funciones q-q sin parametros
        static int UnaOperacionSupongo()
        {
            int añoDeNacimiento = 0;
            int añoActual = 2025;

            añoDeNacimiento = 2007;
            int edad = añoActual - añoDeNacimiento;
            return edad;
        }

        //Modulo 4 - Función con parámetros

        static int UnaOperacionSupongo(int añoActual, int añoDeNacimiento)
        {
            return añoActual - añoDeNacimiento;
        }
    }
}
