using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];

            CalculoCompras(numeros);

            Console.ReadKey(true);
        }

        public static void CalculoCompras(int[,] listaCompras)
        {
            int[] precioFinalClientes = new int[listaCompras.GetLength(0)];

            for (int i = 0; i < listaCompras.GetLength(0); i++)
            {
                for (int j = 0; j < listaCompras.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingresa el precio del cliente {i +1} No {j}: ");

                    listaCompras[i, j] = int.Parse(Console.ReadLine());
                    precioFinalClientes[i] += listaCompras[i, j];

                    
                }
            }

            for ( int i = 0; i < precioFinalClientes.Length; i++)
            {
                if (precioFinalClientes[i] <= 99)
                {
                    Console.WriteLine($"cliente {i+1} no tiene desucento");
                }
                else if (precioFinalClientes[i] >= 100 && precioFinalClientes[i] <= 1000) 
                {
                    Console.WriteLine($" cliente {i + 1} si tiene un descuento del 10% que tendra un precio final de: { precioFinalClientes[i] - (precioFinalClientes[i] * 0.1) }");
                }

                else if (precioFinalClientes[i] >=1000)
                {
                    Console.WriteLine($" cliente {i+1} si aplica el descuento del 20% que tendra un precio final de: { precioFinalClientes[i] - (precioFinalClientes[i] * 0.2) }");

                }
                        }
                
        }
    }
}
