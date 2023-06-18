using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Tacotito_s.Factory;

namespace Tacotito_s
{
    internal class Program
    {
        static void Main()
        {
            List<IIngrediente> listaIngredientes = new List<IIngrediente>();

     /*     IIngrediente tortilla = new Tortilla( "Maiz", 35);
            IIngrediente tortillad = new Tortilla( "Trigo", 45);
            IIngrediente salsa = new Salsa( "Cherddar", 30);
            IIngrediente relleno = new Relleno( "Carne", 150);
            IIngrediente relleno2 = new Relleno( "Pollo", 120);
            IIngrediente relleno3 = new Relleno( "Cerdo", 140);
            IIngrediente relleno4 = new Relleno( "Wacamole", 150);
            IIngrediente relleno5 = new Relleno( "Queso", 100);
            listaIngredientes.Add(tortilla);
            listaIngredientes.Add(tortillad);
            listaIngredientes.Add(salsa);
            listaIngredientes.Add(relleno);
            listaIngredientes.Add(relleno2);
            listaIngredientes.Add(relleno3);
            listaIngredientes.Add(relleno4);
            listaIngredientes.Add(relleno5);
     */

            FactoryIngrediente fabrica = new FactoryIngrediente();
            IIngrediente tortilla = fabrica.GetCreation(Enums.TipoCreacion.Tortilla);
            IIngrediente relleno = fabrica.GetCreation(Enums.TipoCreacion.Relleno);
            IIngrediente salsa = fabrica.GetCreation(Enums.TipoCreacion.Salsa);
            List<IIngrediente> creations = new List<IIngrediente>();
            creations.Add(tortilla);
            creations.Add(relleno);
            creations.Add(salsa);
            Taco taco = new Taco(creations);
            Taco taco2 = new Taco(creations);
            Taco taco3 = new Taco(creations);

            Console.WriteLine("Taco Nro: " + taco.MyId);
            taco.PrecioToString();
            taco.Ingredientes();

            Console.WriteLine("Taco Nro: " + taco2.MyId);
            taco2.PrecioToString();
            taco2.Ingredientes();
            
            Console.WriteLine("Taco Nro: " + taco3.MyId);
            taco3.PrecioToString();
            taco3.Ingredientes();

            Console.ReadLine();

        }
    }
}

