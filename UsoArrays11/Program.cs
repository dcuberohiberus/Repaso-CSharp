
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
            //Console.WriteLine(edades[3]);

            //-- =======================
            //--  36.Arrays II - Implícitos
            //-- =======================   
            //var datos = new[] {"juan","diaz","españa"};

            var valores = new[] { 15, 25, 32.12, 34, 3, 1, 2, 3 };

            //array de objetos
            Empleados[] arrayEmpleados = new Empleados[3];
            arrayEmpleados[0] = new Empleados("Sara", 33);

            Empleados Ana = new Empleados("Ana", 28);
            arrayEmpleados[1] = Ana;

            Empleados e = new Empleados("Manu", 50);
            arrayEmpleados[2] = e;

            //array de tipos o clases anonimas
            var personas = new[]
            {
                new{Nombre="Pepe", Edad=12},
                new{Nombre="asdasd", Edad=14},
                new{Nombre="ffasfaf", Edad=15},
            };

            //Console.WriteLine(personas[0].Edad);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(valores[i]);
            //}

            //-- =======================
            //--  39. Foreach loop. Arrays IV
            //-- =======================

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.WriteLine(valores[i]);
            //}

            //for (int i = 0; i < arrayEmpleados.Length; i++)
            //{
            //    Console.WriteLine(arrayEmpleados[i].getInfo());

            //}


            foreach (Empleados var in arrayEmpleados)
            {
                Console.WriteLine(var.getInfo());
            }

            foreach (double variable in valores)
            {
                Console.WriteLine(variable);
            }




        }//end:main




        class Empleados
        {
            public string nombre;
            public int edad;
            
            public Empleados(String nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            public String getInfo()
            {
                return "Nombre: " + this.nombre + " - Edad: " + this.edad;
            }


        }


    }
}
