namespace DoWhile;

internal class Program
{
    private static void Main(string[] args)
    {
        //-- =======================
        //--  21.  DOWHILE LOOP
        //-- =======================
        //int counter = 0;
        //do
        //{
        //    Console.WriteLine($"Counter: {counter}");
        //    counter++;
        //} while (counter <= 5); //Haz mientras......

        //19. Generar un número aleatorio
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); // Número entre 1 y 100
        int intentos = 0;
        int numeroUsuario;

        Console.WriteLine("Adivina el número entre 1 y 100:");
        do
        {
            numeroUsuario = Int32.Parse(Console.ReadLine());

            if (numeroUsuario < numeroAleatorio) Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
            if (numeroUsuario > numeroAleatorio) Console.WriteLine("Demasiado alto. Intenta de nuevo:");

            intentos++;
        } while (numeroUsuario != numeroAleatorio);

        Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroAleatorio} en {intentos} intentos.");


    }//end:main
}