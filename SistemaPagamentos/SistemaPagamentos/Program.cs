using SistemaPagamentos.Models;
using SistemaPagamentos.Utils;
using System;

namespace SistemaPagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Menu.ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Informe o número do cartão: ");
                        string numeroCartao = Console.ReadLine();

                        Console.Write("Informe o valor do pagamento: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valorCartao))
                        {
                            var pagamentoCartao = new PagamentoCartao(valorCartao, numeroCartao);
                            pagamentoCartao.ProcessarPagamento();
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case "2":
                        Console.Write("Informe o código de barras: ");
                        string codigoBarras = Console.ReadLine();

                        Console.Write("Informe o valor do pagamento: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valorBoleto))
                        {
                            var pagamentoBoleto = new PagamentoBoleto(valorBoleto, codigoBarras);
                            pagamentoBoleto.ProcessarPagamento();
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;

                    case "3":
                        continuar = false;
                        Console.WriteLine("Encerrando o sistema. Obrigado!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
