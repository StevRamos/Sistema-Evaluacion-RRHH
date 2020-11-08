package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.EvaluacionDAO;
import pe.edu.pucp.sed.model.Evaluacion;

public class EvaluacionMySQL implements EvaluacionDAO{

	Connection con;
	PreparedStatement ps;
	ResultSet rs;
	CallableStatement cs;

	@Override
	public int insertar(Evaluacion evaluacion){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call INSERTAR_EVALUACION(?,?,?,?,?,?)}";
                        cs = con.prepareCall(sql);

                         cs.setInt("_ID_COLABORADOR",evaluacion.getColaborador().getIdColaborador());
                         cs.setInt("_ID_PERIODO",evaluacion.getPeriodo().getIdPeriodo());
                         cs.setInt("_ID_ESCALAPRECUPOS",evaluacion.getEscalaPreCupos().getIdEscala());
                         cs.setInt("_ID_ESCALASINCALIBRAR",evaluacion.getEscalaSinCalibrar().getIdEscala());
                         cs.setInt("_ID_ESCALAFINAL",evaluacion.getEscalaFinal().getIdEscala());
                         cs.registerOutParameter("_ID_EVALUACION", java.sql.Types.INTEGER);

                         cs.executeUpdate();

                         evaluacion.setIdEvaluacion(cs.getInt("_ID_EVALUACION"));

                         resultado = 1;
                 }catch(Exception ex){
                         System.out.println(ex.getMessage());
                 }finally{
                         try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
                 }
                 return resultado;
	}
	@Override
	public int actualizar(Evaluacion evaluacion){
		int resultado = 0;
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
			String sql = "{call ACTUALIZAR_EVALUACION(?,?,?,?,?,?)}";
                        cs = con.prepareCall(sql);

                        cs.setInt("_ID_EVALUACION",evaluacion.getIdEvaluacion());
                        cs.setInt("_ESTADOPDI",evaluacion.getEstadoPDI());
                        cs.setString("_OBSERVACIONES",evaluacion.getObservaciones());
                        cs.setDouble("_NOTAAUTOEVAL",evaluacion.getNotaAutoEval());
                        cs.setDouble("_NOTAFINAL",evaluacion.getNotaFinal());
                        cs.setBoolean("_TIPO", evaluacion.getTipo());

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
	public int eliminar(int idEvaluacion){
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
	public ArrayList<Evaluacion> listar(){
		ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
		try{
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);

			String sql = "{call LISTAR_EVALUACION()}";
                            cs = con.prepareCall(sql);

                        rs = cs.executeQuery(sql);
                        while(rs.next()){
                            Evaluacion evaluacion = new Evaluacion();
                            evaluacion.setIdEvaluacion(rs.getInt("id_Evaluacion"));
                            //evaluacionDesempenho.getColaborador(rs.getString("id_Colaborador"));
                            //evaluacionDesempenho.setDescripcion(rs.getString("id_Periodo"));
                            evaluacion.setEstadoPDI(rs.getInt("estadoPDI"));
                            evaluacion.setObservaciones(rs.getString("observaciones"));
                            evaluacion.setTipo(rs.getBoolean("tipo"));
                            evaluacion.setNotaAutoEval(rs.getDouble("notaAutoEval"));
                            evaluacion.setNotaFinal(rs.getDouble("notaFinal"));

                            evaluaciones.add(evaluacion);
                        }


                    }catch(Exception ex){
                        System.out.println(ex.getMessage());
                    }finally{
                        try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
                    }
                    return evaluaciones;
	}
}
