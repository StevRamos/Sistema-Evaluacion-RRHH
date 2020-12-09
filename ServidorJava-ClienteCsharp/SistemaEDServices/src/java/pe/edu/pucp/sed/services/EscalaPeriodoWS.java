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
import pe.edu.pucp.sed.dao.EscalaPeriodoDAO;
import pe.edu.pucp.sed.model.EscalaPeriodo;
import pe.edu.pucp.sed.mysql.EscalaPeriodoMySQL;

@WebService(serviceName = "EscalaPeriodoWS")
public class EscalaPeriodoWS {
    
    private EscalaPeriodoDAO daoEscalaPeriodo;
    
    public EscalaPeriodoWS(){
        daoEscalaPeriodo = new EscalaPeriodoMySQL();
    }

    @WebMethod(operationName = "listarEPXPeriodoActual")
    public ArrayList<EscalaPeriodo> listarEPXPeriodoActual() {
        ArrayList<EscalaPeriodo> cupos = new ArrayList<>();
        
        try {
            cupos = daoEscalaPeriodo.listarXPeriodoActual();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return cupos;
    }
}
