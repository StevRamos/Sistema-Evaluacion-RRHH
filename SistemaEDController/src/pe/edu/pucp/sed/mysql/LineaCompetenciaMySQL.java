package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.LineaCompetenciaDAO;
import pe.edu.pucp.sed.model.LineaCompetencia;

public class LineaCompetenciaMySQL implements LineaCompetenciaDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(LineaCompetencia lineaCompetencia){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_LINEACOMPETENCIA(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_LINEACRITERIO", java.sql.Types.INTEGER);
            cs.setInt("_ID_LINEAEVALUACION"
                    , lineaCompetencia.getLineaEvaluacion().getIdLineaEvaluacion());
            cs.setInt("_ID_PESOSUBCRITERIO"
                    , lineaCompetencia.getPeso().getIdPesoSubcriterio());
            cs.executeUpdate();
            lineaCompetencia.setIdLineaCriterio(cs.getInt("_ID_LINEACRITERIO"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int actualizar(LineaCompetencia lineaCompetencia){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_LINEACOMPETENCIA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEACRITERIO"
                    , lineaCompetencia.getIdLineaCriterio());
            cs.setDouble("_NOTAAUTOEVAL"
                    , lineaCompetencia.getNotaAutoEval());
            cs.setDouble("_NOTAPREVIA"
                    , lineaCompetencia.getNotaPrevia());
            cs.setDouble("_NOTAFINAL"
                    , lineaCompetencia.getNota());
            
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
    public int eliminar(int idLineaCompetencia){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_LINEACOMPETENCIA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEACRITERIO", idLineaCompetencia);
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
    public ArrayList<LineaCompetencia> listar(){
        ArrayList<LineaCompetencia> lineasCompetencia = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lineasCompetencia;
    }
}
