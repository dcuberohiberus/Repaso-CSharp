namespace HerenciaMamiferos13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Caballo Babieca = new Caballo("Babieca");
            //Humano Juan = new Humano("Juan");
            //Gorila Copito = new Gorila("Copito");

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
            //Caballo miBabieca = new Caballo("Babieca");
            //Humano miJuan = new Humano("Juan");
            //Gorila miCopito = new Gorila("Copito");

            ////Principio de sustitución
            //Mamiferos[] almacenAnimales = new Mamiferos[3];
            //almacenAnimales[0] = miBabieca;
            //almacenAnimales[1] = miJuan;
            //almacenAnimales[2] = miCopito;
            //almacenAnimales[0].getNombre();

            //-- =======================
            //--  45. Inheritance V. Polymorphism
            //-- =======================
            //foreach (var item in almacenAnimales)
            //{
            //    Console.WriteLine(item.GetType().Name);
            //    item.pensar();
            //}

            //Ballena miWally = new Ballena("Wally");
            //miWally.nadar();

            //IMamiferosTerrestres ImiBabieca = miBabieca;
            //Console.WriteLine($"Valor de patas deporte: {ImiBabieca.NumeroPatas()}");

            //ISaltoConPatas ImiBabiecaSalto = miBabieca;
            //Console.WriteLine($"Valor de patas salto: {ImiBabiecaSalto.NumeroPatas()}");

            Lagartija Juancho = new Lagartija("Juancho");
            Juancho.respirar();
            Juancho.getNombre();

            Humano Juan = new Humano("Juan");
            Juan.respirar();
            Juan.getNombre();
        }//end:main

        //-- =======================
        //--  48:	Interfaces I
        //-- =======================
        private interface IMamiferosTerrestres
        {
            int NumeroPatas(); //método interfaz, no se desarrolla, se declara. No debe de llevar modificador, es publico por defecto
        }

        private interface IAnimalesDeportes
        {
            string tipoDeporte();

            bool esOlimpico();
        }

        private interface ISaltoConPatas

        {
            int NumeroPatas();
        }

        private class Lagartija : Animales
        {
            private String nombreReptil;

            public Lagartija(String nombre)
            {
                this.nombreReptil = nombre;
            }

            public override void getNombre()
            {
                Console.WriteLine($"El nombre del reptil es: {nombreReptil}");
            }
        }

        private class Mamiferos : Animales   //Superclass
        {
            private String nombreSerVivo;

            //Constructor
            public Mamiferos(String nombre)
            {
                nombreSerVivo = nombre;
            }

            //Encapsulamiento poniéndolas privadas
            public override void getNombre()
            {
                Console.WriteLine($"El nombre del mamífero es: {nombreSerVivo}");
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

        private class Ballena : Mamiferos//Primero clase, y luego interfaz
        {
            public Ballena(String nombreBallena) : base(nombreBallena)
            {
            }

            public void nadar()
            {
                Console.WriteLine("Soy capaz de nadar");
            }
        }

        //-- =======================
        //--  49. Interfaces II
        //-- =======================
        private class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltoConPatas
        {
            public Caballo(String nombreCaballo) : base(nombreCaballo)
            {
            }

            public bool esOlimpico()
            {
                return true;
            }

            public void galopar()
            {
                Console.WriteLine("Soy capaz de galopar");
            }

            //public int NumeroPatas() //ambiguedad en interfaz
            int IMamiferosTerrestres.NumeroPatas()
            {
                return 4;
            }

            int ISaltoConPatas.NumeroPatas()
            {
                return 2;
            }

            public string tipoDeporte()
            {
                return "Hipica";
            }
        }

        private abstract class Animales
        {
            //-- =======================
            //--  52,53f. Clases abstractas I y II
            //-- =======================

            public void respirar() //Permite tener el método desarrollado en la clase abstracta
            {
                Console.WriteLine("Soy capaz de respirar");
            }

            public abstract void getNombre(); //Obliga a la subclases a implementar éste método
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

        private class Gorila : Mamiferos, IMamiferosTerrestres
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

            public int NumeroPatas()
            {
                return 2;
            }
        }
    }//end:program
}