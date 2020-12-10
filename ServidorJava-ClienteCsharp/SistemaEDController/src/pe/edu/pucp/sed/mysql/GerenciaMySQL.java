package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.GerenciaDAO;
import pe.edu.pucp.sed.model.Gerencia;

public class GerenciaMySQL implements GerenciaDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(Gerencia gerencia) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_GERENCIA(?,?,?)}";
            cs = con.prepareCall(sql);

            cs.setString("_NOMBRE", gerencia.getNombre());
            cs.setString("_DESCRIPCION", gerencia.getDescripcion());
            cs.registerOutParameter("_ID_GERENCIA", java.sql.Types.INTEGER);

            cs.executeUpdate();

            gerencia.setIdGerencia(cs.getInt("_ID_GERENCIA"));

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

    public int insertarGerenciaPeriodo(Gerencia gerencia) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_GERENCIA_PERIODO(?,?)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_PERIODO", gerencia.getPeriodo().getIdPeriodo());
            cs.setInt("_ID_GERENCIA", gerencia.getIdGerencia());

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
    public int actualizar(Gerencia gerencia) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_GERENCIA(?,?,?)}";
            cs = con.prepareCall(sql);

            cs.setString("_DESCRIPCION", gerencia.getDescripcion());
            cs.setString("_NOMBRE", gerencia.getNombre());
            cs.setInt("_ID_GERENCIA", gerencia.getIdGerencia());

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
    public int eliminar(int idGerencia) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_GERENCIA(?)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_GERENCIA", idGerencia);

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
    public ArrayList<Gerencia> listar() {
        ArrayList<Gerencia> gerencias = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);

            String sql = "{call LISTAR_GERENCIAS()}";
            cs = con.prepareCall(sql);

            rs = cs.executeQuery();
            while (rs.next()) {
                Gerencia gerencia = new Gerencia();
                gerencia.setIdGerencia(rs.getInt("id_Gerencias"));
                gerencia.setNombre(rs.getString("nombre"));
                gerencia.setDescripcion(rs.getString("descripcion"));
                gerencias.add(gerencia);
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
        return gerencias;
    }
    
    @Override
    public ArrayList<Gerencia> listarXColaborador(int idColaborador) {
        ArrayList<Gerencia> gerencias = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);

            String sql = "{call LISTAR_GERENCIA_X_COLABORADOR(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_ID_COLABORADOR", idColaborador);
            rs = cs.executeQuery();
            while (rs.next()) {
                Gerencia gerencia = new Gerencia();
                gerencia.setIdGerencia(rs.getInt("id_Gerencias"));
                gerencia.setNombre(rs.getString("nombre"));
                gerencia.setDescripcion(rs.getString("descripcion"));
                gerencia.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                gerencia.getPeriodo().setNombre(rs.getString("nombre"));
                gerencia.getPeriodo().setFechaInicio(rs.getDate("fechaInicio"));
                gerencia.getPeriodo().setFechaFin(rs.getDate("fechaFin"));
                gerencias.add(gerencia);
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
        return gerencias;
    }
    
    @Override
    public ArrayList<Gerencia> listarXPeriodoActual() {
        ArrayList<Gerencia> gerencias = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            String sql = "{call LISTAR_GERENCIA_X_PERIODO_ACTUAL()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery();
            while (rs.next()) {
                Gerencia gp = new Gerencia();
                
                gp.setIdGerencia(rs.getInt("id_Gerencias"));
                gp.setNombre(rs.getString("nombre"));
                gp.setDescripcion(rs.getString("descripcion"));
                
                gerencias.add(gp);
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
        return gerencias;
    }
    
}
