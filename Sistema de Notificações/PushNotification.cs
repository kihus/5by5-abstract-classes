namespace Sistema_de_Notificações;

public class PushNotification : Notificacao
{
    public override void Enviar(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.Enviar(msg);
        Console.WriteLine("Mensagem enviada!");
        Console.ResetColor();
    }
}
