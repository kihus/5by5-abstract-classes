namespace Classes_abstratas;

public class FuncionarioPJ : Funcionario
{
    public int HorasTrabalhadas { get; private set; }
    public double ValorHora { get; private set; }

    public void SetHorasTrabalhadas(int horasTrabalhadas)
    {
        HorasTrabalhadas = horasTrabalhadas;
    }
    public void SetValorHora(double valorHora)
    {
        ValorHora = valorHora;
    }

    public override double CalcularSalarioFinal()
    {
        return HorasTrabalhadas * ValorHora;
    }
    public override void ExibirInfo()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Horas trabalhadas: " + HorasTrabalhadas);
        Console.WriteLine("Valor hora: " + ValorHora);
        Console.WriteLine("Salario final: " + CalcularSalarioFinal());
        Console.WriteLine("-----------------------");
    }

}
