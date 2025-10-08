using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _25.Taller_de_vectores_unidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita llenar un vector[15] con números enteros, y encuentre y muestre el valor máximo y mínimo de los números ingresados.

            /*
            float[] numeroIngresado = new float[15];
            float numeroIngresadoMayor = 0;
            float numeroIngresadoMenor = 0;

            Console.WriteLine("Usuario, se te pediran 15 números. De estos se encontrarán el mayor y el menor.");

            for (int i = 0; i < numeroIngresado.Length; i++) 
            {
                Console.WriteLine($"Usuario, ingresa un numero hasta 15, te quedan {15 - i}. Estas en la posición {i}");
                numeroIngresado[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresaste " + numeroIngresado[i]);

                Console.WriteLine("-----------------------------------");

                if (i == 0) 
                {
                    numeroIngresadoMayor = numeroIngresado[i];
                    numeroIngresadoMenor = numeroIngresado[i];
                }
                else
                {
                    if (numeroIngresado[i] > numeroIngresadoMayor)
                    {
                        numeroIngresadoMayor = numeroIngresado[i];
                    }
                    else if (numeroIngresado[i] < numeroIngresadoMenor)
                    {
                        numeroIngresadoMenor = numeroIngresado[i];
                    }
                }
            }
            Console.Clear();

            for (int i = 0; i< numeroIngresado.Length; i++)
            {
                Console.WriteLine($"El numero #{i+1} ingresado fué: {numeroIngresado[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Console.WriteLine($"El numero menor de todos es el {numeroIngresadoMenor} y el numero mayor de todos es el {numeroIngresadoMayor}");
            */

            // ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

            //Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta orden de los elementos del vector. Se deben mostrar lo dos vectores.

            /*
            char[] caracteresIngresadosPorElUsuario = new char[6];
            char[] caracteresIngresadosPorElUsuarioAlReves = new char[6];

            Console.WriteLine("Hola usuario, ingresa 6 letras en un orden y al final se te mostrarán con el orden invertido");

            Console.WriteLine();

            for (int i = 0; i < caracteresIngresadosPorElUsuario.Length; i++)
            {
                Console.WriteLine($"Usuario, ingresa la letra #{i + 1}. Te quedan por poner {6 - i}");
                caracteresIngresadosPorElUsuario[i] = char.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ingresaste el " + caracteresIngresadosPorElUsuario[i]);

                Console.WriteLine("-----------------------------------");
                Console.WriteLine();

                caracteresIngresadosPorElUsuarioAlReves[5 - i] = caracteresIngresadosPorElUsuario[i];
            }

            Console.Clear();

            Console.WriteLine($"Las letras ingresadas de manera normal serían: ");
            for (int i = 0; i < caracteresIngresadosPorElUsuario.Length; i++)
            {
                Console.Write(" | " + caracteresIngresadosPorElUsuario[i]);
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Console.WriteLine($"Las letras ingresadas al reves serían: ");
            for (int i = 0; i < caracteresIngresadosPorElUsuarioAlReves.Length; i++)
            {
                Console.Write(" | " + caracteresIngresadosPorElUsuarioAlReves[i]);
            }

            */

            // ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

            //

            int[] numerosAleatorios = new int[20];
            int numerosAdivinados = 0;
            int TerminarJuego = 0;
            bool ganador = false;
            Random Aleatorio = new Random();

            do
            {
                for (int i = 0; i < numerosAleatorios.Length; i++)
                {
                    numerosAleatorios[i] = Aleatorio.Next(0, 51);
                    Console.WriteLine(numerosAleatorios[i]);
                }

                Console.WriteLine("Bienvenido al juego de adivinar. Adivinarás un número de 0 a 50 y cada vez que no adivinas bien pierdes un punto. Ahora ingresa tu número:");
                numerosAdivinados = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (numerosAdivinados < 0 || numerosAdivinados > 50)
                {
                    do 
                    {
                        Console.WriteLine("Número inválido, por favor ingresa un número entre 0 y 50 para adivinar.");
                        numerosAdivinados = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    } while(numerosAdivinados < 0 || numerosAdivinados > 50);
                }

                for (int i = 0; i < numerosAleatorios.Length; i++)
                {
                    if (numerosAdivinados == numerosAleatorios[i])
                    {
                        ganador = true;
                        //int[] posiciones
                    }
                }

                if (ganador == true)
                {
                    for (int i = 0; i < numerosAleatorios.Length; i++)
                    {
                        if (numerosAdivinados == numerosAleatorios[i])
                        {
                            Console.WriteLine($"Has ganado. El numero que ingresaste esta/estaba en las posicion/posiciones: {i}");


                        }

                    }
                }
                

                if (ganador == false)
                {
                    Console.WriteLine("-1");
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                }

                Console.WriteLine("Si quieres volver a jugar ingresa el numero '1', cualquier otro reinicia el juego");
                Console.WriteLine();
                TerminarJuego = int.Parse(Console.ReadLine());

            } while(TerminarJuego != 1);

            Console.WriteLine("Ha terminado el juego");
        }
    }
}
