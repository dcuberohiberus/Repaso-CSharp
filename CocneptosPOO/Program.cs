namespace ConceptosPOO
{
    internal class Program
    {
        private int hola = 0;

        private static void Main(string[] args)
        {
            //realizarTarea();

            //-- =======================
            //--  35. POO IX. Anonymous classes
            //-- =======================
            //double raiz = Math.Sqrt(9);
            //double potencia = Math.Pow(3, 4);

            //Console.WriteLine($"Valor de raiz: {raiz}");
            //Console.WriteLine($"Valor de potencia: {potencia}");

            //Variable anonima  //Campos publicos, deben estar iniciados, no static, no se pueden definir metodos
            var miVariable = new { Nombre = "Juan", Edad = 19 };

            Console.WriteLine($"Valor de Nombre: {miVariable.Nombre}");
            Console.WriteLine($"Valor de Edad: {miVariable.Edad}");
           
            var miOtraVariable = new { Nombre = "Ana", Edad = 25};

            miVariable = miOtraVariable;

        }

        //-- =======================
        //-- 32. POO VI.Modularización.Constructor por defecto vs propio. Algunas utilidades en Visual Studio.
        //-- =======================
        private static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"Valor de distancia entre los puntos: {distancia}");

            Console.WriteLine($"Valor de num objects creados: {Punto.ContadorDeObjetos()}");
        }
    }//end:class
}