using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Modulos
{
    internal class Program
    {
        //Algoritmo que muestre un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado. Si es suma o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que el desee ingresar. Si es división o resta solo dejar realizar la operación con dos números. (ademas el profe adjuntó una imagen guía)

        static void Main()
        {
            int contadorSumas = 0;
            int contadorFinalizador = 0;
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            char eleccion = ' ';
            char finalizador = ' ';

            Console.WriteLine("Elige una de las siguientes tipo de operaciones con la letra indicada para comenzar a realizar operaciones de ese tipo: ");
            Console.WriteLine("Suma: '+'");
            Console.WriteLine("Resta: '-'");
            Console.WriteLine("Multiplicacion: '*'");
            Console.WriteLine("Divison: '/'");
            eleccion = char.Parse(Console.ReadLine());

            RealizarOperaciones(eleccion);
        }

        static void RealizarOperaciones(char eleccion)
        {
            float numeroDigitado = 0;
            float numeroExistente = 0;

            switch (eleccion)
            {
                case '+':
                    LogicaCiclica(numeroDigitado, numeroExistente, eleccion);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Ha terminado el programa.");
                    break;
            }
        }

        static void LogicaCiclica(float numeroDigitado, float numeroExistente, char eleccion)
        {
            char finalizador = ' ';

            switch (eleccion)
            {
                case '+':
                    do
                    {
                        LeerNumero(numeroDigitado);
                        numeroExistente += Suma(numeroDigitado, numeroExistente);
                        Cambiar(eleccion);
                    } while (finalizador == '+');
                    break;
            }
        }

        static float LeerNumero(float numero)
        {
            Console.Write("Digita un numero: ");
            numero = float.Parse(Console.ReadLine());
            return numero;
        }

        static float Suma(float numero, float numeroExistente)
        {
            numeroExistente += numero; 
            return numeroExistente;
        }

        static void Cambiar(char eleccion)
        {
            Console.WriteLine("Deseas cambiar de operación?");
            Console.WriteLine("No = N");
            Console.WriteLine("Si = S");
            Console.WriteLine("Elige: ");
            eleccion = char.Parse(Console.ReadLine());

            if (eleccion == 'S')
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Puedes cambiar a resta digitando '-'");
                Console.WriteLine("Puedes cambiar a Multiplicacion digitando '*'");
                Console.WriteLine("Puedes cambiar a division digitando '/'");
                Console.WriteLine("Puedes quedar en suma digitando '+'");
                Console.WriteLine("Puedes finalizar el programa en suma digitando cualquier cosa que no sea lo anterior");
                eleccion = char.Parse(Console.ReadLine());
            }
            else if (eleccion == 'N')
            {
                Console.WriteLine("Los numeros estaban en");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Digita 'N' o 'S'");
                Console.WriteLine("Elige: ");
                eleccion = char.Parse(Console.ReadLine());
            }
        }
    }
}
