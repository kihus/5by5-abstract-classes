namespace Classes_abstratas;

public abstract class Funcionario
{
    public string? Nome { get; private set; }
    public double SalarioBase{ get; private set; }

    public void SetNome(string nome)
    {
        Nome = nome;
    }
    public void SetSalarioBase(double salarioBase)
    {
        SalarioBase = salarioBase;
    }

    public static void  AddFun(int qttFun, Funcionario[] funcionario)
    {
        for (int i = 0; i < funcionario.Length; i++)
        {
            Console.Write("\nCLT OU PJ? ");
            var tipoFun = Console.ReadLine().ToLower();
            if (tipoFun == "clt")
            {
                var fun = new FuncionarioCLT();
                Console.Write("\nQual o nome do funcionario CLT? ");
                fun.SetNome(Console.ReadLine());

                Console.Write("Qual o salario base? ");
                fun.SetSalarioBase(double.Parse(Console.ReadLine()));

                Console.Write("Qual é o bonus? ");
                fun.SetBonus(double.Parse(Console.ReadLine()));

                funcionario[i] = fun;
            }
            else if (tipoFun == "pj")
            {
                var fun = new FuncionarioPJ();
                Console.Write("\nNome do funcionario Pj: ");
                fun.SetNome(Console.ReadLine());

                Console.Write("Quantas horas trabalhadas? ");
                fun.SetHorasTrabalhadas(int.Parse(Console.ReadLine()));

                Console.Write("Qual o valor das horas trabalhadas? ");
                fun.SetValorHora(double.Parse(Console.ReadLine()));

                funcionario[i] = fun;
            }
            else
            {
                Console.WriteLine("errou kk");
            }

        }
    }

    public abstract double CalcularSalarioFinal();
    public virtual void ExibirInfo()
    {
        Console.WriteLine($"\n\nNome: " + Nome);
        Console.WriteLine($"Salario base: " + SalarioBase);
    }
}
