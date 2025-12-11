
namespace UsoArrays11
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //-- =======================
            //--  37. Arrays I
            //-- =======================            
            //int[] edades;
            //edades = new int[4];
            //edades[0] = 1;
            //edades[1] = 4;
            //edades[2] = 8;
            //edades[3] = 22;

            int[] edades = { 15, 32, 132, 2 };
            //int[] edades = new int[5] { 15, 32, 132, 2, 3134 };
            Console.WriteLine(edades[3]);

            //-- =======================
            //--  36.Arrays II - Implícitos
            //-- =======================   
            //var datos = new[] {"juan","diaz","españa"};

            var valores = new[] { 15, 25, 32.12, 34 };

            //array de objetos
            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Sara", 33);

            Empleados Ana = new Empleados("Ana", 28);
            arrayEmpleados[1] = Ana;


            //array de tipos o clases anonimas
            var personas = new[]
            {
                new{Nombre="Pepe", Edad=12},
                new{Nombre="asdasd", Edad=14},
                new{Nombre="ffasfaf", Edad=15},
            };

            Console.WriteLine(personas[0].Edad);


        }//end:ckass

        class Empleados
        {
            string nombre;
            int edad;
            
            public Empleados(String nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
        }
    }
}
