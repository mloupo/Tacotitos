using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLinq
{
    public class ControlEmpresasEmpleados
    {
        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id= 1, Name= "Google"});
            listaEmpresas.Add(new Empresa { Id= 2, Name= "Pildoras Informaticas"});
            listaEmpresas.Add(new Empresa { Id= 3, Name= "The Kaizen Arg Consulting"});

            listaEmpleados.Add(new Empleado { Id = 1, Name = "Martin Sergio Lopez", Cargo = "Senior Project Manager", EmpresaId = 1, Salario = 25000 });
            listaEmpleados.Add(new Empleado { Id = 2, Name = "Martin Lopez", Cargo = "Senior Project Manager", EmpresaId = 2, Salario = 500000 });
            listaEmpleados.Add(new Empleado { Id = 3, Name = "Sergio Lopez", Cargo = "Senior Project Manager", EmpresaId = 3, Salario = 24000 });
            listaEmpleados.Add(new Empleado { Id = 4, Name = "Sergio Martin Lopez", Cargo = "Senior Project Manager", EmpresaId = 1, Salario = 30000 });
        }

        public void getProjectManager()
        {
            IEnumerable<Empleado> managers = from empleado in listaEmpleados where empleado.Cargo == "Senior Project Manager" select empleado;
            foreach (Empleado empleado in managers)
            {
                empleado.DatosEmpleado();   
            }
        }
        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Name descending select empleado;
            foreach (Empleado empleado in empleados)
            {
                empleado.DatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int Id)
        {
            IEnumerable<Empleado> empleadosEmpresa = from empleado in listaEmpleados join 
                                              empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id
                                              where empresa.Id== Id select empleado;
            foreach (Empleado empleado in empleadosEmpresa)
            {
                empleado.DatosEmpleado();
                Console.WriteLine("Estamos adentro Marti, esta es tu nueva identidad, por todos");
            }
        }

        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;


    }
}
