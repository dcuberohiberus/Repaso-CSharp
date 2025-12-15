namespace InterfacesAvisosVarios15
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura provincial Madrid", "Sanción de velocidad: 300$", "02/02/2025");

            Console.WriteLine(av2.getFecha());

            av2.mostrarAviso();
        }//end:main
    }//end:program
}