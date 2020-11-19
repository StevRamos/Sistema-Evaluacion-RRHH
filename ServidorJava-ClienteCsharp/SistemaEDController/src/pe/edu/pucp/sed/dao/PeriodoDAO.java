package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Periodo;

public interface PeriodoDAO{
	int insertar(Periodo periodo);
	int actualizar(Periodo periodo);
	int eliminar(int idPeriodo);
        Periodo obtenerPeriodoActual();
	ArrayList<Periodo> listar();
}
