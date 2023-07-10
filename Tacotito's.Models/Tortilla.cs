namespace Tacotito_s
{
    internal class Tortilla : Ingrediente
    {
        private static int GlobalTortillaId = 0;
		private readonly int TortillaId = 0;
		public Tortilla( string name, double precio) 
        {
            Name = name;
            Precio_unitario = precio;
			GlobalTortillaId++;
			this.TortillaId = GlobalTortillaId;
		}
		public override string DatosIngrediente()
		{
			return $" Nro: {TortillaId} de {Name}, Precio: {Precio_unitario}";
		}
	}
}
