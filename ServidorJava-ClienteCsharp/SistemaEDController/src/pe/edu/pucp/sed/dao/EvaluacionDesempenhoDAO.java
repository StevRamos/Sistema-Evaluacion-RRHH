package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.EvaluacionDesempenho;

public interface EvaluacionDesempenhoDAO{
	int insertar(EvaluacionDesempenho evaluacionDesempenho);
        int insertarLineasEvaluacionDesempenho(EvaluacionDesempenho evaluacionDesempenho);
        int actualizarEvaluacionDesempenho(EvaluacionDesempenho evaluacionDesempenho);
        int actualizarEstadoPlanificacion(EvaluacionDesempenho evaluacionDesempenho); 
	int actualizar(EvaluacionDesempenho evaluacionDesempenho);
	int eliminar(int idEvaluacionDesempenho);
	ArrayList<EvaluacionDesempenho> listar();
        ArrayList<EvaluacionDesempenho> listarDesempenhoPorPeriodo(int idColaborador, int idPeriodo);
        EvaluacionDesempenho obtenerEvaluacionDesempenho(int idColaborador, int idPeriodo);
}
