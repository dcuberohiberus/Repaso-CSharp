namespace MiNamespace
{
    internal class DelegadosPredicadosLambdas27
    {
        private static void Main(string[] args)
        {
            //-- =======================
            //--  67. Predicate Delegates and Lambdas I.
            //-- =======================

            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            ElDelegado("Hola acabo de llegar. Qué tal?");

            ObjetoDelegado ElDelegado2 = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            ElDelegado2("Hola ya me marcho. Bye");
        }//end:main

        private delegate void ObjetoDelegado(string msj); //Delegate permite definir el tipo de metodo que se asocia

        private class MensajeBienvenida
        {
            public static void SaludoBienvenida(string msj)
            {
                Console.WriteLine($"Valor de msj: {msj}");
            }
        }

        private class MensajeDespedida
        {
            public static void SaludoDespedida(string msj)
            {
                Console.WriteLine($"Valor de msj: {msj}");
            }
        }
    }//end:program
}