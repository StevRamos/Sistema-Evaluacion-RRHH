using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;


namespace SistemaEDInterfaces
{
    public static class Correo
    {
        public static int enviarCorreo(string correo, string titulo, string cuerpo)
        {
            int resultado = 0; 
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(correo);
            msg.From = new MailAddress("proyectopucp2020@gmail.com", "Sistema de Evaluación", System.Text.Encoding.UTF8);
            msg.Subject = titulo;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = cuerpo;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("proyectopucp2020@gmail.com", "sistemaEvaluacion2020");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail
            try
            {
                client.Send(msg);
                resultado = 1; 
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return resultado; 
        }
    }
}
