namespace PrimeraAplicacion.Ejercicios
{
    public class Video9
    {
        //-.- =======================
        //--  9. 11.  Methods I: int, void
        //-- =======================
        //REFERENCIAS WEB:


        //SOBRECARGA DE MÉTODOS
        // Primera versión: suma fija
        public int sumaNumeros()
        {
            int num1 = 5;
            int num2 = 6;
            int resultado = num1 + num2;
            return resultado;
        }

        // Segunda versión: suma con parámetros
        public int sumaNumeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        // Tercera versión: muestra el resultado en consola
        public void sumaNumerosVoid()
        {
            int num1 = 7;
            int num2 = 9;
            int resultado = num1 + num2;
            Console.WriteLine(resultado);
        }





    }
}