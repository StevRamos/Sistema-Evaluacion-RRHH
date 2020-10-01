package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.LineaPotencialDAO;
import pe.edu.pucp.sed.model.LineaPotencial;

public class LineaPotencialMySQL implements LineaPotencialDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(LineaPotencial lineaPotencial){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_LINEAPOTENCIAL(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_LINEACRITERIO", java.sql.Types.INTEGER);
            cs.setInt("_ID_LINEAEVALUACION"
                    , lineaPotencial.getLineaEvaluacion().getIdLineaEvaluacion());
            cs.setInt("_ID_PESOSUBCRITERIO"
                    , lineaPotencial.getPeso().getIdPesoSubcriterio());
            cs.executeUpdate();
            lineaPotencial.setIdLineaCriterio(cs.getInt("_ID_LINEACRITERIO"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int actualizar(LineaPotencial lineaPotencial){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_LINEAPOTENCIAL(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEACRITERIO"
                    , lineaPotencial.getIdLineaCriterio());
            cs.setBoolean("_CUMPLIOAUTOEVAL"
                    , lineaPotencial.getCumplioAutoEval());
            cs.setBoolean("_CUMPLIOPREVIA"
                    , lineaPotencial.getCumplioPrevia());
            cs.setBoolean("_CUMPLIOFINAL"
                    , lineaPotencial.getCumplioFinal());
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int eliminar(int idLineaPotencial){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_LINEAPOTENCIAL(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEACRITERIO", idLineaPotencial);
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public ArrayList<LineaPotencial> listar(){
        ArrayList<LineaPotencial> lineasPotencial = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lineasPotencial;
    }
}
