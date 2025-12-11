namespace CondicionalIf
{
    internal class Program
    {
        //private: solo puede ser accedido desde dentro de la misma clase en la que está definido.Es decir, no será accesible desde otras clases, incluso si están en el mismo espacio de nombres.
        //si no defines en Main el access modifier, por defecto es private
        //Public: puede ser accedido desde cualquier parte del código, ya sea dentro de la misma clase, desde otras clases en el mismo espacio de nombres o incluso desde otros ensamblados si la clase es pública.
        //Internal: puede ser accedido desde cualquier parte del mismo ensamblado (proyecto), pero no desde ensamblados externos. Es útil para ocultar detalles de implementación dentro de un ensamblado mientras se permite el acceso a otras clases dentro del mismo ensamblado.
        private static void Main(string[] args)
        {
            //-- =======================
            //--  14,15,16  Contidional If
            //-- =======================
            //#14.1
            //bool haceFrio;
            //haceFrio = true;
            //Console.WriteLine("¿Hace frío? " + !haceFrio);

            //#14.2
            //int edad = 15;
            //Console.WriteLine("Edad: " + edad);
            //if (edad >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad.");
            //}
            //else
            //{
            //    Console.WriteLine("Eres menor de edad.");
            //}

            //#15
            //bool carnet = true;
            //if(carnet == false)
            //{
            //    Console.WriteLine("No puedes conducir.");
            //}

            //if (carnet)
            //    Console.WriteLine("Puedes conducir.");

            //#15.2
            //Console.WriteLine("¿Cuál es tu edad?");
            //int edad = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Edad: " + edad);

            //Console.WriteLine("¿Tienes carnet de conducir? (si/no)");
            //string carnet = Console.ReadLine();

            //if(edad >= 18 && carnet.ToLower() == "si")
            //{
            //    Console.WriteLine("Puedes conducir.");
            //}
            //else
            //{
            //    Console.WriteLine("No puedes conducir.");
            //}

            //#16
            //Console.WriteLine("¿Cuál es tu edad?");
            //int edad = Int32.Parse(Console.ReadLine());
            //string carnet = "no";

            //if(edad >= 18 && carnet.ToLower() == "si")
            //{
            //    Console.WriteLine("Puedes conducir.");
            //}
            //else
            //{
            //    Console.WriteLine("No puedes conducir.");
            //}

            //#16.2
            //if (edad >= 18)
            //{
            //    Console.WriteLine("¿Tienes carnet de conducir? (si/no)");
            //    carnet = Console.ReadLine();

            //    if (edad >= 18 && carnet.ToLower() == "si")
            //    {
            //        Console.WriteLine("Puedes conducir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No puedes conducir, no tienes carnet");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No puedes conducir, eres menor.");
            //}

            //#16.3
            //Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            //Console.WriteLine("Introduce tu edad, por favor");

            //int edad = Int32.Parse(Console.ReadLine());

            //if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");
            //else
            //{
            //    Console.WriteLine("¿Tienes carnet?");

            //    string carnet = Console.ReadLine();

            //    int compara=String.Compare(carnet, "si", true); //Ignora mayusculas y minusculas y si es 0 es que son iguales
            //    if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");
            //    else Console.WriteLine("No puedes conducir vehiculos, no tienes carnet");

            //}

            //#16.4 Nota media alumno
            //Console.WriteLine("Introduce la nota del 1 parcial:");
            //float parcial1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce la nota del 2 parcial:");
            //float parcial2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce la nota del 3 parcial:");
            //float parcial3 = Int32.Parse(Console.ReadLine());

            //if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            //{
            //    float notaMedia = (parcial1 + parcial2 + parcial3) / 3;
            //    Console.WriteLine("La nota media del alumno es: " + Math.Round(notaMedia, 2)); //dos decimales
            //}
            //else
            //{
            //    Console.WriteLine("El alumno ha suspendido.");
            //}

            //#17
            Console.WriteLine("Introduce tu edad:");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres menor de edad");
            else if (edad < 30) Console.WriteLine("Eres joven");
            else if(edad < 60) Console.Write("Eres maduro");
                else Console.WriteLine("Debes cuidarte");


        }//end:main
    }
}