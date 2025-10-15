namespace Sistema_de_Notificações;

public class Sms : Notificacao
{
    public override void Enviar(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Mensagem para você!");
        base.Enviar(msg);
        Console.WriteLine("Não responda essa mensagem");
        Console.ResetColor();
    }
}
