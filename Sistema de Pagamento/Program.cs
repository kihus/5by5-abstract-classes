using Sistema_de_Pagamento;

Console.Write("Deseja efetuar o pagamento via Boleto ou Cartao de crédito? (1 - Boleto | 2 - Cartao de crédito) ");
var resp = char.Parse(Console.ReadLine());

if(resp == '1')
{
    Pagamento pagamento2 = new PagamentoBoleto();

    Console.Write("Qual o valor? ");
    var valor = double.Parse(Console.ReadLine());
    pagamento2.Valor = valor;
    pagamento2.ProcessarPagamento();
}
if(resp == '2')
{
    Console.Write("Qual o valor? ");
    var valor = double.Parse(Console.ReadLine());

    Pagamento pagamento = new PagamentoCartaoCredito();
    pagamento.Valor = valor;
    pagamento.ProcessarPagamento();
}

