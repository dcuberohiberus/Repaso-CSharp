namespace HerenciasVehiculosEjercicio14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Avion avion1 = new Avion("Boeing747", 300, 4);
            Coche coche1 = new Coche("Toyota", 5, 4);
            avion1.arrancarMotor(avion1);
            coche1.arrancarMotor(coche1);

            avion1.conducir();
            coche1.conducir();

        }//end:main

        private class Vehiculo //Superclass
        {
            private string Modelo;
            private int CapacidadPasajeros;

            public Vehiculo(String modelo, int capacidadPasajeros)
            {
                this.Modelo = modelo;
                this.CapacidadPasajeros = capacidadPasajeros;
            }

            public void arrancarMotor(Object obj)
            {
                Console.WriteLine($"Arrancando el motor {obj.GetType().Name}");
            }

            public void pararMotor(Object obj)
            {
                Console.WriteLine($"Arrancando el motor del {obj.GetType().Name}");
            }

            public void infoGeneral()
            {
                Console.WriteLine($"Modelo: {Modelo}; Capacidad de Pasajeros {CapacidadPasajeros}");
            }

            public virtual void conducir()
            {
                Console.WriteLine("Superclass | Conduciendo vehículo.");
            }
        }

        private class Avion : Vehiculo
        {
            private int motores;

            public Avion(String modelo, int capacidadPasajeros, int motores) : base(modelo, capacidadPasajeros)
            {
                this.motores = motores;
            }

            public override void conducir()
            {
                Console.WriteLine("override | Conduciendo un Avion");
            }
        }

        private class Coche : Vehiculo
        {
            private int puertas;


            public Coche(String modelo, int capacidadPasajeros, int puertas) : base(modelo, capacidadPasajeros)
            {
                this.puertas = puertas;
            }

            public override void conducir()
            {
                Console.WriteLine("override | Conduciendo un Coche");
            }
        }
    }//end:program
}