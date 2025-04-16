# Sistema de Processamento de Pagamentos (Console App)

Este projeto em C# simula um sistema de pagamentos simples via console, onde o usuário pode escolher entre duas formas de pagamento: **Cartão** ou **Boleto**.

## Funcionalidades

- Exibição de um menu com três opções:
  - 1 - Pagamento com Cartão
  - 2 - Pagamento com Boleto
  - 3 - Sair
- Solicita informações específicas dependendo do tipo de pagamento:
  - Número do Cartão
  - Código de Barras do Boleto
- Solicita o valor do pagamento.
- Processa o pagamento e exibe um resumo com a data atual.
- Permanece em loop até que o usuário escolha a opção de sair.

## Estrutura de Pastas

SistemaPagamentos/ ├── Models/ │ ├── Pagamento.cs │ ├── PagamentoCartao.cs │ └── PagamentoBoleto.cs ├── Utils/ │ └── Menu.cs ├── Program.cs ├── README.md

markdown
Copiar
Editar

## Como Executar

1. Abra o projeto no Visual Studio ou VS Code.
2. Compile e execute o projeto.
3. Siga as instruções no console.

## Exemplo de Saída

***** Sistema de Processamento de Pagamentos ***** ********** Escolha a forma de pagamento ********** 1 - Cartão 2 - Boleto 3 - Sair Escolha uma opção: 1 Informe o número do cartão: 1234-5678-9012-3456 Informe o valor do pagamento: 150.50 Processando pagamento de R$ 150,50 via Cartão (Número: 1234-5678-9012-3456) na data 15/04/2025.