using System;

namespace LanzamientoExcepciones
{
    internal class Program
    {
        //REFERENCIAS WEB: https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception?view=net-10.0
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número de mes (1-12):");
            int NumeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreDelMes(NumeroMes));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Mensaje de la excepción: {e.Message}");
            }


            Console.WriteLine("Continuaría la ejecución...");
        }//end:main

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "Julio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}