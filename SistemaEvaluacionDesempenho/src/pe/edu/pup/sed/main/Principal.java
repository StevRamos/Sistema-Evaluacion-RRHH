/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pup.sed.main;

import java.sql.Array;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.sed.dao.AreaDAO;
import pe.edu.pucp.sed.dao.ColaboradorDAO;
import pe.edu.pucp.sed.dao.CriterioDAO;
import pe.edu.pucp.sed.dao.ItemPDIDAO;
import pe.edu.pucp.sed.dao.PuestoTrabajoDAO;
import pe.edu.pucp.sed.model.Area;
import pe.edu.pucp.sed.model.Colaborador;
import pe.edu.pucp.sed.model.Criterio;
import pe.edu.pucp.sed.model.ItemPDI;
import pe.edu.pucp.sed.model.PuestoTrabajo;
import pe.edu.pucp.sed.mysql.AreaMySQL;
import pe.edu.pucp.sed.mysql.ColaboradorMySQL;
import pe.edu.pucp.sed.mysql.CriterioMySQL;
import pe.edu.pucp.sed.mysql.ItemPDIMySQL;
import pe.edu.pucp.sed.mysql.PuestoTrabajoMySQL;

/**
 *
 * @author Jorge Miguel Baca
 */
public class Principal {
    public static void main(String[] args){
        
        //SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
       // AreaDAO daoArea = new AreaMySQL();
       // Area area = new Area();
        
     
       // try{
       //     area.setIdArea(1);
  //          area.setNombre("Tontos");
  //          area.setDescripcion("area de tontos");
            
   //     }catch(Exception ex){
    //        System.out.println(ex.getMessage());
    //    }
   //     if(daoArea.eliminar(3) == 1)
   //         System.out.println("Se ha eliminado un area");
        
//        if(daoArea.actualizar(area) == 1)
//            System.out.println("Se ha actualizado un area");
        
       // if(daoArea.insertar(area) == 1)
         //   System.out.println("Se ha insertado un area");
        
       // ArrayList<Area> areas = daoArea.listar();
        //for(Area a : areas){
         //   System.out.println(a.getIdArea() + " - " + a.getNombre());
        //}
        
        
       //CriterioDAO daoCriterio = new CriterioMySQL();
      //  Criterio criterio = new Criterio();
        
     
      //  try{
      //  criterio.setIdCriterio(3);
     //   criterio.setNombre("COMUNICACION");
      //   criterio.setDescripcion("comunicacion con los clientes interno");
     //    criterio.setTipo(1);
            
      //  }catch(Exception ex){
     //   System.out.println(ex.getMessage());
       // }
    
       // if(daoCriterio.eliminar(3) == 1)
        //    System.out.println("Se ha eliminado un criterio");
        
       // if(daoCriterio.actualizar(criterio) == 1)
         //   System.out.println("Se ha actualizado un criterio");
        
       // if(daoCriterio.insertar(criterio) == 1)
       //     System.out.println("Se ha insertado un criterio");
        
       // ArrayList<Criterio> criterios = daoCriterio.listar();
       // for(Criterio a : criterios){
       //     System.out.println(a.getIdCriterio()+ " - " + a.getNombre());
       // }
        
     //   ItemPDIDAO daoitemPDI = new ItemPDIMySQL();
     //   ItemPDI itemPDI = new ItemPDI();
        
     
     //   try{
     //       itemPDI.setIdItemPDI(2);
     //       itemPDI.setNombre("FORTALEZA");
            
     //   }catch(Exception ex){
     //       System.out.println(ex.getMessage());
     //   }
    
    //    if(daoitemPDI.eliminar(2) == 1)
     //       System.out.println("Se ha eliminado un itemPDI");
        
        //if(daoitemPDI.actualizar(itemPDI) == 1)
         //   System.out.println("Se ha actualizado un itemPDI");
        
        //if(daoitemPDI.insertar(itemPDI) == 1)
         //   System.out.println("Se ha insertado un itemPDI");
        
       // ArrayList<ItemPDI> itemPDIs = daoitemPDI.listar();
       // for(ItemPDI a : itemPDIs){
        //    System.out.println(a.getIdItemPDI()+ " - " + a.getNombre());
        //}
        
        PuestoTrabajoDAO daoPuestoTrabajo = new PuestoTrabajoMySQL();
        PuestoTrabajo puestoTrabajo = new PuestoTrabajo();
        
     
        try{
            puestoTrabajo.setIdPuestoTrabajo(3);
            puestoTrabajo.setNombre("Senior Data Scientist");
            puestoTrabajo.setDescripcion("CREA MODELOS DE DEEP LEARNING");     
        }catch(Exception ex){
        System.out.println(ex.getMessage());
        }
    
        if(daoPuestoTrabajo.eliminar(3) == 1)
            System.out.println("Se ha eliminado un puestoTrabajo");
        
       // if(daoPuestoTrabajo.actualizar(puestoTrabajo) == 1)
         //   System.out.println("Se ha actualizado un puestoTrabajo");
        
        //if(daoPuestoTrabajo.insertar(puestoTrabajo) == 1)
         //   System.out.println("Se ha insertado un puestoTrabajo");
        
        //ArrayList<PuestoTrabajo> puestosTrabajo = daoPuestoTrabajo.listar();
        //for(PuestoTrabajo a : puestosTrabajo){
         //   System.out.println(a.getIdPuestoTrabajo()+ " - " + a.getNombre());
        //}
   
    
    }
}
