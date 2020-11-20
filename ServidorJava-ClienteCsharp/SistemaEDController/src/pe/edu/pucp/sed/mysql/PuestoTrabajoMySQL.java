package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.PuestoTrabajoDAO;
import pe.edu.pucp.sed.model.Gerencia;
import pe.edu.pucp.sed.model.PuestoTrabajo;

public class PuestoTrabajoMySQL implements PuestoTrabajoDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(PuestoTrabajo puestoTrabajo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_PUESTO_TRABAJO(?,?,?)}";
            cs = con.prepareCall(sql);

            cs.setString("_NOMBRE", puestoTrabajo.getNombre());
            cs.setString("_DESCRIPCION", puestoTrabajo.getDescripcion());
            cs.registerOutParameter("_ID_PUESTO_TRABAJO", java.sql.Types.INTEGER);

            cs.executeUpdate();

            puestoTrabajo.setIdPuestoTrabajo(cs.getInt("_ID_PUESTO_TRABAJO"));

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
    public int actualizar(PuestoTrabajo puestoTrabajo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_PUESTO_TRABAJO(?,?,?)}";
            cs = con.prepareCall(sql);

            cs.setString("_DESCRIPCION", puestoTrabajo.getDescripcion());
            cs.setString("_NOMBRE", puestoTrabajo.getNombre());
            cs.setInt("_ID_PUESTO_TRABAJO", puestoTrabajo.getIdPuestoTrabajo());

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
    public int eliminar(int idPuestoTrabajo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_PUESTO_TRABAJO(?)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_PUESTO_TRABAJO", idPuestoTrabajo);

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
    public ArrayList<PuestoTrabajo> listar(String nombreGerencia) {
        ArrayList<PuestoTrabajo> puestosTrabajo = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);

            String sql = "{call LISTAR_PUESTOS_TRABAJO(?)}";
            cs = con.prepareCall(sql);
            cs.setString("_NOMBRE_GERENCIA", nombreGerencia);
            rs = cs.executeQuery();

            while (rs.next()) {

                Gerencia ger = new Gerencia();
                ger.setNombre(rs.getString("nombreGerencia"));

                PuestoTrabajo puestoTrabajo = new PuestoTrabajo();
                puestoTrabajo.setIdPuestoTrabajo(rs.getInt("idPuestoTrabajo"));
                puestoTrabajo.setNombre(rs.getString("nombrePuestoTrabajo"));
                puestoTrabajo.setDescripcion(rs.getString("descripcion"));

                puestoTrabajo.setGerencia(ger);
                puestosTrabajo.add(puestoTrabajo);

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
        return puestosTrabajo;
    }

    public ArrayList<PuestoTrabajo> listarXColaborador(int idColaborador) {
        ArrayList<PuestoTrabajo> puestosTrabajo = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);

            String sql = "{call LISTAR_PUESTOTRABAJO_X_COLABORADOR(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_ID_COLABORADOR", idColaborador);
            rs = cs.executeQuery();

            while (rs.next()) {

                PuestoTrabajo puestoTrabajo = new PuestoTrabajo();
                puestoTrabajo.setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                puestoTrabajo.setNombre(rs.getString("nombre"));
                puestoTrabajo.setDescripcion(rs.getString("descripcion"));

                puestosTrabajo.add(puestoTrabajo);

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
        return puestosTrabajo;
    }
}
