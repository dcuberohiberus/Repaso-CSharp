namespace PropiedadesAcceso16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");

            Juan.SALARIO = 1200;
            Juan.SALARIO -= 2000;
            Console.WriteLine($"Valor del salario: {Juan.SALARIO}");
        }

        private class Empleado
        {

            //-- =======================
            //--  55. Properties I
            //-- =======================
            private double evaluaSalario(double salario)
            {
                if (salario < 0)
                {
                    return 0;
                }
                else
                {
                    return salario;
                }
            }

            ////Creación de propiedad
            //public double SALARIO
            //{
            //    get { return this.salario; }

            //    set { this.salario = evaluaSalario(value); }
            //}

            public double SALARIO
            {
                get => this._salario;
                set => this._salario = evaluaSalario(value);
            }

            private double _salario;
            private string _nombre;

            private int numero1 = 10;
            private int numero2 = 20;

            public Empleado(string nombre)
            {
                this._nombre = nombre;
            }

            //public void setSalario(double salario)
            //{
            //    if (salario < 0)
            //    {
            //        Console.WriteLine("El salario no puede ser negativo. Se asignará 0 como salario");
            //        this.salario = 0;
            //    }
            //    else
            //    {
            //        this.salario = salario;
            //    }
            //}

            //public double getSalario()
            //{
            //    return salario;
            //}
        }//end:empleado
    }
}//end:program