using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLinq
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cargo { get; set;}
        public double Salario { get; set;}   

        public int EmpresaId { get; set; }

        public void DatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, Cargo {2} con Salario U$S {3} y pertenece a la empresa {4}",
                    Name, Id, Cargo, Salario, EmpresaId);
        }


    }
}
