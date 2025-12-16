namespace Enum18
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //-- =======================
            //--  58. Enum
            //-- =======================
            //Estaciones? alergia = null;
            //Estaciones alergia = Estaciones.Primavera;
            //String LaLAlergia = alergia.ToString();
            //Console.WriteLine(alergia);

            Bonus Antonio = Bonus.bueno;
            double bonusAntonio = (double)Antonio; //casteo a double
            Console.WriteLine(bonusAntonio);

            //Empleado Juan = new Empleado(Bonus.extra, 1900.50);
            //Console.WriteLine($"Valor del salario: {Juan.getSalario()}");

        }//end:main

        private enum Estaciones { Primavera, Verano, Otoño, Invierno };
        private enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 };

        private class Empleado
        {
            private double salario;
            private Bonus bonusEmpleado;

            public Empleado(Bonus bonusEmpleado, double salario)
            {
                this.bonusEmpleado = bonusEmpleado;
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario + (double)bonusEmpleado;
            }
        }
    }//end:program
}