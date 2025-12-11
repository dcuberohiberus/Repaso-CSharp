
namespace MiNamespace
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;
            int contador = 0;
            try
            {
                string linea;

                string path = @"C:\Users\DarioCuberoJimenez\source\repos\Repaso-CSharp\EjemploFinally\fichero.txt";
                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error con la lectura");
                contador++;
            }
            finally{
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexión con el fichero cerrada");
            }




        }
    }
}
