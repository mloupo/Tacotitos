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

			var ListaIngredientes = new List<IIngrediente>();
			CreationsController cont = new();


			IIngrediente Maiz = cont.Create(Enums.TipoCreacion.Tortilla, "Maiz", 135.50);
			IIngrediente Trigo = cont.Create(Enums.TipoCreacion.Tortilla, "Trigo", 120.5);

			IIngrediente CannabisSativa = cont.Create(Enums.TipoCreacion.Relleno, "Maria Juana", 905.75);
			IIngrediente PsilocybeCubensis = cont.Create(Enums.TipoCreacion.Relleno, "Goomba", 905.75);
			IIngrediente HericiumErinaceus = cont.Create(Enums.TipoCreacion.Relleno, "Champicóptero", 905.75); /*https://mario.fandom.com/es/wiki/Champi%C3%B1%C3%B3n#Tipos_de_champi%C3%B1ones*/
			IIngrediente Carne = cont.Create(Enums.TipoCreacion.Relleno, "Carne", 150);
			IIngrediente Pollo = cont.Create(Enums.TipoCreacion.Relleno, "Pollo", 120);
			IIngrediente Cerdo = cont.Create(Enums.TipoCreacion.Relleno, "Cerdo", 140);
			IIngrediente Queso = cont.Create(Enums.TipoCreacion.Relleno, "Queso", 100);

			IIngrediente Wacamole = cont.Create(Enums.TipoCreacion.Salsa, "Wacamole", 150);
			IIngrediente Cheddar = cont.Create(Enums.TipoCreacion.Salsa, "Cheddar", 110.50);
			IIngrediente Tempura = cont.Create(Enums.TipoCreacion.Salsa, "Tempura", 135.50);

			ListaIngredientes.Add(Maiz);
			ListaIngredientes.Add(Trigo);

			ListaIngredientes.Add(CannabisSativa);
			ListaIngredientes.Add(PsilocybeCubensis);
			ListaIngredientes.Add(HericiumErinaceus);
			ListaIngredientes.Add(Carne);
			ListaIngredientes.Add(Pollo);
			ListaIngredientes.Add(Cerdo);
			ListaIngredientes.Add(Queso);

			ListaIngredientes.Add(Wacamole);
			ListaIngredientes.Add(Cheddar);
			ListaIngredientes.Add(Tempura);

			var taco1 = new Taco(ListaIngredientes);
			var taco2 = new Taco(ListaIngredientes);
			var taco3 = new Taco(ListaIngredientes);
			int years = 1;
			string msg = @$"Este evento,
ocurrio hace {years} año{(years>1? "s" : "")}"; //interpolation + verbatim + operador ternario
			Console.WriteLine(msg);
			taco1.InfoTaco();
			Console.WriteLine("-----------------------------------------------------------");
			taco2.InfoTaco();
			Console.WriteLine("-----------------------------------------------------------");
			taco3.InfoTaco();			
			Console.ReadLine();

/*
			string frase = """
								Beautiful is better than ugly.
								Explicit is better than implicit.
								Simple is better than complex.
								Complex is better than complicated.
								Flat is better than nested.
								Sparse is better than dense.
								Readability counts.
								Special cases aren't special enough to break the rules.
								Although practicality beats purity.
								Errors should never pass silently.
								Unless explicitly silenced.\r\nIn the face of ambiguity, refuse the temptation to guess.
								There should be one-- and preferably only one --obvious way to do it.
								Although that way may not be obvious at first unless you're Dutch.
								Now is better than never.
								Although never is often better than *right* now.
								If the implementation is hard to explain, it's a bad idea.
								If the implementation is easy to explain, it may be a good idea.
								Namespaces are one honking great idea -- let's do more of those!
							""";

			Console.WriteLine(frase);
			//string patron = "[better]";
			string patron2 = @"\d{3}";
			Regex miRegex = new Regex(patron2);
			MatchCollection elMatch = miRegex.Matches(frase);
			if (elMatch.Count > 0) Console.WriteLine($"Se ha encontrado ...{patron2}");
			else Console.WriteLine("No se ha encontrado");
			Console.ReadLine();
*/
		}
	}
}

