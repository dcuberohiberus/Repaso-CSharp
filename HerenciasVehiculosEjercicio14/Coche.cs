namespace HerenciasVehiculosEjercicio14
{
    internal class Coche : Vehiculo
    {
        private int puertas;

        public void Frenar()
        {
            Console.WriteLine("Frenando...");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public Coche(String modelo, int capacidadPasajeros, int puertas) : base(modelo, capacidadPasajeros)
        {
            this.puertas = puertas;
        }

        public override void Conducir()
        {
            Console.WriteLine("override | Conduciendo un Coche");
        }
    }
}