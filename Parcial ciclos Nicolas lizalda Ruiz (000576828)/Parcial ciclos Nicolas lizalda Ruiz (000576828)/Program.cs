using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_ciclos_Nicolas_lizalda_Ruiz__000576828_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float nota1Estudiante = 0;
            float nota2Estudiante = 0;
            float nota3Estudiante = 0;

            float promedioNotasEstudiante = 0;

            int contadorEstudiantes = 1;

            do
            {
                //Primera nota

                Console.WriteLine($"Estudiante #{contadorEstudiantes}, ingresa la primera nota de tu primer examen en un rango de 0.0 a 5.0 y ten en cuenta que debes poner el decimal solamente con COMAS: ");
                nota1Estudiante = float.Parse(Console.ReadLine());

                if (nota1Estudiante < 0.0f || nota1Estudiante > 5.0f)
                {
                    do
                    {
                        Console.WriteLine("Digita una nota en el rango de 0.0 a 5.0. Vuelve a intentar digitar la nota de segundo examen");
                        nota1Estudiante = float.Parse(Console.ReadLine());

                    } while (nota1Estudiante < 0.0f || nota1Estudiante > 5.0f);
                }

                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" ");
                //Segunda nota

                Console.WriteLine("Ahora ingresa la segunda nota de tu segundo examen y ten en cuenta que debes poner el decimal de la nota solamente con COMAS");
                nota2Estudiante = float.Parse(Console.ReadLine());

                if (nota2Estudiante < 0.0f || nota2Estudiante > 5.0f)
                {
                    do
                    {
                        Console.WriteLine("Digita una nota en el rango de 0.0 a 5.0. Vuelve a intentar digitar la nota de segundo examen y ten en cuenta que debes poner el decimal de la nota solamente con COMAS");
                        nota1Estudiante = float.Parse(Console.ReadLine());

                    } while (nota1Estudiante < 0.0f || nota1Estudiante > 5.0f);
                }
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" ");
                //Tercera nota

                Console.WriteLine("Ahora ingresa la tercera nota de tu proyecto de investigación y ten en cuenta que debes poner el decimal de la nota solamente con COMAS y ten en cuenta que debes poner el decimal de la nota solamente con COMAS");
                nota3Estudiante = float.Parse(Console.ReadLine());

                if (nota3Estudiante < 0.0f || nota3Estudiante > 5.0f)
                {
                    do
                    {
                        Console.WriteLine("Digita una nota en el rango de 0.0 a 5.0. Vuelve a intentar digitar la nota del tercer examen y ten en cuenta que debes poner el decimal de la nota solamente con COMAS");
                        nota1Estudiante = float.Parse(Console.ReadLine());

                    } while (nota3Estudiante < 0.0f || nota3Estudiante > 5.0f);
                }

                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" ");
                //promedio de notas
                promedioNotasEstudiante = (nota1Estudiante + nota2Estudiante + nota3Estudiante) / 3;


                if (promedioNotasEstudiante < 3.5)
                {
                    Console.WriteLine($"El estudiante #{contadorEstudiantes} no logro aprobar ética. El promedio mínimo requerido es de 3.5 y se obtuvo un promedio de {promedioNotasEstudiante}");
                }
                else
                {
                    Console.WriteLine($"El estudiante #{contadorEstudiantes} logro aprobar ética. El promedio mínimo requerido es de 3.5 y se obtuvo un promedio de {promedioNotasEstudiante}");
                }

                contadorEstudiantes++;
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" ");

            } while (contadorEstudiantes <= 25);


            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Ha finalizado el programa");
        }
    }
}
