package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.GerenciaPeriodoDAO;
import pe.edu.pucp.sed.model.GerenciaPeriodo;

public class GerenciaPeriodoMySQL implements GerenciaPeriodoDAO {

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(GerenciaPeriodo gerenciaPeriodo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_GERENCIA_PERIODO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERIODO", gerenciaPeriodo.getPeriodo().getIdPeriodo());
            cs.setInt("_ID_GERENCIA", gerenciaPeriodo.getGerencia().getIdGerencia());
            cs.executeUpdate();
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int actualizar(GerenciaPeriodo gerenciaPeriodo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_GERENCIA_PERIODO(?,?,?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERIODO", gerenciaPeriodo.getPeriodo().getIdPeriodo());
            cs.setInt("_ID_GERENCIA", gerenciaPeriodo.getGerencia().getIdGerencia());
            
            cs.setDate("_FECHA_INICIO_PLAN", 
                   new java.sql.Date(gerenciaPeriodo.getFechaInicioPlan().getTime()));
            cs.setDate("_FECHA_FIN_PLAN", 
                   new java.sql.Date(gerenciaPeriodo.getFechaFinPlan().getTime()));
            cs.setDate("_FECHA_INICIO_PDI", 
                   new java.sql.Date(gerenciaPeriodo.getFechaInicioPDI().getTime()));
            cs.setDate("_FECHA_FIN_PDI", 
                   new java.sql.Date(gerenciaPeriodo.getFechaFinPDI().getTime()));
            cs.setDate("_FECHA_INICIO_EVAL_PREVD", 
                   new java.sql.Date(gerenciaPeriodo.getFechaInicioEvalPrevD().getTime()));
            cs.setDate("_FECHA_FIN_EVAL_PREVD", 
                   new java.sql.Date(gerenciaPeriodo.getFechaFinEvalPrevD().getTime()));
            cs.setDate("_FECHA_INICIO_EVAL_FIND", 
                   new java.sql.Date(gerenciaPeriodo.getFechaInicioEvalFinD().getTime()));
            cs.setDate("_FECHA_FIN_EVAL_FIND", 
                   new java.sql.Date(gerenciaPeriodo.getFechaFinEvalFinD().getTime()));
            cs.setDate("_FECHA_INICIO_CAL", 
                   new java.sql.Date(gerenciaPeriodo.getFechaInicioCal().getTime()));
            cs.setDate("_FECHA_FIN_CAL", 
                   new java.sql.Date(gerenciaPeriodo.getFechaFinCal().getTime()));
            
            cs.executeUpdate();
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(GerenciaPeriodo gerenciaPeriodo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_GERENCIA_PERIODO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERIODO", gerenciaPeriodo.getPeriodo().getIdPeriodo());
            cs.setInt("_ID_GERENCIA", gerenciaPeriodo.getGerencia().getIdGerencia());
            cs.executeUpdate();
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<GerenciaPeriodo> listarXPeriodo(int idPeriodo) {
        ArrayList<GerenciaPeriodo> gerenciaPeriodos = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);

            String sql = "{call LISTAR_GERENCIA_PERIODO_X_PERIODO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_PERIODO", idPeriodo);
            rs = cs.executeQuery();
            while (rs.next()) {
                GerenciaPeriodo gp = new GerenciaPeriodo();
                
                gp.getGerencia().setIdGerencia(rs.getInt("id_Gerencias"));
                gp.getGerencia().setNombre(rs.getString("nombre"));
                gp.getGerencia().setDescripcion(rs.getString("descripcion"));
                gp.setFechaInicioPlan(rs.getDate("fechaInicioPlan"));
                gp.setFechaFinPlan(rs.getDate("fechaFinPlan"));
                gp.setFechaInicioPDI(rs.getDate("fechaInicioPDI"));
                gp.setFechaFinPDI(rs.getDate("fechaFinPDI"));
                gp.setFechaInicioEvalPrevD(rs.getDate("fechaInicioEvalPrevD"));
                gp.setFechaFinEvalPrevD(rs.getDate("fechaFinEvalPrevD"));
                gp.setFechaInicioEvalFinD(rs.getDate("fechaInicioEvalFinD"));
                gp.setFechaFinEvalFinD(rs.getDate("fechaFinEvalFinD"));
                gp.setFechaInicioCal(rs.getDate("fechaInicioCal"));
                gp.setFechaFinCal(rs.getDate("fechaFinCal"));
                
                gerenciaPeriodos.add(gp);
            }            
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return gerenciaPeriodos;
    }
}
