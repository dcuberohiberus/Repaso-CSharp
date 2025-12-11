namespace ConceptosPOO
{
    internal class Punto
    {
        private int x, y;
        private static int contadorDeObjetos = 0;
        public const int constantePrueba = 7; //Todas las constantes son STATIC, para modificarlas debes instanciar la clase

        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        //-- =======================
        //--  33. OOP VII.Calls and Math class.
        //-- =======================
        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2)); //Teorema de Pitágoras. cuadrado de la hipotenusa es igual a la suma de los cuadrados
            return distanciaPuntos;
        }

        //public static int ContadorDeObjetos()
        //{
        //    return contadorDeObjetos = 0;
        //}

        //-- =======================
        //--  34. POO VIII.Variables and static methods
        //-- =======================

        public static int ContadorDeObjetos() => contadorDeObjetos;




    }//end:class
}