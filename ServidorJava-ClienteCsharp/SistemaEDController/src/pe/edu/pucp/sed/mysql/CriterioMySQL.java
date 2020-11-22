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
import pe.edu.pucp.sed.model.PesoCriterio;

public class CriterioMySQL implements CriterioDAO{
	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar_masivo(Criterio criterio){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call INSERTAR_CRITERIO(?,?,?,?,?)}";
			cs = con.prepareCall(sql);
                        cs.setInt("_ID_CRITERIO", criterio.getIdCriterio());
                        if (criterio.getCriterioPadre().getIdCriterio()==-1){
                            cs.setInt("_ID_CRITERIOPADRE", -1);
                        }else{
                            cs.setInt("_ID_CRITERIOPADRE", criterio.getCriterioPadre().getIdCriterio());
                        }
                        cs.setString("_NOMBRE",criterio.getNombre());
                        cs.setString("_DESCRIPCION",criterio.getDescripcion());
                        cs.setInt("_TIPO",criterio.getTipo());                        
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
	public int actualizar(Criterio criterio){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ACTUALIZAR_CRITERIO(?,?)}";
			cs = con.prepareCall(sql);
                        cs.setString("_DESCRIPCION",criterio.getDescripcion());
                        cs.setInt("_ID_CRITERIO",criterio.getIdCriterio());
                        cs.setString("_NOMBRE_CRITERIO", criterio.getNombre());
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
                            criterio.setDescripcion(rs.getString("descripcion"));
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

        @Override
        public int insertar_individual(Criterio criterio) {
            int resultado = 0;
            try{
                Class.forName("com.mysql.cj.jdbc.Driver");
                con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
                con.setAutoCommit(false);
                
                String sql = "{call INSERTAR_CRITERIO_INDIVIDIAL(?,?,?,?,?)}";   
                cs = con.prepareCall(sql);
                cs.registerOutParameter("_ID_CRITERIO", java.sql.Types.INTEGER);
                if (criterio.getCriterioPadre().getIdCriterio()==-1){
                    cs.setInt("_ID_CRITERIOPADRE", -1);
                }else{
                    cs.setInt("_ID_CRITERIOPADRE", criterio.getCriterioPadre().getIdCriterio());
                }
                cs.setString("_NOMBRE",criterio.getNombre());
                cs.setString("_DESCRIPCION",criterio.getDescripcion());
                cs.setInt("_TIPO",criterio.getTipo());
                
                cs.executeUpdate();

                criterio.setIdCriterio(cs.getInt("_ID_CRITERIO"));
                
                for(PesoCriterio pc: criterio.getPesoscriterios()){
                    sql = "{call INSERTAR_PESO_CRITERIO_STR(?,?,?,?,?)}";     
                    cs = con.prepareCall(sql);
                    cs.registerOutParameter("_ID_PESO_CRITERIO", java.sql.Types.INTEGER);
                    cs.setString("_NOMBRE_PERIODO",pc.getNombrePeriodo());
                    cs.setString("_NOMBRE_PUESTO_TRABAJO",pc.getNombrePuestoTrabajo());
                    cs.setString("_NOMBRE_CRITERIO",pc.getNombreCriterio());
                    cs.setDouble("_PESO", pc.getPeso());
                    cs.executeUpdate();
                    pc.setIdPesoCriterio(cs.getInt("_ID_PESO_CRITERIO"));
                }
                con.commit();
                System.out.println("8888888");
                resultado = 1;
            }catch(Exception ex){
                try{
                    con.rollback();
                }catch(Exception exR){
                    System.out.println(exR.getMessage());
                }
                System.out.println("*******");
                System.out.println(ex.getMessage());
            }finally{
                try{
                    con.setAutoCommit(true);
                    con.close();
                }catch(Exception ex){
                    System.out.println(ex.getMessage());
                }
                System.out.println("--------");
            }
            return resultado;
        }
}