namespace Sistema_de_zoologico;

public class Leao : Animal
{
    public Leao(string nome, int idade) : base(nome, idade)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("rugido");
    }
}
