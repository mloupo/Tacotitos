using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tacotito_s.Controllers;
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

        /*    CreationsController cont = new CreationsController();

            IIngrediente tortilla = cont.Create(Enums.TipoCreacion.Tortilla, "Maiz", 135.50);
            IIngrediente relleno = cont.Create(Enums.TipoCreacion.Relleno, "Maria Juana", 905.75);
            IIngrediente salsa = cont.Create(Enums.TipoCreacion.Salsa, "Cheddar", 110.50);
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
        */

            string frase = "Beautiful is better than ugly.\r\nExplicit is better than implicit.\r\nSimple is better than complex.\r\nComplex is better than complicated.\r\nFlat is better than nested.\r\nSparse is better than dense.\r\nReadability counts.\r\nSpecial cases aren't special enough to break the rules.\r\nAlthough practicality beats purity.\r\nErrors should never pass silently.\r\nUnless explicitly silenced.\r\nIn the face of ambiguity, refuse the temptation to guess.\r\nThere should be one-- and preferably only one --obvious way to do it.\r\nAlthough that way may not be obvious at first unless you're Dutch.\r\nNow is better than never.\r\nAlthough never is often better than *right* now.\r\nIf the implementation is hard to explain, it's a bad idea.\r\nIf the implementation is easy to explain, it may be a good idea.\r\nNamespaces are one honking great idea -- let's do more of those!";
            Console.WriteLine(frase);
            //string patron = "[better]";
            string patron2 = @"\d{3}";
            Regex miRegex = new Regex(patron2);
            MatchCollection elMatch = miRegex.Matches(frase);
            if (elMatch.Count > 0) Console.WriteLine($"Se ha encontrado ...{patron2}");
            else Console.WriteLine("No se ha encontrado"); 
            Console.ReadLine();
        }
    }
}

