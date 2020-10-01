/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pup.sed.main;

import java.text.SimpleDateFormat;
import pe.edu.pucp.sed.dao.ColaboradorDAO;
import pe.edu.pucp.sed.model.Colaborador;
import pe.edu.pucp.sed.mysql.ColaboradorMySQL;

/**
 *
 * @author Jorge Miguel Baca
 */
public class Principal {
    public static void main(String[] args){
        
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        ColaboradorDAO daoColab = new ColaboradorMySQL();
        Colaborador jefe = new Colaborador();
        jefe.setIdColaborador(1);
        Colaborador col1 = new Colaborador();
        
        try{
            col1.setNombres("Jorge Baca");
            col1.setApellidos("Baca Saenz");
            col1.setDireccion("PUCP");
            col1.setCorreo("jorge.baca@pucp.edu.pe");
            col1.setTelefono("997328619");
            col1.setFechaNac(formato.parse("18-04-2000"));
            col1.setDni("73359285");
            col1.setJefe(jefe);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
//        if(daoColab.insertar(col1) == 1)
//            System.out.println("Se ha insertado un empleado");
        
//        if(daoColab.actualizar(col1) == 1)
//            System.out.println("Se ha actualizado un empleado");
        
        if(daoColab.eliminar(col1.getIdColaborador()) == 1)
            System.out.println("Se ha eliminado un empleado");
    }
}
