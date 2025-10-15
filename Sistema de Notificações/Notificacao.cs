using System.Globalization;

namespace Sistema_de_Notificações;

public abstract class Notificacao
{

    public static void CadastrarVeiculo(char resposta, Notificacao[] notificacao, int posicao)
    {
       

    }

    public virtual void Enviar(string msg)
    {
        Console.WriteLine("Messagem: " + msg);
    }
}
