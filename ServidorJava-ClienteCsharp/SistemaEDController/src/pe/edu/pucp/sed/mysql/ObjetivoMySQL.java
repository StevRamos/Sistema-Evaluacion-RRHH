package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.ObjetivoDAO;
import pe.edu.pucp.sed.model.Objetivo;

public class ObjetivoMySQL implements ObjetivoDAO {

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(Objetivo objetivo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_OBJETIVO(?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);

            cs.setInt("FID_COLABORADOR", objetivo.getColaborador().getIdColaborador());
            cs.setString("_DESCRIPCION", objetivo.getDescripcion());
            cs.setDouble("_META", objetivo.getMeta());
            cs.setString("_UNIDADMEDIDA", String.valueOf(objetivo.getUnidadMedida()));
            cs.setDouble("_PESO", objetivo.getPeso());
            cs.registerOutParameter("_ID_OBJETIVO", java.sql.Types.INTEGER);

            cs.executeUpdate();

            objetivo.setIdObjetivo(cs.getInt("_ID_OBJETIVO"));

            resultado = objetivo.getIdObjetivo();
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
    public int actualizar(Objetivo objetivo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_OBJETIVO(?,?,?,?,?,?,?,?,?,?,?,null)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_OBJETIVO", objetivo.getIdObjetivo());
            cs.setString("_DESCRIPCION", objetivo.getDescripcion());
            cs.setDouble("_META", objetivo.getMeta());
            cs.setString("_UNIDADMEDIDA", String.valueOf(objetivo.getUnidadMedida()));
            cs.setDouble("_PESO", objetivo.getPeso());
            cs.setInt("_ESTADO", objetivo.getEstado());
            cs.setString("_OBSERVACION", objetivo.getObservacion());
            cs.setDouble("_NOTAAUTOEVAL", objetivo.getNotaAutoEval());
            cs.setDouble("_NOTAPREVIA", objetivo.getNotaPrevia());
            cs.setDouble("_NOTAFINAL", objetivo.getNotaFinal());
            cs.setInt("_ID_EVALUACION", objetivo.getEvaluacion().getIdEvaluacion());
            SimpleDateFormat sdformat = new SimpleDateFormat("yyyy-MM-dd");
           //Date d1 = new java.util.Date(sdformat.parse("1970-01-01"));
            //if (objetivo.getFechaAprobacion().compareTo(new (sdformat.parse("1970-01-01")))==0){
            //    cs.setDate("_FECHA_APROBACION" , null);
           // }else{
            //    cs.setDate("_FECHA_APROBACION" , new java.sql.Date(objetivo.getFechaAprobacion().getTime()));
            //}
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
    public int eliminar(int idObjetivo) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_OBJETIVO(?)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_OBJETIVO", idObjetivo);

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
    public ArrayList<Objetivo> listar() {
        ArrayList<Objetivo> objetivos = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call LISTAR_OBJETIVOS()}";
            cs = con.prepareCall(sql);

            rs = cs.executeQuery();
            while (rs.next()) {                
                Objetivo objetivo = new Objetivo();
                objetivo.setIdObjetivo(rs.getInt("id_Objetivo"));
//                objetivo.getColaborador().setIdColaborador(idColaborador);
                objetivo.getEvaluacion().setIdEvaluacion(rs.getInt("id_Evaluacion"));
                objetivo.setDescripcion(rs.getString("descripcion"));
                objetivo.setEstado(rs.getInt("estado"));
                objetivo.setFechaFormulacion(rs.getDate("fechaFormulacion")); //posible error
                objetivo.setFechaAprobacion(rs.getDate("fechaAprobacion")); //posible error
                objetivo.setMeta(rs.getDouble("meta"));
                objetivo.setUnidadMedida(rs.getString("unidadMedida"));
                objetivo.setObservacion(rs.getString("observacion"));
                objetivo.setPeso(rs.getDouble("peso"));
                objetivo.setNotaPrevia(rs.getDouble("notaPrevia"));
                objetivo.setNotaAutoEval(rs.getDouble("notaAutoEval"));
                objetivo.setNotaFinal(rs.getDouble("notaFinal"));

                objetivos.add(objetivo);
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
        return objetivos;
    }
    
    @Override
    public ArrayList<Objetivo> listarObjetivosXColaborador( int idColaborador ) {
        ArrayList<Objetivo> objetivos = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{CALL LISTAR_OBJETIVOS_X_COLABORADOR(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_COLABORADOR", idColaborador);
            rs = cs.executeQuery();
            while (rs.next()) {                
                Objetivo objetivo = new Objetivo();
                objetivo.setIdObjetivo(rs.getInt("id_Objetivo"));
                objetivo.getColaborador().setIdColaborador(idColaborador);
                objetivo.getEvaluacion().setIdEvaluacion(rs.getInt("id_Evaluacion"));
                objetivo.setDescripcion(rs.getString("descripcion"));
                objetivo.setEstado(rs.getInt("estado"));
                objetivo.setFechaFormulacion(rs.getDate("fechaFormulacion")); //posible error
                objetivo.setFechaAprobacion(rs.getDate("fechaAprobacion")); //posible error
                objetivo.setMeta(rs.getDouble("meta"));
                objetivo.setUnidadMedida(rs.getString("unidadMedida"));
                objetivo.setObservacion(rs.getString("observacion"));
                objetivo.setPeso(rs.getDouble("peso"));
                objetivo.setNotaPrevia(rs.getDouble("notaPrevia"));
                objetivo.setNotaAutoEval(rs.getDouble("notaAutoEval"));
                objetivo.setNotaFinal(rs.getDouble("notaFinal"));

                objetivos.add(objetivo);
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
        return objetivos;
    }
    
    
}