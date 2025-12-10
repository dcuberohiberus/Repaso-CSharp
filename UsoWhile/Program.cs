namespace UsoWhile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //-- =======================
            //--  19.  WHILE LOOP
            //-- =======================

            ////VARS
            //string nombre;

            //Console.WriteLine("Cual es tu nombre?");
            //nombre = Console.ReadLine();

            //while (string.IsNullOrEmpty(nombre))
            //{
            //    Console.WriteLine("No ingresaste un nombre válido. Intenta de nuevo:");
            //    nombre = Console.ReadLine();
            //}

            //Console.WriteLine($"Hola {nombre}, bienvenido al programa.");

            //Console.WriteLine("Desear entrar en el bucle while (s/n):");
            //string respuesta = Console.ReadLine();
            //while (respuesta.ToLower() == "s")
            //{
            //    Console.WriteLine("Dentro del bucle WHILE.");
            //    Console.WriteLine("Desear seguir en el bucle while (s/n):");
            //    respuesta = Console.ReadLine();
            //}

            //19. Generar un número aleatorio
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101); // Número entre 1 y 100
            int intentos = 0;
            int numeroUsuario;
            Console.WriteLine("Adivina el número entre 1 y 100:");
            numeroUsuario = Int32.Parse(Console.ReadLine());

            while (numeroUsuario != numeroAleatorio)
            {
                if (numeroUsuario < numeroAleatorio) Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
                else
                {
                    intentos++;
                    Console.WriteLine("Demasiado alto. Intenta de nuevo:");
                    numeroUsuario = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroAleatorio} en {intentos} intentos.");
        }//end:main
    }
}