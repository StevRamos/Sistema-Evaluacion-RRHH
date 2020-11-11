package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.ColaboradorDAO;
import pe.edu.pucp.sed.model.Colaborador;

public class ColaboradorMySQL implements ColaboradorDAO{

    Connection con;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(Colaborador colaborador){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_COLABORADOR(?,?,?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_COLABORADOR", java.sql.Types.INTEGER);
            cs.setString("_DNI", colaborador.getDni());
            cs.setString("_NOMBRES", colaborador.getNombres());
            cs.setString("_APELLIDOS", colaborador.getApellidos());
            cs.setString("_DIRECCION", colaborador.getDireccion());
            cs.setString("_CORREO", colaborador.getCorreo());
            cs.setString("_TELEFONO", colaborador.getTelefono());
            cs.setDate("_FECHANAC", 
                    new java.sql.Date(colaborador.getFechaNac().getTime()));
            cs.setInt("_ID_JEFE", colaborador.getJefe().getIdColaborador());
            
            cs.executeUpdate();
            colaborador.setIdColaborador(cs.getInt("_ID_COLABORADOR"));
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Colaborador colaborador){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_COLABORADOR(?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            //System.out.println(colaborador.getIdColaborador());
            cs.setInt("_ID_COLABORADOR", colaborador.getIdColaborador());
             cs.setString("_DIRECCION", colaborador.getDireccion());
            cs.setString("_CORREO", colaborador.getCorreo());
            cs.setString("_TELEFONO", colaborador.getTelefono());
            cs.setDate("_FECHANAC", 
                    new java.sql.Date(colaborador.getFechaNac().getTime()));
            cs.setInt("_ID_JEFE", colaborador.getJefe().getIdColaborador());
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
    public int eliminar(int idColaborador){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_COLABORADOR(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_COLABORADOR", idColaborador);
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
    public ArrayList<Colaborador> listar(){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_COLABORADORES()}";
            cs = con.prepareCall(sql);
            rs = cs.executeQuery(); 
            while(rs.next()){
                Colaborador col = new Colaborador();
                col.setIdColaborador(rs.getInt("id_Colaborador"));
                col.setDni(rs.getString("dni"));
                col.setNombres(rs.getString("nombres"));
                col.setApellidos(rs.getString("apellidos"));
                col.setDireccion(rs.getString("direccion"));
                col.setCorreo(rs.getString("correo"));
                col.setTelefono(rs.getString("telefono"));
                col.setFechaNac(formato.parse(rs.getDate("fechaNac").toString()));
                
                colaboradores.add(col);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return colaboradores;
    }
    
    public ArrayList<Colaborador> listarColaboradoresXJefe( int idJefe ){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_COLABORADORES_X_JEFE(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_ID_JEFE", idJefe);
            rs = cs.executeQuery(); 
            while(rs.next()){
                Colaborador col = new Colaborador();
                col.setIdColaborador(rs.getInt("id_Colaborador"));
                col.getJefe().setIdColaborador(idJefe);
                col.setDni(rs.getString("dni"));
                col.setNombres(rs.getString("nombres"));
                col.setApellidos(rs.getString("apellidos"));
                col.setDireccion(rs.getString("direccion"));
                col.setCorreo(rs.getString("correo"));
                col.setTelefono(rs.getString("telefono"));
                col.setFechaNac(formato.parse(rs.getDate("fechaNac").toString()));
                col.getGerencia().setNombre(cs.getString(10));
                col.getGerencia().setDescripcion(cs.getString(11));
                col.getPuestoTrabajo().setNombre(cs.getString(12));
                col.getPuestoTrabajo().setDescripcion(cs.getString(13));
                
                colaboradores.add(col);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return colaboradores;
    }
    
    public Colaborador buscarJefe( int idJefe ){
        Colaborador jefe = new Colaborador();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call BUSCAR_JEFE(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_COLABORADOR", idJefe);
            rs = cs.executeQuery(); 
            while(rs.next()){
                jefe.setIdColaborador(rs.getInt("id_Colaborador"));
                jefe.getJefe().setIdColaborador(idJefe);
                jefe.setDni(rs.getString("dni"));
                jefe.setNombres(rs.getString("nombres"));
                jefe.setApellidos(rs.getString("apellidos"));
                jefe.setDireccion(rs.getString("direccion"));
                jefe.setCorreo(rs.getString("correo"));
                jefe.setTelefono(rs.getString("telefono"));
                jefe.setFechaNac(formato.parse(rs.getDate("fechaNac").toString()));
                jefe.getGerencia().setNombre(cs.getString(10));
                jefe.getGerencia().setDescripcion(cs.getString(11));
                jefe.getPuestoTrabajo().setNombre(cs.getString(12));
                jefe.getPuestoTrabajo().setDescripcion(cs.getString(13));
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return jefe;
    }
    
}
