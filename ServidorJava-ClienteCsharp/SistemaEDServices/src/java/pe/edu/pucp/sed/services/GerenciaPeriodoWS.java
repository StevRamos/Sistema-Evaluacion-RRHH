package pe.edu.pucp.sed.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.sed.dao.GerenciaPeriodoDAO;
import pe.edu.pucp.sed.model.GerenciaPeriodo;
import pe.edu.pucp.sed.mysql.GerenciaPeriodoMySQL;

@WebService(serviceName = "GerenciaPeriodoWS")
public class GerenciaPeriodoWS{
    private GerenciaPeriodoDAO daoGerenciaPeriodo;

    public GerenciaPeriodoWS(){
        daoGerenciaPeriodo = new GerenciaPeriodoMySQL();
    }

//    @WebMethod(operationName = "insertarGerenciaPeriodo")
//    public int insertarGerenciaPeriodo(@WebParam(name = "gerenciaPeriodo") GerenciaPeriodo gerenciaPeriodo){
//        int resultado = 0;
//        try{
//            resultado =  daoGerenciaPeriodo.insertar(gerenciaPeriodo);
//        }catch( Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }
//
//    @WebMethod(operationName = "actualizarGerenciaPeriodo")
//    public int actualizarGerenciaPeriodo(@WebParam(name = "gerenciaPeriodo") GerenciaPeriodo gerenciaPeriodo){
//        int resultado = 0;
//        try{
//            resultado =  daoGerenciaPeriodo.actualizar(gerenciaPeriodo);
//        }catch( Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }
//
//    @WebMethod(operationName = "eliminarGerenciaPeriodo")
//    public int eliminarGerenciaPeriodo(@WebParam(name = "gerenciaPeriodo") GerenciaPeriodo gerenciaPeriodo){
//        int resultado = 0;
//        try{
//            resultado =  daoGerenciaPeriodo.eliminar(gerenciaPeriodo);
//        }catch( Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        return resultado;
//    }

    @WebMethod(operationName = "listarXPeriodo")
    public ArrayList<GerenciaPeriodo> listarXPeriodo(@WebParam(name = "idPeriodo") int idPeriodo){
        ArrayList<GerenciaPeriodo> gerenciaPeriodos = new ArrayList<>();
        try{
            gerenciaPeriodos =  daoGerenciaPeriodo.listarXPeriodo(idPeriodo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return gerenciaPeriodos;
    }
}