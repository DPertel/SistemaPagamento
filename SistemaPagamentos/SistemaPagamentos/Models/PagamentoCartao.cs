namespace SistemaPagamentos.Models
{
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(decimal valor, string numeroCartao)
            : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento de R$ {Valor:F2} via Cartão (Número: {NumeroCartao}) na data {DataPagamento:dd/MM/yyyy}.");
        }
    }
}
