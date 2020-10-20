package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.LineaEvaluacionDAO;
import pe.edu.pucp.sed.model.LineaEvaluacion;

public class LineaEvaluacionMySQL implements LineaEvaluacionDAO{

	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar(LineaEvaluacion lineaEvaluacion){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call INSERTAR_LINEA_EVALUACION(?,?,?,?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setInt("_ID_PESO_CRITERIO",lineaEvaluacion.getPesoCriterio().getIdPesoCriterio());
                        cs.setInt("_ID_EVALUACION",lineaEvaluacion.getEvaluacion().getIdEvaluacion());
                        cs.setInt("_ID_ITEM",lineaEvaluacion.getItemPDI().getIdItemPDI());
                        cs.registerOutParameter("_ID_LINEA_EVALUACION", java.sql.Types.INTEGER);
                        
			cs.executeUpdate();
                        
                        lineaEvaluacion.setIdLineaEvaluacion(cs.getInt("_ID_LINEA_EVALUACION"));
                     ;
			resultado = 1;
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return resultado;
	}
	@Override
	public int actualizar(LineaEvaluacion lineaEvaluacion){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ACTUALIZAR_LINEA_EVALUACION(?,?,?,?)}";
			cs = con.prepareCall(sql);

                        cs.setDouble("_NOTA_AUTO",lineaEvaluacion.getNotaAutoEval());
                        cs.setDouble("_NOTA_PREV",lineaEvaluacion.getNotaPrevia());
                        cs.setDouble("_NOTA_FINAL",lineaEvaluacion.getNotaFinal());
                        cs.setInt("_ID_LINEA_EVALUACION",lineaEvaluacion.getIdLineaEvaluacion());
                        
                        
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
	public int eliminar(int idLineaEvaluacion){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ELIMINAR_LINEA_EVAL(?)}";
			cs = con.prepareCall(sql);

                        cs.setInt("_ID_LINEA_EVAL",idLineaEvaluacion);
                            
                        
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
	public ArrayList<LineaEvaluacion> listar(){
		ArrayList<LineaEvaluacion> lineaEvaluacion = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

                        
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return lineaEvaluacion;
	}
}
