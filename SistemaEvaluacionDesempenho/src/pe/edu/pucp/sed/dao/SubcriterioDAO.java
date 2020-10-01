package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Subcriterio;

public interface SubcriterioDAO{
	int insertar(Subcriterio subcriterio);
	int actualizar(Subcriterio subcriterio);
	int eliminar(int idSubcriterio);
	ArrayList<Subcriterio> listar();
}
