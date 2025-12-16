namespace Destructores19
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.mensaje();
        }//end:main

        private class ManejoArchivos
        {
            //-- =======================
            //--  59. Destructores
            //-- =======================
            private StreamReader archivo = null;
            private int contador = 0;

            private string linea;
            private string rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\texto.txt");

            public ManejoArchivos()
            {
                //Porque cuando ejecutas desde Visual Studio, el directorio actual es:
                //Para llegar a la raíz del proyecto, hay que subir tres niveles.
                archivo = new StreamReader(rutaArchivo);
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }

            public void mensaje()
            {
                Console.WriteLine($"Hay: {contador} líneas");
            }

            ~ManejoArchivos() //~ sirve para definir el destructor
            {
                archivo.Close();
            }
        }
    }//end:program
}