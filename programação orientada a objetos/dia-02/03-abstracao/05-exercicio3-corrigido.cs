// 3. Sistema de notificações

using System;

public class App
{
    static void Main()
    {
        INotificador email = new NotificadorEmail();
        INotificador sms = new NotificadorSMS();
        INotificador push = new NotificadorPush();

        string mensagem = "Pedido confirmado!";

        email.EnviarMensagem(mensagem);
        sms.EnviarMensagem(mensagem);
        push.EnviarMensagem(mensagem);
    }
}

public interface INotificador
{
    void EnviarMensagem(string mensagem);
}

public class NotificadorEmail : INotificador
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando E-mail: {mensagem}");
    }
}

public class NotificadorSMS : INotificador
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}

public class NotificadorPush : INotificador
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando Push: {mensagem}");
    }
}
