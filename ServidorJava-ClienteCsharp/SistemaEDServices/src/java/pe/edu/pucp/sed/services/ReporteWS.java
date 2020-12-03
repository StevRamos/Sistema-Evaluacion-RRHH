package pe.edu.pucp.sed.services;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.servlets.Reporte;

@WebService(serviceName = "ReporteWS")
public class ReporteWS {

    @WebMethod(operationName = "generarReporteEvaluacion")
    public byte[] generarReporteEvaluacion() {
        byte[] arreglo = null;
        try{
            String rutaReporte = Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReporteEvaluacion.jasper")
                    .getPath().replaceAll("%20", " ");
            
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(rutaReporte);
            
            String rutaSubreporte1 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReporObj.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte2 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReporteCriterioPadre.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte3 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReportePotenciales.jasper")
                    .getPath().replaceAll("%20", " ");

            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            HashMap hm = new HashMap();
            hm.put("RUTA_REPOR_OBJ",rutaSubreporte1);
            hm.put("RUTA_SUBREPORTECRIPADRE1",rutaSubreporte2);
            hm.put("RUTA_POTENCIAL",rutaSubreporte3);
            
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
}
