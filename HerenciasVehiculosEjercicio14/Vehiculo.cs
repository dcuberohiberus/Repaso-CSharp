using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciasVehiculosEjercicio14
{
    class Vehiculo
    {
        private string Modelo;
        private int CapacidadPasajeros;

        public Vehiculo(String modelo, int capacidadPasajeros)
        {
            this.Modelo = modelo;
            this.CapacidadPasajeros = capacidadPasajeros;
        }

        public void arrancarMotor(string sonidoAlArrancar)
        {
            Console.WriteLine($"Arrancando el motor {sonidoAlArrancar}");
        }

        public void pararMotor(Object obj)
        {
            Console.WriteLine($"Parando el motor de el vehículo tipo: {obj.GetType().Name}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("VIRTUAL | Metodo genérico de conducir");
        }

        public void infoGeneral()
        {
            Console.WriteLine($"Modelo: {Modelo}; Capacidad de Pasajeros {CapacidadPasajeros}");
        }



    }
}
