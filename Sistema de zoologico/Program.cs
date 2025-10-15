using Sistema_de_zoologico;


Console.WriteLine("Quantos animais deseja adicionar?");
var qtt = int.Parse(Console.ReadLine());


Animal[] animal = new Animal[qtt];
for(int i = 0; i < animal.Length; i++)
{
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
            animal[i] = cachorro;
            break;
        case 2:
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            var gato = new Gato(nome, idade);
            animal[i] = gato;
            break;
        case 3:
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            var leao = new Leao(nome, idade);
            animal[i] = leao;
            break;
    }
}

foreach(var item in animal)
{
    Console.WriteLine(item);
    item.EmitirSom();
    Console.WriteLine();
}