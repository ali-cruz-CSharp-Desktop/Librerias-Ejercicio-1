using LibreriaDLL_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocaLibreriaDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaDesordenada = new List<int>();
            listaDesordenada.Add(32);
            listaDesordenada.Add(1);
            listaDesordenada.Add(9);
            listaDesordenada.Add(25);

            Console.WriteLine("Lista desordenada\n");
            foreach (int element in listaDesordenada)
            {
                Console.WriteLine($"Elemento: {element.ToString()}");
            }

            OrdenaList ordenaL = new OrdenaList();
            ordenaL.ordenaAscendente(listaDesordenada);


            Console.WriteLine("\nLista ordenada ASC\n");
            foreach (int element in listaDesordenada)
            {
                Console.WriteLine($"Elemento: {element.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
