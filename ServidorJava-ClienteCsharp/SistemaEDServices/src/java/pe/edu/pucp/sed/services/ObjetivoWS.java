package pe.edu.pucp.sed.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.sed.dao.ObjetivoDAO;
import pe.edu.pucp.sed.model.Objetivo;
import pe.edu.pucp.sed.mysql.ObjetivoMySQL;

@WebService(serviceName = "ObjetivoWS")
public class ObjetivoWS{
    private ObjetivoDAO daoObjetivo;

    public ObjetivoWS(){
        daoObjetivo = new ObjetivoMySQL();
    }

    @WebMethod(operationName = "insertarObjetivo")
    public int insertarObjetivo(@WebParam(name = "objetivo") Objetivo objetivo){
        int resultado = 0;
        try{
            resultado =  daoObjetivo.insertar(objetivo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "actualizarObjetivo")
    public int actualizarObjetivo(@WebParam(name = "objetivo") Objetivo objetivo){
        int resultado = 0;
        try{
            resultado =  daoObjetivo.actualizar(objetivo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarObjetivo")
    public int eliminarObjetivo(@WebParam(name = "objetivo") int idObjetivo){
        int resultado = 0;
        try{
            resultado =  daoObjetivo.eliminar(idObjetivo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarObjetivos")
    public ArrayList<Objetivo> listarObjetivos(){
        ArrayList<Objetivo> objetivos = new ArrayList<>();
        try{
            objetivos =  daoObjetivo.listar();
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return objetivos;
    }
}
