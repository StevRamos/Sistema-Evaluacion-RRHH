/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.sed.config.DBManager;

/**
 *
 * @author Jorge Miguel Baca
 */
public class Reporte extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
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
            
            JasperExportManager.exportReportToPdfStream(jp,response.getOutputStream());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
