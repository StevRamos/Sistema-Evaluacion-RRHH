package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Gerencia;

public interface GerenciaDAO{
	int insertar(Gerencia gerencia);
        int insertarGerenciaPeriodo(Gerencia gerencia);
	int actualizar(Gerencia gerencia);
	int eliminar(int idGerencia);
	ArrayList<Gerencia> listar();
	ArrayList<Gerencia> listarXColaborador(int idColaborador);
	ArrayList<Gerencia> listarXPeriodoActual();
}
