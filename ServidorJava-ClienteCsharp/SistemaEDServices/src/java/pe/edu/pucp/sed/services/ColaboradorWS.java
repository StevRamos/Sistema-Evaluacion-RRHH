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
    public ArrayList<Colaborador> listarColaboradores(@WebParam(name = "idPuestoTrabajo") int idPuestoTrabajo,
                                                    @WebParam(name = "DNI") String DNI) {
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try {
            colaboradores = daoColaborador.listar(idPuestoTrabajo,DNI);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaboradores;
    }
    
    @WebMethod(operationName = "insertarColaborador")
    public int insertarColaborador(@WebParam(name = "colaborador") Colaborador colaborador){
        int resultado = 0;
        try{
            resultado =  daoColaborador.insertar(colaborador);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarColaborador")
    public int actualizarColaborador(@WebParam(name = "colaborador") Colaborador colaborador){
        int resultado = 0;
        try{
            resultado =  daoColaborador.actualizar(colaborador);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
        @WebMethod(operationName = "eliminarColaborador")
    public int eliminarColaborador(@WebParam(name = "idColaborador") int idColaborador){
        int resultado = 0;
        try{
            resultado =  daoColaborador.eliminar(idColaborador);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
 
    @WebMethod(operationName = "listarColaboradoresXJefe")
    public ArrayList<Colaborador> listarColaboradoresXJefe(@WebParam(name = "idJefe") int idJefe){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try {
            colaboradores = daoColaborador.listarColaboradoresXJefe(idJefe);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaboradores;
    }
    
    @WebMethod(operationName = "listarColaboradoresXGerencia")
    public ArrayList<Colaborador> listarColaboradoresXGerencia(@WebParam(name = "idGerencia") int idGerencia){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try {
            colaboradores = daoColaborador.listarColaboradoresXGerencia(idGerencia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaboradores;
    }
    
    
    @WebMethod(operationName = "buscarJefe")
    public Colaborador buscarJefe(@WebParam(name = "idJefe") int idJefe){
        Colaborador colaborador = new Colaborador();
        
        try {
            colaborador = daoColaborador.buscarJefe(idJefe);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaborador;
    }
    
    @WebMethod(operationName = "listarJefeXGerenciaXPeriodoActual")
    public ArrayList<Colaborador> listarJefeXGerenciaXPeriodoActual(@WebParam(name = "idGerencia") int idGerencia){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try {
            colaboradores = daoColaborador.listarJefeXGerenciaXPeriodoActual(idGerencia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaboradores;
    }
        
    @WebMethod(operationName = "autenticarUsuario")
    public Colaborador autenticarUsuario(@WebParam(name = "correo") String correo,
            @WebParam(name = "contrasenha") String contrasenha) {
        Colaborador colaborador = new Colaborador();
        try{
            colaborador = daoColaborador.autenticarUsuario(correo, contrasenha);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
        return colaborador;
        
    }
    
    @WebMethod(operationName = "listarColaboradoresXJefeXPeriodo")
    public ArrayList<Colaborador> listarColaboradoresXJefeXPeriodo(@WebParam(name = "idJefe") int idJefe,
            @WebParam(name = "idPeriodo") int idPeriodo){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try {
            colaboradores = daoColaborador.listarColaboradoresXJefeXPeriodo(idJefe, idPeriodo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaboradores;
    }
    
    @WebMethod(operationName = "listarColaboradoresXGerencia9Box")
    public ArrayList<Colaborador> listarColaboradoresXGerencia9Box(@WebParam(name = "idGerencia") int idGerencia,
            @WebParam(name = "idPeriodo") int idPeriodo){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try {
            colaboradores = daoColaborador.listarColaboradoresXGerencia9Box(idGerencia, idPeriodo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return colaboradores;
    }
    
}
