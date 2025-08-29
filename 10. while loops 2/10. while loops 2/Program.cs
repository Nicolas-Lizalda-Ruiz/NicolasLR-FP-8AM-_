using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.while_loops_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int numeroFactorial = 0;
            int numeroMuestra = 2;
            int contadorFactorial = 1;
            int acumuladorFactorial = 1;

            Console.WriteLine("Usuario, digita un número. Este será calculado en su factorial, oséa, se multiplicara por cada número de 1 hasta la cantidad del número elegido entre sí");
            numeroFactorial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");

            while (contadorFactorial <= numeroFactorial)
            {
                acumuladorFactorial *= contadorFactorial;
                Console.WriteLine($"{acumuladorFactorial/contadorFactorial} * {contadorFactorial} = {(acumuladorFactorial/contadorFactorial) * contadorFactorial} ");
                contadorFactorial++;
            }

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("El número digitado con el proceso factorial sería: " + acumuladorFactorial);
        }
    }
}
