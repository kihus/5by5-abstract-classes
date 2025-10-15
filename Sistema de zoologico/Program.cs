using Sistema_de_zoologico;

Console.Write("Qual animal deseja adicionar? (1 - cachorro | 2 - gato | 3 - leao) ");
var resp = int.Parse(Console.ReadLine());

switch (resp)
{
    case 1:
        var cachorro = new Cachorro();

        Console.WriteLine("Nome: ");
        cachorro.SetNome(Console.ReadLine());

        Console.WriteLine("Idade: ");
        cachorro.SetIdade(int.Parse(Console.ReadLine()));
        cachorro.EmitirSom();
        break;
    case 2:
        var gato = new Cachorro();

        Console.WriteLine("Nome: ");
        gato.SetNome(Console.ReadLine());

        Console.WriteLine("Idade: ");
        gato.SetIdade(int.Parse(Console.ReadLine()));
        gato.EmitirSom();
        break;
    case 3:
        var leao = new Cachorro();

        Console.WriteLine("Nome: ");
        leao.SetNome(Console.ReadLine());

        Console.WriteLine("Idade: ");
        leao.SetIdade(int.Parse(Console.ReadLine()));
        leao.EmitirSom();
        break;
}