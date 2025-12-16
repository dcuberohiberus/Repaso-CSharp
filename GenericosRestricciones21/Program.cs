namespace GenericosRestricciones21
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //-- =======================
            //--  62. Generics III
            //-- =======================

            //AlmacenEmpleados<Director> empleadosDirector = new AlmacenEmpleados<Director>(3);
            //empleadosDirector.agregar(new Director(3000));
            //empleadosDirector.agregar(new Director(4000));
            //empleadosDirector.agregar(new Director(4500));

            AlmacenEmpleados<Secretaria> empleadosSecretaria = new AlmacenEmpleados<Secretaria>(3);
            empleadosSecretaria.agregar(new Secretaria(3000));
            empleadosSecretaria.agregar(new Secretaria(4000));
            empleadosSecretaria.agregar(new Secretaria(4500));

            //AlmacenEmpleados<Estudiante> empleadosDirector = new AlmacenEmpleados<Estudiante>(3);
            //empleadosDirector.agregar(new Estudiante(3000));
            //empleadosDirector.agregar(new Estudiante(4000));
            //empleadosDirector.agregar(new Estudiante(4500));
        }//end:main

        private class AlmacenEmpleados<T> where T : IParaEmpleados // Restricción=> Para instanciar la clase T debe implementar la interfaz
        {
            private int i = 0;
            private T[] datosEmpleado;

            //private int num = 0;
            //private int nuasdadasdasdasdam = 0;

            public AlmacenEmpleados(int z)
            {
                datosEmpleado = new T[z];
            }

            public void agregar(T obj)
            {
                datosEmpleado[i] = obj;
                i++;
            }

            public T getEmpleado(int i)
            {
                return datosEmpleado[i];
            }
        }

        private class Director : IParaEmpleados
        {
            private double salario;

            public Director(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario;
            }
        }

        private class Secretaria : IParaEmpleados
        {
            private double salario;

            public Secretaria(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario;
            }
        }

        private class Electricista : IParaEmpleados
        {
            private double salario;

            public Electricista(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario;
            }
        }

        private class Estudiante
        {
            private double edad;

            public Estudiante(double edad)
            {
                this.edad = edad;
            }

            public double getEdad()
            {
                return edad;
            }
        }

        private interface IParaEmpleados
        {
            double getSalario();
        }
    }
}