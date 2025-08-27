using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_condicionales_NicolasLizaldaRuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pizzaVegetariana = false;
            bool pizzaNormal = false;
            char desicionPizza = ' ';
            int elecciónIngrediente1 = 0;
            int elecciónIngrediente2 = 0;
            int elecciónIngrediente3 = 0;
            float precioBase = 0;
            float impuestoValorAgregado = 0;
            string nombreIngrediente1 = " ";
            string nombreIngrediente2 = " ";
            string nombreIngrediente3 = " ";

            Console.WriteLine("Bienvenido usuario, a continuación podrás elegir que tipo de pizza quieres y cuales serán sus ingredientes. Se te mostrarán la lista de ingredientes, de los cuales eliges 3 digitando su número como se muestra en dicha lista. Empieza elgiendo que tipo de pizza quieres copiando la letra exacta mostrada: ");

            Console.WriteLine(" ");

            Console.WriteLine("Vegetariana: 'V' ");
            Console.WriteLine("Normal: 'N' ");
            desicionPizza = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            switch (desicionPizza)
            {
                case 'V':
                    pizzaVegetariana= true;
                    Console.WriteLine("A continuación se te mostrarán 5 ingredientes de los cuales solo podrás elegir 3, no puedes repetir ingredientes. Empieza digitando el número del que quieres y le das a enter, despues el segundo que quieres con otro enter y cuando ya termines con el tercero dale a enter para el precio final (IVA incluído) con los ingredientes que elejiste.");

                    Console.WriteLine("................");

                    Console.WriteLine("Pimiento = 1");
                    Console.WriteLine("Tofu = 2");
                    Console.WriteLine("Champiñones = 3");
                    Console.WriteLine("Tomate = 4");
                    Console.WriteLine("Lechuga = 5");
                    elecciónIngrediente1 = Convert.ToInt32(Console.ReadLine());
                    elecciónIngrediente2 = Convert.ToInt32(Console.ReadLine());
                    elecciónIngrediente3 = Convert.ToInt32(Console.ReadLine());
                    if (elecciónIngrediente1 > 5 || elecciónIngrediente1 < 1 || elecciónIngrediente2 > 5 || elecciónIngrediente2 < 1 || elecciónIngrediente3 > 5 || elecciónIngrediente3 < 1)
                    {
                        Console.WriteLine("Pon un número de ingrediente válido");
                        pizzaVegetariana = false;
                    }
                    else if (elecciónIngrediente1 == elecciónIngrediente2 && elecciónIngrediente1 == elecciónIngrediente3)
                    {
                        Console.WriteLine("No repitas ingredientes");
                        pizzaVegetariana = false;
                    }
                    break;

                case 'N':
                    pizzaNormal= true;
                    Console.WriteLine("A continuación se te mostrarán 5 ingredientes de los cuales solo podrás elegir 2, no puedes repetir ingredientes. Empieza digitando el número del que quieres y le das a enter y cuando ya termines con el segundo dale a enter para el precio final (IVA incluído) con los ingredientes que elegiste.");

                    Console.WriteLine("................");

                    Console.WriteLine("Res = 1");
                    Console.WriteLine("Chorizo= 2");
                    Console.WriteLine("Pollo = 3");
                    Console.WriteLine("Tocineta = 4");
                    Console.WriteLine("Cerdo = 5");
                    elecciónIngrediente1 = Convert.ToInt32(Console.ReadLine());
                    elecciónIngrediente2 = Convert.ToInt32(Console.ReadLine());
                    if (elecciónIngrediente1 > 5 || elecciónIngrediente1 < 1 || elecciónIngrediente2 > 5 || elecciónIngrediente2 < 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Pon un número de ingrediente válido");
                        pizzaNormal= false;
                    }
                    else if (elecciónIngrediente1 == elecciónIngrediente2)
                    {
                        Console.WriteLine("No repitas ingredientes");
                        pizzaVegetariana = false;
                    }
                    break;

                default:
                    Console.WriteLine("No digites letras que no esten mostradas, ten en cuenta que debe estar en MAYÚSCULA la letra digitada");
                    break;
            }

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            if (pizzaVegetariana == true)
            {
                switch (elecciónIngrediente1)
                {
                    case 1:
                        nombreIngrediente1 = "Pimiento";
                        break;

                    case 2:
                        nombreIngrediente1 = "tofu";
                        break;

                    case 3:
                        nombreIngrediente1 = "Champiñones";
                        break;

                    case 4:
                        nombreIngrediente1 = "Tomate";
                        break;

                    case 5:
                        nombreIngrediente1 = "Lechuga";
                        break;
                }

                switch (elecciónIngrediente2)
                {
                    case 1:
                        nombreIngrediente2 = "Pimiento";
                        break;

                    case 2:
                        nombreIngrediente2 = "tofu";
                        break;

                    case 3:
                        nombreIngrediente2 = "Champiñones";
                        break;

                    case 4:
                        nombreIngrediente2 = "Tomate";
                        break;

                    case 5:
                        nombreIngrediente2 = "Lechuga";
                        break;
                }

                switch (elecciónIngrediente3)
                {
                    case 1:
                        nombreIngrediente3 = "Pimiento";
                        break;

                    case 2:
                        nombreIngrediente3 = "tofu";
                        break;

                    case 3:
                        nombreIngrediente3 = "Champiñones";
                        break;

                    case 4:
                        nombreIngrediente3 = "Tomate";
                        break;

                    case 5:
                        nombreIngrediente3 = "Lechuga";
                        break;
                }

                if ((elecciónIngrediente1 == 1 || elecciónIngrediente1 == 3 || elecciónIngrediente1 == 5) && (elecciónIngrediente2 == 1 || elecciónIngrediente2 == 3 || elecciónIngrediente2 == 5) && (elecciónIngrediente3 == 1 || elecciónIngrediente3 == 3 || elecciónIngrediente3 == 5))
                {
                    precioBase = 20000;
                    impuestoValorAgregado = 19;
                }
                else if ((elecciónIngrediente1 == 2 || elecciónIngrediente1 == 3 || elecciónIngrediente1 == 5) && (elecciónIngrediente2 == 2 || elecciónIngrediente2 == 3 || elecciónIngrediente2 == 5) && (elecciónIngrediente3 == 2 || elecciónIngrediente3 == 3 || elecciónIngrediente3 == 5))
                {
                    precioBase = 30000;
                    impuestoValorAgregado = 15;
                }
                else
                {
                    precioBase = 25000;
                    impuestoValorAgregado = 10;
                }

                Console.WriteLine("Has eleigo la pizza Vegetariana");
                Console.WriteLine($"El precio final de la pizza sería: {(precioBase * impuestoValorAgregado) / 100 + precioBase}");
                Console.WriteLine($"Con un precio base del: {precioBase} y con un impuesto del valor agreado del {impuestoValorAgregado}%");
                Console.WriteLine($"Este impuesto del valor agregado le suma {(precioBase * impuestoValorAgregado) / 100} al precio final");
                Console.WriteLine("Tu primer ingrediente fué: " + nombreIngrediente1);
                Console.WriteLine("Tu segundo ingrediente fué: " + nombreIngrediente2);
                Console.WriteLine("Tu tercer ingrediente fué: " + nombreIngrediente3);
            }
            else if (pizzaNormal == true)
            {
                switch (elecciónIngrediente1)
                {
                    case 1:
                        nombreIngrediente1 = "Res";
                        break;

                    case 2:
                        nombreIngrediente1 = "Chorizo";
                        break;

                    case 3:
                        nombreIngrediente1 = "Pollo";
                        break;

                    case 4:
                        nombreIngrediente1 = "Tocineta";
                        break;

                    case 5:
                        nombreIngrediente1 = "Cerdo";
                        break;
                }

                switch (elecciónIngrediente2)
                {
                    case 1:
                        nombreIngrediente2 = "Res";
                        break;

                    case 2:
                        nombreIngrediente2 = "Chorizo";
                        break;

                    case 3:
                        nombreIngrediente2 = "Pollo";
                        break;

                    case 4:
                        nombreIngrediente2 = "Tocineta";
                        break;

                    case 5:
                        nombreIngrediente2 = "Cerdo";
                        break;
                }

                switch (elecciónIngrediente3)
                {
                    case 1:
                        nombreIngrediente3 = "Res";
                        break;

                    case 2:
                        nombreIngrediente3 = "Chorizo";
                        break;

                    case 3:
                        nombreIngrediente3 = "Pollo";
                        break;

                    case 4:
                        nombreIngrediente3 = "Tocineta";
                        break;

                    case 5:
                        nombreIngrediente3 = "Cerdo";
                        break;
                }

                if ((elecciónIngrediente1 == 1 || elecciónIngrediente1 == 3) && (elecciónIngrediente2 == 1 || elecciónIngrediente2 == 3))
                {
                    precioBase = 10000;
                    impuestoValorAgregado = 19;
                }
                else if ((elecciónIngrediente1 == 1 || elecciónIngrediente1 == 4) && (elecciónIngrediente2 == 1 || elecciónIngrediente2 == 4))
                {
                    precioBase = 15000;
                    impuestoValorAgregado = 17;
                }
                else if ((elecciónIngrediente1 == 2 || elecciónIngrediente1 == 4) && (elecciónIngrediente2 == 2 || elecciónIngrediente2 == 4))
                {
                    precioBase = 25000;
                    impuestoValorAgregado = 9;
                }
                else
                {
                    precioBase = 22000;
                    impuestoValorAgregado = 10;
                }

                Console.WriteLine("Has elegido la pizza normal");
                Console.WriteLine($"El precio final de la pizza sería: {(precioBase * impuestoValorAgregado) / 100 + precioBase}");
                Console.WriteLine($"Con un precio base del: {precioBase} y con un impuesto del valor agreado del {impuestoValorAgregado}%");
                Console.WriteLine($"Este impuesto del valor agregado le suma {(precioBase * impuestoValorAgregado) / 100} al precio final");
                Console.WriteLine("Tu primer ingrediente fué: " + nombreIngrediente1);
                Console.WriteLine("Tu segundo ingrediente fué: " + nombreIngrediente2);
            }
            else
            {
                Console.WriteLine("Reinicia le programa para tu elección");
            }
        }
    }
}
