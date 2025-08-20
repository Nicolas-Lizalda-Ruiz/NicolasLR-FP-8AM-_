using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Condicional_múltiple_terciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de la compra: ");
            valorCompra = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el día de la semana | L:lunes | M:martes | X:miercoles | J:jueves | V:viernes | S:sábado | D:domingo");
            dia = Convert.ToChar(Console.ReadLine());

            switch(dia)
            {
                case 'L':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine("Hoy lunes, recibes un descuento del 10%: " + (valorCompra - descuento));
                    break;

                case 'M':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine("Hoy martes, recibes un descuento del 15%: " + (valorCompra - descuento));
                    break;

                case 'X':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine("Hoy miercoles, recibes un descuento del 10%: " + (valorCompra - descuento));
                    break;

                case 'J':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine("Hoy jueves, recibes un descuento del 15%: " + (valorCompra - descuento));
                    break;

                case 'V':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine("Hoy viernes, recibes un descuento del 20%: " + (valorCompra - descuento));
                    break;

                case 'S':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine("Hoy sábado, recibes un descuento del 20%: " + (valorCompra - descuento));
                    break;

                case 'D':
                    descuento = 0f;
                    Console.WriteLine("Hoy domingo no recibes descuento: " + (valorCompra - descuento));
                    break;

                default:
                    Console.WriteLine("Debes ingresar un día válido, pon el día en MAYÚSCULA, vuelva a iniciar el programa, porfavor.");
                    break;

                    

            }
            */

            //Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.

            /*
            float numero1 = 0;
            float numero2 = 0;
            float numeroFinal = 0;
            int opciónOperativa = 0;

            Console.WriteLine("Esto es una calculadora, Vas a elegir 2 números de los cuales vas a sumar, restar, dividir o multiplicar. Puedes elegir el primero y el segundo y por último su operación en orden de (numero uno | operación | numero dos). Ahora empieza eligiendo el primer número:");
            numero1 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número: ");
            numero2 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Eliga la operación | 1:Suma | 2:Resta | 3:Multiplicación | 4:Divison");
            opciónOperativa = Convert.ToInt32(Console.ReadLine());

            switch (opciónOperativa)
            {
                case 1:
                    numeroFinal = numero1 + numero2;
                    Console.WriteLine("Tu operación elegido es una suma: " + numeroFinal);
                    break;

                case 2:
                    numeroFinal = numero1 - numero2;
                    Console.WriteLine("Tu operación elegido es una resta: " + numeroFinal);
                    break;

                case 3:
                    numeroFinal = numero1 * numero2;
                    Console.WriteLine("Tu operación elegido es: " + numeroFinal);
                    break;

                case 4:
                    numeroFinal = numero1 / numero2;
                    Console.WriteLine("Tu operación elegido es: " + numeroFinal);
                    break;

                default:
                    Console.WriteLine("ingresa un número válido de los mostrados para la operación");
                    break;
            }
            */

            //  Diseñar un algoritmo que solicite al usuario un número del 1 al 12, correspondiente a un mes del año (1 para enero, 2 para febrero, etc.). El algoritmo debe mostrar en pantalla el nombre del mes seleccionado y la cantidad de días que contiene.

            /*
            int mesElegido = 0;

            Console.WriteLine("Eliga uno de los siguientes meses copiando su respectivo número para ver la cantidad de días que tiene: ");
            Console.WriteLine("Enero = 1");
            Console.WriteLine("febrero = 2");
            Console.WriteLine("Marzo = 3");
            Console.WriteLine("Abril = 4");
            Console.WriteLine("Mayo = 5");
            Console.WriteLine("Junio = 6");
            Console.WriteLine("Julio = 7");
            Console.WriteLine("Agosto = 8");
            Console.WriteLine("Septiembre = 9");
            Console.WriteLine("Octubre = 10");
            Console.WriteLine("Noviembre = 11");
            Console.WriteLine("Diciembre = 12");
            mesElegido = Convert.ToInt32(Console.ReadLine());

            switch (mesElegido)
            {
                case 1:
                    Console.WriteLine("Has elegido a Enero, el cual, tiene 31 días");
                    break;

                case 2:
                    Console.WriteLine("Has elegido a Febrero, el cual, tiene 28 días pero en años bisiestos tiene 29");
                    break;

                case 3:
                    Console.WriteLine("Has elegido a Marzo, el cual, tiene 30 días");
                    break;

                case 4:
                    Console.WriteLine("Has elegido a Abril, el cual, tiene 30 días");
                    break;

                case 5:
                    Console.WriteLine("Has elegido a Mayo, el cual, tiene 31 días");
                    break;

                case 6:
                    Console.WriteLine("Has elegido a Junio, el cual, tiene 30 días");
                    break;

                case 7:
                    Console.WriteLine("Has elegido a Julio, el cual, tiene 31 días pero en  años bisisesto tiene 30");
                    break;

                case 8:
                    Console.WriteLine("Has elegido a Agosto, el cual, tiene 31 días");
                    break;

                case 9:
                    Console.WriteLine("Has elegido a Septiembre, el cual, tiene 30 días");
                    break;

                case 10:
                    Console.WriteLine("Has elegido a Octubre, el cual, tiene 31 días");
                    break;

                case 11:
                    Console.WriteLine("Has elegido a Noviembre, el cual, tiene 30 días");
                    break;

                case 12:
                    Console.WriteLine("Has elegido a Diciembre, el cual, tiene 31 días");
                    break;

                default:
                    Console.WriteLine("Copia un número válido porfavor");
                    break;
            }
            */

            //.
        }
    }
}
