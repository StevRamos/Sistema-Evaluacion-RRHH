package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.AreaDAO;
import pe.edu.pucp.sed.model.Area;

public class AreaMySQL implements AreaDAO{

	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar(Area area){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call INSERTAR_AREA(?,?,?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setString("_NOMBRE",area.getNombre());
                        cs.setString("_DESCRIPCION",area.getDescripcion());
                        cs.registerOutParameter("_ID_AREA", java.sql.Types.INTEGER);
                        
			cs.executeUpdate();
                        
                        area.setIdArea(cs.getInt("_ID_AREA"));
                        
			resultado = 1;
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return resultado;
	}
	@Override
	public int actualizar(Area area){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ACTUALIZAR_AREA(?,?)}";
			cs = con.prepareCall(sql);

                        cs.setString("_DESCRIPCION",area.getDescripcion());
                        cs.setInt("_ID_AREA",area.getIdArea());
                        
                        
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
	public int eliminar(int idArea){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ELIMINAR_AREA(?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setInt("_ID_AREA",idArea);
                        
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
	public ArrayList<Area> listar(){
		ArrayList<Area> areas = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
                        
                        String sql = "{call LISTAR_AREAS()}";
			cs = con.prepareCall(sql);
                        
                        rs = cs.executeQuery(sql);
                        while(rs.next()){
                            Area area = new Area();
                            area.setIdArea(rs.getInt("id_Area"));
                            area.setNombre(rs.getString("nombre"));
                            area.setDescripcion(rs.getString("descripcion"));
                            area.setActivo(rs.getBoolean("activo"));
                            areas.add(area);
                        }
                        
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return areas;
	}
}
