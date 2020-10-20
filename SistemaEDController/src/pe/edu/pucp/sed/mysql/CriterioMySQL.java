package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.CriterioDAO;
import pe.edu.pucp.sed.model.Criterio;

public class CriterioMySQL implements CriterioDAO{

	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar(Criterio criterio){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call INSERTAR_CRITERIO(?,?,?,?)}";
			cs = con.prepareCall(sql);
                        
                        cs.setString("_NOMBRE",criterio.getNombre());
                        //cs.setString("_DESCRIPCION",criterio.getDescripcion());
                        cs.setInt("_TIPO",criterio.getTipo());
                        cs.registerOutParameter("_ID_CRITERIO", java.sql.Types.INTEGER);
                        
			cs.executeUpdate();
                        
                        criterio.setIdCriterio(cs.getInt("_ID_CRITERIO"));
         		resultado = 1;
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return resultado;
	}
	@Override
	public int actualizar(Criterio criterio){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ACTUALIZAR_CRITERIO(?,?)}";
			cs = con.prepareCall(sql);
                        
                        //cs.setString("_DESCRIPCION",criterio.getDescripcion());
                        cs.setInt("_ID_CRITERIO",criterio.getIdCriterio());
                        
                        
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
	public int eliminar(int idCriterio){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ELIMINAR_CRITERIO(?)}";
			cs = con.prepareCall(sql);

                        cs.setInt("_ID_CRITERIO",idCriterio);
                        
                        
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
	public ArrayList<Criterio> listar(){
		ArrayList<Criterio> criterios = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
                        
                        String sql = "{call LISTAR_CRITERIOS()}";
			cs = con.prepareCall(sql);
                        
                        rs = cs.executeQuery(sql);
                        while(rs.next()){
                            Criterio criterio = new Criterio();
                            criterio.setIdCriterio(rs.getInt("id_Criterio"));
                            criterio.setNombre(rs.getString("nombre"));
                            //criterio.setDescripcion(rs.getString("descripcion"));
                            //criterio.setEsVigente(rs.getBoolean("esVigente"));
                            criterio.setTipo(rs.getInt("tipo"));
                            criterios.add(criterio);
                        }
                        
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return criterios;
	}
}
