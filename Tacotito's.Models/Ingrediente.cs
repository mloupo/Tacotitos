using System.Timers;
using Tacotito_s.Factory;

namespace Tacotito_s
{
    internal abstract class Ingrediente : IIngrediente
    {
        protected double _precio_unitario;

        public double Precio_unitario { get => _precio_unitario; init => _precio_unitario = value; }
        public string Name { get; init; }
        private static int ID = 0;
        private readonly int myId = 0;

        public int MyUniqueId
        {
            get { return myId; }
        }
        /// <summary>
        /// Incializacion de Ingrediente. Asigna un Id unico.
        /// </summary>
        public Ingrediente()
        {
            ID++;
            this.myId = ID;
        }
        
        public void Precio()
        {
            Console.WriteLine(_precio_unitario);
        }

        public override string? ToString()
        {
            return this.GetType().Name + DatosIngrediente();
        }

        public abstract string DatosIngrediente();
	}
}
