/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.sed.dao.ColaboradorDAO;
import pe.edu.pucp.sed.model.Colaborador;
import pe.edu.pucp.sed.mysql.ColaboradorMySQL;

/**
 *
 * @author stevramos
 */
@WebService(serviceName = "ColaboradorWS")
public class ColaboradorWS {

    private ColaboradorDAO daoColaborador;

    public ColaboradorWS() {
        daoColaborador = new ColaboradorMySQL();
    }
    
    
    @WebMethod(operationName = "listarColaboradores")
    public ArrayList<Colaborador> listarColaboradores() {
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try {
            colaboradores = daoColaborador.listar();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaboradores;
    }
}