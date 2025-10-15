namespace Sistema_de_Veiculos;

public class Caminhao : Veiculo
{
    public double CapacidadeDeCarga { get; set; }

    public void SetCapacidadeDeCarga(double capacidadeDeCarga)
    {
        CapacidadeDeCarga = capacidadeDeCarga;
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
        Console.WriteLine($"Capacidade de carga: {CapacidadeDeCarga}");
    }
}
