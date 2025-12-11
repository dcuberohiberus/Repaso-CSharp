namespace Constructores
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Coche coche1 = new Coche();  // crear objeto/instancia de tipo Coche.

            Coche coche2 = new Coche();
            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);
            Console.WriteLine(coche3.getInfoCoche());
            //coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
        }
    }//end:program

    internal partial class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;

        private bool climatizador;
        private String tapiceria;

        //Sobrecarga de constructores

        //-- =======================
        //--  30. POO IV.Constructores
        //-- =======================
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;

            tapiceria = "tela";
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

            tapiceria = "tela";
        }
    }

    internal partial class Coche
    {
        //-- =======================
        //--   31. POO V.Getters and Setters.
        //-- =======================

        public String getInfoCoche()
        {
            return $"Información del coche:\n Ruedas: {ruedas}, \n Largo: {largo}\n  Ancho: {ancho} ";
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public string getExtras()
        {
            return $"extras del coche:\n climatizadorCoche: {climatizador}, \n paramTapiceria: {tapiceria}";
        }
    }//end:coche
}