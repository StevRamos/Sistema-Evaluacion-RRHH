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
import pe.edu.pucp.sed.dao.EvaluacionDAO;
import pe.edu.pucp.sed.model.Evaluacion;
import pe.edu.pucp.sed.mysql.EvaluacionMySQL;

/**
 *
 * @author Luis Rodrigo
 */
@WebService(serviceName = "EvaluacionPotencialWS")
public class EvaluacionPotencialWS {

    private EvaluacionDAO daoEval;
    
    public EvaluacionDesempenhoWS(){
        daoEval = new EvaluacionMySQL();
    }
    
    
    @WebMethod(operationName = "insertarLineasEvaluacionPotencial")
    public int insertarLineasEvaluacionPotencial(@WebParam(name = "eval")Evaluacion eval ) {
        int resultado =0;
        try{
            resultado = daoEval.insertarLineasEvaluacionPotencial(eval);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarEvaluacionPotencial")
    public int actualizarEvaluacionPotencial(@WebParam(name = "eval")Evaluacion eval ) {
        int resultado =0;
        try{
            resultado = daoEval.actualizarEvaluacionPotencial(eval);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }


}
