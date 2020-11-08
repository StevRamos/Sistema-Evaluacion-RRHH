package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.PesoCriterio;

public interface PesoCriterioDAO{
	int insertar(PesoCriterio pesoCriterio);
	int actualizar(PesoCriterio pesoCriterio);
	int eliminar(int idPesoCriterio);
	ArrayList<PesoCriterio> listar();
}
