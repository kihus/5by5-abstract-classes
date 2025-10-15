namespace Sistema_de_zoologico;

public class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade)
    {
        
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Au au");
    }
}
