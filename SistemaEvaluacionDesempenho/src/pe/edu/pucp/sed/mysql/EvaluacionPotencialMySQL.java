package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.EvaluacionPotencialDAO;
import pe.edu.pucp.sed.model.EvaluacionPotencial;

public class EvaluacionPotencialMySQL implements EvaluacionPotencialDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(EvaluacionPotencial evaluacionPotencial){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_EVALUACIONPOTENCIAL(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_EVALUACION", java.sql.Types.INTEGER);
            cs.setInt("_ID_COLABORADOR"
                    , evaluacionPotencial.getColaborador().getIdColaborador());
            cs.setInt("_ID_PERIODO"
                    , evaluacionPotencial.getPeriodo().getIdPeriodo() );
            cs.executeUpdate();
            evaluacionPotencial.setIdEvaluacion(cs.getInt("_ID_EVALUACION"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int actualizar(EvaluacionPotencial evaluacionPotencial){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_EVALUACIONPOTENCIAL(?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EVALUACION"
                    , evaluacionPotencial.getIdEvaluacion());
            cs.setInt("_ID_ESCALASINCALIBRAR"
                    , evaluacionPotencial.getEscalaSinCalibrar().getIdEscala());
            cs.setInt("_ID_ESCALAFINAL"
                    , evaluacionPotencial.getEscalaFinal().getIdEscala());
            cs.setString("_OBSERVACIONES"
                    , evaluacionPotencial.getObservaciones());
            cs.setDouble("_NOTAAUTOEVAL"
                    , evaluacionPotencial.getNotaAutoEval());
            cs.setDouble("_NOTAPREVIA"
                    , evaluacionPotencial.getNotaPrevia());
            cs.setDouble("_NOTAFINAL"
                    , evaluacionPotencial.getNotaFinal());
            
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
    public int eliminar(int idEvaluacionPotencial){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_EVALUACIONPOTENCIAL(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EVALUACION", idEvaluacionPotencial);
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
    public ArrayList<EvaluacionPotencial> listar(){
        ArrayList<EvaluacionPotencial> evaluacionesPotencial = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            //falta implementar
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return evaluacionesPotencial;
    }
}
