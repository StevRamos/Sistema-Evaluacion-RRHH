package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.EscalaPeriodo;
import pe.edu.pucp.sed.model.GerenciaPeriodo;
import pe.edu.pucp.sed.model.ItemPDIPeriodo;
import pe.edu.pucp.sed.model.Periodo;

public interface PeriodoDAO{
	int insertar(Periodo periodo);
	int actualizar(Periodo periodo);
	int eliminar(Periodo periodo);
        Periodo obtenerPeriodoActual();
	ArrayList<Periodo> listar();
        Periodo listarGerenciaPeriodo(Periodo periodo);
        ArrayList<GerenciaPeriodo> listarGerenciaPeriodoPorId(int idPeriodo);
        ArrayList<EscalaPeriodo> listarEscalaPeriodo(int idPeriodo);
        ArrayList<ItemPDIPeriodo> listarItemPDIPeriodo(int idPeriodo);
        int actualizarRangos(Periodo periodo);
}
