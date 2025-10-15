using Sistema_de_zoologico;

Console.Write("Qual animal deseja adicionar? (1 - cachorro | 2 - gato | 3 - leao) ");
var resp = int.Parse(Console.ReadLine());

switch (resp)
{
    case 1:

        Console.Write("Nome: ");
        var nome = Console.ReadLine();

        Console.Write("Idade: ");
        var idade = int.Parse(Console.ReadLine());

        var cachorro = new Cachorro(nome, idade);
        Console.WriteLine(nome);
        cachorro.EmitirSom();
        break;
    case 2:
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine(idade);
        var gato = new Gato(nome, idade);
        gato.EmitirSom();
        break;
    case 3:
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        var leao = new Leao(nome, idade);
        Console.WriteLine(leao);
        leao.EmitirSom();
        break;
}