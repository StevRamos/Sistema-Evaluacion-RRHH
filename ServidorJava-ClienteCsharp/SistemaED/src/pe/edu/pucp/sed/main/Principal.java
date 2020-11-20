/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.main;

import java.sql.Time;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.sed.dao.ColaboradorDAO;
import pe.edu.pucp.sed.dao.EscalaDAO;
import pe.edu.pucp.sed.dao.EvaluacionDesempenhoDAO;
import pe.edu.pucp.sed.dao.GerenciaDAO;
import pe.edu.pucp.sed.dao.GerenciaPeriodoDAO;
import pe.edu.pucp.sed.dao.ObjetivoDAO;
//import pe.edu.pucp.sed.dao.EvaluacionPotencialDAO;
import pe.edu.pucp.sed.dao.PeriodoDAO;
import pe.edu.pucp.sed.dao.PuestoTrabajoDAO;
import pe.edu.pucp.sed.dao.UsuarioDAO;
import pe.edu.pucp.sed.model.Colaborador;
import pe.edu.pucp.sed.model.Escala;
import pe.edu.pucp.sed.model.EstadoCuenta;
import pe.edu.pucp.sed.model.EvaluacionDesempenho;
import pe.edu.pucp.sed.model.Gerencia;
import pe.edu.pucp.sed.model.GerenciaPeriodo;
import pe.edu.pucp.sed.model.Objetivo;
//import pe.edu.pucp.sed.model.EvaluacionPotencial;
import pe.edu.pucp.sed.model.Periodo;
import pe.edu.pucp.sed.model.PuestoTrabajo;
import pe.edu.pucp.sed.mysql.ColaboradorMySQL;
import pe.edu.pucp.sed.mysql.EscalaMySQL;
import pe.edu.pucp.sed.mysql.EvaluacionDesempenhoMySQL;
import pe.edu.pucp.sed.mysql.GerenciaMySQL;
import pe.edu.pucp.sed.mysql.GerenciaPeriodoMySQL;
import pe.edu.pucp.sed.mysql.ObjetivoMySQL;
//import pe.edu.pucp.sed.mysql.EvaluacionPotencialMySQL;
import pe.edu.pucp.sed.mysql.PeriodoMySQL;
import pe.edu.pucp.sed.mysql.PuestoTrabajoMySQL;
import pe.edu.pucp.sed.mysql.UsuarioMySQL;

/**
 *
 * @author Jorge Miguel Baca
 */
