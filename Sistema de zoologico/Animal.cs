namespace Sistema_de_zoologico;

public abstract class Animal
{
    private string _nome;
    private int _idade;

    public string GetNome()
    {
        return _nome;
    }

    public int GetIdade()
    {
        return _idade;
    }

    public void SetNome(string nome)
    {
        _nome = nome;
    }

    public void SetIdade(int idade)
    {
        _idade = idade;
    }

    public abstract void EmitirSom();
}

