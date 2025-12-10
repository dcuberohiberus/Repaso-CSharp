using System;

namespace UsoChecked
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Checked: Habilita la comprobación de desbordamiento para operaciones aritméticas y conversiones de tipo. Sino se las salta por cuestión de rendimiento.
            int numero = int.MaxValue;
            int resultado = numero + 20; //sumamos 20 al valor máximo de un entero deberia dar error de desbordamiento
            Console.WriteLine("Resultado sin checked: " + resultado);



        }//end:main
    }
}