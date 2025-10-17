using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taller_3_de_modulos
{
    internal class Program
    {
        /* -------------------------------- 1 ---------------------------------
         //1. Desarrolla un programa que permita:
           //  Ingresar una palabra
           //  LLevar la palabra ingresada a un vector de caracteres
           //  Contar la cantidad de vocales y consonantes en la palabra proporcionada por el usuario.

        static void Main()
        {
            Console.WriteLine("Ingresa una palabra. Se contarana las vocales y consonantes");
            string palabraUsuario = Console.ReadLine();
            char[] vectorPalabra = new char[LongitudPalabra(palabraUsuario)];

            CrearVector(palabraUsuario, vectorPalabra);

            Console.Clear();
            mostrarVector(vectorPalabra);
            Console.WriteLine();
            Console.WriteLine(ContarVocalesYConsonantes(vectorPalabra));
        }

        static int LongitudPalabra(string palabraUsuario)
        {
            int longitudPalabra = 0;
            for (int i = 0; i < palabraUsuario.Length; i++)
            {
                longitudPalabra++;
            }
            return longitudPalabra;
        }

        static void CrearVector(string palabraUsuario, char[] vectorPalabra)
        {
            for (int i = 0; i < palabraUsuario.Length; i++)
            {
                vectorPalabra[i] = palabraUsuario[i];
            }
        }

        static void mostrarVector(char[] vectorPalabra)
        {
            for (int i = 0; i < vectorPalabra.Length; i++)
            {
                Console.Write($"| {vectorPalabra[i]} |");
            }
        }

        static string ContarVocalesYConsonantes(char[] vectorPalabra)
        {
            int vocales = 0;
            int consonantes = 0;
            for (int i = 0; i < vectorPalabra.Length; i++)
            {
                switch (vectorPalabra[i])
                {
                    case 'a':
                        vocales++;
                        break;

                    case 'A':
                        vocales++;
                        break;

                    case 'e':
                        vocales++;
                        break;

                    case 'E':
                        vocales++;
                        break;

                    case 'i':
                        vocales++;
                        break;

                    case 'I':
                        vocales++;
                        break;

                    case 'o':
                        vocales++;
                        break;

                    case 'O':
                        vocales++;
                        break;

                    case 'u':
                        vocales++;
                        break;

                    case 'U':
                        vocales++;
                        break;

                        default:
                        consonantes++;
                        break;
                }
            }
            return $"La cantidad de vocales son {vocales} y la cantidad de consonantes son {consonantes}";
        }
         -------------------------------- 1 ---------------------------------*/


        //2. Crear un programa que permita gestionar una lista de tareas:
        // Agregar tareas.
        // Eliminar tareas
        // Mostrar la lista de tareas.

        static void Main()
        {
            LogicaLista();
        }

        static void LogicaLista()
        {
            string[] listaTareas = new string[0];
            int opcion = 0;

            do
            {
                Console.WriteLine("Para agregar una tarea digita: '1'");
                Console.WriteLine("Para Borrar una tarea digita: '2'");
                Console.WriteLine("Para Mostrar la lista de tareas: '3'");
                Console.Write("Elige: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Clear();                    
                    listaTareas = AgregarTarea(listaTareas);
                    Console.Clear();

                }
                if (opcion == 2)
                {
                    if (listaTareas.Length == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("No hay tareas para eliminar. Agrega una tarea primero.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        listaTareas = BorrarTare(listaTareas);
                        Console.Clear();
                    }

                }
                if (opcion == 3)
                {
                    Console.Clear();
                    MostrarLista(listaTareas);
                }
            } while (true);
        }

        static string[] AgregarTarea(string[] listaTareas)
        {
                string[] nuevaTarea = new string[listaTareas.Length + 1];

                for (int i = 0; i < listaTareas.Length; i++)
                {
                    if (listaTareas[i] == null)
                    {
                        nuevaTarea[i] = " ";
                    }
                    else
                    {
                        nuevaTarea[i] = listaTareas[i];
                    }
                }

                Console.Write("Ingresa la tarea: ");
                nuevaTarea[nuevaTarea.Length - 1] = Console.ReadLine();

                listaTareas = nuevaTarea;

            return listaTareas;
        }

        static string[] BorrarTare(string[] listaDeTareas)
        {
            int posicionEliminar = 0;
            string[] listaActualizada = new string[listaDeTareas.Length - 1];
            MostrarLista(listaDeTareas);

            Console.Write("Ingresa la tarea que deseas eliminar digitando su número en la lista: ");
            posicionEliminar = int.Parse(Console.ReadLine());

            for (int i = 0; i < listaActualizada.Length; i++)
            {
                if (i != (posicionEliminar - 1))
                {
                    listaActualizada[i] = listaDeTareas[i + 1];
                }
                else
                {
                    listaActualizada[posicionEliminar - 1] = listaDeTareas[i + 1];
                }
            }
            listaDeTareas = listaActualizada;

            return listaDeTareas;
        }

        static void MostrarLista(string[] listaTareas)
        {
            Console.Clear();
            Console.WriteLine("Lista de tareas: ");
            Console.WriteLine();

            for (int i = 0; i < listaTareas.Length; i++)
            {
                Console.WriteLine($"{i+1}. {listaTareas[i]}");
                Console.WriteLine();
            }
        }
    }
}
