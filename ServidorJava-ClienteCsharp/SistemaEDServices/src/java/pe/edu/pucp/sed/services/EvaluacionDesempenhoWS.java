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
import pe.edu.pucp.sed.dao.EvaluacionDesempenhoDAO;
import pe.edu.pucp.sed.model.EvaluacionDesempenho;
import pe.edu.pucp.sed.mysql.EvaluacionDesempenhoMySQL;

/**
 *
 * @author Luis Rodrigo
 */
@WebService(serviceName = "EvaluacionDesempenhoWS")
public class EvaluacionDesempenhoWS {

    private EvaluacionDesempenhoDAO daoEvalDesempenho;
    
    public EvaluacionDesempenhoWS(){
        daoEvalDesempenho = new EvaluacionDesempenhoMySQL();
    }
    
    @WebMethod(operationName = "listarDesempenhoPorPeriodo")
    public ArrayList<EvaluacionDesempenho> listarDesempenhoPorPeriodo(@WebParam(name = "idColaborador")int idColaborador,
            @WebParam(name = "idPeriodo") int idPeriodo ) {
        ArrayList<EvaluacionDesempenho> evaluacionDes = new ArrayList<>();
        try{
            evaluacionDes =  daoEvalDesempenho.listarDesempenhoPorPeriodo(idColaborador,idPeriodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return evaluacionDes;
    }
    
    @WebMethod(operationName = "insertarLineasEvaluacionDesempenho")
    public int insertarLineasEvaluacionDesempenho(@WebParam(name = "evalDes")EvaluacionDesempenho evalDes ) {
        int resultado =0;
        try{
            resultado = daoEvalDesempenho.insertarLineasEvaluacionDesempenho(evalDes);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarEvaluacionDesempenho")
    public int actualizarEvaluacionDesempenho(@WebParam(name = "evalDes")EvaluacionDesempenho evalDes ) {
        int resultado =0;
        try{
            resultado = daoEvalDesempenho.actualizarEvaluacionDesempenho(evalDes);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "actualizarEstadoPlanificacion")
    public int actualizarEstadoPlanificacion(@WebParam(name = "evalDes")EvaluacionDesempenho evalDes ) {
        int resultado =0;
        try{
            resultado = daoEvalDesempenho.actualizarEstadoPlanificacion(evalDes);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    
    @WebMethod(operationName = "obtenerEvaluacionDesempenho")
    public EvaluacionDesempenho obtenerEvaluacionDesempenho(@WebParam(name = "idColaborador")int idColaborador,
            @WebParam(name = "idPeriodo")int idPeriodo) {
        EvaluacionDesempenho resultado = null;
        try{
            resultado = daoEvalDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
