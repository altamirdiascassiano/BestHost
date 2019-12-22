using System;
using System.Net;
using System.Net.Mail;

namespace WebEnvironment.Helper
{
    public static class LogEmailHelper
    {

        public static void LogMail(Exception ex)
        {
            var to = "@gmail.com";
            var from = "@gmail.com";
            var message = new MailMessage(from, to);
            message.Subject = "Ei teve algo de errado com o BestHost :/ ";
            var body= string.Format("<div><div><h2><strong>Olá!</h2><h3>O sistema BestHost teve um comportamento anormal e lançou a exeção abaixo:</strong><h3><br><div><br/> <em>Message: {0} <br/>InnerException: {1}<br/> StackTrace: {2}<br/></em><br><div>",ex.Message,ex.InnerException,ex.StackTrace);
            message.IsBodyHtml = true;
            message.Body = body;
            var client = new SmtpClient("smtp.gmail.com",587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = new NetworkCredential("@gmail.com", "");

            try
            {
                client.Send(message);
            }
            catch (Exception ex02)
            {
                LogFileSystemHelper.LogFile("Ocorreu falha no envio do Log por email e gravamos ele aqui.", ex02);
            }
        }
    }
}
