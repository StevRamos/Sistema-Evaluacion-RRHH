package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.ColaboradorDAO;
import pe.edu.pucp.sed.dao.EvaluacionDAO;
import pe.edu.pucp.sed.dao.EvaluacionDesempenhoDAO;
import pe.edu.pucp.sed.model.Colaborador;
//<<<<<<< HEAD
import pe.edu.pucp.sed.model.EstadoCuenta;
import pe.edu.pucp.sed.model.Gerencia;
import pe.edu.pucp.sed.model.PuestoTrabajo;
//=======
//>>>>>>> 40f6c63b16ff207e9d70f65fe25200e24739e879

public class ColaboradorMySQL implements ColaboradorDAO{

    Connection con;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(Colaborador colaborador){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call INSERTAR_COLABORADOR(?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_COLABORADOR", java.sql.Types.INTEGER);
            cs.setString("_DNI", colaborador.getDni());
            cs.setString("_NOMBRES", colaborador.getNombres());
            cs.setString("_APELLIDOS", colaborador.getApellidos());
            cs.setString("_DIRECCION", colaborador.getDireccion());
            cs.setString("_CORREO", colaborador.getCorreo());
            cs.setString("_TELEFONO", colaborador.getTelefono());
            cs.setDate("_FECHANAC", 
                    new java.sql.Date(colaborador.getFechaNac().getTime()));
            cs.setInt("_ID_JEFE", colaborador.getJefe().getIdColaborador());
            
            cs.executeUpdate();
            colaborador.setIdColaborador(cs.getInt("_ID_COLABORADOR"));
            
            sql = "{call INSERTAR_COLABORADORES_GPT(?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_COLABORADOR", colaborador.getIdColaborador());
            cs.setInt("_ID_PUESTOSTRABAJO", colaborador.getPuestoTrabajo().getIdPuestoTrabajo());
            cs.setInt("_ID_PERIODO", colaborador.getPeriodo().getIdPeriodo());
            cs.setInt("_ID_GERENCIA", colaborador.getGerencia().getIdGerencia());
            
            cs.executeUpdate();
            
            
            colaborador.getUsuario().setIdUsuario(colaborador.getIdColaborador());
            
            sql = "{call INSERTAR_USUARIO(?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_FID_USUARIO", colaborador.getUsuario().getIdUsuario());
            cs.setString("_CONTRASENHA", colaborador.getUsuario().getContrasenha());
            cs.setInt("_NIVEL_ACCESO", colaborador.getUsuario().getNivelAcceso());
            cs.executeUpdate();
            
