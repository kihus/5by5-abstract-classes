namespace Sistema_de_zoologico;

public abstract class Animal
{
    private string _nome;
    private int _idade;


    protected Animal(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }
    public string GetNome()
    {
        return _nome;
    }

    public int GetIdade()
    {
        return _idade;
    }

    public abstract void EmitirSom();

    public override string ToString()
    {
        return $"Nome: {_nome}, Idade: {_idade}";
    }
}

