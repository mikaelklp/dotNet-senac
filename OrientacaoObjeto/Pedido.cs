using OrientacaoObjeto;

namespace OrientacaoObjeto
{
    public class Pedido
    {

        public Pedido(string cliente, string produto, double valorTotal, DateTime dataDoServico, bool isPago)
        { 
            Cliente = cliente;
            Produto = produto;
            ValorTotal = valorTotal;
            DataDoServico = dataDoServico;
            IsPago = isPago;
        }

        public string Cliente { get; set; }

        public string Produto { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataDoServico { get; set; }

        public bool IsPago { get; set; }
    }
}