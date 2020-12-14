package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Criterio;

public interface CriterioDAO{
	int insertar_masivo(Criterio criterio);
        int insertar_individual(Criterio criterio);
	int actualizar(Criterio criterio);
	int eliminar(int idCriterio);
	ArrayList<Criterio> listar(int tipo,String nombrecriterio);
}
