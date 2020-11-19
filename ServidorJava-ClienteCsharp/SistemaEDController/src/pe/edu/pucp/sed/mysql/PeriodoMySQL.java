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
            String sql = "{call INSERTAR_PERIODO(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.registerOutParameter("_ID_PERIODO", java.sql.Types.INTEGER);
            cs.setDate("_FECHA_INICIO", 
                   new java.sql.Date(periodo.getFechaInicio().getTime()));
            cs.setDate("_FECHA_FIN", 
                   new java.sql.Date(periodo.getFechaFin().getTime()));
            cs.setDate("_DIA_NOTIFICACION", 
                   new java.sql.Date(periodo.getDiaNotificacion().getTime()));
            cs.setTime("_HORA_NOTIFICACION", periodo.getHoraNotificacion());
            cs.setDouble("_PESO_EVAL_OBJ", periodo.getPesoEvalObj());
            cs.setDouble("_PESO_EVAL_COMP", periodo.getPesoEvalComp());
            cs.setString("_NOMBRE", periodo.getNombre());
            cs.executeUpdate();
            periodo.setIdPeriodo(cs.getInt("_ID_PERIODO"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Periodo periodo){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_PERIODO(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERIODO", periodo.getIdPeriodo());
            cs.setDate("_NEW_INI", 
                   new java.sql.Date(periodo.getFechaInicio().getTime()));
            cs.setDate("_NEW_FIN", 
                   new java.sql.Date(periodo.getFechaFin().getTime()));
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
    public int eliminar(int idPeriodo){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_PERIODO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERIODO", idPeriodo);   
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
                per.setDiaNotificacion(rs.getDate("diaNotificacion"));
                per.setHoraNotificacion(rs.getTime("horaNotificacion"));
                per.setNombre(rs.getString("nombre"));
                
                periodos.add(per);
            }
            rs.close();
            //falta acabar
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
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_PERIODO()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery(); 

            per.setIdPeriodo(rs.getInt("id_Periodo"));
            per.setFechaInicio(rs.getDate("fechaInicio"));
            per.setFechaFin(rs.getDate("fechaFin"));
            per.setPesoEvalObj(rs.getDouble("pesoEvalObj"));
            per.setPesoEvalComp(rs.getDouble("pesoEvalComp"));
            per.setDiaNotificacion(rs.getDate("diaNotificacion"));
            per.setHoraNotificacion(rs.getTime("horaNotificacion"));
            per.setNombre(rs.getString("nombre"));
     
            rs.close();
            //falta acabar
            
            cs = con.prepareCall(" call LISTAR_PESOSCRITERIO_X_ID_PERIODO() ");
            rs = cs.executeQuery();
            ArrayList<PesoCriterio> pesosCriterios = new ArrayList();
            while(rs.next()){
                PesoCriterio pc = new PesoCriterio();
                pc.setIdPesoCriterio(rs.getInt("id_Criterio"));
                pc.setPeso(rs.getDouble("peso"));
                pesosCriterios.add(pc);
            }
            per.setPesosCriterio(pesosCriterios);
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return per;
    }
}
