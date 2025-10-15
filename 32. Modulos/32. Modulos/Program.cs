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
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            char eleccion = ' ';

            Console.WriteLine("Elige una de las siguientes tipo de operaciones con la letra indicada para comenzar a realizar operaciones de ese tipo: ");
            Console.WriteLine("Suma: '+'");
            Console.WriteLine("Resta: '-'");
            Console.WriteLine("Multiplicacion: '*'");
            Console.WriteLine("Divison: '/'");
            Console.WriteLine("Para finalizar el programa, digita cualquier otra cosa que no sea lo anterior");
            Console.Write("Elige: ");
            eleccion = char.Parse(Console.ReadLine());

            RealizarOperaciones(eleccion);
        }

        static void RealizarOperaciones(char eleccion)
        {
            float numeroDigitado = 0;
            float numeroExistente = 0;
            bool terminar = false;
            do
            {
                switch (eleccion)
                {
                    case '+':
                        eleccion = Suma(numeroDigitado, numeroExistente, eleccion);
                        break;

                    case '-':
                        eleccion = Resta(numeroDigitado, numeroExistente, eleccion);
                        break;

                    case '*':
                        eleccion = Multiplicacion(numeroDigitado, numeroExistente, eleccion);
                        break;

                    case '/':
                        eleccion = Division(numeroDigitado, numeroExistente, eleccion);
                        break;

                    default:
                        terminar = true;
                        break;
                }
            } while (terminar == false);
            Console.Clear();
            Console.WriteLine("||--------------Programa finalizado--------------||");
        }


        static char Suma(float numeroDigitado, float numeroExistente, char eleccion)
        {
            Console.Clear();
            int contador = 0;
            char cambiar = ' ';
            do
            {
                Console.Write($"Ingresa un numero para sumar a {numeroExistente}: +");
                numeroDigitado = float.Parse(Console.ReadLine());

                Console.WriteLine();

                numeroExistente += numeroDigitado;
                Console.WriteLine($"{Math.Abs(numeroExistente - numeroDigitado)} + {numeroDigitado} = {numeroExistente}");
                contador++;

                Console.WriteLine();

                if (contador > 1)
                {
                    Console.WriteLine($"Puedes seguir sumando a este mismo numero");
                    Console.Write("Quieres cambiar de operacion? 'S' es si | 'N' es no: ");
                    cambiar = char.Parse(Console.ReadLine());

                    if (cambiar == 'S')
                    {
                        eleccion = Cambiar(eleccion);
                    }
                    else if (cambiar == 'N')
                    {
                        Console.Clear();
                    }
                }
            } while (eleccion == '+');
            return eleccion;
        }

        static char Resta(float numeroDigitado, float numeroExistente, char eleccion)
        {
            Console.Clear();
            char cambiar = ' ';
            do
            {
                Console.Write($"Ingresa un primer numero que será restado por otro: ");
                numeroDigitado = float.Parse(Console.ReadLine());

                Console.Write($"Ingresa un segundo numero que restará el anterior: -");
                numeroExistente = float.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine($"{numeroDigitado} - {numeroExistente} = {numeroDigitado - numeroExistente}");

                Console.WriteLine();

                Console.Write("Quieres cambiar de operacion? 'S' es si | 'N' es no: ");
                cambiar = char.Parse(Console.ReadLine());

                if (cambiar == 'S')
                {
                    eleccion = Cambiar(eleccion);
                    Console.WriteLine(eleccion);
                }
                else if (cambiar == 'N')
                {
                    Console.Clear();
                }
            } while (eleccion == '-');
            return eleccion;
        }

        static char Multiplicacion(float numeroDigitado, float numeroExistente, char eleccion)
        {
            Console.Clear();
            int contador = 0;
            char cambiar = ' ';
            do
            {
                if (contador == 0)
                {
                    Console.Write($"Ingresa un primer numero que será multiplicado por otro: ");
                    numeroDigitado = float.Parse(Console.ReadLine());

                    Console.Write($"Ingresa un segundo numero que multiplicará el anterior: *");
                    numeroExistente = float.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Estas multiplicando a {numeroExistente}");

                    Console.Write($"Ingresa un segundo numero que multiplicará el anterior: *");
                    numeroDigitado = float.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                numeroExistente *= numeroDigitado;
                Console.WriteLine($"{numeroDigitado} * {numeroExistente / numeroDigitado} = {numeroExistente}");
                contador++;

                Console.WriteLine();

                if (contador > 1)
                {
                    Console.WriteLine($"Puedes seguir multiplicando a este mismo numero");
                    Console.Write("Quieres cambiar de operacion? 'S' es si | 'N' es no: ");
                    cambiar = char.Parse(Console.ReadLine());

                    if (cambiar == 'S')
                    {
                        eleccion = Cambiar(eleccion);
                    }
                    else if (cambiar == 'N')
                    {
                        Console.Clear();
                    }
                }
            } while (eleccion == '*');
            return eleccion;
        }

        static char Division(float numeroDigitado, float numeroExistente, char eleccion)
        {
            Console.Clear();
            int contador = 0;
            char cambiar = ' ';
            do
            {
                Console.Write($"Ingresa un primer numero que será dividido por otro: ");
                numeroDigitado = float.Parse(Console.ReadLine());

                Console.Write($"Ingresa un segundo numero que dividirá el anterior: *");
                numeroExistente = float.Parse(Console.ReadLine());

                Console.WriteLine();

                numeroDigitado /= numeroExistente;
                Console.WriteLine($"{numeroDigitado*numeroExistente} / {numeroExistente} = {numeroDigitado}");
                contador++;

                Console.WriteLine();

                    Console.WriteLine($"Puedes seguir multiplicando a este mismo numero");
                    Console.Write("Quieres cambiar de operacion? 'S' es si | 'N' es no: ");
                    cambiar = char.Parse(Console.ReadLine());

                    if (cambiar == 'S')
                    {
                        eleccion = Cambiar(eleccion);
                    }
                    else if (cambiar == 'N')
                    {
                        Console.Clear();
                    }
            } while (eleccion == '/');
            return eleccion;
        }

        static char Cambiar(char eleccion)
        {
            Console.Clear();
            Console.WriteLine("Puedes cambiar a resta digitando '-'");
            Console.WriteLine("Puedes cambiar a Multiplicacion digitando '*'");
            Console.WriteLine("Puedes cambiar a division digitando '/'");
            Console.WriteLine("Puedes cambiar a suma digitando '+'");
            Console.WriteLine("Para quedarte en tu operacion, digita el mismo tipo de signo del tipo de operacion");
            Console.WriteLine("Puedes finalizar el programa digitando cualquier cosa que no sea lo anterior");
            Console.Write("Elige: ");
            eleccion = char.Parse(Console.ReadLine());
            return eleccion;
        }
    }
}
