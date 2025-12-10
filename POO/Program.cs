namespace POO
{
    using System;

    internal class Program
    {
        //-- =======================
        //--  28.  POO II. Creation of classes and instances
        //-- =======================


        private static void Main(string[] args)
        {
            Circulo miCirculo; //Creación de objeto

        }
    }

    internal class Circulo
    {
        private double pi = 3.1416; // propiedad de la clase Circulo. Campo de clase.
        private double calculoArea(int radio) // método de clase. ¿Qué pueden hacer los objetos de tipo círculo?
        {
            return pi * radio * radio;
        }
    }


}//end:namespace