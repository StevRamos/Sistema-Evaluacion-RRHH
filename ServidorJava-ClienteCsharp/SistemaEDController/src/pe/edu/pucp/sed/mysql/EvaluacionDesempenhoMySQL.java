package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.EvaluacionDesempenhoDAO;
import pe.edu.pucp.sed.model.EvaluacionDesempenho;

public class EvaluacionDesempenhoMySQL implements EvaluacionDesempenhoDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(EvaluacionDesempenho evaluacionDesempenho){
        int resultado = 0;
        try{
                Class.forName("com.mysql.cj.jdbc.Driver");
                con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
                String sql = "{call INSERTAR_EVALUACIONDESEMPENHO(?,?,?)}";
                cs = con.prepareCall(sql);
                
                cs.setInt("_ID_COLABORADOR",evaluacionDesempenho.getColaborador().getIdColaborador());
                cs.setInt("_ID_PERIODO",evaluacionDesempenho.getPeriodo().getIdPeriodo());
                cs.registerOutParameter("_ID_EVALUACION", java.sql.Types.INTEGER);
                        
                cs.executeUpdate();
                        
                evaluacionDesempenho.setIdEvaluacion(cs.getInt("_ID_EVALUACION"));
      
                resultado = 1;
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }finally{
                try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int actualizar(EvaluacionDesempenho evaluacionDesempenho){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_EVALUACIONDESEMPENHO(?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_EVALUACION",evaluacionDesempenho.getIdEvaluacion());
            //cs.setInt("_ID_ESCALASINCALIBRAR",evaluacionDesempenho.getEscalaSinCalibrar().getIdEscala());
            //cs.setInt("_ID_ESCALAFINAL",evaluacionDesempenho.getEscalaFinal().getIdEscala());
            cs.setString("_OBSERVACIONESCOMP",evaluacionDesempenho.getObservacionesComp());
            cs.setDouble("_NOTAAUTOEVALCOMP",evaluacionDesempenho.getNotaAutoEvalComp());
            cs.setDouble("_NOTAPREVIACOMP",evaluacionDesempenho.getNotaPreviaComp());
            cs.setDouble("_NOTAFINALCOMP",evaluacionDesempenho.getNotaFinalComp());
            cs.setString("_OBSERVACIONESOBJ",evaluacionDesempenho.getObservacionesObj());
            cs.setDouble("_NOTAAUTOEVALOBJ",evaluacionDesempenho.getNotaAutoEvalObj());
            cs.setDouble("_NOTAPREVIAOBJ",evaluacionDesempenho.getNotaPreviaObj());
            cs.setDouble("_NOTAFINALOBJ",evaluacionDesempenho.getNotaFinalObj());
            
                        
            
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
    public int eliminar(int idEvaluacionDesempenho){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_EVALUACIONDESEMPENHO(?)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_EVALUACION",idEvaluacionDesempenho);
                        
            
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
    public ArrayList<EvaluacionDesempenho> listar(){
        ArrayList<EvaluacionDesempenho> evaluacionesDesempenho = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

            String sql = "{call LISTAR_EVALUACIONDESEMPENHO()}";
                cs = con.prepareCall(sql);
                        
            rs = cs.executeQuery(sql);
            while(rs.next()){
                EvaluacionDesempenho evaluacionDesempenho = new EvaluacionDesempenho();
                evaluacionDesempenho.setIdEvaluacion(rs.getInt("id_Evaluacion"));
                //evaluacionDesempenho.getColaborador(rs.getString("id_Colaborador"));
                //evaluacionDesempenho.setDescripcion(rs.getString("id_Periodo"));
                evaluacionDesempenho.setObservacionesComp(rs.getString("observacionesComp"));
                evaluacionDesempenho.setObservacionesObj(rs.getString("observacionesObj"));
                
                evaluacionDesempenho.setNotaAutoEvalComp(rs.getDouble("notaAutoEvalComp"));
                evaluacionDesempenho.setNotaPreviaComp(rs.getDouble("notaPreviaComp"));
                evaluacionDesempenho.setNotaFinalComp(rs.getDouble("notaFinalComp"));

                evaluacionDesempenho.setNotaAutoEvalObj(rs.getDouble("notaAutoEvalObj"));
                evaluacionDesempenho.setNotaPreviaObj(rs.getDouble("notaPreviaObj"));
                evaluacionDesempenho.setNotaFinalObj(rs.getDouble("notaFinalObj"));
                
                
                evaluacionesDesempenho.add(evaluacionDesempenho);
            }
            
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return evaluacionesDesempenho;
    }
}
