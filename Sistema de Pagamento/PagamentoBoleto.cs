namespace Sistema_de_Pagamento;
internal class PagamentoBoleto : Pagamento
{
    public override void ProcessarPagamento()
    {
        DataPagamento = DateTime.Now;
        Console.WriteLine("Cliente Emissor: Seila da Silva");
        Console.WriteLine("N° do Boleto: NF 1 1/1\n");

        Console.WriteLine("Pagador: Jorge da Silva - CPF: 123.321.123-12");

        Console.WriteLine($"Boleto no valor de R${Valor:F2}");
        Console.WriteLine($"Data de Emissão do Boleto: {DataPagamento:d}");
        Console.WriteLine($"Data vencimento: {DataPagamento.AddDays(3):d}");

        Console.WriteLine("Código do Boleto: 00000.11111.222222 33333.444444 5 66666666666");
    }
}
