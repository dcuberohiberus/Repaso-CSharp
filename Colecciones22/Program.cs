namespace Colecciones22
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //-- =======================
            //--  63. Collections I
            //-- =======================
            List<int> numeros = new List<int>(); //Declarar coleccion generica tipo lista
            //EJERCICIO 1
            //Console.WriteLine("Cuántos elementos quieres introducir?");
            //int numElem = Int32.Parse(Console.ReadLine());

            //for (int i = 0; i < numElem; i++)
            //{
            //    numeros.Add(Int32.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("");

            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Valor de Count: {numeros.Count()}");

            //EJERCICIO 2
            Console.WriteLine("Introduce elementos en la colección (0 para salir)");

            int elem = 1;
            while (elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());
                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos introducidos: ");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }


        }//end:main
    }//end:program
}