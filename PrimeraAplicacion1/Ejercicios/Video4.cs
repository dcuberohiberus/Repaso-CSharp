namespace PrimeraAplicacion.Ejercicios

{
    public class Video4
    {
        //-- =======================
        //--  4. Sintaxis básica II: Tipso de datos, declaración variables, convenciones y buenas prácticas
        //-- =======================
        public static void Ejecutar()
        {
            //Primitivos
            //Enteros con signo: Positivos y negativos
            var entero = 10; //int
            sbyte enteroPequeño = -5; //sbyte
            short enteroCorto = -30000; //short
            int enteroNormal = -2000000000; //int
            long enteroLargo = -9000000000; //long

            //Enteros sin signo Valores solo positivos

            byte enteroPequeñoSinSigno = 5; //byte
            ushort enteroCortoSinSigno = 60000; //ushort
            uint enteroNormalSinSigno = 4000000000; //uint
            ulong enteroLargoSinSigno = 18000000000; //ulong

            //Reales
            var real = 10.5; //double
            //Booleans
            var booleano = true; //bool


            Console.WriteLine($"booleano: {booleano}"); //true
        }
    }
}