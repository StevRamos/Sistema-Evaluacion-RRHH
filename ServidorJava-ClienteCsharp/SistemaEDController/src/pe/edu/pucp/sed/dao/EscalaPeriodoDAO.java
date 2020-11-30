package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.EscalaPeriodo;

public interface EscalaPeriodoDAO{
	int insertar(EscalaPeriodo escalaPeriodo);
	int actualizar(EscalaPeriodo escalaPeriodo);
	int eliminar(int idEscalaPeriodo);
	ArrayList<EscalaPeriodo> listar();
	ArrayList<EscalaPeriodo> listarXPeriodoActual();
}
