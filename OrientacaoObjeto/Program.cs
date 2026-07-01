namespace OrientacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pessoa1 = new Pessoa("Mikael", new DateTime(2008, 9, 22), 1.70, "05286359051", true);

            //Console.WriteLine("Informações da pessoa 1");
            //Console.WriteLine($"Nome {pessoa1.Nome}");
            //Console.WriteLine($"Data de Nascimento {pessoa1.DataDeNascimento}");
            //Console.WriteLine($"Altura {pessoa1.Altura}");
            //Console.WriteLine($"Cpf {pessoa1.Cpf}");
            //Console.WriteLine($"Está Ativo {pessoa1.IsAtivo}");

            //pessoa1.Email = "novoemail@email.com";

            //pessoa1.SeComunicar();
            //pessoa1.SeAlimentar();

            //Pessoa pessoa2 = new Pessoa("Douglas", new DateTime(1996, 11, 20), 1.77, "03890096031", true);

            //Console.WriteLine("Informações da pessoa 2");
            //Console.WriteLine($"Nome {pessoa2.Nome}");
            //Console.WriteLine($"Data de Nascimento {pessoa2.DataDeNascimento}");
            //Console.WriteLine($"Altura {pessoa2.Altura}");
            //Console.WriteLine($"Cpf {pessoa2.Cpf}");
            //Console.WriteLine($"Está Ativo {pessoa2.IsAtivo}");

            //pessoa2.SeComunicar();

            

            Console.WriteLine("");
            Animal pessoa = new Pessoa("Mika", DateTime.Now, 175, "cpf", true);
            Animal cachorro = new Cachorro("Lico", DateTime.Now, "raça", true);

            var Lista = new List<Animal> { pessoa, cachorro };

            foreach
            
        }
    }
}
