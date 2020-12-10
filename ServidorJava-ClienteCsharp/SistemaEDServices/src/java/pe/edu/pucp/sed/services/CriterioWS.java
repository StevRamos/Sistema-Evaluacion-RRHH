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
import pe.edu.pucp.sed.dao.CriterioDAO;
import pe.edu.pucp.sed.model.Criterio;
import pe.edu.pucp.sed.mysql.CriterioMySQL;

/**
 *
 * @author Luis Rodrigo
 */
@WebService(serviceName = "CriterioWS")
public class CriterioWS {

    private CriterioDAO daoCriterio;
    public CriterioWS(){
        daoCriterio = new CriterioMySQL();
    }
    
    @WebMethod(operationName = "insertarMasivo")
    public int insertarMasivo(@WebParam(name = "criterio") Criterio criterio){
        int resultado = 0;
        try{
            resultado =  daoCriterio.insertar_masivo(criterio);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarIndividual")
    public int insertarIndividual(@WebParam(name = "criterio") Criterio criterio){
        int resultado = 0;
        try{
            resultado =  daoCriterio.insertar_individual(criterio);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }


    @WebMethod(operationName = "actualizarCriterio")
    public int actualizarCriterio(@WebParam(name = "criterio") Criterio criterio){
        int resultado = 0;
        try{
            resultado =  daoCriterio.actualizar(criterio);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listar")
    public ArrayList<Criterio> listar(int tipo,String nombrecriterio) {
        ArrayList<Criterio> criterios = new ArrayList();
        try{
            criterios = daoCriterio.listar(tipo,nombrecriterio);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return criterios;
    }
}

