namespace ArraysAsParameters12
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] numeros = new int[4];

            //numeros[0] = 1;
            //numeros[1] = 2;
            //numeros[2] = 3;
            //numeros[3] = 4;

            //ProcesaDatos(numeros);

            //-- =======================
            //--  40. Arrays V Arrays by parameters
            //-- =======================
            int[] arrayElementos = LeerDatos();
            Console.WriteLine("Imprimiendo desde el main");
            foreach (int i in arrayElementos) Console.WriteLine(i);



        }//end:main

        //private static void ProcesaDatos(int[] datos)
        //{
        //    //Le suma 10 a cada elemento
        //    for (int i = 0; i < 4; i++)
        //    {
        //        datos[i] += 10;
        //    }

        //    foreach (int i in datos)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        static int[] LeerDatos() {

            Console.WriteLine("¿Cuántos elementos quieres que tenga el array?");
            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce dato posición: {i}");
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);
                datos[i] = datosElemento;
            }

            return datos;
        }

    }//end:program
}