namespace ColeccionesLinkedList23
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int n in new int[] { 10, 3, 3, 12, 3, 0 })
            {
                numeros.AddFirst(n);
            }

            //foreach (var n in numeros)
            //{
            //    Console.WriteLine(n);
            //}


            //numeros.Remove(12);
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(177);
            numeros.AddFirst(nodoImportante);

            for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }



        }//end:main
    }//end:program
}