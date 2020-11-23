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
import pe.edu.pucp.sed.dao.PeriodoDAO;
import pe.edu.pucp.sed.model.Periodo;
import pe.edu.pucp.sed.mysql.PeriodoMySQL;

/**
 *
 * @author stevramos
 */
@WebService(serviceName = "PeriodoWS")
public class PeriodoWS {

    private PeriodoDAO daoPeriodo;

    public PeriodoWS() {
        daoPeriodo = new PeriodoMySQL();
    }
    
    @WebMethod(operationName = "listarPeriodos")
    public ArrayList<Periodo> listarPeriodos() {
        ArrayList<Periodo> periodos = new ArrayList<>();
        
        try {
            periodos = daoPeriodo.listar();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return periodos;
    }
    
 
    
    @WebMethod(operationName = "insertarPeriodo")
    public int insertarPeriodo(@WebParam(name = "periodo") Periodo periodo){
        int resultado = 0;
        try{
            resultado =  daoPeriodo.insertar(periodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerPeriodo")
    public Periodo obtenerPeriodo(){
        Periodo periodo = new Periodo();        
        try{
            periodo = daoPeriodo.obtenerPeriodoActual();
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return periodo;
    }
    
    @WebMethod(operationName = "listarGerenciaPeriodo")
    public Periodo listarGerenciaPeriodo(@WebParam(name = "periodo") Periodo periodo){
        Periodo periodonew = new Periodo();        
        try{
            periodonew = daoPeriodo.listarGerenciaPeriodo(periodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return periodonew;
    }
    
}
