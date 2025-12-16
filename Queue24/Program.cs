namespace Queue24
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>();

            //rellenar elementos en la cola
            foreach (int x in new int[5] { 1, 3, 4, 5, 6 })
            {
                nums.Enqueue(x);
            }

            //recorrer
            Console.WriteLine("Recorriendo el Queue");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            //eliminando
            nums.Dequeue(); //borra el primero en entrar
            Console.WriteLine("Eliminando elemento | Dequeue......................");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            //Clear
            nums.Clear();
            Console.WriteLine("Eliminando | CLEAR......................");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }//end:main
    }//end:program
}