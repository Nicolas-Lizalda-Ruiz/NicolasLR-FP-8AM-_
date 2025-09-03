using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.while_loops_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes.

            float dineroAhorrado = 0;
            int contadorDeMes = 1;
            float acumuladorDeAhorros = 0;

            float enero = 0;
            float febrero = 0;
            float marzo = 0;
            float abril = 0;
            float mayo = 0;
            float julio = 0;
            float junio = 0;
            float agosto = 0;
            float septiembre = 0;
            float octubre = 0;
            float noviembre = 0;
            float diciembre = 0;

            /*
            Console.WriteLine("Usuario, ingresa lo que llevas ahorrado de los mese del año. Esto lo realizaras en orden, de enero a diciembre. El mes en el que estás estará en el que está despues de el último que tiene un valor ingresado en la tabla mostrada en cada ingreso");

            while (contadorDeMes <= 12)
            {
                Console.WriteLine("Ingresa lo que ahorraras este mes: ");
                dineroAhorrado = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------");

                if (contadorDeMes == 1)
                {
                    enero = dineroAhorrado;
                }
                else if (contadorDeMes == 2)
                {
                    febrero = dineroAhorrado;
                }
                else if (contadorDeMes == 3)
                {
                    marzo = dineroAhorrado;
                }
                else if (contadorDeMes == 4)
                {
                    abril = dineroAhorrado;
                }
                else if (contadorDeMes == 5)
                {
                    mayo = dineroAhorrado;
                }
                else if (contadorDeMes == 6)
                {
                    junio = dineroAhorrado;
                }
                else if (contadorDeMes == 7)
                {
                    julio = dineroAhorrado;
                }
                else if (contadorDeMes == 8)
                {
                    agosto = dineroAhorrado;
                }
                else if (contadorDeMes == 9)
                {
                    septiembre = dineroAhorrado;
                }
                else if (contadorDeMes == 10)
                {
                    octubre = dineroAhorrado;
                }
                else if (contadorDeMes == 11)
                {
                    noviembre = dineroAhorrado;
                }
                else if (contadorDeMes == 12)
                {
                    diciembre = dineroAhorrado;
                }

                    contadorDeMes++;
                acumuladorDeAhorros += dineroAhorrado;

                Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                Console.WriteLine("Lo que llevas ahorrado desde julio es: " + julio);
                Console.WriteLine("Lo que llevas ahorrado desde agosto es: " + agosto);
                Console.WriteLine("Lo que llevas ahorrado desde septiembre es: " + septiembre);
                Console.WriteLine("Lo que llevas ahorrado desde octubre es: " + octubre);
                Console.WriteLine("Lo que llevas ahorrado desde noviembre es: " + noviembre);
                Console.WriteLine("Lo que llevas ahorrado desde diciembre es: " + diciembre);
                Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                Console.WriteLine("--------------------------------------");

            }

            Console.WriteLine("Ha finalizado el programa");
            */

            Console.WriteLine("Usuario, ingresa el dinero que llevas en cada mes. Puedes referirte a la tabla para ver en que mes estás (sería el que esta despues del que tiene el último valor ingresado)");
            Console.WriteLine("--------------------------------------");

            while (contadorDeMes <= 12)
            {
                Console.WriteLine("Ingresa lo que ahorraras este mes: ");
                dineroAhorrado = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------");

                acumuladorDeAhorros += dineroAhorrado;

                switch (contadorDeMes)
                {
                    case 1:
                        enero = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero );
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 2:
                        febrero = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 3:
                        marzo = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 4:
                        abril = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 5:
                        mayo = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 6:
                        junio = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 7:
                        julio = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                        Console.WriteLine("Lo que llevas ahorrado desde julio es: " + julio);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 8:
                        agosto = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                        Console.WriteLine("Lo que llevas ahorrado desde julio es: " + julio);
                        Console.WriteLine("Lo que llevas ahorrado desde agosto es: " + agosto);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 9:
                        septiembre = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                        Console.WriteLine("Lo que llevas ahorrado desde julio es: " + julio);
                        Console.WriteLine("Lo que llevas ahorrado desde agosto es: " + agosto);
                        Console.WriteLine("Lo que llevas ahorrado desde septiembre es: " + septiembre);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 10:
                        octubre = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                        Console.WriteLine("Lo que llevas ahorrado desde julio es: " + julio);
                        Console.WriteLine("Lo que llevas ahorrado desde agosto es: " + agosto);
                        Console.WriteLine("Lo que llevas ahorrado desde septiembre es: " + septiembre);
                        Console.WriteLine("Lo que llevas ahorrado desde octubre es: " + octubre);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                    case 11:
                        noviembre = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                        Console.WriteLine("Lo que llevas ahorrado desde julio es: " + julio);
                        Console.WriteLine("Lo que llevas ahorrado desde agosto es: " + agosto);
                        Console.WriteLine("Lo que llevas ahorrado desde septiembre es: " + septiembre);
                        Console.WriteLine("Lo que llevas ahorrado desde octubre es: " + octubre);
                        Console.WriteLine("Lo que llevas ahorrado desde noviembre es: " + noviembre);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;

                        case 12:
                        diciembre = dineroAhorrado;
                        Console.WriteLine("Lo que llevas ahorrado desde enero es: " + enero);
                        Console.WriteLine("Lo que llevas ahorrado desde febrero es: " + febrero);
                        Console.WriteLine("Lo que llevas ahorrado desde marzo es: " + marzo);
                        Console.WriteLine("Lo que llevas ahorrado desde abril es: " + abril);
                        Console.WriteLine("Lo que llevas ahorrado desde mayo es: " + mayo);
                        Console.WriteLine("Lo que llevas ahorrado desde junio es: " + junio);
                        Console.WriteLine("Lo que llevas ahorrado desde julio es: " + julio);
                        Console.WriteLine("Lo que llevas ahorrado desde agosto es: " + agosto);
                        Console.WriteLine("Lo que llevas ahorrado desde septiembre es: " + septiembre);
                        Console.WriteLine("Lo que llevas ahorrado desde octubre es: " + octubre);
                        Console.WriteLine("Lo que llevas ahorrado desde noviembre es: " + noviembre);
                        Console.WriteLine("Lo que llevas ahorrado desde diciembre es: " + diciembre);
                        Console.WriteLine("Llevas en total ahorrando: " + acumuladorDeAhorros);
                        Console.WriteLine("--------------------------------------");
                        break;
                }

                contadorDeMes++;
            }

        }
    }
}
