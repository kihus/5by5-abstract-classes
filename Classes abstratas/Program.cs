using Classes_abstratas;

try
{
    Console.Write("Quantos funcinoarios deseja colocar? ");
    var qttFun = int.Parse(Console.ReadLine());

    var funcionario = new Funcionario[qttFun];



    Funcionario.AddFun(qttFun, funcionario);

    Console.Clear();

    for (int i = 0; i < funcionario.Length; i++)
    {
        funcionario[i].ExibirInfo();
    }

}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

