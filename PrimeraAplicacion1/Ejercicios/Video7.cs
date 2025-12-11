namespace PrimeraAplicacion.Ejercicios
{
    public class Video7
    {
        //-.- =======================
        //--  7.  Basic Syntax V
        //-- =======================
        //REFERENCIAS WEB:

        public static void Ejecutar()
        {

            //Operador =, Declaración implícita
            var edad = 30; //Declarar e iniciar en la misma línea.

            //conversión implicita. EJ: Decimal a Int
            float temperaturaFloat = 5.78F;
            double temperaturaDouble = temperaturaFloat; //double
            Console.WriteLine($"Temperatura implícita: {temperaturaDouble}"); //35

            //conversión explicita
            double temperaturaDecimal = 34.5;
            int temperaturaInt = (int)temperaturaDecimal;
            Console.WriteLine($"Temperatura exexplicita {temperaturaInt}"); //35

            //Convierte el valor numerico en Entero
            int num1 = int.Parse(Console.ReadLine());

        }

    }
}