public class Principal {
    public static void main(String[] args) throws ParseException{
        
//Colaboradores        
   SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
 //       ColaboradorDAO daoColab = new ColaboradorMySQL();
//        Colaborador jefe = new Colaborador();
//        jefe.setIdColaborador(1);
//        Colaborador col1 = new Colaborador();
//        PuestoTrabajo pt = new PuestoTrabajo();
//        Gerencia ger = new Gerencia();
//        Periodo per = new Periodo();
//        
//        ger.setIdGerencia(1);
//        pt.setIdPuestoTrabajo(1);
//        per.setIdPeriodo(1);
//
//        try{
//            //col1.setIdColaborador(1);
//            col1.setNombres("lionel");
//            col1.setApellidos("messi");
//            col1.setDireccion("uap");
//            col1.setCorreo("messi.baca@pucp.edu.pe");
//            col1.setTelefono("54578481");
//            col1.setFechaNac(formato.parse("10-04-1998"));
//            col1.setDni("09681123");
//            col1.setJefe(jefe);
//            col1.setPeriodo(per);
//            col1.setPuestoTrabajo(pt);
//            col1.setGerencia(ger);
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//       }
//      if(daoColab.insertar(col1) == 1)
//            System.out.println("Se ha insertado un empleado");
        
         // se actualiza correo u otro campo pero nombres no
//        if(daoColab.actualizar(col1) == 1)
//            System.out.println("Se ha actualizado un empleado");
        
        

//        if(daoColab.eliminar(col1.getIdColaborador()) == 1)
//            System.out.println("Se ha eliminado un empleado");
        
   //     for(Colaborador c : daoColab.listarColaboradoresXJefe(1))
     //       System.out.println(c.getNombres() +" " +c.getCorreo());
     
//     Colaborador c = daoColab.buscarJefe(11);
//      System.out.println(c.getNombres() +" " +c.getCorreo());
        
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
//        
//        GerenciaDAO daoGerencia = new GerenciaMySQL();
//       Gerencia gerencia = new Gerencia();
       
//        for(Gerencia g : daoGerencia.listarXColaborador(11)){
//            System.out.println(g.getIdGerencia()+ " - " + g.getNombre()
//                                +" - " +g.getDescripcion());
//            System.out.println(g.getPeriodo().getIdPeriodo());
//        }
             
//       try{
//           gerencia.setIdGerencia(5);
//           gerencia.setNombre("AREA DE cobros");
//           gerencia.setDescripcion("esta area se encarga de cobrar");
//            
//        }catch(Exception ex){
//           System.out.println(ex.getMessage());
//       }
//       if(daoGerencia.eliminar(5) == 1)
//           System.out.println("Se ha eliminado un gerencia");
       
//       if(daoGerencia.actualizar(gerencia) == 1)
//           System.out.println("Se ha actualizado un gerencia");
        
//        if(daoGerencia.insertar(gerencia) == 1)
//            System.out.println("Se ha insertado un gerencia");
        
//        ArrayList<Gerencia> gerencias = daoGerencia.listar();
//        for(Gerencia a : daoGerencia.listar()){
//            System.out.println(a.getIdGerencia()+ " - " + a.getNombre()
//                                +" - " +a.getDescripcion());
//        }
        
        
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
//        for(PuestoTrabajo pt : daoPuestoTrabajo.listar("Sistemas") )
//            System.out.println(pt.getNombre());
////        
////     
//        try{
//            puestoTrabajo.setIdPuestoTrabajo(5);
//            puestoTrabajo.setNombre("DATA SCIENTIST LEAD");
//            puestoTrabajo.setDescripcion("halla la captura de valor dell modelo analitico");     
//        }catch(Exception ex){
//        System.out.println(ex.getMessage());
//        }
////    
//    if(daoPuestoTrabajo.eliminar(4) == 1)
//            System.out.println("Se ha eliminado un puestoTrabajo");
//        
//        if(daoPuestoTrabajo.actualizar(puestoTrabajo) == 1)
//            System.out.println("Se ha actualizado un puestoTrabajo");
//         System.out.println("Se hQUEIER INSERTAR");
//        if(daoPuestoTrabajo.insertar(puestoTrabajo) == 1)
//            System.out.println("Se ha insertado un puestoTrabajo");
//        
//        ArrayList<PuestoTrabajo> puestosTrabajo = daoPuestoTrabajo.listar("");
//        for(PuestoTrabajo a : puestosTrabajo){
//            System.out.println(a.getIdPuestoTrabajo()+ " - " + a.getNombre());
//        }
    
//    ArrayList<Periodo> periodos = new ArrayList<>();
//    
//    Periodo per = new Periodo();
//    per.setNombre("periodo prueba 2");
//    per.setPesoEvalComp(0.7);
//    per.setPesoEvalObj(0.3);
//    per.setFechaFin(new SimpleDateFormat("yyyy-MM-dd").parse("2016-05-12"));
//    per.setFechaInicio(new SimpleDateFormat("yyyy-MM-dd").parse("2014-02-12"));
//    per.setDiaNotificacion(new SimpleDateFormat("yyyy-MM-dd").parse("2015-01-12"));
//    per.setHoraNotificacion(new java.sql.Time((new SimpleDateFormat("hh:mm:ss").parse("12:00:00")).getTime()));
//    
//    
//    PeriodoDAO daoPeriodo = new PeriodoMySQL();
//    
//    System.out.println("entra aqui");
    
   // if(daoPeriodo.insertar(per) == 1)
    //    System.out.println("Se ha ingresaro un Periodo");
//    try{
//        per.setFechaFin(formato.parse("18-10-2000"));
//    }catch(Exception ex){
//        System.out.println(ex.getMessage());
//    }
    
//    if(perDAO.actualizar(per) == 1)
//        System.out.println("Se ha actualizado un Periodo");
    
//    if(perDAO.eliminar(per.getIdPeriodo()) == 1)
//        System.out.println("Se ha eliminado un Periodo");
    
//    try {
//            periodos = daoPeriodo.listar();
//        } catch (Exception ex) {
//            System.out.println(ex.getMessage());
//        }
//    
//      for(Periodo p : daoPeriodo.listar()){
//        System.out.println(p.getNombre()+ " - " + p.getIdPeriodo() + " - " + p.getFechaInicio());
//    }
//    

//ObjetivoDAO daoObjetivo = new ObjetivoMySQL();
//    Objetivo o = new Objetivo();
//
//    for(Objetivo ob : daoObjetivo.listarObjetivosXColaborador(1))
//        System.out.println(ob.getIdObjetivo());
//

//    GerenciaPeriodoDAO daoObjetivo = new GerenciaPeriodoMySQL();
//
//
//    for(GerenciaPeriodo gp : daoObjetivo.listarXPeriodo(1))
//        System.out.println(gp.getGerencia().getNombre());

//        UsuarioDAO daoUsuario = new UsuarioMySQL();
//        Colaborador c = daoUsuario.autenticarUsuario("diego.baca@pucp.edu.pe", "ABCDE");
//        System.out.println(c.getNombres() + " " + c.getApellidos());
//        System.out.println(c.getGerencia().getNombre());
//        System.out.println(c.getPuestoTrabajo().getNombre());
//        PeriodoDAO daoperiodo = new PeriodoMySQL();
//        Periodo per = new Periodo();
//        per = daoperiodo.obtenerPeriodoActual();
//        System.out.println(per.getIdPeriodo());
//        System.out.println("-----");

//          EvaluacionDesempenhoDAO daoEvalDes = new EvaluacionDesempenhoMySQL();
//          EvaluacionDesempenho evalDes = new EvaluacionDesempenho();
////          ArrayList<EvaluacionDesempenho> evaluacionesDesempenho = new ArrayList<>();
////          evaluacionesDesempenho = daoEvalDes.listarDesempenhoPorPeriodo(1,1);
////          for (EvaluacionDesempenho eval : evaluacionesDesempenho){
////              System.out.println(eval.getIdEvaluacion());
////          }
//
//         evalDes.setIdEvaluacion(1);
//         evalDes.setEstadoPlanificacion(1);
//         int resultado = daoEvalDes.actualizarEvaluacionDesempenho(evalDes);
//         System.out.println(resultado);
    }
}