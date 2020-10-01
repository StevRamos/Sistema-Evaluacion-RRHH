package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.AreaPeriodo;

public interface AreaPeriodoDAO{
	int insertar(AreaPeriodo areaPeriodo);
	int actualizar(AreaPeriodo areaPeriodo);
	int eliminar(int idAreaPeriodo);
	ArrayList<AreaPeriodo> listar();
}
