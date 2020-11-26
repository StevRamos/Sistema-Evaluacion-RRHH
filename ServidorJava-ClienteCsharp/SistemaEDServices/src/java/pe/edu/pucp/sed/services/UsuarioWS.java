/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.sed.dao.UsuarioDAO;
import pe.edu.pucp.sed.model.Usuario;
import pe.edu.pucp.sed.mysql.UsuarioMySQL;

/**
 *
 * @author Jorge Miguel Baca
 */
@WebService(serviceName = "UsuarioWS")
public class UsuarioWS {

    private UsuarioDAO daoUsuario;

    public UsuarioWS() {
        this.daoUsuario = new UsuarioMySQL();
    }
    
    @WebMethod(operationName = "insertarUsuario")
    public int insertarUsuario(@WebParam(name = "usuario") Usuario usuario){
        int resultado = 0;
        try{
            resultado =  daoUsuario.insertar(usuario);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
}
