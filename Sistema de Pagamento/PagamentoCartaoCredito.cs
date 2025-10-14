namespace Sistema_de_Pagamento;
internal class PagamentoCartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        int parcela;
        switch (Valor)
        {
            case >= 1000:
                Console.WriteLine($"1 parcela = R${Valor:F2}");
                Console.WriteLine($"2 parcelas = R${(Valor / 2):F2}");
                Console.WriteLine($"3 parcelas = R${(Valor / 3):F2}");
                Console.WriteLine($"4 parcelas = R${(Valor / 4):F2}");
                Console.WriteLine($"5 parcelas = R${(Valor / 5):F2}");
                Console.WriteLine($"6 parcelas = R${(Valor / 6):F2}");
                Console.WriteLine($"7 parcelas = R${(Valor / 7):F2}");
                Console.WriteLine($"8 parcelas = R${(Valor / 8):F2}");
                Console.WriteLine($"9 parcelas = R${(Valor / 9):F2}");
                Console.WriteLine($"10 parcelas = R${(Valor / 10):F2}");
                Console.WriteLine($"11 parcelas = R${((Valor / 11) + (Valor * 0.23)):F2} com juros*");
                Console.WriteLine($"12 parcelas = R${((Valor / 12) + (Valor * 0.23)):F2} com juros*");

                Console.Write("Quantas vezes deseja parcelar o pagamento? ");
                parcela = int.Parse(Console.ReadLine()!);

                Console.WriteLine("\nPagamento em " + parcela + " parcela(as)");
                break;
            case >= 800:
                Console.WriteLine($"1 parcela = R${Valor:F2}");
                Console.WriteLine($"2 parcelas = R${(Valor / 2):F2}");
                Console.WriteLine($"3 parcelas = R${(Valor / 3):F2}");
                Console.WriteLine($"4 parcelas = R${(Valor / 4):F2}");
                Console.WriteLine($"5 parcelas = R${(Valor / 5):F2}");
                Console.WriteLine($"6 parcelas = R${(Valor / 6):F2}");
                Console.WriteLine($"7 parcelas = R${(Valor / 7):F2}");
                Console.WriteLine($"8 parcelas = R${(Valor / 8):F2}");
                Console.WriteLine($"9 parcelas = R${(Valor / 9):F2}");
                Console.WriteLine($"10 parcelas = R${(Valor / 10):F2}");

                Console.Write("Quantas vezes deseja parcelar o pagamento? ");
                parcela = int.Parse(Console.ReadLine()!);

                Console.WriteLine("\nPagamento em " + parcela + " parcela(as)");
                break;
            case >= 500:
                Console.WriteLine($"1 parcela = R${Valor:F2}");
                Console.WriteLine($"2 parcelas = R${(Valor / 2):F2}");
                Console.WriteLine($"3 parcelas = R${(Valor / 3):F2}");
                Console.WriteLine($"4 parcelas = R${(Valor / 4):F2}");
                Console.WriteLine($"5 parcelas = R${(Valor / 5):F2}");
                Console.WriteLine($"6 parcelas = R${(Valor / 6):F2}");

                Console.Write("Quantas vezes deseja parcelar o pagamento? ");
                parcela = int.Parse(Console.ReadLine()!);

                Console.WriteLine("\nPagamento em " + parcela + " parcela(as)");
                break;
            case >= 100:
                Console.WriteLine($"1 parcela = R${Valor:F2}");
                Console.WriteLine($"2 parcelas = R${(Valor / 2):F2}");
                Console.WriteLine($"3 parcelas = R${(Valor / 3):F2}");

                Console.Write("Quantas parcelas deseja efetuar o pagamento? ");
                parcela = int.Parse(Console.ReadLine()!);

                Console.WriteLine("\nPagamento em " + parcela + " parcela(as)");
                break;
            case <= 99.99:
                Console.WriteLine("Sem parcelas");
                break;
            default:
                Console.WriteLine("Valor fora dos padrões");
                break;
        }
        DataPagamento = DateTime.Now;
        Console.WriteLine($"\nPagamento efetuado no cartão 5192 62** **** ****\nData do Pagamento: {DataPagamento}");

    }
}
