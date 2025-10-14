using System.Text.RegularExpressions;

namespace Conta_Bancaria;
internal class ContaBancaria
{
    private string? _titular;
    private decimal _saldo;

    public void SetTitular(string titular)
    {
        bool ehNumero = titular.All(char.IsDigit);
        while (titular == "")
        {
            Console.WriteLine("Seu nome não pode estar vazio.");
            Console.Write("Qual o nome do titular da conta? ");
            titular = Console.ReadLine() ?? "";
        }
        _titular = titular;
    }

    public void Depositar(decimal valor)
    {
        while(valor <= 1.0m)
        {
            Console.WriteLine("Valor informado é menor que o exigido!");
            Console.WriteLine("\nPara utilizar as funções da conta, precisa fazer um desposito acima de R1,00");
            Console.Write("Digite o valor que vai ser depositado: ");
            valor = decimal.Parse(Console.ReadLine());
        }
        _saldo += valor;
        Extrato();
    }

    public void Sacar(decimal valor)
    {
        while (valor > _saldo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nValor maior que o saldo.");
            Console.ResetColor();

            Console.Write("Digite o valor que vai ser Sacado: ");
            valor = decimal.Parse(Console.ReadLine());

        }
        
            _saldo -= valor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tSaque efetuado.");
            Console.ResetColor();
            Extrato();
        
    }

    public void Extrato()
    {

        Console.WriteLine($"\n| Banco Nubank\t   Agencia: 8888 |");
        Console.WriteLine("| \t\t\t\t |");
        Console.WriteLine("| Titular: " + _titular + "\t |");
        Console.WriteLine("| \t\t\t\t |");
        Console.WriteLine("| Saldo da conta: " + _saldo.ToString("F2") + "\t |");
        Console.WriteLine("| \t\t\t\t |");
        Console.WriteLine(@"|/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\|");
     
    }
}
