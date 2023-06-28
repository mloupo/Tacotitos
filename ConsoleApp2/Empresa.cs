using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLinq
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void DatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Name, Id);
        }
    }
}
