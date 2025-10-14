namespace Classes_abstratas;

public class FuncionarioCLT : Funcionario
{
    public double Bonus { get; private set; }
    
    public void SetBonus(double bonus)
    {
        Bonus = bonus;
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine("Valor do bonus: " + Bonus);
        Console.WriteLine("Salario final: " + CalcularSalarioFinal());
        Console.WriteLine("-----------------------");
    }
}

