namespace PrimeraAplicacion.Ejercicios
{
    public class Video6
    {
        //-.- =======================
        //--  6.  Basic Syntax IV | Operador =, Declaración implícita y conversiones de tipos
        //-- =======================
        //REFERENCIAS WEB:

        public static void Ejecutar()
        {
            //Declaracion múltiple de variables
            int edadPersona1, edadPersona2, edadPersona3, edadPersona4;
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 25;
            Console.WriteLine($"Edad personas: {edadPersona1}, {edadPersona2}, {edadPersona3}, {edadPersona4}");

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
        }
    }
}