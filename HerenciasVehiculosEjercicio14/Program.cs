namespace HerenciasVehiculosEjercicio14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Avion miAvion = new Avion("Boeing747", 300, 4);
            Coche miCoche = new Coche("Toyota", 5, 4);

            //-- =======================
            //--  47:	Inheritance VII. Guided exercise, solution
            //-- =======================
            miAvion.arrancarMotor("fiuuumm tracatrá");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.pararMotor(miAvion);

            Console.WriteLine("");

            miCoche.arrancarMotor("brummmm brum");
            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.Frenar();
            miCoche.pararMotor(miCoche);

            Console.WriteLine("");
            Console.WriteLine("");

            Vehiculo miVehiculo = miCoche;
            miVehiculo.Conducir(); //Polimorfismo, mismo objeto diferente comportamiento
            miVehiculo = miAvion;
            miVehiculo.Conducir(); //Polimorfismo, mismo objeto diferente comportamiento
        }//end:main
    }//end:program
}