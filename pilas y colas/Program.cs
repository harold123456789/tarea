namespace pilaycola
{
    class pilasycolas
    {
        static void Main(string[] args)
        {
            Queue<string> Colas = new Queue<string>();
            
            Colas.Enqueue("-------Tarea Pilas y colas-------");
            Colas.Enqueue("Harold");
            Colas.Enqueue("Isaac");
            Colas.Enqueue("Avila");
            Colas.Enqueue("Mendez");
            while (Colas.Count >0)
            {
                Console.WriteLine(Colas.Dequeue());

            }
            Stack<string> pilas = new Stack<string>();

            pilas.Push("1");
            pilas.Push("2");
            pilas.Push("3");
            pilas.Push("4");
            pilas.Push("5");
        }
    }
}    
    