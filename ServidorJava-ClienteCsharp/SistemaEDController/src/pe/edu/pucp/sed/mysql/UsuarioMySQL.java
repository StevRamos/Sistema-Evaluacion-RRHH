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
    
}
