namespace MeuPrimeiroProjetoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Meu nome é Mikael");

            int idade = 17;
            string nome = "Mikael";
            string sobrenome = "Paim";
            bool ehProfessor = false;
            double altura = 1.70;

            //Console.WriteLine($"Meu nome é {nome} {sobrenome}.");
            //Console.WriteLine($"Tenho {idade} anos de idade.");
            //Console.WriteLine($"Sou professor: {ehProfessor}");
            //Console.WriteLine($"Tenho {altura} de altura");

            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);
            Console.WriteLine($"meu nome é {nomeCompleto}");
        }

        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static void ExibirSeEhProfessorEAltura(bool ehProfessor, double altura)
        {
            Console.WriteLine($"Sou professor: {ehProfessor}");
            Console.WriteLine($"Tenho {altura} de altura");
        }
    }
}
