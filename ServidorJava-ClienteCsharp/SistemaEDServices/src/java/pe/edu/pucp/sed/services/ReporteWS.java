package pe.edu.pucp.sed.services;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStream;
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
import pe.edu.pucp.sed.correo.Correo;
import pe.edu.pucp.sed.model.Colaborador;
import pe.edu.pucp.sed.servlets.Reporte;

@WebService(serviceName = "ReporteWS")
public class ReporteWS {

    @WebMethod(operationName = "generarReporteEvaluacion")
    public byte[] generarReporteEvaluacion( @WebParam(name = "idJefe") int idJefe ) {
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
            
            String rutaSubreporte4 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReporSubCom.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte5 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/Reportesubpotencial.jasper")
                    .getPath().replaceAll("%20", " ");
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            HashMap hm = new HashMap();
            hm.put("RUTA_REPOR_OBJ",rutaSubreporte1);
            hm.put("RUTA_SUBREPORTECRIPADRE1",rutaSubreporte2);
            hm.put("RUTA_POTENCIAL",rutaSubreporte3);
            hm.put("RUTA_SUB_COM_PADRE ",rutaSubreporte4);
            hm.put("RUTA_SUB_POT_PADRE ",rutaSubreporte5);
            hm.put("FID_JEFE  ", idJefe);
            
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteObjetivos")
    public byte[] generarReporteObjetivos(@WebParam(name = "idGerencia") int idGerencia) {
        byte[] arreglo = null;
        try{
            String rutaReporte = Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReportePlanificacionObjetivos.jasper")
                    .getPath().replaceAll("%20", " ");
            
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(rutaReporte);
            
            String rutaSubreporte1 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePlanObj1.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte2 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePlanObj2.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte3 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePlanObj3.jasper")
                    .getPath().replaceAll("%20", " ");

            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            HashMap hm = new HashMap();
            hm.put("ID_GERENCIA",idGerencia);
            hm.put("RUTA_SR1",rutaSubreporte1);
            hm.put("RUTA_SR2",rutaSubreporte2);
            hm.put("RUTA_SR3",rutaSubreporte3);
            
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    
    @WebMethod(operationName = "generarReportePDI")
    public byte[] generarReportePDI(@WebParam(name = "idColaborador") int idColaborador) {
        byte[] arreglo = null;
        try{
            String rutaReporte = Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReportePDI.jasper")
                    .getPath().replaceAll("%20", " ");
            
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(rutaReporte);
            
            String rutaSubreporte1 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI1.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte2 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI2.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte3 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI3.jasper")
                    .getPath().replaceAll("%20", " ");

            String rutaSubreporte4 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI4.jasper")
                    .getPath().replaceAll("%20", " ");

            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            HashMap hm = new HashMap();
            hm.put("ID_COLABORADOR",idColaborador);
            hm.put("R_SR1",rutaSubreporte1);
            hm.put("R_SR2",rutaSubreporte2);
            hm.put("R_SR3",rutaSubreporte3);
            hm.put("R_SR4",rutaSubreporte3);
            
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteEvaluacionColaborador")
    public byte[] generarReporteEvaluacionColaborador( 
            @WebParam(name = "idColaborador") int idColaborador ) {
        byte[] arreglo = null;
        try{
            String rutaReporte = Reporte.class.getResource("/pe/edu/pucp/sed/"
                    + "reportes/ReporteObjetivoColaborador/ReporteEvaluacion.jasper")
                    .getPath().replaceAll("%20", " ");
            
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(rutaReporte);
            
            String rutaSubreporte1 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/"
                       + "ReporteObjetivoColaborador/ReporObj.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte2 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/"
                       + "ReporteObjetivoColaborador/ReporteCriterioPadre.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte3 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/"
                       + "ReporteObjetivoColaborador/ReportePotenciales.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte4 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/"
                       + "ReporteObjetivoColaborador/ReporSubCom.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte5 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/"
                       + "ReporteObjetivoColaborador/Reportesubpotencial.jasper")
                    .getPath().replaceAll("%20", " ");
            
            

            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            HashMap hm = new HashMap();
            hm.put("RUTA_REPOR_OBJ",rutaSubreporte1);
            hm.put("RUTA_SUBREPORTECRIPADRE1",rutaSubreporte2);
            hm.put("RUTA_POTENCIAL",rutaSubreporte3);
            hm.put("RUTA_SUB_COM_PADRE ",rutaSubreporte4);
            hm.put("RUTA_SUB_POT_PADRE ",rutaSubreporte5);
            hm.put("FID_COL_IN  ", idColaborador);
            
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            con.close();
            
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    
    @WebMethod(operationName = "enviarReportePDI")
    public void enviarReportePDI(@WebParam(name = "colaborador") Colaborador colaborador) {
        try{
            String rutaReporte = Reporte.class.getResource("/pe/edu/pucp/sed/reportes/ReportePDI.jasper")
                    .getPath().replaceAll("%20", " ");
            
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(rutaReporte);
            
            String rutaSubreporte1 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI1.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte2 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI2.jasper")
                    .getPath().replaceAll("%20", " ");
            
            String rutaSubreporte3 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI3.jasper")
                    .getPath().replaceAll("%20", " ");

            String rutaSubreporte4 = 
               Reporte.class.getResource("/pe/edu/pucp/sed/reportes/SubReportePDI4.jasper")
                    .getPath().replaceAll("%20", " ");

            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            HashMap hm = new HashMap();
            hm.put("ID_COLABORADOR",colaborador.getIdColaborador());
            hm.put("R_SR1",rutaSubreporte1);
            hm.put("R_SR2",rutaSubreporte2);
            hm.put("R_SR3",rutaSubreporte3);
            hm.put("R_SR4",rutaSubreporte3);
            
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            con.close();
            
            File pdi = File.createTempFile("ReportePDI", null);
            try{
                FileOutputStream aux = new FileOutputStream(pdi);

                aux.write(JasperExportManager.exportReportToPdf(jp));
                aux.close();
                
                String cuerpo = "Estimado " + colaborador.getNombres() + ":\n"
                        + "Se le presenta su Plan de Desarrollo Integral para el"
                        + "proximo año, esperoamos que pueda seguir mejorando.\n";
                
                Correo.enviarCorreo(colaborador.getCorreo(), "Plan de Desarrollo"
                        + " Integral " + colaborador.getPeriodo().getNombre()
                        , cuerpo, pdi);
                
//                pdi.deleteOnExit();
            }catch(Exception e){
                System.out.println(e.getMessage());
            }finally{
                System.out.println(pdi.getPath());
            }
            pdi.delete();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
}
