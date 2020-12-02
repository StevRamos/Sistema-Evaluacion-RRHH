package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.PesoCriterioDAO;
import pe.edu.pucp.sed.model.Criterio;
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
                        String sql = "{call INSERTAR_PESO_CRITERIO_STR(?,?,?,?,?)}";
                        cs = con.prepareCall(sql);
                        cs.registerOutParameter("_ID_PESO_CRITERIO", java.sql.Types.INTEGER);
                        cs.setString("_NOMBRE_PERIODO",pesoCriterio.getPeriodo().getNombre());
                        cs.setString("_NOMBRE_PUESTO_TRABAJO",pesoCriterio.getPuestoTrabajo().getNombre());
                        cs.setString("_NOMBRE_CRITERIO",pesoCriterio.getCriterio().getNombre());
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
			String sql = "{call ACTUALIZAR_PESO_CRITERIO_STR(?,?,?,?)}";
                        cs = con.prepareCall(sql);
                        cs.setString("_NOMBRE_PERIODO",pesoCriterio.getPeriodo().getNombre());
                        cs.setString("_NOMBRE_PUESTO_TRABAJO",pesoCriterio.getPuestoTrabajo().getNombre());
                        cs.setString("_NOMBRE_CRITERIO",pesoCriterio.getCriterio().getNombre());
                        cs.setDouble("_PESO", pesoCriterio.getPeso());
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
	public int eliminar(PesoCriterio pesoCriterio){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ELIMINAR_PESO_CRITERIO(?)}";
			cs = con.prepareCall(sql);
                        cs.setInt("_ID_PESO_CRITERIO",pesoCriterio.getIdPesoCriterio());
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
	public ArrayList<PesoCriterio> listar(int tipo,String nomcargo,String nomPeriodo,String nomCompetencia){
		ArrayList<PesoCriterio> pesoCriterios = new ArrayList<>();
		try{
                    Class.forName("com.mysql.cj.jdbc.Driver");
                    con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

                    if (tipo==0){
                        String sql = "{call LISTAR_COMPETENCIAS(?,?,?)}";
                        cs = con.prepareCall(sql);
                        cs.setString("_NOMBRE_CARGO",nomcargo);
                        cs.setString("_NOMBRE_PERIODO",nomPeriodo);
                        cs.setString("_NOMBRE_COMPETENCIA",nomCompetencia);
                        rs = cs.executeQuery();
                        while(rs.next()){
                            PesoCriterio pesocriterio = new PesoCriterio();
                            pesocriterio.setIdPesoCriterio(rs.getInt("id_PesoCriterio"));
                            pesocriterio.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                            pesocriterio.getPeriodo().setNombre(rs.getString("periodo"));
                            pesocriterio.getCriterio().setIdCriterio(rs.getInt("id_Criterio"));
                            pesocriterio.getCriterio().setNombre(rs.getString("nombre"));
                            pesocriterio.getCriterio().setDescripcion(rs.getString("descripcion"));
                            pesocriterio.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                            pesocriterio.getPuestoTrabajo().setNombre(rs.getString("cargo"));
                            pesocriterio.setPeso(rs.getDouble("peso"));
                            pesoCriterios.add(pesocriterio);
                        }
                    }else if (tipo ==1){
                        String sql = "{call LISTAR_POTENCIALES(?,?,?)}";
                        cs = con.prepareCall(sql);
                        cs.setString("_NOMBRE_CARGO",nomcargo);
                        cs.setString("_NOMBRE_PERIODO",nomPeriodo);
                        cs.setString("_NOMBRE_POTENCIAL",nomCompetencia);
                        rs = cs.executeQuery();
                        while(rs.next()){
                            PesoCriterio pesocriterio = new PesoCriterio();
                            pesocriterio.setIdPesoCriterio(rs.getInt("id_PesoCriterio"));
                            pesocriterio.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                            pesocriterio.getPeriodo().setNombre(rs.getString("periodo"));
                            pesocriterio.getCriterio().setIdCriterio(rs.getInt("id_Criterio"));
                            pesocriterio.getCriterio().setNombre(rs.getString("nombre"));
                            pesocriterio.getCriterio().setDescripcion(rs.getString("descripcion"));
                            pesocriterio.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                            pesocriterio.getPuestoTrabajo().setNombre(rs.getString("cargo"));
                            pesocriterio.setPeso(rs.getDouble("peso"));
                            pesoCriterios.add(pesocriterio);
                        }
                    }else if (tipo == 2){
                        String sql = "{call LISTAR_SUBCOMPETENCIAS(?,?,?)}";
                        cs = con.prepareCall(sql);
                        cs.setString("_NOMBRE_CARGO",nomcargo);
                        cs.setString("_NOMBRE_PERIODO",nomPeriodo);
                        cs.setString("_NOMBRE_SUBCOMPETENCIA",nomCompetencia);
                        rs = cs.executeQuery();
                        while(rs.next()){
                            PesoCriterio pesocriterio = new PesoCriterio();
                            pesocriterio.setIdPesoCriterio(rs.getInt("id_PesoCriterio"));
                            pesocriterio.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                            pesocriterio.getPeriodo().setNombre(rs.getString("periodo"));
                            pesocriterio.getCriterio().setIdCriterio(rs.getInt("id_Criterio"));
                            pesocriterio.getCriterio().setNombre(rs.getString("nombrehijo"));
                            Criterio criteriopadre = new Criterio();
                            criteriopadre.setIdCriterio(rs.getInt("id_CriterioPadre"));
                            criteriopadre.setNombre(rs.getString("nombrepadre"));
                            
                            pesocriterio.getCriterio().setCriterioPadre(criteriopadre);  
                            pesocriterio.getCriterio().setDescripcion(rs.getString("descripcion"));
                            pesocriterio.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                            pesocriterio.getPuestoTrabajo().setNombre(rs.getString("cargo"));
                            pesocriterio.setPeso(rs.getDouble("peso"));
                            pesoCriterios.add(pesocriterio);
                        }
                    }else if (tipo==3){
                        String sql = "{call LISTAR_SUBPOTENCIALES(?,?,?)}";
                        cs = con.prepareCall(sql);
                        cs.setString("_NOMBRE_CARGO",nomcargo);
                        cs.setString("_NOMBRE_PERIODO",nomPeriodo);
                        cs.setString("_NOMBRE_SUBPOTENCIAL",nomCompetencia);
                        rs = cs.executeQuery();
                        while(rs.next()){
                            PesoCriterio pesocriterio = new PesoCriterio();
                            pesocriterio.setIdPesoCriterio(rs.getInt("id_PesoCriterio"));
                            pesocriterio.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                            pesocriterio.getPeriodo().setNombre(rs.getString("periodo"));
                            pesocriterio.getCriterio().setIdCriterio(rs.getInt("id_Criterio"));
                            pesocriterio.getCriterio().setNombre(rs.getString("nombrehijo"));
                            Criterio criteriopadre = new Criterio();
                            criteriopadre.setIdCriterio(rs.getInt("id_CriterioPadre"));
                            criteriopadre.setNombre(rs.getString("nombrepadre"));
                            
                            pesocriterio.getCriterio().setCriterioPadre(criteriopadre);  
                            pesocriterio.getCriterio().setDescripcion(rs.getString("descripcion"));
                            pesocriterio.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                            pesocriterio.getPuestoTrabajo().setNombre(rs.getString("cargo"));
                            pesocriterio.setPeso(rs.getDouble("peso"));
                            pesoCriterios.add(pesocriterio);
                        }
                    }                            
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return pesoCriterios;
	}

        @Override
        public ArrayList<PesoCriterio> listar_subcriterios_x_criterio(int _id_criterio_padre, int _id_cargo, int _id_periodo) {
                ArrayList<PesoCriterio> pesoCriterios = new ArrayList<>();
                try{
                    Class.forName("com.mysql.cj.jdbc.Driver");
                    con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
                    String sql = "{call LISTAR_PESO_SUBCRI_X_ID_CRITERIO(?,?,?)}";
                    cs = con.prepareCall(sql);
                    cs.setInt("_ID_CRITERIO_PADRE",_id_criterio_padre);
                    cs.setInt("_ID_PERIODO",_id_periodo);
                    cs.setInt("_ID_PUESTO_TRABAJO",_id_cargo);
                    rs = cs.executeQuery();
                    while(rs.next()){
                        PesoCriterio pesocriterio = new PesoCriterio();
                        pesocriterio.getCriterio().setIdCriterio(rs.getInt("id_Criterio"));
                        pesocriterio.getCriterio().setNombre(rs.getString("nombre"));
                        Criterio c = new Criterio();
                        c.setIdCriterio(rs.getInt("id_CriterioPadre"));
                        pesocriterio.getCriterio().setCriterioPadre(c);
                        pesocriterio.getCriterio().setDescripcion(rs.getString("descripcion"));
                        pesocriterio.getCriterio().setTipo(rs.getInt("tipo"));
                        pesocriterio.setPeso(rs.getDouble("peso"));
                        pesocriterio.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                        pesocriterio.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                        pesoCriterios.add(pesocriterio);
                    }
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}finally{
			try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
		}
		return pesoCriterios;
        }
}