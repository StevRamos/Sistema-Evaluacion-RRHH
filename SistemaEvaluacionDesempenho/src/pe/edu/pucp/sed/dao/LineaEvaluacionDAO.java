package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.LineaEvaluacion;

public interface LineaEvaluacionDAO{
	int insertar(LineaEvaluacion lineaEvaluacion);
	int actualizar(LineaEvaluacion lineaEvaluacion);
	int eliminar(int idLineaEvaluacion);
	ArrayList<LineaEvaluacion> listar();
}
