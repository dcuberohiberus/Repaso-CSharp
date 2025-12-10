namespace EjercicioLuisma3
{
    internal class Numeros
    {
        public static int RecogerNumero()
        {
            int NumRecogido = 0;
            Console.WriteLine("Introduzca numero entre 1-100: ");
            NumRecogido = Int32.Parse(Console.ReadLine());

            return NumRecogido;
        }

        public static bool RecogerBooleano()
        {
            bool Valido = false;
            Console.WriteLine("Introduce 'false' o 'true': ");

            Valido = bool.Parse(Console.ReadLine());

            return Valido;
        }


    }//end:class


}