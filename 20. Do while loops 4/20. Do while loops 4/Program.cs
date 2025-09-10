using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Do_while_loops_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:
            //El número de partidos perdidos
            //El número de partidos empatados
            //El número de partidos ganados
            //El porcentaje de partidos perdidos
            //El porcentaje de partidos empatados
            //El porcentaje de partidos ganados

            int partidosPerdidos = 0;
            int partidosGanados = 0;
            int partidosEmpatados = 0;
            char diferenciadorPartidos = ' ';

            int contadorPartidos = 0;

            float porcentajePartidos;

            do
            {
                contadorPartidos++;

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Si este partido #" + contadorPartidos + " Se ganó, digita 'G'. Si perdió digita 'P' y se fúe un empate digita 'E': ");
                diferenciadorPartidos = char.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------");

                switch (diferenciadorPartidos)
                {
                    case 'G':
                        partidosGanados++;
                        break;

                    case 'P':
                        partidosPerdidos++;
                        break;

                    case 'E':
                        partidosEmpatados++;
                        break;
                    default:
                        Console.WriteLine("Digita una létra válida. Esta debe estar en mayúscula como se muestran. Vuelve a digitar el resultado de este partido.");
                        contadorPartidos--;
                        break;
                }
            } while (contadorPartidos < 30);

            
            Console.WriteLine("La cantidad de partidos ganados fueron: " + partidosGanados);
            Console.WriteLine("La cantidad de partidos empatados fueron: " + partidosEmpatados);
            Console.WriteLine("La cantidad de partidos perdidos fueron: " + partidosPerdidos);

            Console.WriteLine("");

            porcentajePartidos = (partidosGanados * 100) / 30;
            Console.WriteLine("El porcentaje de partidos ganados de 30 es: " + porcentajePartidos + "%");
            porcentajePartidos = (partidosEmpatados * 100) / 30;
            Console.WriteLine("El porcentaje de partidos empatados de 30 es: " + porcentajePartidos + "%");
            porcentajePartidos = (partidosPerdidos * 100) / 30;
            Console.WriteLine("El porcentaje de partidos perdidos de 30 es: " + porcentajePartidos + "%");
            
        }
    }
}
