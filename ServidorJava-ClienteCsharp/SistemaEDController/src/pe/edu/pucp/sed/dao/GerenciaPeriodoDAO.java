package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.GerenciaPeriodo;

public interface GerenciaPeriodoDAO{
	int insertar(GerenciaPeriodo gerenciaPeriodo);
	int actualizar(GerenciaPeriodo gerenciaPeriodo);
	int eliminar(GerenciaPeriodo gerenciaPeriodo);
	ArrayList<GerenciaPeriodo> listarXPeriodo(int idPeriodo);
}
