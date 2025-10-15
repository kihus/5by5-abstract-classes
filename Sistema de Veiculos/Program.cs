using Sistema_de_Veiculos;
using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Deseja fazer o cadastro de qual veiculo? (1 - moto | 2 - carro | 3 - caminhao) ");
var resposta = char.Parse(Console.ReadLine());

while (resposta != '1' && resposta != '2' && resposta != '3')
{
    Console.WriteLine("vc escreveu errado\n");
    Console.WriteLine("Deseja fazer o cadastro de qual veiculo? (1 - moto | 2 - carro | 3 - caminhao) ");
    resposta = char.Parse(Console.ReadLine());
}

Console.Clear();

Veiculo.CadastrarVeiculo(resposta);

