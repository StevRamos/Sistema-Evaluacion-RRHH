package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.ObjetivoDAO;
import pe.edu.pucp.sed.model.Objetivo;

public class ObjetivoMySQL implements ObjetivoDAO{

	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar(Objetivo objetivo){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call INSERTAR_OBJETIVO(?,?,?,?,?,?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setInt("FID_COLABORADOR",objetivo.getColaborador().getIdColaborador());
                        cs.setString("_DESCRIPCION",objetivo.getDescripcion());
                        cs.setDouble("_META",objetivo.getMeta());
                        cs.setString("_UNIDADMEDIDA",String.valueOf(objetivo.getUnidadMedida()));
                        cs.setDouble("_PESO",objetivo.getPeso());
                        cs.registerOutParameter("_ID_OBJETIVO", java.sql.Types.INTEGER);
                        
			cs.executeUpdate();
                        
                        objetivo.setIdObjetivo(cs.getInt("_ID_OBJETIVO"));
                        
                        resultado = 1;
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return resultado;
	}
	@Override
	public int actualizar(Objetivo objetivo){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ACTUALIZAR_OBJETIVO(?,?,?,?,?,?,?,?,?,?,?)}";
			cs = con.prepareCall(sql);
                        
                        
                        cs.setInt("_ID_OBJETIVO",objetivo.getIdObjetivo());
                        cs.setString("_DESCRIPCION",objetivo.getDescripcion());
                        cs.setDouble("_META",objetivo.getMeta());
                        cs.setString("_UNIDADMEDIDA",String.valueOf(objetivo.getUnidadMedida()));
                        cs.setDouble("_PESO",objetivo.getPeso());
                        cs.setBoolean("_ESTADO",objetivo.getEstado());
                        cs.setString("_OBSERVACION",objetivo.getObservacion());
                        cs.setDouble("_NOTAAUTOEVAL",objetivo.getNotaAutoEval());
                        cs.setDouble("_NOTAPREVIA",objetivo.getNotaPrevia());
                        cs.setDouble("_NOTAFINAL",objetivo.getNotaFinal());
                        cs.setInt("_ID_EVALUACION",objetivo.getEvaluacion().getIdEvaluacion());
                        
                        
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
	public int eliminar(int idObjetivo){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ELIMINAR_OBJETIVO(?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setInt("_ID_OBJETIVO",idObjetivo);
                        
                        
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
	public ArrayList<Objetivo> listar(){
		ArrayList<Objetivo> objetivo = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return objetivo;
	}
}
