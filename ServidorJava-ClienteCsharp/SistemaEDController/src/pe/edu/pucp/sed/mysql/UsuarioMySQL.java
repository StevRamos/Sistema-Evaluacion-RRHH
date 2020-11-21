/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.UsuarioDAO;
import pe.edu.pucp.sed.model.Colaborador;
import pe.edu.pucp.sed.model.Gerencia;
import pe.edu.pucp.sed.model.PuestoTrabajo;
import pe.edu.pucp.sed.model.Usuario;

/**
 *
 * @author Jorge Miguel Baca
 */
public class UsuarioMySQL implements UsuarioDAO{
    
    Connection con;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public int insertar(Usuario usuario) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_USUARIO(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_USUARIO", usuario.getIdUsuario());
            cs.setString("_CONTRASENHA", usuario.getContrasenha());
            cs.setInt("_NIVEL_ACCESO", usuario.getNivelAcceso());
            
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
    public Colaborador autenticarUsuario(String correo, String contrasenha) {
        Colaborador col = null;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call AUTENTICAR_USUARIO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setString("_CORREO", correo);
            cs.setString("_CONTRASENHA", contrasenha);
            rs = cs.executeQuery(); 
            rs.next();
            
            col = new Colaborador();
            
            col.setIdColaborador(rs.getInt("id_Colaborador"));
            col.setJefe(new Colaborador());
            col.getJefe().setIdColaborador(rs.getInt("id_Jefe"));
            col.setDni(rs.getString("dni"));
            col.setNombres(rs.getString("nombres"));
            col.setApellidos(rs.getString("apellidos"));
            col.setDireccion(rs.getString("direccion"));
            col.setCorreo(rs.getString("correo"));
            col.setTelefono(rs.getString("telefono"));
            col.setFechaNac(formato.parse(rs.getDate("fechaNac").toString()));

            col.getGerencia().setIdGerencia(rs.getInt("id_Gerencias"));
            col.getGerencia().setNombre(rs.getString("nombreGerencia"));
            col.getGerencia().setDescripcion(rs.getString("descripcionGerencia"));

            col.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
            col.getPuestoTrabajo().setNombre(rs.getString("nombrePuestoTrabajo"));
            col.getPuestoTrabajo().setDescripcion(rs.getString("descripcionPuestoTrabajo"));
            
            col.setNivelAcceso(rs.getInt("nivelAcceso"));
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return col;
    }
    
}
