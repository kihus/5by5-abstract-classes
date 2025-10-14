using Conta_Bancaria;
using System.Drawing;

var contaBanc = new ContaBancaria();
var resposta = "";

Console.Write("Qual o nome do titular da conta? ");
contaBanc.SetTitular(Console.ReadLine() ?? "");

Console.WriteLine("\nPara utilizar as funções da conta, precisa fazer um desposito acima de R$1,00");

Console.Write("Digite o valor que vai ser depositado: ");
contaBanc.Depositar(decimal.Parse(Console.ReadLine()));

do
{
    Console.Write("\nDeseja fazer um saque ou um deposito? (1 - saque | 2 - deposito) ");
    var opcao = char.Parse(Console.ReadLine());

    while (opcao != '1' && opcao != '2')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nErro. Digite corretamente!\n");
        Console.ResetColor();

        Console.Write("Deseja fazer um saque ou um deposito? (1 - saque | 2 - deposito) ");
        opcao = char.Parse(Console.ReadLine());
    }

    if (opcao == '1')
    {
        Console.Write("Digite o valor que vai ser Sacado: ");
        contaBanc.Sacar(decimal.Parse(Console.ReadLine()));
    }
    else
    {
        Console.Write("Digite o valor que vai ser depositado: ");
        contaBanc.Depositar(decimal.Parse(Console.ReadLine()));
    }

    Console.Clear();
    contaBanc.Extrato();
    Console.Write("\nDeseja depositar ou fazer um saque novamente? (s/n) ");
    resposta = Console.ReadLine();
} while (resposta == "s");

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Obrigado por utilizar nossos serviços. Volte sempre!");
Console.ResetColor();



