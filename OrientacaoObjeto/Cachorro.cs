namespace OrientacaoObjeto
{
    internal class Cachorro: Animal
    {
        public Cachorro(string nome, DateTime dataDeNascimeto, string raça, bool isAmigavel, bool sabeFazerTruques)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimeto;
            Raca = raça;
            IsAmigavel = isAmigavel;
            SabeFazerTruques = sabeFazerTruques;
        }

        public string Raca { get; private set; }

        public bool IsAmigavel { get; set; }

        public bool SabeFazerTruques { get; set; }

        public override void SeComunicar()
        {
            Console.WriteLine($"Au au");
        }

        public void Caminhar()
        {
            Console.WriteLine("Cachorro caminhando...");
        }
        
        public void FazerTruque(string truque)
        {
            Console.WriteLine($"Truque: {truque}");
        }
    }
}
