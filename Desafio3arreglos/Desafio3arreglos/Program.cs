using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3arreglos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool validacion = true;
            int opcion;
            List<string> lista = new List<string>(){};

            do
            {
                Console.Clear();
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1. Mostrar");
                Console.WriteLine("2. Agregar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion) {
                    case 1:

                        foreach (string elemento in lista)
                        {
                            Console.WriteLine(elemento);
                        }

                        break;

                    case 2:
                        Console.WriteLine("Escriba la tarea que desea agregar:");
                        string tareaPorAgregar = Console.ReadLine();
                        lista.Add(tareaPorAgregar);
                        break;


                        case 3:
                        Console.WriteLine("Escribe la tarea que deseas eliminar: ");
                        string tareaPorEliminar = Console.ReadLine();

                        lista.Remove(tareaPorEliminar);

                        break;

                    case 4: validacion = false; break;
                }
                Console.ReadKey(true);

            } while (validacion);
        }
    }
}
