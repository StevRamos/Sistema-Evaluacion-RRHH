package pe.edu.pucp.sed.correo;

import java.io.File;
import java.util.Properties;
import javax.activation.DataHandler;
import javax.activation.FileDataSource;

import javax.mail.BodyPart;
import javax.mail.Message;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeBodyPart;
import javax.mail.internet.MimeMessage;
import javax.mail.internet.MimeMultipart;

public class Correo {
    public static int enviarCorreo( String correo, String titulo,
            String cuerpo, File reporte){
        
        int resultado = 0;
        
        try{

            Properties props = new Properties();
            props.put("mail.smtp.host", "smtp.gmail.com");
            props.setProperty("mail.smtp.starttls.enable", "true");
            props.setProperty("mail.smtp.port", "587");
            props.setProperty("mail.smtp.user", "Sistema de Evaluación");
            props.setProperty("mail.smtp.auth", "true");
            props.setProperty("mail.smtp.ssl.trust", "smtp.gmail.com");
            
            Session session = Session.getDefaultInstance(props, null);
//            session.setDebug(true);

            BodyPart texto = new MimeBodyPart();
            texto.setText(cuerpo);

            BodyPart adjunto = new MimeBodyPart();
            adjunto.setDataHandler(
                new DataHandler(new FileDataSource(reporte.getPath().
                        replaceAll("%20", " "))));
            adjunto.setFileName("Reporte de Evaluacion.pdf");
            
            MimeMultipart multiParte = new MimeMultipart();
            multiParte.addBodyPart(texto);
            multiParte.addBodyPart(adjunto);
            
            MimeMessage message = new MimeMessage(session);
            message.setFrom(new InternetAddress("proyectopucp2020@gmail.com"));

            message.addRecipient(
                Message.RecipientType.TO,
                new InternetAddress(correo));
            message.setSubject(titulo);
            message.setContent(multiParte);

            Transport t = session.getTransport("smtp");
            t.connect("proyectopucp2020@gmail.com", "sistemaEvaluacion2020");
            t.sendMessage(message, message.getAllRecipients());
            t.close();
            resultado = 1;
        }
        catch (Exception e){
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
}
