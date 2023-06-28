using Tacotito_s.Factory;

namespace Tacotito_s
{
    internal abstract class Ingrediente : IIngrediente
    {
        protected string _name=String.Empty;
        protected double _precio_unitario;

        public double Precio_unitario { get => _precio_unitario; init => _precio_unitario = value; }
        public string Name { get => _name; init => _name = value; }
        private static int ID = 0;
        private int myId = 0;

        public int MyId
        {
            get { return myId; }
        }
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
            return this.GetType().Name + " Nro: " + MyId +" de "+ Name + ", Precio: " + Precio_unitario;
        }




    }
}
