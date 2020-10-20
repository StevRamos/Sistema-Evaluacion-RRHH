package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.SubcriterioDAO;
import pe.edu.pucp.sed.model.Criterio;
import pe.edu.pucp.sed.model.Subcriterio;

public class SubcriterioMySQL implements SubcriterioDAO{

    Connection con;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(Subcriterio subcriterio){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_SUBCRITERIO(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_SUBCRITERIO", java.sql.Types.INTEGER);
            cs.setInt("_ID_CRITERIO", subcriterio.getIdSubcriterio());
            cs.setString("_NOMBRE", subcriterio.getNombre());
            cs.setString("_DESCRIPCION", subcriterio.getDescripcion());
            cs.setInt("_TIPO", subcriterio.getTipo()); //Posible Error por casteo de int a boolean
            cs.executeUpdate();
            subcriterio.setIdSubcriterio(cs.getInt("_ID_SUBCRITERIO"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Subcriterio subcriterio){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_SUBCRITERIO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_SUBCRITERIOS", subcriterio.getIdSubcriterio());
            cs.setString("_DESCRIPCION", subcriterio.getDescripcion());
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
    public int eliminar(int idSubcriterio){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_SUBCRITERIO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_SUBCRITERIOS", idSubcriterio);
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
    public ArrayList<Subcriterio> listar(){
        ArrayList<Subcriterio> subcriterios = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_PERIODO()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery(); 
            while(rs.next()){
                Subcriterio sub = new Subcriterio();
                Criterio cri = new Criterio();
                cri.setIdCriterio(rs.getInt("id_Criterio"));
                sub.setCriterio(cri);
                sub.setIdSubcriterio(rs.getInt("id_Subcriterios"));
                sub.setNombre(rs.getString("nombre"));
                sub.setDescripcion(rs.getString("descripcion"));
                sub.setEsVigente(rs.getBoolean("esVigente"));
                sub.setTipo(rs.getInt("tipo"));
                
                subcriterios.add(sub);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return subcriterios;
}
}
