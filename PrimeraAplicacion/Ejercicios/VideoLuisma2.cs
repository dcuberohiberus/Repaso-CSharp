using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion.Ejercicios
{
    public class VideoLuisma2 : VideoLuima
    {

        //Generar Objeto "Multiplicación" e invocarlo en los parámetros y que se envíe a otro método.
       public static void llamarMetodoClase(double x, double y)
        {
            var resultado = VideoLuima.MultiplicarNums(x, y);
            Console.WriteLine(resultado);
        }



    }
}
