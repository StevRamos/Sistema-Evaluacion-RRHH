package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.PesoCriterioDAO;
import pe.edu.pucp.sed.model.PesoCriterio;

public class PesoCriterioMySQL implements PesoCriterioDAO{

	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar(PesoCriterio pesoCriterio){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
                        String sql = "{call INSERTAR_PESO_CRITERIO(?,?,?,?,?)}";
                        cs = con.prepareCall(sql);
                        cs.registerOutParameter("_ID_PESO_CRITERIO", java.sql.Types.INTEGER);
                        cs.setInt("_ID_PERIODO", pesoCriterio.getPeriodo().getIdPeriodo());
                        cs.setInt("_ID_PUESTO_TRABAJO",pesoCriterio.getPuestoTrabajo().getIdPuestoTrabajo());
                        cs.setInt("_ID_CRITERIO",pesoCriterio.getCriterio().getIdCriterio());
                        cs.setDouble("_PESO", pesoCriterio.getPeso());
                        
                        cs.executeUpdate();
                        pesoCriterio.setIdPesoCriterio(cs.getInt("_ID_PESO_CRITERIO"));
                        resultado = 1;
                    }catch(Exception ex){
                        System.out.println(ex.getMessage());
                    }finally{
                        try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
                    }
                    return resultado;
	}
	@Override
	public int actualizar(PesoCriterio pesoCriterio){
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
	public int eliminar(int idPesoCriterio){
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
	public ArrayList<PesoCriterio> listar(){
		ArrayList<PesoCriterio> pesoCriterios = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

			String sql = "{call ()}";
			cs = con.prepareCall(sql);

			rs = cs.executeQuery();
			while(rs.next()){
			}
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return pesoCriterios;
	}
}