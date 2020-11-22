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
import pe.edu.pucp.sed.dao.PesoCriterioDAO;
import pe.edu.pucp.sed.model.PesoCriterio;
import pe.edu.pucp.sed.mysql.PesoCriterioMySQL;

/**
 *
 * @author Luis Rodrigo
 */
@WebService(serviceName = "PesoCriterioWS")
public class PesoCriterioWS {

    private PesoCriterioDAO daopesocriterio;
    
    public PesoCriterioWS(){
        daopesocriterio = new PesoCriterioMySQL();
    }
    
    @WebMethod(operationName = "insertarPesoCriterio")
    public int insertarPesoCriterio(@WebParam(name = "pesocriterio") PesoCriterio pesocriterio){
        int resultado = 0;
        try{
            resultado =  daopesocriterio.insertar(pesocriterio);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    


    @WebMethod(operationName = "actualizarPesoCriterio")
    public int actualizarPesoCriterio(@WebParam(name = "pesocriterio") PesoCriterio pesocriterio){
        int resultado = 0;
        try{
            resultado =  daopesocriterio.actualizar(pesocriterio);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarPesoCriterio")
    public int eliminarPesoCriterio(@WebParam(name = "pesocriterio") PesoCriterio pesocriterio){
        int resultado = 0;
        try{
            resultado = daopesocriterio.eliminar(pesocriterio) ;
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "listarPesosCriterios")
    public ArrayList<PesoCriterio> listarPesosCriterios(@WebParam(name = "tipo") int tipo,@WebParam(name = "nomcargo") String nomcargo,
            @WebParam(name = "nomPeriodo") String nomPeriodo,@WebParam(name = "nomCompetencia") String nomCompetencia) {
        ArrayList<PesoCriterio> pesoscriterios = new ArrayList<>();
        try{
            pesoscriterios =  daopesocriterio.listar(tipo, nomcargo, nomPeriodo, nomCompetencia);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return pesoscriterios;
    }
}
