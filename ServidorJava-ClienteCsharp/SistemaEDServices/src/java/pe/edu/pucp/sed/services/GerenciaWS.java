package pe.edu.pucp.sed.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.sed.dao.GerenciaDAO;
import pe.edu.pucp.sed.model.Gerencia;
import pe.edu.pucp.sed.mysql.GerenciaMySQL;

@WebService(serviceName = "GerenciaWS")
public class GerenciaWS{
    private GerenciaDAO daoGerencia;

    public GerenciaWS(){
        daoGerencia = new GerenciaMySQL();
    }

    @WebMethod(operationName = "insertarGerencia")
    public int insertarGerencia(@WebParam(name = "gerencia") Gerencia gerencia){
        int resultado = 0;
        try{
            resultado =  daoGerencia.insertar(gerencia);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
        @WebMethod(operationName = "insertarGerenciaPeriodo")
    public int insertarGerenciaPeriodo(@WebParam(name = "gerencia") Gerencia gerencia){
        int resultado = 0;
        try{
            resultado =  daoGerencia.insertarGerenciaPeriodo(gerencia);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "actualizarGerencia")
    public int actualizarGerencia(@WebParam(name = "gerencia") Gerencia gerencia){
        int resultado = 0;
        try{
            resultado =  daoGerencia.actualizar(gerencia);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarGerencia")
    public int eliminarGerencia(@WebParam(name = "idGerencia") int idGerencia){
        int resultado = 0;
        try{
            resultado =  daoGerencia.eliminar(idGerencia);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarGerencias")
    public ArrayList<Gerencia> listarGerencias(){
        ArrayList<Gerencia> gerencias = new ArrayList<>();
        try{
            gerencias =  daoGerencia.listar();
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return gerencias;
    }
}
