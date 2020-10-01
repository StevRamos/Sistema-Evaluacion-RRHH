/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pup.sed.main;

import java.text.SimpleDateFormat;
import pe.edu.pucp.sed.dao.ColaboradorDAO;
import pe.edu.pucp.sed.dao.EscalaDAO;
import pe.edu.pucp.sed.dao.EvaluacionPotencialDAO;
import pe.edu.pucp.sed.dao.PeriodoDAO;
import pe.edu.pucp.sed.model.Colaborador;
import pe.edu.pucp.sed.model.Escala;
import pe.edu.pucp.sed.model.EvaluacionPotencial;
import pe.edu.pucp.sed.model.Periodo;
import pe.edu.pucp.sed.mysql.ColaboradorMySQL;
import pe.edu.pucp.sed.mysql.EscalaMySQL;
import pe.edu.pucp.sed.mysql.EvaluacionPotencialMySQL;
import pe.edu.pucp.sed.mysql.PeriodoMySQL;

/**
 *
 * @author Jorge Miguel Baca
 */
public class Principal {
    public static void main(String[] args){
        
//Colaboradores        
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
//        
//        ColaboradorDAO daoColab = new ColaboradorMySQL();
//        Colaborador jefe = new Colaborador();
//        jefe.setIdColaborador(1);
//        Colaborador col1 = new Colaborador();
////        
//        try{
//            col1.setIdColaborador(6);
//            col1.setNombres("Jorge Baca");
//            col1.setApellidos("Baca Saenz");
//            col1.setDireccion("PUCP");
//            col1.setCorreo("jorge.baca@pucp.edu.pe");
//            col1.setTelefono("997328619");
//            col1.setFechaNac(formato.parse("18-04-2000"));
//            col1.setDni("1234678");
//            col1.setJefe(jefe);
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        if(daoColab.insertar(col1) == 1)
//            System.out.println("Se ha insertado un empleado");
//        
//        if(daoColab.actualizar(col1) == 1)
//            System.out.println("Se ha actualizado un empleado");
//        
//        
//
//        if(daoColab.eliminar(col1.getIdColaborador()) == 1)
//            System.out.println("Se ha eliminado un empleado");
        
//        for(Colaborador c : daoColab.listar())
//            System.out.println(c.getNombres());
        
//Escala
//        EscalaDAO daoEsc = new EscalaMySQL();
//        Escala esc = new Escala();
//        
//        esc.setIdEscala(21);
//        esc.setNombre("I");
//        esc.setTipo(true);
        
//        if(daoEsc.insertar(esc) == 1)
//            System.out.println("Se ha insertado una escala");
        
//        if(daoEsc.actualizar(esc) == 1)
//            System.out.println("Se ha actualizado una escala");
        
//        if(daoEsc.eliminar(esc.getIdEscala()) == 1)
//            System.out.println("Se ha eliminado una escala");
        
//        for(Escala e : daoEsc.listar())
//            System.out.println(e.getNombre());

//EvaluacionPotencial
//        EvaluacionPotencialDAO daoEp = new EvaluacionPotencialMySQL();
//        EvaluacionPotencial ep = new EvaluacionPotencial();
//        
//        Periodo per = new Periodo();
//        per.setIdPeriodo(1);
//        
//        ep.setColaborador(col1);
//        ep.setPeriodo(per);
//        
//        if(daoEp.insertar(ep) == 1)
//            System.out.println("Se ha insertado una evaluacion potencial");        
        
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
//        
//        PuestoTrabajoDAO daoPuestoTrabajo = new PuestoTrabajoMySQL();
//        PuestoTrabajo puestoTrabajo = new PuestoTrabajo();
//        
//     
//        try{
//            puestoTrabajo.setIdPuestoTrabajo(3);
//            puestoTrabajo.setNombre("Senior Data Scientist");
//            puestoTrabajo.setDescripcion("CREA MODELOS DE DEEP LEARNING");     
//        }catch(Exception ex){
//        System.out.println(ex.getMessage());
//        }
//    
//        if(daoPuestoTrabajo.eliminar(3) == 1)
//            System.out.println("Se ha eliminado un puestoTrabajo");
//        
//       // if(daoPuestoTrabajo.actualizar(puestoTrabajo) == 1)
//         //   System.out.println("Se ha actualizado un puestoTrabajo");
//        
//        //if(daoPuestoTrabajo.insertar(puestoTrabajo) == 1)
//         //   System.out.println("Se ha insertado un puestoTrabajo");
//        
//        ArrayList<PuestoTrabajo> puestosTrabajo = daoPuestoTrabajo.listar();
//        for(PuestoTrabajo a : puestosTrabajo){
//            System.out.println(a.getIdPuestoTrabajo()+ " - " + a.getNombre());
//        }
    
//    Periodo per = new Periodo();
//    
//    
//    try{
//        per.setFechaInicio(formato.parse("18-04-2000"));
//        per.setFechaFin(formato.parse("18-04-2001"));
//        per.setPesoEvalObj(0.5);
//        per.setPesoEvalComp(0.5);
//    }catch(Exception ex){
//        System.out.println(ex.getMessage());
//    }
//    
//    PeriodoDAO perDAO = new PeriodoMySQL();
    
//    if(perDAO.insertar(per) == 1)
//        System.out.println("Se ha ingresaro un Periodo");
//    try{
//        per.setFechaFin(formato.parse("18-10-2000"));
//    }catch(Exception ex){
//        System.out.println(ex.getMessage());
//    }
    
//    if(perDAO.actualizar(per) == 1)
//        System.out.println("Se ha actualizado un Periodo");
    
//    if(perDAO.eliminar(per.getIdPeriodo()) == 1)
//        System.out.println("Se ha eliminado un Periodo");
    
//    for(Periodo p : perDAO.listar()){
//            System.out.println(p.getFechaInicio()+ " - " + p.getFechaFin());
//        }
    
    }
}
