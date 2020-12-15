package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.PeriodoDAO;
import pe.edu.pucp.sed.model.EscalaPeriodo;
import pe.edu.pucp.sed.model.EstadoPeriodo;
import pe.edu.pucp.sed.model.GerenciaPeriodo;
import pe.edu.pucp.sed.model.ItemPDIPeriodo;
import pe.edu.pucp.sed.model.Periodo;
import pe.edu.pucp.sed.model.PesoCriterio;

public class PeriodoMySQL implements PeriodoDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public int insertar(Periodo periodo){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call INSERTAR_PERIODO(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.registerOutParameter("_ID_PERIODO", java.sql.Types.INTEGER);
            cs.setDate("_FECHA_INICIO", 
                   new java.sql.Date(periodo.getFechaInicio().getTime()));
            cs.setDate("_FECHA_FIN", 
                   new java.sql.Date(periodo.getFechaFin().getTime()));
            cs.setString("_DIA_NOTIFICACION", periodo.getDiaNotificacion());
            cs.setTime("_HORA_NOTIFICACION", periodo.getHoraNotificacion());
            cs.setDouble("_PESO_EVAL_OBJ", periodo.getPesoEvalObj());
            cs.setDouble("_PESO_EVAL_COMP", periodo.getPesoEvalComp());
            cs.setString("_NOMBRE", periodo.getNombre());
            cs.executeUpdate();
            periodo.setIdPeriodo(cs.getInt("_ID_PERIODO"));
            
            
            for(GerenciaPeriodo gPer : periodo.getConfiguracionFechas()){
                sql = "{call INSERTAR_GERENCIA_PERIODO(?,?,?,?,?,?,?,?,?,?,?,?)}";
                
                gPer.setPeriodo(periodo);
                
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PERIODO", gPer.getPeriodo().getIdPeriodo());
                cs.setInt("_ID_GERENCIA", gPer.getGerencia().getIdGerencia());
                cs.setDate("_FECHAINICIOPLAN", 
                   new java.sql.Date(gPer.getFechaInicioPlan().getTime()));
                cs.setDate("_FECHAFINPLAN", 
                   new java.sql.Date(gPer.getFechaFinPlan().getTime()));
                cs.setDate("_FECHAINICIOPDI", 
                   new java.sql.Date(gPer.getFechaInicioPDI().getTime()));
                cs.setDate("_FECHAFINPDI", 
                   new java.sql.Date(gPer.getFechaFinPDI().getTime()));
                cs.setDate("_FECHAINICIOEVALPREVD", 
                   new java.sql.Date(gPer.getFechaInicioEvalPrevD().getTime()));
                cs.setDate("_FECHAFINEVALPREVD", 
                   new java.sql.Date(gPer.getFechaFinEvalPrevD().getTime()));
                cs.setDate("_FECHAINICIOEVALFIND", 
                   new java.sql.Date(gPer.getFechaInicioEvalFinD().getTime()));
                cs.setDate("_FECHAFINEVALFIND", 
                   new java.sql.Date(gPer.getFechaFinEvalFinD().getTime()));
                cs.setDate("_FECHAINICIOCAL", 
                   new java.sql.Date(gPer.getFechaInicioCal().getTime()));
                cs.setDate("_FECHAFINCAL", 
                   new java.sql.Date(gPer.getFechaFinCal().getTime()));
                
                cs.executeUpdate();
            }
            
            for(EscalaPeriodo escalas : periodo.getEscalas()){
                sql = "{call REGISTRAR_ESCALA_PERIODO_INI(?,?,?,?,?)}";
                
                escalas.setPeriodo(periodo);
                
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PERIODO", escalas.getPeriodo().getIdPeriodo());
                cs.setInt("_ID_ESCALA", escalas.getEscala().getIdEscala());
                cs.setDouble("_NOTAMAX", escalas.getNotaMax());
                cs.setDouble("_NOTAMIN", escalas.getNotaMin());
                cs.setDouble("_PORCENTAJECUPOS", escalas.getPorcentajeCupos());
                cs.executeUpdate();
            }
                      
            for(ItemPDIPeriodo rangosPDI : periodo.getRangosPDI()){
                sql = "{call INSERTAR_ITEM_PDI_PERIODOS(?,?,?,?)}";
                
                rangosPDI.setPeriodo(periodo);
                
                cs = con.prepareCall(sql);
                cs.setInt("_ID_ITEMPDI", rangosPDI.getItemPDI().getIdItemPDI());
                cs.setInt("_ID_PERIODO", rangosPDI.getPeriodo().getIdPeriodo());
                cs.setDouble("_NOTAMIN", rangosPDI.getNotaMin());
                cs.setDouble("_NOTAMAX", rangosPDI.getNotaMax());
                cs.executeUpdate();
            }
            
            
            
            con.commit();
            
            
            resultado = periodo.getIdPeriodo();
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
    public int actualizar(Periodo periodo){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call ACTUALIZAR_PERIODO(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERIODO", periodo.getIdPeriodo());
            cs.setDate("_NEW_INI", 
                   new java.sql.Date(periodo.getFechaInicio().getTime()));
            cs.setDate("_NEW_FIN", 
                   new java.sql.Date(periodo.getFechaFin().getTime()));
            cs.setString("_NOMBRE", periodo.getNombre());
            cs.setDouble("_PESO_EVOBJETIVOS", periodo.getPesoEvalObj());
            cs.setDouble("_PESO_EVCOMPETENCIAS", periodo.getPesoEvalComp());
            cs.setString("_DIA_NOTIFICACION", periodo.getDiaNotificacion());
            cs.setTime("_HORA_NOT", new java.sql.Time(periodo.getHoraNotificacion().getTime()));

            cs.executeUpdate();
            
            
            for(GerenciaPeriodo gPer : periodo.getConfiguracionFechas()){
                sql = "{call ACTUALIZAR_GERENCIA_PERIODO(?,?,?,?,?,?,?,?,?,?,?,?)}";
                
                gPer.setPeriodo(periodo);
                
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PERIODO", gPer.getPeriodo().getIdPeriodo());
                cs.setInt("_ID_GERENCIA", gPer.getGerencia().getIdGerencia());

                cs.setDate("_FECHA_INICIO_PLAN", 
                       new java.sql.Date(gPer.getFechaInicioPlan().getTime()));
                cs.setDate("_FECHA_FIN_PLAN", 
                       new java.sql.Date(gPer.getFechaFinPlan().getTime()));
                cs.setDate("_FECHA_INICIO_PDI", 
                       new java.sql.Date(gPer.getFechaInicioPDI().getTime()));
                cs.setDate("_FECHA_FIN_PDI", 
                       new java.sql.Date(gPer.getFechaFinPDI().getTime()));
                cs.setDate("_FECHA_INICIO_EVAL_PREVD", 
                       new java.sql.Date(gPer.getFechaInicioEvalPrevD().getTime()));
                cs.setDate("_FECHA_FIN_EVAL_PREVD", 
                       new java.sql.Date(gPer.getFechaFinEvalPrevD().getTime()));
                cs.setDate("_FECHA_INICIO_EVAL_FIND", 
                       new java.sql.Date(gPer.getFechaInicioEvalFinD().getTime()));
                cs.setDate("_FECHA_FIN_EVAL_FIND", 
                       new java.sql.Date(gPer.getFechaFinEvalFinD().getTime()));
                cs.setDate("_FECHA_INICIO_CAL", 
                       new java.sql.Date(gPer.getFechaInicioCal().getTime()));
                cs.setDate("_FECHA_FIN_CAL", 
                       new java.sql.Date(gPer.getFechaFinCal().getTime()));

                cs.executeUpdate();
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
    public int eliminar(Periodo periodo){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call ELIMINAR_PERIODO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERIODO", periodo.getIdPeriodo());   
            cs.executeUpdate();
            
            
            for(GerenciaPeriodo gPer : periodo.getConfiguracionFechas()){
                sql = "{call ELIMINAR_GERENCIA_PERIODO(?,?)}";
                
                gPer.setPeriodo(periodo);
                
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PERIODO", gPer.getPeriodo().getIdPeriodo());
                cs.setInt("_ID_GERENCIA", gPer.getGerencia().getIdGerencia());
                cs.executeUpdate();
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
    public ArrayList<Periodo> listar(){
        ArrayList<Periodo> periodos = new ArrayList<>();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_PERIODO()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery(); 
            while(rs.next()){
                Periodo per = new Periodo();
                per.setIdPeriodo(rs.getInt("id_Periodo"));
                per.setFechaInicio(rs.getDate("fechaInicio"));
                per.setFechaFin(rs.getDate("fechaFin"));
                per.setPesoEvalObj(rs.getDouble("pesoEvalObj"));
                per.setPesoEvalComp(rs.getDouble("pesoEvalComp"));
                per.setDiaNotificacion(rs.getString("diaNotificacion"));
                per.setHoraNotificacion(rs.getTime("horaNotificacion"));
                per.setNombre(rs.getString("nombre"));
                per.setEstado(EstadoPeriodo.valueOf(rs.getInt("estado")));
                periodos.add(per);
            }
            rs.close();
            
            for(Periodo p : periodos){
                cs = con.prepareCall(" call LISTAR_PESOSCRITERIO_X_ID_PERIODO() ");
                rs = cs.executeQuery();
                while(rs.next()){
                    PesoCriterio pc = new PesoCriterio();
                    pc.setIdPesoCriterio(rs.getInt("id_Criterio"));
                    pc.setPeso(rs.getDouble("peso"));
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return periodos;
    }

    @Override
    public Periodo obtenerPeriodoActual() {
        Periodo per = new Periodo();
        int resultado = 0;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call OBTENER_PERIODO_ACTUAL()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery(); 
            rs.next();
            per.setIdPeriodo(rs.getInt("id_Periodo"));
            per.setFechaInicio(rs.getDate("fechaInicio"));
            per.setFechaFin(rs.getDate("fechaFin"));
            per.setPesoEvalObj(rs.getDouble("pesoEvalObj"));
            per.setPesoEvalComp(rs.getDouble("pesoEvalComp"));
            per.setDiaNotificacion(rs.getString("diaNotificacion"));
            per.setHoraNotificacion(rs.getTime("horaNotificacion"));
            per.setNombre(rs.getString("nombre"));
            resultado =1;
            rs.close();
            //falta acabar
            
//            cs = con.prepareCall(" call LISTAR_PESOSCRITERIO_X_ID_PERIODO() ");
//            rs = cs.executeQuery();
//            ArrayList<PesoCriterio> pesosCriterios = new ArrayList();
//            while(rs.next()){
//                PesoCriterio pc = new PesoCriterio();
//                pc.setIdPesoCriterio(rs.getInt("id_Criterio"));
//                pc.setPeso(rs.getDouble("peso"));
//                pesosCriterios.add(pc);
//            }
//            per.setPesosCriterio(pesosCriterios);
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return per;
    }

    @Override
    public Periodo listarGerenciaPeriodo(Periodo periodo) {
        ArrayList<GerenciaPeriodo> gerenciasPeriodo = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_GERENCIA_PERIODO_X_PERIODO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_PERIODO", periodo.getIdPeriodo());
            rs = cs.executeQuery(); 
            while(rs.next()){
                GerenciaPeriodo gerPer = new GerenciaPeriodo();
                gerPer.setPeriodo(periodo);
                
                gerPer.getGerencia().setIdGerencia(rs.getInt("id_Gerencias"));
                gerPer.getGerencia().setNombre(rs.getString("nombre"));
                gerPer.getGerencia().setDescripcion(rs.getString("descripcion"));
                
                gerPer.setFechaFinCal(rs.getDate("fechaFinCal"));
                gerPer.setFechaFinEvalFinD(rs.getDate("fechaFinEvalFinD"));
                gerPer.setFechaFinEvalPrevD(rs.getDate("fechaFinEvalPrevD"));
                gerPer.setFechaFinPDI(rs.getDate("fechaFinPDI"));
                gerPer.setFechaFinPlan(rs.getDate("fechaFinPlan"));
                gerPer.setFechaInicioCal(rs.getDate("fechaInicioCal"));
                gerPer.setFechaInicioEvalFinD(rs.getDate("fechaInicioEvalFinD"));
                gerPer.setFechaInicioEvalPrevD(rs.getDate("fechaInicioEvalPrevD"));
                gerPer.setFechaInicioPDI(rs.getDate("fechaInicioPDI"));
                gerPer.setFechaInicioPlan(rs.getDate("fechaInicioPlan"));
                
                gerenciasPeriodo.add(gerPer);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        periodo.setConfiguracionFechas(gerenciasPeriodo);
        
        return periodo;        
    }

    @Override
    public ArrayList<GerenciaPeriodo> listarGerenciaPeriodoPorId(int idPeriodo) {
        ArrayList<GerenciaPeriodo> gerenciasPeriodo = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_GERENCIA_PERIODO_X_PERIODO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_PERIODO", idPeriodo);
            rs = cs.executeQuery(); 
            while(rs.next()){
                GerenciaPeriodo gerPer = new GerenciaPeriodo();
                gerPer.getPeriodo().setIdPeriodo(idPeriodo);
                
                gerPer.getGerencia().setIdGerencia(rs.getInt("id_Gerencias"));
                gerPer.getGerencia().setNombre(rs.getString("nombre"));
                gerPer.getGerencia().setDescripcion(rs.getString("descripcion"));
                
                gerPer.setFechaFinCal(rs.getDate("fechaFinCal"));
                gerPer.setFechaFinEvalFinD(rs.getDate("fechaFinEvalFinD"));
                gerPer.setFechaFinEvalPrevD(rs.getDate("fechaFinEvalPrevD"));
                gerPer.setFechaFinPDI(rs.getDate("fechaFinPDI"));
                gerPer.setFechaFinPlan(rs.getDate("fechaFinPlan"));
                gerPer.setFechaInicioCal(rs.getDate("fechaInicioCal"));
                gerPer.setFechaInicioEvalFinD(rs.getDate("fechaInicioEvalFinD"));
                gerPer.setFechaInicioEvalPrevD(rs.getDate("fechaInicioEvalPrevD"));
                gerPer.setFechaInicioPDI(rs.getDate("fechaInicioPDI"));
                gerPer.setFechaInicioPlan(rs.getDate("fechaInicioPlan"));
                
                gerenciasPeriodo.add(gerPer);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return gerenciasPeriodo;
    }

    @Override
    public ArrayList<EscalaPeriodo> listarEscalaPeriodo(int idPeriodo) {
        ArrayList<EscalaPeriodo> escalasPeriodo = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_ESCALA_PERIODO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_PERIODO", idPeriodo);
            rs = cs.executeQuery(); 
            while(rs.next()){
                EscalaPeriodo escPer = new EscalaPeriodo();
                
                escPer.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                escPer.getPeriodo().setFechaInicio(rs.getDate("fechaInicio"));
                escPer.getPeriodo().setFechaFin(rs.getDate("fechaFin"));
                escPer.getPeriodo().setPesoEvalObj(rs.getDouble("pesoEvalObj"));
                escPer.getPeriodo().setPesoEvalComp(rs.getDouble("pesoEvalComp"));
                escPer.getPeriodo().setDiaNotificacion(rs.getString("diaNotificacion"));
                escPer.getPeriodo().setHoraNotificacion(rs.getTime("horaNotificacion"));
                escPer.getPeriodo().setNombre(rs.getString("nombrePeriodo"));
                
                escPer.getEscala().setIdEscala(rs.getInt("id_Escala"));
                escPer.getEscala().setNombre(rs.getString("nombreEscala"));
                escPer.getEscala().setTipo(rs.getBoolean("tipo"));
                
                escPer.setNotaMax(rs.getDouble("notaMax"));
                escPer.setNotaMin(rs.getDouble("notaMin"));
                escPer.setPorcentajeCupos(rs.getDouble("porcentajeCupos"));
                
                escalasPeriodo.add(escPer);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return escalasPeriodo;
    }

    @Override
    public ArrayList<ItemPDIPeriodo> listarItemPDIPeriodo(int idPeriodo) {
        ArrayList<ItemPDIPeriodo> itemsPeriodo = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_ITEM_PDI_PERIODOS(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_PERIODO", idPeriodo);
            rs = cs.executeQuery(); 
            while(rs.next()){
                ItemPDIPeriodo iPer = new ItemPDIPeriodo();
                
                iPer.getPeriodo().setIdPeriodo(rs.getInt("id_Periodo"));
                iPer.getPeriodo().setFechaInicio(rs.getDate("fechaInicio"));
                iPer.getPeriodo().setFechaFin(rs.getDate("fechaFin"));
                iPer.getPeriodo().setPesoEvalObj(rs.getDouble("pesoEvalObj"));
                iPer.getPeriodo().setPesoEvalComp(rs.getDouble("pesoEvalComp"));
                iPer.getPeriodo().setDiaNotificacion(rs.getString("diaNotificacion"));
                iPer.getPeriodo().setHoraNotificacion(rs.getTime("horaNotificacion"));
                iPer.getPeriodo().setNombre(rs.getString("nombrePeriodo"));
                
                iPer.getItemPDI().setIdItemPDI(rs.getInt("id_ItemPDI"));
                iPer.getItemPDI().setNombre(rs.getString("nombreItemPDI"));
                
                iPer.setNotaMax(rs.getDouble("notaMax"));
                iPer.setNotaMin(rs.getDouble("notaMin"));
                
                itemsPeriodo.add(iPer);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return itemsPeriodo;
    
    }

    @Override
    public int actualizarRangos(Periodo periodo) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql;
            
            for(EscalaPeriodo escalas : periodo.getEscalas()){
                sql = "{call ACTUALIZAR_ESCALA_PERIODO(?,?,?,?,?)}";
                
                escalas.setPeriodo(periodo);
                
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PERIODO", escalas.getPeriodo().getIdPeriodo());
                cs.setInt("_ID_ESCALA", escalas.getEscala().getIdEscala());
                cs.setDouble("_NOTAMAX", escalas.getNotaMax());
                cs.setDouble("_NOTAMIN", escalas.getNotaMin());
                cs.setDouble("_PORCENTAJECUPOS", escalas.getPorcentajeCupos());
                cs.executeUpdate();
            }
                      
            for(ItemPDIPeriodo rangosPDI : periodo.getRangosPDI()){
                sql = "{call ACTUALIZAR_ITEM_PDI_PERIODOS(?,?,?,?)}";
                
                rangosPDI.setPeriodo(periodo);
                
                cs = con.prepareCall(sql);
                cs.setInt("_ID_PERIODO", rangosPDI.getPeriodo().getIdPeriodo());
                cs.setInt("_ID_ITEMPDI", rangosPDI.getItemPDI().getIdItemPDI());
                cs.setDouble("_NOTAMIN", rangosPDI.getNotaMin());
                cs.setDouble("_NOTAMAX", rangosPDI.getNotaMax());
                cs.executeUpdate();
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
   
    
    
    
}
