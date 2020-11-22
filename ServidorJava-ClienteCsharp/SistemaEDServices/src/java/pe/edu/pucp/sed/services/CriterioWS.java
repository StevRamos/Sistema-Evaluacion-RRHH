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
    @WebMethod(operationName = "listarCriterios")
    public ArrayList<Criterio> listarCriterios(@WebParam(name = "tipo") int tipo,@WebParam(name = "nomcargo") String nomcargo,
            @WebParam(name = "nomPeriodo") String nomPeriodo,@WebParam(name = "nomCompetencia") String nomCompetencia) {
        ArrayList<Criterio> criterios = new ArrayList();
//        try{
//            criterios =  daoCriterio.listar();
//        }catch( Exception ex){
//            System.out.println(ex.getMessage());
//        }
        return criterios;
    }
}
