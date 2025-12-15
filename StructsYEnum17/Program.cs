namespace StructsYEnum17
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Empleado empleado1 = new Empleado(1200, 250);
            empleado1.cambiaSalario(empleado1, 100);

            Console.WriteLine(empleado1);
        }//end:main

        //Clases: Empleado se almacena en HEAP. y empleado1 referencia en el STACK que apunta al HEAP.
        //Si hago cambios en empleado1 se ven reflejeados en el HEAP
        //HEAP: Disponibles durante toda la ejcución: Variables super, objetos, 
        //Struct. No se verán reflejados los cambios en la estructura de Empleado en HEAP, se quedan en la copia de empleado1 del STACK.
        //STACK: LIFO:Numeros complejos, puntos tridimimensionales, instancias que no cambien.
        //public class Empleado
        public struct Empleado
        {
            public double salarioBase, comision;

            public Empleado(int salarioBase, int comision)
            {
                this.salarioBase = salarioBase;
                this.comision = comision;
            }

            public override string ToString()
            {
                return string.Format("Salario y comisión del empleado ({0},{1})", this.salarioBase, this.comision);
            }

            public void cambiaSalario(Empleado emp, double incremento)
            {
                emp.salarioBase += incremento;
                emp.comision += incremento;
            }
        }
    }//end:program
}