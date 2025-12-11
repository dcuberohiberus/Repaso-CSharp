namespace POO
{
    internal class Program
    {
        //-- =======================
        //--  28.  POO II. Creation of classes and instances
        //-- =======================

        private static void Main(string[] args)
        {
            //Circulo miCirculo; //Creación de objeto

            //miCirculo = new Circulo(); //Iniciación
            //Console.WriteLine(miCirculo.CalculoArea(5));


            //Circulo miCirculo2 = new Circulo();
            //Console.WriteLine(miCirculo2.CalculoArea(9));


            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.cambiaValorEuro(0.5);
            Console.WriteLine(obj.convierte(50));

        }
    } //end:main

    internal class Circulo
    {
        private const double pi = 3.1416;

        public double CalculoArea(int radio) // método de clase. ¿Qué pueden hacer los objetos de tipo círculo?
        {
            return pi * radio * radio;
        }
    }//end:circulo


    //-- =======================
    //--  29.  POO III. Encapsulation and conventions
    //-- =======================
    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }


        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;
            else
                euro = nuevoValor;
        }



    }



}//end:namespace