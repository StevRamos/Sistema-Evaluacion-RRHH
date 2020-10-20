package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Evaluacion;

public interface EvaluacionDAO{
	int insertar(Evaluacion evaluacion);
	int actualizar(Evaluacion evaluacion);
	int eliminar(int idEvaluacion);
	ArrayList<Evaluacion> listar();
}
