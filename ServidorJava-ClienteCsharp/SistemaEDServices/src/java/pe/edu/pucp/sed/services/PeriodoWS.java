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
import pe.edu.pucp.sed.model.EscalaPeriodo;
import pe.edu.pucp.sed.model.GerenciaPeriodo;
import pe.edu.pucp.sed.model.ItemPDIPeriodo;
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
    
    @WebMethod(operationName = "actualizarPeriodo")
    public int actualizarPeriodo(@WebParam(name = "periodo") Periodo periodo){
        int resultado = 0;
        try{
            resultado =  daoPeriodo.actualizar(periodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPeriodo")
    public int eliminarPeriodo(@WebParam(name = "periodo") Periodo periodo){
        int resultado = 0;
        try{
            resultado =  daoPeriodo.eliminar(periodo);
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
    
    @WebMethod(operationName = "listarGerenciaPeriodoPorId")
    public ArrayList<GerenciaPeriodo> listarGerenciaPeriodoPorId(@WebParam(name = "idPeriodo") int idPeriodo){
        ArrayList<GerenciaPeriodo> gerenciasPeriodo = new ArrayList<>();      
        try{
            gerenciasPeriodo = daoPeriodo.listarGerenciaPeriodoPorId(idPeriodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return gerenciasPeriodo;
    }
    
    @WebMethod(operationName = "listarEscalaPeriodo")
    public ArrayList<EscalaPeriodo> listarEscalaPeriodo(@WebParam(name = "idPeriodo") int idPeriodo){
        ArrayList<EscalaPeriodo> escalasPeriodo = new ArrayList<>();      
        try{
            escalasPeriodo = daoPeriodo.listarEscalaPeriodo(idPeriodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return escalasPeriodo;
    }
    
    
    @WebMethod(operationName = "listarItemPDIPeriodo")
    public ArrayList<ItemPDIPeriodo> listarItemPDIPeriodo(@WebParam(name = "idPeriodo") int idPeriodo){
        ArrayList<ItemPDIPeriodo> itemsPDIPeriodo = new ArrayList<>();      
        try{
            itemsPDIPeriodo = daoPeriodo.listarItemPDIPeriodo(idPeriodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return itemsPDIPeriodo;
    }
    
    
    @WebMethod(operationName = "actualizarRangos")
    public int actualizarRangos(@WebParam(name = "periodo") Periodo periodo){
        int resultado = 0;
        try{
            resultado =  daoPeriodo.actualizarRangos(periodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
}
