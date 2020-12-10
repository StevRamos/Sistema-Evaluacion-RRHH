package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Colaborador;

public interface ColaboradorDAO{
    int insertar(Colaborador colaborador);
    int actualizar(Colaborador colaborador);
    int eliminar(int idColaborador);
    ArrayList<Colaborador> listar(int idPuestoTrabajo, String DNI);
    ArrayList<Colaborador> listarColaboradoresXJefe(int idJefe);
    Colaborador buscarJefe( int idJefe );
    ArrayList<Colaborador> listarJefeXGerenciaXPeriodoActual(int idGerencia);
    Colaborador autenticarUsuario(String correo, String contrasenha); 
    ArrayList<Colaborador> listarColaboradoresXJefeXPeriodo(int idJefe, int idPeriodo);
    ArrayList<Colaborador> listarColaboradoresXJefe9Box(int idJefe, int idPeriodo);
}
