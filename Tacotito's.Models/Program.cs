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
		static void MostrarListaTacos(List<Taco> listaTacos)
		{
			foreach (var taco in listaTacos)
			{
				Console.WriteLine("\n-----------------------------------------------------------");
				taco.Info();
			}
		}
		static void Main() 
		{ 
			TacoController tacoController = new();
			IngredientController ingredientController = new();

			IIngrediente Maiz = ingredientController.Create(Enums.TipoIngrediente.Tortilla, "Maiz", 135.50);
			IIngrediente Trigo = ingredientController.Create(Enums.TipoIngrediente.Tortilla, "Trigo", 120.5);

			IIngrediente CannabisSativa = ingredientController.Create(Enums.TipoIngrediente.Relleno, "Maria Juana", 905.75);
			IIngrediente PsilocybeCubensis = ingredientController.Create(Enums.TipoIngrediente.Relleno, "Goomba", 905.75);
			IIngrediente HericiumErinaceus = ingredientController.Create(Enums.TipoIngrediente.Relleno, "Champicóptero", 905.75); /*https://mario.fandom.com/es/wiki/Champi%C3%B1%C3%B3n#Tipos_de_champi%C3%B1ones*/
			IIngrediente Carne = ingredientController.Create(Enums.TipoIngrediente.Relleno, "Carne", 150);
			IIngrediente Pollo = ingredientController.Create(Enums.TipoIngrediente.Relleno, "Pollo", 120);
			IIngrediente Cerdo = ingredientController.Create(Enums.TipoIngrediente.Relleno, "Cerdo", 140);
			IIngrediente Queso = ingredientController.Create(Enums.TipoIngrediente.Relleno, "Queso", 100);

			IIngrediente Wacamole = ingredientController.Create(Enums.TipoIngrediente.Salsa, "Wacamole", 150);
			IIngrediente Cheddar = ingredientController.Create(Enums.TipoIngrediente.Salsa, "Cheddar", 110.50);
			IIngrediente Tempura = ingredientController.Create(Enums.TipoIngrediente.Salsa, "Tempura", 135.50);

			List<IIngrediente> ListaIngredientes = new()
			{
				Maiz, Trigo,
				CannabisSativa,
				PsilocybeCubensis,
				HericiumErinaceus,
				Carne, Pollo, Cerdo,
				Queso, Wacamole,
				Cheddar, Tempura
			};
			
			var taco1 = tacoController.Create(ListaIngredientes);
			var taco2 = tacoController.Create(ListaIngredientes);
			var taco3 = tacoController.Create(ListaIngredientes);

			List<Taco> ListaTacos = new ()
			{
				taco1,
				taco2,
				taco3
			};

			List<Taco> ListaTacosConIdMayorADos = ListaTacos.FindAll(t => t.MyId > 2);
			int years = 1;
			string msg = @$"Este evento,
ocurrio hace {years} año{(years>1? "s" : "")}"; //interpolation + verbatim + operador ternario
			Console.WriteLine(msg);			
			MostrarListaTacos(ListaTacos);
			MostrarListaTacos(ListaTacosConIdMayorADos);
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

