using System;
using System.Text.RegularExpressions;

namespace Excepciones;

internal class Program
{
    private static void Main(string[] args) //el
    {
        //-- =======================
        //--  22 Exceptions
        //-- =======================
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); // Número entre 1 y 100
        int intentos = 0;
        int numeroUsuario;

        //Console.WriteLine("Adivina el número entre 1 y 100:");
        //do
        //{
        //    try
        //    {
        //        numeroUsuario = Int32.Parse(Console.ReadLine());
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero. Se toma el 0");
        //        numeroUsuario = 0;
        //    }

        //    if (numeroUsuario < numeroAleatorio) Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
        //    if (numeroUsuario > numeroAleatorio) Console.WriteLine("Demasiado alto. Intenta de nuevo:");

        //    intentos++;
        //} while (numeroUsuario != numeroAleatorio);

        //Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroAleatorio} en {intentos} intentos.");

        //-- =======================
        //--  23 Exceptions: Catching Multiple Exception Types
        //-- =======================

        //Console.WriteLine("Adivina el número entre 1 y 100:");
        //do
        //{
        //    try
        //    {
        //        numeroUsuario = Int32.Parse(Console.ReadLine());
        //    }
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("No has introducido un valor numérico. Por favor, ingresa un número entero. Se toma el 0");
        //        numeroUsuario = 0;
        //    }
        //    catch (OverflowException ex)
        //    {
        //        Console.WriteLine("Has introducido un valor demasiado alto. Por favor, ingresa un número entero. Se toma el 0");
        //        numeroUsuario = 0;
        //    }

        //    if (numeroUsuario < numeroAleatorio) Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
        //    if (numeroUsuario > numeroAleatorio) Console.WriteLine("Demasiado alto. Intenta de nuevo:");

        //    intentos++;
        //} while (numeroUsuario != numeroAleatorio);

        //Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroAleatorio} en {intentos} intentos.");

        //EXPLICACIÓN:
        //Exception: Es la clase base para todas las excepciones en.NET.
        //SystemException: Hereda de Exception y agrupa las excepciones que ocurren dentro del sistema(errores comunes en tiempo de ejecución).
        //FormatException y OverflowException: Son ejemplos de excepciones específicas que heredan de SystemException.

        //FormatException: Se lanza cuando el formato de un dato no es válido(por ejemplo, convertir un texto a número y no coincide).
        //OverflowException: Se lanza cuando una operación aritmética excede el rango permitido para el tipo de dato.

        //Console.WriteLine("Adivina el número entre 1 y 100:");
        //do
        //{
        //    try
        //    {
        //        numeroUsuario = Int32.Parse(Console.ReadLine());
        //    }
        //    catch (Exception e) //Ponemos el padre. Debemos trazar de la forma mas exacta el error.
        //    {
        //        Console.WriteLine("Por favor, ingresa un número entero. Se toma el 0");
        //        Console.WriteLine(e.Message);
        //        numeroUsuario = 0;
        //    }

        //    if (numeroUsuario < numeroAleatorio) Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
        //    if (numeroUsuario > numeroAleatorio) Console.WriteLine("Demasiado alto. Intenta de nuevo:");

        //    intentos++;
        //} while (numeroUsuario != numeroAleatorio);

        //Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroAleatorio} en {intentos} intentos.");


        //-- =======================
        //--  24  Exceptions III. Conflicts several exceptions, capture with filters.
        //-- =======================
        Console.WriteLine("Adivina el número entre 1 y 100:");
        do
        {
            
            try
            {
                numeroUsuario = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType()!=typeof(FormatException))//Filtro para todas las excepciones menos FormatException
            {
                Console.WriteLine("Error. Por favor, ingresa un número entero. Se toma el 0");
                //Console.WriteLine(e.Message);
                numeroUsuario = 0;
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error en el formato. Por favor, ingresa un número entero. Se toma el 0");
                numeroUsuario = 0;
            }

            if (numeroUsuario < numeroAleatorio) Console.WriteLine("Demasiado bajo. Intenta de nuevo:");
            if (numeroUsuario > numeroAleatorio) Console.WriteLine("Demasiado alto. Intenta de nuevo:");

            intentos++;
        } while (numeroUsuario != numeroAleatorio);

        Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroAleatorio} en {intentos} intentos.");



    } //end:main
}