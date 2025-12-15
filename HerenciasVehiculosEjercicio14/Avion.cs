using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasVehiculosEjercicio14
{
    internal class Avion : Vehiculo
    {
        private int motores;

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando...");
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando...");
        }

        public Avion(String modelo, int capacidadPasajeros, int motores) : base(modelo, capacidadPasajeros)
        {
            this.motores = motores;
        }

        public override void Conducir()
        {
            Console.WriteLine("override | Conduciendo un Avion");
        }
    }
}