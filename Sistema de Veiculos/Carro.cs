namespace Sistema_de_Veiculos;

public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }
    public void SetNumeroDePortas(int numeroDePortas)
    {
        NumeroDePortas = numeroDePortas;
    }


    public void SetMarca(string marca)
    {
        Marca = marca;
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
        Console.WriteLine($"Numeros de portas: {NumeroDePortas}");
    }
}
