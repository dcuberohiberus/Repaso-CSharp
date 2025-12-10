using EjercicioLuisma3;

namespace UsoChecked

{
    internal class Program
    {
        private static void Main()
        {
            // int, bool, //El usuario cuando le haga una pregunta, introduzca numero entre 1-100, le pida un booleano.
            // Generar clase nueva, llamar a un metodo de otra clase distinta, y que recoja varios tipos de excepciones.
            int NumRecogido = 0;
            bool Valido = false;

            try
            {
                NumRecogido = Numeros.RecogerNumero();
                Valido = Numeros.RecogerBooleano();

                if (NumRecogido >= 50 && Valido == true)
                {
                    Console.WriteLine("El número es válido");
                }

                if (NumRecogido < 50 && Valido != false)
                {
                    Console.WriteLine("El número no es válido");
                }

                if (NumRecogido >= 10 && NumRecogido <= 20 || Valido == false)
                {
                    Console.WriteLine("El número abarca el rango de 10 y 20 y no es válido");
                }

            }
            catch (Exception e)
            {
                throw new Exception("Error controlado genérico.");
                
            }
            finally
            {
                Main();
            }

            Console.WriteLine("Continua.");
        }//end:main
    }
}