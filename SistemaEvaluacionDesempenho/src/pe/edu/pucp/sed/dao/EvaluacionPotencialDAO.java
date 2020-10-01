package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.EvaluacionPotencial;

public interface EvaluacionPotencialDAO{
	int insertar(EvaluacionPotencial evaluacionPotencial);
	int actualizar(EvaluacionPotencial evaluacionPotencial);
	int eliminar(int idEvaluacionPotencial);
	ArrayList<EvaluacionPotencial> listar();
}
