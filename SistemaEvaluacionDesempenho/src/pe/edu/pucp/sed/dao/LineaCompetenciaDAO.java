package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.LineaCompetencia;

public interface LineaCompetenciaDAO{
	int insertar(LineaCompetencia lineaCompetencia);
	int actualizar(LineaCompetencia lineaCompetencia);
	int eliminar(int idLineaCompetencia);
	ArrayList<LineaCompetencia> listar();
}
