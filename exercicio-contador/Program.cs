namespace exercicio_contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- For --");
            for (int i = 1; i <= 10; i++) 
            {
                double raiz = Math.Sqrt(i); 

                Console.WriteLine($"Número {i} | Raiz: {raiz:F2}");
            }
        }
    }
}
