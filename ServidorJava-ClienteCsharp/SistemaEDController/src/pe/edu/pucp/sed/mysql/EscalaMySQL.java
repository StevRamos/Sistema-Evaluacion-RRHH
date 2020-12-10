package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.EscalaDAO;
import pe.edu.pucp.sed.model.Escala;

public class EscalaMySQL implements EscalaDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(Escala escala){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_ESCALA(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_ESCALA", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", escala.getNombre());
            cs.setBoolean("_TIPO", escala.getTipo());
            cs.executeUpdate();
            escala.setIdEscala(cs.getInt("_ID_ESCALA"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Escala escala){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_ESCALA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ESCALA", escala.getIdEscala());
            cs.setString("_NOMBRE", escala.getNombre());
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
    public int eliminar(int idEscala){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_ESCALA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ESCALA", idEscala);
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
    public ArrayList<Escala> listar(){
        ArrayList<Escala> escalas = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_ESCALA()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery(); 
            while(rs.next()){            
                Escala esc = new Escala();
                esc.setIdEscala(rs.getInt("id_Escala"));
                esc.setNombre(rs.getString("nombre"));
                esc.setTipo(rs.getBoolean("tipo"));
                
                escalas.add(esc);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return escalas;
    }
}
