namespace Sistema_de_Veiculos;

public class Moto : Veiculo
{
    public int Cilindrada { get; set; }

    public void SetMarca(string marca)
    {
        Marca = marca;
    }

    public void SetCilindrada(int cilindrada)
    {
        Cilindrada = cilindrada;
    }

    public void SetModelo(string modelo)
    {
        Modelo = modelo;
    }

    public void SetAno(DateTime ano)
    {
        Ano = ano;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Cilindrada da moto: {Cilindrada}");
    }
}
