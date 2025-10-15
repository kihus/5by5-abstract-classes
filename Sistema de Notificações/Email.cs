namespace Sistema_de_Notificações;

public class Email : Notificacao
{
    
    public override void Enviar(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Email para <bruno.silva@gmail.com>");
        base.Enviar(msg);
        Console.WriteLine($"\nData de hoje: {DateTime.Now}");
        Console.ResetColor();
    }
}
