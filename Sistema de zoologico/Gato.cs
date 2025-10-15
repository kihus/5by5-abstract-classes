namespace Sistema_de_zoologico;

public class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("miau");
    }
}
