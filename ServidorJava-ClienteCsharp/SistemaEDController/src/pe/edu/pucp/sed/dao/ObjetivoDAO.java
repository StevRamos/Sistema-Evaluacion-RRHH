package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Objetivo;

public interface ObjetivoDAO{
	int insertar(Objetivo objetivo);
	int actualizar(Objetivo objetivo);
	int eliminar(int idObjetivo);
	ArrayList<Objetivo> listar();
        ArrayList<Objetivo> listarObjetivosXColaborador( int idColaborador );
}