using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDLL_1
{
    public class OrdenaList
    {
        private string val1 = "val1";
        public string val2 = "val2";

        public List<int> ordenarDescendente(List<int> listaNumeros)
        {
            List<int> ordenados = listaNumeros;
            ordenados.Sort((a, b) => b.CompareTo(a));
            return ordenados;
        }

        public List<int> ordenaAscendente(List<int> listaNumeros)
        {
            List<int> ordenados = listaNumeros;
            ordenados.Sort((a, b) => a.CompareTo(b));
            return ordenados;
        }

        private bool metodoPrivado()
        {
            return true;
        }

        public string regresaSaludo(string nombre)
        {
            return "Hola " + nombre;
        }
    }
}