            con.commit();
            resultado = 1;
        }catch(Exception ex){
            try{
                con.rollback();
            }catch(Exception exR){
                System.out.println(exR.getMessage());
            }
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.setAutoCommit(true);
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    @Override
    public int actualizar(Colaborador colaborador){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_COLABORADOR(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            //System.out.println(colaborador.getIdColaborador());
            cs.setInt("_ID_COLABORADOR", colaborador.getIdColaborador());
             cs.setString("_DIRECCION", colaborador.getDireccion());
            cs.setString("_CORREO", colaborador.getCorreo());
            cs.setString("_TELEFONO", colaborador.getTelefono());
            cs.setDate("_FECHANAC", 
                    new java.sql.Date(colaborador.getFechaNac().getTime()));
            cs.setInt("_ID_JEFE", colaborador.getJefe().getIdColaborador());
            cs.setInt("_ID_PUESTO_TRABAJO", colaborador.getPuestoTrabajo().getIdPuestoTrabajo());
            cs.setInt("_ID_GERENCIA", colaborador.getGerencia().getIdGerencia());
            
            
            
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public int eliminar(int idColaborador){
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_COLABORADOR(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_COLABORADOR", idColaborador);
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    @Override
    public ArrayList<Colaborador> listar(int idPuestoTrabajo, String DNI ){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_COLABORADORES(?,?)}";
            
            
            cs = con.prepareCall(sql);
            
            cs.setString("_DNI", DNI);   
            cs.setInt("_ID_PUESTO_TRABAJO", idPuestoTrabajo);
            
            rs = cs.executeQuery(); 
            while(rs.next()){
                Colaborador col = new Colaborador();
                Colaborador jefe = new Colaborador();
                
                jefe.setIdColaborador(rs.getInt("id_Jefe"));
                jefe.setNombres(rs.getString("nombreJefe"));
                jefe.setApellidos(rs.getString("apellidosJefe"));
                jefe.setDni(rs.getString("dniJefe"));
                
                col.setJefe(jefe);
                
                col.setIdColaborador(rs.getInt("id_Colaborador"));
                col.setDni(rs.getString("dni"));
                col.setNombres(rs.getString("nombres"));
                col.setApellidos(rs.getString("apellidos"));
                col.setDireccion(rs.getString("direccion"));
                col.setCorreo(rs.getString("correo"));
                col.setTelefono(rs.getString("telefono"));
                col.setFechaNac(rs.getDate("fechaNac"));
                
                Gerencia ger = new Gerencia();
                ger.setIdGerencia(rs.getInt("id_Gerencias"));
                ger.setNombre(rs.getString("nombreG"));
                
                PuestoTrabajo pt = new PuestoTrabajo();
                pt.setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
                pt.setNombre(rs.getString("nombrePT"));
                
                col.setGerencia(ger);
                col.setPuestoTrabajo(pt);
                
                colaboradores.add(col);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return colaboradores;
    }
    
    public ArrayList<Colaborador> listarColaboradoresXJefe( int idJefe ){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_COLABORADORES_X_JEFE(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_ID_JEFE", idJefe);
            rs = cs.executeQuery(); 
            while(rs.next()){
                Colaborador jefe = new Colaborador();
                
                jefe.setIdColaborador(rs.getInt("id_Jefe"));

               
                Colaborador col = new Colaborador();
                col.setJefe(jefe);
                col.setIdColaborador(rs.getInt("id_Colaborador"));
                col.setDni(rs.getString("dni"));
                col.setNombres(rs.getString("nombres"));
                col.setApellidos(rs.getString("apellidos"));
                col.setDireccion(rs.getString("direccion"));
                col.setCorreo(rs.getString("correo"));
                col.setTelefono(rs.getString("telefono"));
                col.setFechaNac(rs.getDate("fechaNac"));
                
                Gerencia ger = new Gerencia();
                ger.setNombre(rs.getString("nombreGerencia"));
                ger.setDescripcion(rs.getString("descripcionGerencia"));
                
                PuestoTrabajo pt = new PuestoTrabajo();
               pt.setNombre(rs.getString("nombrePuestoTrabjo"));
                pt.setDescripcion(rs.getString("descripcionPuestoTrabajo"));
                
                col.setGerencia(ger);
                col.setPuestoTrabajo(pt);
                
                colaboradores.add(col);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return colaboradores;
    }
    
    public Colaborador buscarJefe( int idJefe ){
        Colaborador jefe = new Colaborador();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call BUSCAR_JEFE(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_COLABORADOR", idJefe);
            rs = cs.executeQuery(); 
            while(rs.next()){
                Colaborador jefeJ = new Colaborador();
                
                jefeJ.setIdColaborador(rs.getInt("id_Jefe"));
                
                jefe.setJefe(jefeJ);
                
                jefe.setIdColaborador(rs.getInt("id_Colaborador"));

                jefe.setDni(rs.getString("dni"));
                jefe.setNombres(rs.getString("nombres"));
                jefe.setApellidos(rs.getString("apellidos"));
                jefe.setDireccion(rs.getString("direccion"));
                jefe.setCorreo(rs.getString("correo"));
                jefe.setTelefono(rs.getString("telefono"));
                jefe.setFechaNac(rs.getDate("fechaNac"));
               
                Gerencia ger = new Gerencia();
                ger.setNombre(rs.getString("nombreGerencia"));
                ger.setDescripcion(rs.getString("descripcionGerencia"));
                
                PuestoTrabajo pt = new PuestoTrabajo();
               pt.setNombre(rs.getString("nombrePuestoTrabjo"));
                pt.setDescripcion(rs.getString("descripcionPuestoTrabajo"));
                
                jefe.setGerencia(ger);
                jefe.setPuestoTrabajo(pt);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return jefe;
    }
    
    @Override
    public ArrayList<Colaborador> listarJefeXGerenciaXPeriodoActual( int idGerencia ){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_JEFE_X_GERENCIA_X_PERIODO_ACTUAL(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_GERENCIA", idGerencia);
            rs = cs.executeQuery(); 
            while(rs.next()){               
                Colaborador col = new Colaborador();
                col.setIdColaborador(rs.getInt("id_Colaborador"));
                col.setNombres(rs.getString("nombres"));
                col.setApellidos(rs.getString("apellidos"));
                
                colaboradores.add(col);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return colaboradores;
    }
    
    @Override
    public Colaborador autenticarUsuario(String correo, String contrasenha) {
        Colaborador col = null;
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call AUTENTICAR_USUARIO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setString("_CORREO", correo);
            cs.setString("_CONTRASENHA", contrasenha);
            rs = cs.executeQuery(); 
            rs.next();
            
            col = new Colaborador();
            
            col.setIdColaborador(rs.getInt("id_Colaborador"));
            col.setJefe(new Colaborador());
            col.getJefe().setIdColaborador(rs.getInt("id_Jefe"));
            col.getJefe().setNombres(rs.getString("nombreJefe"));
            col.getJefe().setApellidos(rs.getString("apellidosJefe"));
            
            col.setDni(rs.getString("dni"));
            col.setNombres(rs.getString("nombres"));
            col.setApellidos(rs.getString("apellidos"));
            col.setDireccion(rs.getString("direccion"));
            col.setCorreo(rs.getString("correo"));
            col.setTelefono(rs.getString("telefono"));
            col.setFechaNac(rs.getDate("fechaNac"));

            col.getGerencia().setIdGerencia(rs.getInt("id_Gerencias"));
            col.getGerencia().setNombre(rs.getString("nombreGerencia"));
            col.getGerencia().setDescripcion(rs.getString("descripcionGerencia"));

            col.getPuestoTrabajo().setIdPuestoTrabajo(rs.getInt("id_PuestosTrabajo"));
            col.getPuestoTrabajo().setNombre(rs.getString("nombrePuestoTrabajo"));
            col.getPuestoTrabajo().setDescripcion(rs.getString("descripcionPuestoTrabajo"));
            
            col.getUsuario().setIdUsuario(col.getIdColaborador());
            col.getUsuario().setNivelAcceso(rs.getInt("nivelAcceso"));
            col.getUsuario().setEstadoCuenta(rs.getInt("estadoCuenta"));
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return col;
    }
    
    @Override
    public ArrayList<Colaborador> listarColaboradoresXJefeXPeriodo(int idJefe, int idPeriodo){
        ArrayList<Colaborador> colaboradores = new ArrayList<>();
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            String sql = "{call LISTAR_COLABORADORES_X_JEFE_X_PERIODO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_FID_ID_JEFE", idJefe);
            cs.setInt("_FID_PERIODO", idPeriodo);
            rs = cs.executeQuery(); 
            while(rs.next()){
                Colaborador jefe = new Colaborador();
                
                jefe.setIdColaborador(rs.getInt("id_Jefe"));

               
                Colaborador col = new Colaborador();
                col.setJefe(jefe);
                col.setIdColaborador(rs.getInt("id_Colaborador"));
                col.setDni(rs.getString("dni"));
                col.setNombres(rs.getString("nombres"));
                col.setApellidos(rs.getString("apellidos"));
                col.setDireccion(rs.getString("direccion"));
                col.setCorreo(rs.getString("correo"));
                col.setTelefono(rs.getString("telefono"));
                col.setFechaNac(rs.getDate("fechaNac"));
                
                Gerencia ger = new Gerencia();
                ger.setNombre(rs.getString("nombreGerencia"));
                ger.setDescripcion(rs.getString("descripcionGerencia"));
                
                PuestoTrabajo pt = new PuestoTrabajo();
               pt.setNombre(rs.getString("nombrePuestoTrabjo"));
                pt.setDescripcion(rs.getString("descripcionPuestoTrabajo"));
                
                col.setGerencia(ger);
                col.setPuestoTrabajo(pt);
                
                colaboradores.add(col);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return colaboradores;
    }
    
    public ArrayList<Colaborador> listarColaboradoresXJefe9Box( int idJefe, int idPeriodo ){
        ArrayList<Colaborador> colaboradores = null;
                
        EvaluacionDAO daoEvaluacion = new EvaluacionMySQL();
        EvaluacionDesempenhoDAO daoEvaluacionDesempenho = new EvaluacionDesempenhoMySQL();
        
        try{
            colaboradores = this.listarColaboradoresXJefe(idJefe);
            for(Colaborador c : colaboradores){
                c.getEvaluaciones().add(daoEvaluacion.obtenerEvaluacionPotencial(c.getIdColaborador(), idPeriodo));
                c.getEvaluaciones().add(daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(c.getIdColaborador(), idPeriodo));
            }
            Collections.sort(colaboradores);
        }
        catch(Exception ex){
            System.out.print(ex.getMessage());
        }
        
        return colaboradores;
    }
    
}
