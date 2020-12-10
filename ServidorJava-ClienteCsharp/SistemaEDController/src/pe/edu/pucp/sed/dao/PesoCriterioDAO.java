package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.PesoCriterio;

public interface PesoCriterioDAO{
	int insertar(PesoCriterio pesoCriterio);
	int actualizar(PesoCriterio pesoCriterio);
	int eliminar(PesoCriterio pesoCriterio);
	ArrayList<PesoCriterio> listar(int tipo,String nomcargo,String nomPeriodo,String nomCompetencia);
        ArrayList<PesoCriterio> listar_subcriterios_x_criterio(int _id_criterio_padre,int _id_cargo, int _id_periodo);
}
