
namespace Stack25
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>();

            //rellenar elementos en la cola
            foreach (int x in new int[5] { 1, 3, 4, 5, 6 })
            {
                nums.Push(x);
            }

            //recorrer
            Console.WriteLine("Recorriendo el Stack");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            //eliminando
            nums.Pop(); //borra el primero en entrar
            Console.WriteLine("Eliminando elemento | Stack......................");
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
