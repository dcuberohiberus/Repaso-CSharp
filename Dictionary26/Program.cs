namespace Dictionary26
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            //-- =======================
            //-- 66. Stacks and Dictionary
            //-- =======================
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //Rellenar el diccionario
            edades.Add("Juan", 18);
            edades.Add("Diandra", 35);
            edades["María"] = 25;
            edades["Antonio"] = 29;

            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("Nombre: " + persona.Key + " Edad: " + persona.Value);
            }
        }//end:main
    }//end:program
}