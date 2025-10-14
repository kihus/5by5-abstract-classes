namespace Sistema_de_Pagamento;
abstract class Pagamento
{
    public double Valor { get; set; }
    public DateTime DataPagamento { get; set; }

    public abstract void ProcessarPagamento();
}
