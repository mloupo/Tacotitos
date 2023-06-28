using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero%2==0 select numero;

            foreach(int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }


            ControlEmpresasEmpleados ce= new ControlEmpresasEmpleados();
            ce.getProjectManager();

            ce.getEmpleadosOrdenados();
            string entrada = Console.ReadLine();

            try 
            {
                int entradaId = Convert.ToInt32(entrada);
                ce.getEmpleadosEmpresa(entradaId);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Has introducido un Id erroneo Ameoooo", ex);
            }

            Console.ReadLine();
        }
    }
}
