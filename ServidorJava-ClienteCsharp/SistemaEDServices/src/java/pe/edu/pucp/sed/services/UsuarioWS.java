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
import pe.edu.pucp.sed.model.Colaborador;
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
    
    @WebMethod(operationName = "autenticarUsuario")
    public Colaborador autenticarUsuario(@WebParam(name = "correo") String correo,
            @WebParam(name = "contrasenha") String contrasenha) {
        Colaborador colaborador = new Colaborador();
        try{
            colaborador = daoUsuario.autenticarUsuario(correo, contrasenha);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
        return colaborador;
        
    }
}
