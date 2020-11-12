package pe.edu.pucp.sed.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.sed.dao.PuestoTrabajoDAO;
import pe.edu.pucp.sed.model.PuestoTrabajo;
import pe.edu.pucp.sed.mysql.PuestoTrabajoMySQL;

@WebService(serviceName = "PuestoTrabajoWS")
public class PuestoTrabajoWS{
    private PuestoTrabajoDAO daoPuestoTrabajo;

    public PuestoTrabajoWS(){
        daoPuestoTrabajo = new PuestoTrabajoMySQL();
    }

    @WebMethod(operationName = "insertarPuestoTrabajo")
    public int insertarPuestoTrabajo(@WebParam(name = "puestoTrabajo") PuestoTrabajo puestoTrabajo){
        int resultado = 0;
        try{
            resultado =  daoPuestoTrabajo.insertar(puestoTrabajo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "actualizarPuestoTrabajo")
    public int actualizarPuestoTrabajo(@WebParam(name = "puestoTrabajo") PuestoTrabajo puestoTrabajo){
        int resultado = 0;
        try{
            resultado =  daoPuestoTrabajo.actualizar(puestoTrabajo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarPuestoTrabajo")
    public int eliminarPuestoTrabajo(@WebParam(name = "puestoTrabajo") int idPuestoTrabajo){
        int resultado = 0;
        try{
            resultado =  daoPuestoTrabajo.eliminar(idPuestoTrabajo);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarPuestoTrabajos")
    public ArrayList<PuestoTrabajo> listarPuestoTrabajos(@WebParam(name = "nombreGerencia") String nombreGerencia){
        ArrayList<PuestoTrabajo> puestoTrabajos = new ArrayList<>();
        try{
            puestoTrabajos =  daoPuestoTrabajo.listar(nombreGerencia);
        }catch( Exception ex){
            System.out.println(ex.getMessage());
        }
        return puestoTrabajos;
    }
}
