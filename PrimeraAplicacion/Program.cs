//Test de que el CSPROJ está configurado para C# 10.0 l
//global using System;
//namespace Prueba;
//record struct Point(int X, int Y);
//class Program
//{
//    static void Main()
//    {
//        var p = new Point(1, 2);
//        Console.WriteLine(p);
//    }
//}

//.NET 6, el SDK incluye automáticamente un archivo implícito llamado ImplicitUsings que agrega los espacios de nombres más utilizados, como System, System.Collections.Generic, System.Linq, etc.
//  en .csproj <ImplicitUsings>enable</ImplicitUsings>
//using System;

namespace PrimeraAplicacion;

class Program
{

    //REFERENCIAS WEB:
    //https://www.youtube.com/watch?v=6EBNIgkrU74&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=1
    //https://learn.microsoft.com/es-es/dotnet/csharp/

    private static void Main(string[] args)
    {
        Console.WriteLine("--MAIN--");
        //4.Sintaxis básica II: Tipso de datos, declaración variables, convenciones y buenas prácticas
        //Video4.Ejecutar();

        //5.Sintaxis básica V | Operadores ariméticos básicos: Suma, resta, multiplicación, división y residuo
        //Video5.Ejecutar();

        //6.Basic Syntax IV | Operador =, Declaración implícita y conversiones de tipos
        //Video6.Ejecutar();

        //7. Basic Syntax V
        //Video7.Ejecutar();

        //9. Method I: int, void
        //Invocarlo instanciando la clase ya que no está como "static"
        //var video9 = new Video9();
        //int resultado = video9.sumaNumeros();
        //int resultado2 = video9.sumaNumeros(1, 2);
        //Console.WriteLine($"El resultado de la suma es: {resultado}");
        //Console.WriteLine($"El resultado2 de la suma es: {resultado2}");

        //10. Methods II: Void with parameters
        //sumaNumeros(3, 4);
        //internal class Video10{... //Solo será accesible dentro del ensamblado PrimeraAplicacion. Al compilar se generará un ensamblado llamado PrimeraAplicacion.dll o .exe. y contiene todas las clases y métodos

        //11. Methods III: int return type
        //Console.WriteLine("La suma es: " + sumaNumeros(3, 4));

        //12. Methods IV: Alcance de métodos, y sobrecarga de métodos

        int valor1 = 7; //Variable ambito local, solo accesible dentro de este método
        double valor2 = 5.2;
        double valor3 = 8.3;
        Console.WriteLine(Suma(valor1, valor2));

        //Suma(valor1: 10, num3: 4.5, num2: 6.3); //13. Methods V: Parámetros opcionales y con nombre
    }


    //10. Methods II: Void with parameters
    //static void sumaNumeros(int Num1, int Num2)
    //{
    //    Console.WriteLine("La suma es:" + $"La suma es:" + (Num1 + Num2));
    //}

    //11. Methods III: int return type
    //static int sumaNumeros(int Num1, int Num2)
    //{
    //    return Num1 + Num2;
    //}

    //static int sumaNumerosLambda(int Num1, int Num2) => Num1 + Num2; //Si solo tiene una línea de código

    //12. Methods IV: Alcance de métodos, y sobrecarga de métodos
    //static int Suma(int operador1, int operador2) => operador1 + operador2;

    ////SOBRECARGA: Dos o más metodos pero con diferentes tipos de parametros, o número de parametros
    //static int Suma(int num1, double num2) => num1 + (int)num2;

    //static int Suma(int num1, int num2, int num3, int num4) => num1 + num2;

    //13. Methods V: Parámetros opcionales y con nombre
    static double Suma(int num1, double num2, double num3=0)
    {
        return num1 + num2 + num3;
    }

    static double Suma(int num1, double num2)
    {
        return num1 + num2;
    }

}

////EXTRA: He probado a crear varios namespaces en el mismo fichero .cs y he empleado las mejoras en código de C# 10.0
//namespace PrimeraAplicacion
//{
//    internal class Program
//    {
//        public static void Ejecutar() => Console.WriteLine("¡Hola, Mundo desde PrimeraAplicacion!");
//    }
//}

//namespace PrimeraAplicacion2
//{
//    internal class Program2
//    {
//        public static void Ejecutar() => Console.WriteLine("¡Hola, Mundo desde PrimeraAplicacion2!");
//    }
//}

//internal class MainProgram
//{
//    private static void Main()
//    {
//        PrimeraAplicacion.Program.Ejecutar();
//        PrimeraAplicacion2.Program2.Ejecutar();
//    }
//}