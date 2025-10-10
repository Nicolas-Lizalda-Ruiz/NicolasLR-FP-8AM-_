using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_3_Arreglos_NicolasLR000576828
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matrizMaterias = new float[10,4];

            string[] tipoDeColumna = new string[5];
            tipoDeColumna[0] = "Estudiante";
            tipoDeColumna[1] = "Matematicas";
            tipoDeColumna[2] = "Fisica";
            tipoDeColumna[3] = "Ingles";
            tipoDeColumna[4] = "Sociales";

            float promedioDeTodo = 0.0f;
            float[] vectorEstudiante9 = new float[4];
            float promedioEstudiante9 = 0.0f;
            float[] vectorPromedioMaterias = new float[4];

            Console.WriteLine("Saludos estudiantes. Porfavor hagan una fila de 10 personas. Se les va a pedir a continuacion su nota total en matemáticas, física, ingles y sociales. Ya cuando ingresen sus 4 notas dejan al siguiente estudiante hasta que ya los 10 hayan ingresado sus notas. Al final se les mostrará el promedio de todas las notas de los 10 estudiantes, el promedio del estudiante 9 y se mostrará un promedio de todas las notas de el tipo de materia");
            Console.WriteLine();

            for (int i = 0; i < matrizMaterias.GetLength(0); i++)
            {
                for (int j = 0; j < matrizMaterias.GetLength(1); j++)
                {
                    Console.Write($"Estudiante {i + 1}, Ingresa tus calificacion en {tipoDeColumna[j + 1]}: ");
                    matrizMaterias[i,j] = float.Parse(Console.ReadLine());

                    while(matrizMaterias[i, j] < 0.0f || matrizMaterias[i, j] > 5.0f)
                    {
                        Console.Write("Porfavor ingresa uan nota en el rango de 0.0 a 5.0: ");
                        matrizMaterias[i, j] = float.Parse(Console.ReadLine());
                    }

                    promedioDeTodo += (matrizMaterias[i, j] / matrizMaterias.Length);
                    
                    if (i == 8)
                        vectorEstudiante9[j] += (matrizMaterias[8, j]);
    
                    vectorPromedioMaterias[j] += (matrizMaterias[i,j] / matrizMaterias.GetLength(0));
                }
            }

            for (int i = 0; i < vectorEstudiante9.Length; i++)
            {
                promedioEstudiante9 += (vectorEstudiante9[i] / 4);
            }

            Console.WriteLine();

            for (int i = 0; i < tipoDeColumna.Length; i++)
            {
                Console.Write($"|{tipoDeColumna[i]}|");
            }

            Console.WriteLine();

            for (int i = 0; i < matrizMaterias.GetLength(0); i++)
            {
                Console.Write($"Estudiante {i + 1}: ");
                for (int j = 0; j < matrizMaterias.GetLength(1); j++)
                {
                    Console.Write($"|   {matrizMaterias[i,j]}   |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine($"El promedio de todas las notas es: {promedioDeTodo}");
            Console.WriteLine($"El promedio del estudiante 9 es: {promedioEstudiante9}");
            Console.WriteLine($"El promedio en Matemáticas es: {vectorPromedioMaterias[0]}");
            Console.WriteLine($"El promedio en Física es: {vectorPromedioMaterias[1]}");
            Console.WriteLine($"El promedio en Ingles es: {vectorPromedioMaterias[2]}");
            Console.WriteLine($"El promedio en Sociales es: {vectorPromedioMaterias[3]}");
        }
    }
}
