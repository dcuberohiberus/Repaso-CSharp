namespace Genericos20
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //-- =======================
            //--  60, 61. Generics I, II
            //-- =======================
            //AlmacenObjetos <String> files = new AlmacenObjetos<String>(4);
            //files.agregar("Juan");
            //files.agregar("Elena");
            //files.agregar("Antonio");
            //files.agregar("Sandra");
            //String nombrePersona = files.getElemento(0);

            //AlmacenObjetos <Int> files = new AlmacenObjetos<Int>(4);
            //files.agregar(new Empleado(1200));
            //files.agregar(new Empleado(1500));
            //files.agregar(new Empleado(2000));
            //files.agregar(new Empleado(2400));

            AlmacenObjetos<DateTime> date = new AlmacenObjetos<DateTime>(4);
            date.agregar(new DateTime());
            date.agregar(new DateTime());
            date.agregar(new DateTime());
            date.agregar(new DateTime());

            DateTime datex = date.getElemento(0);
            Console.WriteLine(datex);
        }//end:main

        private class AlmacenObjetos<T> //manejara objetos de cualquier tipo
        {
            private T[] datosElemento; //Superclase cósmica Object
            private int i = 0;

            public AlmacenObjetos(int z) //constructor de la clase generica que recibe el tamaño del array con el tipo T
            {
                datosElemento = new T[z];
            }

            public void agregar(T obj)
            {
                datosElemento[i] = obj;
                i++;
            }

            public T getElemento(int i)
            {
                return datosElemento[i];
            }
        }

        private class Empleado
        {
            private double salario;

            public Empleado(double salario)
            {
                this.salario = salario;
            }

            public double getSalario() //private por defecto
            {
                return salario;
            }
        }
    }//end:program
}