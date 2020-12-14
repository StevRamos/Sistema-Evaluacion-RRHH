package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.HashMap;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.EvaluacionDAO;
import pe.edu.pucp.sed.model.Evaluacion;
import pe.edu.pucp.sed.model.LineaEvaluacion;
import pe.edu.pucp.sed.model.ItemPDI;
import pe.edu.pucp.sed.model.EstadoEvaluacion;
import pe.edu.pucp.sed.dao.ItemPDIDAO;
import pe.edu.pucp.sed.dao.ObjetivoDAO;
import pe.edu.pucp.sed.model.Criterio;
import pe.edu.pucp.sed.model.Escala;
import pe.edu.pucp.sed.dao.EscalaDAO;

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

    @Override
    public int insertarLineasEvaluacionPotencial(Evaluacion evaluacion){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            
            String sql;
            
            sql = "{call ACTUALIZAR_EVALUACIONPOTENCIAL(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_EVALUACION", evaluacion.getIdEvaluacion());
            cs.setInt("_ID_ESCALAPRE", evaluacion.getEscalaPreCupos().getIdEscala());
            cs.setInt("_ID_ESCALASIN", evaluacion.getEscalaSinCalibrar().getIdEscala());
            cs.setInt("_ID_ESCALAFIN", evaluacion.getEscalaFinal().getIdEscala());
            cs.setInt("_ESTADOPDI", evaluacion.getEstadoPDI());
            cs.setString("_OBSERVACIONES", evaluacion.getObservaciones());
            cs.setDouble("_NOTAFINAL", evaluacion.getNotaFinal());
            cs.setInt("_ESTADO", evaluacion.getEstado());

            
            cs.executeUpdate();
            
              //registrar lineas evaluacion
               
                //registrar padre
               for(LineaEvaluacion lEval : evaluacion.getLineasEvaluacion()){
                    sql = "{call INSERTAR_LINEA_EVALUACION(?,?,?,?,?,?,?)}";
                    cs = con.prepareCall(sql);
                   cs.registerOutParameter("_ID_LINEA_EVALUACION", java.sql.Types.INTEGER);

                   cs.setInt("_ID_EVALUACION", evaluacion.getIdEvaluacion());
                   cs.setInt("_ID_LINEA_EVALUACION_PADRE", -1);
                   cs.setInt("_ID_PESO_CRITERIO", lEval.getPesoCriterio().getIdPesoCriterio());
                   cs.setDouble("_NOTAAUTOEVAL", -1);  
                   cs.setDouble("_NOTAPREVIA", -1);  
                   cs.setDouble("_NOTAFINAL", lEval.getNotaFinal());  
                   
                   cs.executeUpdate();
                   
                   lEval.setIdLineaEvaluacion(cs.getInt("_ID_LINEA_EVALUACION"));
                   //insertar hijos
                   for(LineaEvaluacion subLineaEval : lEval.getSublineasEvaluacion()){
                     
                       
                       sql = "{call INSERTAR_LINEA_EVALUACION(?,?,?,?,?,?,?)}";
                       cs = con.prepareCall(sql);
                       
                        cs.registerOutParameter("_ID_LINEA_EVALUACION", java.sql.Types.INTEGER);
                       
                        cs.setInt("_ID_EVALUACION", evaluacion.getIdEvaluacion());
                        cs.setInt("_ID_LINEA_EVALUACION_PADRE", lEval.getIdLineaEvaluacion());
                        cs.setInt("_ID_PESO_CRITERIO", subLineaEval.getPesoCriterio().getIdPesoCriterio());
                        cs.setDouble("_NOTAAUTOEVAL", -1);  
                        cs.setDouble("_NOTAPREVIA", -1);  
                        cs.setDouble("_NOTAFINAL", subLineaEval.getNotaFinal()); 
                        cs.executeUpdate();
                   }
                
                
               }

            con.commit();
            resultado = 1;
        }catch(Exception ex){
            try{
                con.rollback();
            }catch(Exception exR){
                System.out.println(exR.getMessage());
            }
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.setAutoCommit(true);
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado; 
    }

    @Override
    public int actualizarEvaluacionPotencial(Evaluacion evaluacion){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            
            String sql;
            
            sql = "{call ACTUALIZAR_EVALUACIONPOTENCIAL(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_EVALUACION", evaluacion.getIdEvaluacion());
            cs.setInt("_ID_ESCALAPRE", evaluacion.getEscalaPreCupos().getIdEscala());
            cs.setInt("_ID_ESCALASIN", evaluacion.getEscalaSinCalibrar().getIdEscala());
            cs.setInt("_ID_ESCALAFIN", evaluacion.getEscalaFinal().getIdEscala());
            cs.setInt("_ESTADOPDI", evaluacion.getEstadoPDI());
            cs.setString("_OBSERVACIONES", evaluacion.getObservaciones());
            cs.setDouble("_NOTAFINAL", evaluacion.getNotaFinal());
            cs.setInt("_ESTADO", evaluacion.getEstado());
            
            cs.executeUpdate();
            
                //actualizar lineas evaluacion 
                for(LineaEvaluacion lEval : evaluacion.getLineasEvaluacion()){
                    sql = "{call ACTUALIZAR_LINEA_EVALUACION(?,?,?,?,?,?,?)}";
                    cs = con.prepareCall(sql);
                
                    cs.setInt("_ID_LINEA_EVALUACION", lEval.getIdLineaEvaluacion());
                    cs.setInt("_ID_ITEM", lEval.getItemPDI().getIdItemPDI());
                    cs.setDouble("_NOTAAUTOEVAL", -1);  
                    cs.setDouble("_NOTAPREVIA", -1);  
                    cs.setDouble("_NOTAFINAL", lEval.getNotaFinal());  
                    cs.setString("_ACCIONES", lEval.getAccionesAtomar());
                    cs.setDate("_FECHA", 
                             new java.sql.Date(lEval.getFechaCumplimiento().getTime()));
                    
                    cs.executeUpdate();
                    for(LineaEvaluacion subLineaEval : lEval.getSublineasEvaluacion()){
                        sql = "{call ACTUALIZAR_LINEA_EVALUACION(?,?,?,?,?,?,?)}";
                        cs = con.prepareCall(sql);

                        cs.setInt("_ID_LINEA_EVALUACION", subLineaEval.getIdLineaEvaluacion());
                        cs.setInt("_ID_ITEM", subLineaEval.getItemPDI().getIdItemPDI());
                        cs.setDouble("_NOTAAUTOEVAL", -1);  
                        cs.setDouble("_NOTAPREVIA", -1);  
                        cs.setDouble("_NOTAFINAL", subLineaEval.getNotaFinal());  
                        cs.setString("_ACCIONES", subLineaEval.getAccionesAtomar());
                        cs.setDate("_FECHA", 
                                 new java.sql.Date(subLineaEval.getFechaCumplimiento().getTime()));

                        cs.executeUpdate();   
                    }
                    
                }


            con.commit();
            resultado = 1;
        }catch(Exception ex){
            try{
                con.rollback();
            }catch(Exception exR){
                System.out.println(exR.getMessage());
            }
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.setAutoCommit(true);
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;  
    }


    @Override
    public Evaluacion obtenerEvaluacionPotencial(int idColaborador, int idPeriodo){
        Evaluacion evaluacionPot = new Evaluacion();
        EscalaDAO daoEscala = new EscalaMySQL();
        ItemPDIDAO daoItem = new ItemPDIMySQL();
        HashMap<Integer, Escala> escalas = new HashMap<>();
        HashMap<Integer, ItemPDI> itemsPDI = new HashMap<>();
      //  ObjetivoDAO daoObjetivo = new ObjetivoMySQL();
        int aux = 0;
        
        for(Escala e : daoEscala.listar())
            escalas.put(e.getIdEscala(), e);
        
        for(ItemPDI i : daoItem.listar())
            itemsPDI.put(i.getIdItemPDI(), i);
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            
            String sql = "{call LISTAR_EVAL_POTENCIAL_POR_PERIODO(?,?)}";
            
            cs = con.prepareCall(sql);
            cs.setInt("_ID_COLABORADOR",idColaborador);
            cs.setInt("_ID_PERIODO",idPeriodo);
            
            rs = cs.executeQuery();
            rs.next();
            
            evaluacionPot.setIdEvaluacion(rs.getInt("id_Evaluacion"));
            
            aux = rs.getInt("id_EscalaPreCupos");
            if(aux != 0)
                evaluacionPot.setEscalaPreCupos(escalas.get(aux));
            
            aux = rs.getInt("id_EscalaSinCalibrar");
            if(aux != 0)
                evaluacionPot.setEscalaSinCalibrar(escalas.get(aux));
            
            aux = rs.getInt("id_EscalaFinal");
            if(aux != 0)
                evaluacionPot.setEscalaFinal(escalas.get(aux));
            
            evaluacionPot.setEstadoPDI(rs.getInt("estadoPDI"));
            evaluacionPot.setObservaciones(rs.getString("observaciones"));
            // evaluacionDesempenho.setNotaAutoEval(rs.getDouble("notaAutoEval"));
            evaluacionPot.setNotaFinal(rs.getDouble("notaFinal"));
            evaluacionPot.setEstado(rs.getInt("estado"));
            
            // evaluacionDesempenho.setObservacionesComp(rs.getString("observacionesComp"));
            // evaluacionDesempenho.setObservacionesObj(rs.getString("observacionesObj"));

            // evaluacionDesempenho.setNotaAutoEvalComp(rs.getDouble("notaAutoEvalComp"));
            // evaluacionDesempenho.setNotaPreviaComp(rs.getDouble("notaPreviaComp"));
            // evaluacionDesempenho.setNotaFinalComp(rs.getDouble("notaFinalComp"));

            // evaluacionDesempenho.setNotaAutoEvalObj(rs.getDouble("notaAutoEvalObj"));
            // evaluacionDesempenho.setNotaPreviaObj(rs.getDouble("notaPreviaObj"));
            // evaluacionDesempenho.setNotaFinalObj(rs.getDouble("notaFinalObj"));
            
            
            // evaluacionDesempenho.setEstadoAutoEval(rs.getInt("estadoAutoEval"));
            // evaluacionDesempenho.setEstadoPlanificacion(rs.getInt("estadoPlanificacion"));
            
            rs.close();
            
            //evaluacionDesempenho.setObjetivos(daoObjetivo.listarObjetivosXColaborador(idColaborador));
            
            sql = "{call LISTAR_LINEAS_EVAL_POR_EVAL(?)}";
            
            cs = con.prepareCall(sql);
            cs.setInt("_ID_EVAL", evaluacionPot.getIdEvaluacion());
            
            rs = cs.executeQuery();
            while(rs.next()){
                LineaEvaluacion le = new LineaEvaluacion();
                
                le.setIdLineaEvaluacion(rs.getInt("id_LineasEvaluacion"));
                
                aux = rs.getInt("id_ItemPDI");
                if( aux != 0)
                    le.setItemPDI(itemsPDI.get(aux));
                
                le.getPesoCriterio().setIdPesoCriterio(rs.getInt("id_PesoCriterio"));
                le.getPesoCriterio().setPeso(rs.getDouble("peso"));
                
                le.getPesoCriterio().getPuestoTrabajo().
                        setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                
                le.getPesoCriterio().getCriterio().
                        setIdCriterio(rs.getInt("id_Criterio"));
                
                le.getPesoCriterio().getCriterio().
                        setCriterioPadre(new Criterio());
                
                le.getPesoCriterio().getCriterio().
                        getCriterioPadre().setIdCriterio(rs.getInt("id_CriterioPadre"));
                
                le.getPesoCriterio().getCriterio().
                        setNombre(rs.getString("nombre"));
                        
                le.getPesoCriterio().getCriterio().
                        setDescripcion(rs.getString("descripcion"));
                        
                le.getPesoCriterio().getCriterio().
                        setTipo(rs.getInt("tipo"));
                
                // le.setNotaAutoEval(rs.getInt("notaAutoEval"));
                // le.setNotaPrevia(rs.getInt("notaPrevia"));
                le.setNotaFinal(rs.getDouble("notaFinal"));

                evaluacionPot.getLineasEvaluacion().add(le);
            }
            
            rs.close();
            
            sql = "{call LISTAR_LINEAS_EVAL_X_LINEAP(?)}";
            
            for(LineaEvaluacion l : evaluacionPot.getLineasEvaluacion()){
                cs = con.prepareCall(sql);
                cs.setInt("_FID_LINEA", l.getIdLineaEvaluacion());

                rs = cs.executeQuery();
                while(rs.next()){
                    LineaEvaluacion le = new LineaEvaluacion();
                    
                    le.setIdLineaEvaluacion(rs.getInt("id_LineasEvaluacion"));
                
                    aux = rs.getInt("id_ItemPDI");
                    if( aux != 0)
                        le.setItemPDI(itemsPDI.get(aux));

                    le.getPesoCriterio().setIdPesoCriterio(rs.getInt("id_PesoCriterio"));
                    le.getPesoCriterio().setPeso(rs.getDouble("peso"));

                    le.getPesoCriterio().getPuestoTrabajo().
                            setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));

                    le.getPesoCriterio().getCriterio().
                            setIdCriterio(rs.getInt("id_Criterio"));

                    le.getPesoCriterio().getCriterio().
                            setCriterioPadre(new Criterio());

                    le.getPesoCriterio().getCriterio().
                            getCriterioPadre().setIdCriterio(rs.getInt("id_CriterioPadre"));

                    le.getPesoCriterio().getCriterio().
                            setNombre(rs.getString("nombre"));

                    le.getPesoCriterio().getCriterio().
                            setDescripcion(rs.getString("descripcion"));

                    le.getPesoCriterio().getCriterio().
                            setTipo(rs.getInt("tipo"));
                    
                    // le.setNotaAutoEval(rs.getInt("notaAutoEval"));
                    // le.setNotaPrevia(rs.getInt("notaPrevia"));
                    le.setNotaFinal(rs.getDouble("notaFinal"));

                    l.getSublineasEvaluacion().add(le);
                }
            
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return evaluacionPot;        

    }


}
