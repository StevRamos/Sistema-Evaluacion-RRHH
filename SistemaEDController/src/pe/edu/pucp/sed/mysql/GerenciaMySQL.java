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
	public int insertar(Gerencia gerencia){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call INSERTAR_AREA(?,?,?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setString("_NOMBRE",gerencia.getNombre());
                        cs.setString("_DESCRIPCION",gerencia.getDescripcion());
                        cs.registerOutParameter("_ID_AREA", java.sql.Types.INTEGER);
                        
			cs.executeUpdate();
                        
                        gerencia.setIdGerencia(cs.getInt("_ID_AREA"));
                        
			resultado = 1;
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return resultado;
	}
	@Override
	public int actualizar(Gerencia gerencia){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ACTUALIZAR_AREA(?,?)}";
			cs = con.prepareCall(sql);

                        cs.setString("_DESCRIPCION",gerencia.getDescripcion());
                        cs.setInt("_ID_AREA",gerencia.getIdGerencia());
                        
                        
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
	public int eliminar(int idGerencia){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ELIMINAR_AREA(?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setInt("_ID_AREA",idGerencia);
                        
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
	public ArrayList<Gerencia> listar(){
		ArrayList<Gerencia> gerencias = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
                        
                        String sql = "{call LISTAR_AREAS()}";
			cs = con.prepareCall(sql);
                        
                        rs = cs.executeQuery(sql);
                        while(rs.next()){
                            Gerencia gerencia = new Gerencia();
                            gerencia.setIdGerencia(rs.getInt("id_Area"));
                            gerencia.setNombre(rs.getString("nombre"));
                            gerencia.setDescripcion(rs.getString("descripcion"));
                            gerencias.add(gerencia);
                        }
                        
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return gerencias;
	}
}