using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                    //  --OPERADORES--

            // Cambio de signo en operadores numericos

            int numero1 = 90;
            int numeroMath1 = -numero1;
            int numeroMath2 = +numeroMath1;
            int numeroMath3 = -numeroMath2;

            Console.WriteLine(numero1 + " // " + numeroMath1 + " // " + numeroMath2 + " // " + numeroMath3);

            //-Operadores aritmétricos-
            Console.WriteLine("---------------------------------------");

            int numeroMath4 = 20 + 60;//suma
            Console.WriteLine(numeroMath4);
            int numeroMath5 = 686868 - 24564;//resta
            Console.WriteLine(numeroMath5);
            int numeroMath6 = 565 * 94;
            Console.WriteLine(numeroMath6);
            double numeroMath7 = 45439d / 3274d;//precision
            Console.WriteLine(numeroMath7);
            float numeroMath8 = (float) 123439 / 3864;
            Console.WriteLine(numeroMath8);
            decimal numeroMath9 = (decimal)564757 / 1234567;//super precision
            Console.WriteLine(numeroMath9);
            decimal numeroMath10 = 7658576865m / 6464646m;
            Console.WriteLine(numeroMath10);

            //-Operadores de incremento y decremento-
            Console.WriteLine("---------------------------------------");

            int numeroMath11 = ++numeroMath4;//incremento
            Console.WriteLine(numeroMath11);

            int numeroMath12 = --numero1;//decremento
            Console.WriteLine(numeroMath12);

            /*
            --numeroMath4;
            Console.Write(numeroMath4);

            --numero1;
            Console.WriteLine(numero1);
            */

            numeroMath1 += 125; //asignación positiva
            Console.WriteLine(numeroMath1);

            numeroMath2 -= 225; //asignación negativa
            Console.WriteLine(numeroMath2);

            numeroMath3 *= 100; //asignacion multiplicativa
            Console.WriteLine(numeroMath3);

            numeroMath4 /= 2; //asignacion fraccionaria
            Console.WriteLine(numeroMath4);

            //orden de evaluación de operadores numericos
            Console.WriteLine("---------------------------------------");

            float numeroMath13 = 17f * 7695f / 1.5f;
            Console.WriteLine(numeroMath13);

            float numeroMath14 = 7695f / 1.5f * 17f;
            Console.WriteLine(numeroMath14);

            float numeroMath15 =(17f * 7695f) / 1.5f;
            Console.WriteLine(numeroMath15);

            float numeroMath16 = 17f + 7695f * 1.5f;
            Console.WriteLine(numeroMath16);

            float numeroMath17 = 176f + 3332f * (575f - 3f);
            Console.WriteLine(numeroMath17);

            //operadores lógicos
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("TABLA DE VERDAD: CONJUNCIÓN");
            Console.WriteLine($"V && V ={true && true}");
            Console.WriteLine($"V && F ={true && false}");
            Console.WriteLine($"F && V ={false && true}");
            Console.WriteLine($"F && F ={false && false}");

            Console.WriteLine("~~~~~~~~~");

            Console.WriteLine("TABLA DE VERDAD: DISYUNCION");
            Console.WriteLine($"V || V ={true || true}");
            Console.WriteLine($"V || F ={true || false}");
            Console.WriteLine($"F || V ={false || true}");
            Console.WriteLine($"F || F ={false || false}");

            Console.WriteLine("~~~~~~~~~");

            bool expresion1 = true;
            bool expresion2 = false;
            bool expresion3 = expresion1 && expresion2;
            bool expresion4 = !expresion2;
            bool expresion5 = !expresion3 || expresion4;
            Console.WriteLine($"expresion1 = {expresion1} | expresion2 = {expresion2} | expresion3 = {expresion3} | expresion4 = {expresion4} | expresion5 ={expresion5} ");

        }
    }
}
