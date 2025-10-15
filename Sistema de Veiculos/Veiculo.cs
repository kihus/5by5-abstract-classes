using System.Globalization;

namespace Sistema_de_Veiculos;

public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public DateTime Ano { get; set; }

    public static void CadastrarVeiculo(char resposta)
    {
        switch (resposta)
        {
            case '1':
                var moto = new Moto();

                Console.Write("Escreva a marca da moto: ");
                moto.SetMarca(Console.ReadLine() ?? "");

                Console.Write("Escreva o modelo da moto: ");
                moto.SetModelo(Console.ReadLine() ?? "");

                Console.Write("Escreva o ano da moto: (yyyy) ");
                moto.SetAno(DateTime.ParseExact(Console.ReadLine() ?? "", "yyyy", CultureInfo.InvariantCulture));

                Console.Write("Escreva a cilindrada da moto: ");
                moto.SetCilindrada(int.Parse(Console.ReadLine() ?? ""));

                moto.ExibirInformacoes();
                break;

            case '2':
                var carro = new Carro();

                Console.Write("Escreva a marca do carro: ");
                carro.SetMarca(Console.ReadLine() ?? "");

                Console.Write("Escreva o modelo do carro: ");
                carro.SetModelo(Console.ReadLine() ?? "");

                Console.Write("Escreva o ano do carro: (yyyy) ");
                carro.SetAno(DateTime.ParseExact(Console.ReadLine() ?? "", "yyyy", CultureInfo.InvariantCulture));

                Console.Write("Escreva o numero de portas do carro: ");
                carro.SetNumeroDePortas(int.Parse(Console.ReadLine() ?? ""));

                carro.ExibirInformacoes();
                break;

            case '3':
                var caminhao = new Caminhao();

                Console.Write("Escreva a marca do caminhao: ");
                caminhao.SetMarca(Console.ReadLine() ?? "");

                Console.Write("Escreva o modelo do caminhao: ");
                caminhao.SetModelo(Console.ReadLine() ?? "");

                Console.Write("Escreva o ano do caminhao: (yyyy) ");
                caminhao.SetAno(DateTime.ParseExact(Console.ReadLine() ?? "", "yyyy", CultureInfo.InvariantCulture));

                Console.Write("Escreva a capacidade de carga do caminhao: ");
                caminhao.SetCapacidadeDeCarga(double.Parse(Console.ReadLine() ?? ""));

                caminhao.ExibirInformacoes();
                break;

            default:
                break;
        }

    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano de fabricação: {Ano.Year}");
    }
}
