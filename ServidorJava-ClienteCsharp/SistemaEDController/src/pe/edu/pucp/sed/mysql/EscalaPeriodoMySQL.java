package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.EscalaPeriodoDAO;
import pe.edu.pucp.sed.model.EscalaPeriodo;

public class EscalaPeriodoMySQL implements EscalaPeriodoDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(EscalaPeriodo escalaPeriodo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ()}";
            cs = con.prepareCall(sql);

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
    public int actualizar(EscalaPeriodo escalaPeriodo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ()}";
            cs = con.prepareCall(sql);

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
    public int eliminar(int idEscalaPeriodo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ()}";
            cs = con.prepareCall(sql);

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
    public ArrayList<EscalaPeriodo> listar() {
        ArrayList<EscalaPeriodo> escalaPeriodos = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);

            String sql = "{call ()}";
            cs = con.prepareCall(sql);

            rs = cs.executeQuery();
            while (rs.next()) {
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
        return escalaPeriodos;
    }
    
    
    @Override
    public ArrayList<EscalaPeriodo> listarXPeriodoActual() {
        ArrayList<EscalaPeriodo> escalaPeriodos = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);

            String sql = "{call LISTAR_CUPOS_X_ESCALA()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery();
            while(rs.next()) {
                EscalaPeriodo ep = new EscalaPeriodo();
                
                ep.getEscala().setIdEscala(rs.getInt("id_Escala"));
                ep.getEscala().setNombre(rs.getString("nombre"));
                ep.setPorcentajeCupos(rs.getDouble("porcentajeCupos"));
                
                escalaPeriodos.add(ep);
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
        return escalaPeriodos;
    }
    
}
