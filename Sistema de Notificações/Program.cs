using Sistema_de_Notificações;
using System.Globalization;

Console.WriteLine("Quantas msg deseja enviar? ");
var qtt = int.Parse(Console.ReadLine() ?? "");

for(int i = 0; i < qtt; i++)
{
    Console.Write("Deseja enviar a msg via: (1 - email | 2 - sms | 3 - enviar notificao) ");
    var resposta = int.Parse(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            Console.Write("Escreva o email: ");
            var msg = Console.ReadLine() ?? "";

            var email = new Email();
            email.Enviar(msg);
            break;

        case 2:
            Console.Write("Escreva o sms: ");
            msg = Console.ReadLine() ?? "";

            var sms = new Sms();
            sms.Enviar(msg);
            break;

        case 3:
            Console.Write("Escreva a mensagem que vai ser enviada: ");
            msg = Console.ReadLine() ?? "";

            var enviarNotif= new PushNotification();
            enviarNotif.Enviar(msg);
            break;

        default:
            break;
    }
}
