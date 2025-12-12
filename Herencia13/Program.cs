namespace Herencia13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");
            Humano Juan = new Humano("Juan");
            Gorila Copito = new Gorila("Copito");

            //-- =======================
            //--  42. Heritage II. Syntax and class Object
            //-- =======================
            //Copito.trepar();

            //-- =======================
            //--  43. Inheritance III. Builders and base
            //-- =======================
            //Babieca.getNombre();
            //Juan.getNombre();
            //Copito.getNombre();

            //-- =======================
            //--  44. Inheritance IV. Substitution principle
            //-- =======================
            Caballo miBabieca = new Caballo("Babieca");
            Humano miJuan = new Humano("Juan");
            Gorila miCopito = new Gorila("Copito");

            //Principio de sustitución
            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = miBabieca;
            almacenAnimales[1] = miJuan;
            almacenAnimales[2] = miCopito;
            //almacenAnimales[0].getNombre();

            //-- =======================
            //--  45. Inheritance V. Polymorphism
            //-- =======================
            foreach (var item in almacenAnimales)
            {
                Console.WriteLine(item.GetType().Name);
                item.pensar();
            }



        }//end:main

        private class Mamiferos //Superclass
        {
            private String nombreSerVivo;

            //Constructor
            public Mamiferos(String nombre)
            {
                nombreSerVivo = nombre;
            }

            //Encapsulamiento poniéndolas privadas
            public void getNombre()
            {
                Console.WriteLine($"El nombre del ser vivo es: {nombreSerVivo}");
            }

            protected void respirar()
            {
                Console.WriteLine("Soy capaz de respirar");
            }

            public void cuidarCrias()
            {
                Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
            }

            public virtual void pensar()//Le estamos indicnado que este método puede ser sobreescritor
            {
                Console.WriteLine("Pensamiento básico instintivo");
            }
        }

        private class Caballo : Mamiferos
        {
            public Caballo(String nombreCaballo) : base(nombreCaballo)
            {
            }

            public void galopar()
            {
                Console.WriteLine("Soy capaz de galopar");
            }
        }

        private class Humano : Mamiferos
        {
            public Humano(String nombreHumano) : base(nombreHumano)
            {
            }

            public override void pensar()
            {
                Console.WriteLine("Soy capaz de pensar¿?");
            }
        }

        private class Gorila : Mamiferos
        {
            public Gorila(String nombreGorila) : base(nombreGorila)
            {
            }

            public void trepar()
            {
                Console.WriteLine("Soy capaz de trepar");
            }

            public override void pensar()
            {
                Console.WriteLine("Pensamiento instintivo avanzado");
            }
        }
    }//end:program
}