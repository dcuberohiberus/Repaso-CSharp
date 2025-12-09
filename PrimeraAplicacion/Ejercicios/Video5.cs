namespace PrimeraAplicacion.Ejercicios
{
    public class Video5
    {
        //-- =======================
        //--  5.  Sintaxis básica V | Operadores ariméticos básicos: Suma, resta, multiplicación, división y residuo
        //-- =======================
        //REFERENCIAS WEB:

        public static void Ejecutar()
        {
            //Suma
            int a = 5;
            int b = 10;
            Console.WriteLine($"Suma: {a} + {b} = {a + b}");

            //Resta
            Console.WriteLine($"Resta: {b} - {a} = {b - a}");

            //Multiplicación
            Console.WriteLine($"Multiplicación: {a} * {b} = {a * b}");

            //División
            Console.WriteLine($"División: {b} / {a} = {b / a}");

            //Residuo
            Console.WriteLine($"Residuo: {b} % {a} = {b % a}");

            //Edad
            int edad = 25;
            Console.WriteLine($"Tienes una edad de {edad} años");
        }
    }
}