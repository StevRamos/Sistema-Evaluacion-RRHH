package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.PuestoTrabajoDAO;
import pe.edu.pucp.sed.model.PuestoTrabajo;

public class PuestoTrabajoMySQL implements PuestoTrabajoDAO{

	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar(PuestoTrabajo puestoTrabajo){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ()}";
			cs = con.prepareCall(sql);

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
	int actualizar(PuestoTrabajo puestoTrabajo){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ()}";
			cs = con.prepareCall(sql);

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
	int eliminar(int idPuestoTrabajo){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ()}";
			cs = con.prepareCall(sql);

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
	ArrayList<PuestoTrabajo> listar(){
		ArrayList<PuestoTrabajo> puestoTrabajo = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return ;
	}
}
