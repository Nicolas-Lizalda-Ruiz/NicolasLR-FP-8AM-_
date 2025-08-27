using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Taller_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.*/

            /*
            float numero1 = 0;
            float numero2 = 0;
            float numero3 = 0;

            Console.WriteLine("A continuación podrás ingresar 3 números. Si los 3 números son diferentes mostrará cual es el mayor y los ordenará de menor a mayor");

            Console.WriteLine("Ingresa el primer número: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número: ");
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer número: ");
            numero3 = float.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3)
            {
                if (numero1 > numero2)
                {
                    if (numero1 > numero3)
                    {
                        Console.WriteLine("El numero mayor es el: " + numero1);
                        Console.WriteLine
                            (numero2 > numero3 
                            ? 
                            $"Los números de menor a mayor serían: {numero3} | {numero2} | {numero1}"
                            :
                            $"Los números de menor a mayor serían: {numero2} | {numero3} | {numero1}" 
                            );
                    }

                    else
                    {
                        Console.WriteLine
                            (numero1 > numero2
                            ?
                            $"Los números de menor a mayor serían: {numero2} | {numero1} | {numero3}"
                            :
                            $"Los números de menor a mayor serían: {numero1} | {numero2} | {numero3}"
                            );
                    }
                }

                else
                {
                    if (numero2 > numero3)
                    {
                        Console.WriteLine
                            (numero3 > numero1
                            ?
                            $"Los números de menor a mayor serían: {numero1} | {numero3} | {numero2}"
                            :
                            $"Los números de menor a mayor serían: {numero3} | {numero1} | {numero2}"
                            );
                    }

                    else
                    {
                        Console.WriteLine
                            (numero2 > numero1
                            ?
                            $"Los números de menor a mayor serían: {numero1} | {numero2} | {numero3}"
                            :
                            $"Los números de menor a mayor serían: {numero2} | {numero1} | {numero3}"
                            );

                    }
                }
            }

            else
            {
                Console.WriteLine("Los 3 números son iguales, no se revisará cual es el mayor de todos.");
            }

            */

            // -    -   -   -   -   
            //El mismo ejercicio con switch

            //


        }
    }
}
