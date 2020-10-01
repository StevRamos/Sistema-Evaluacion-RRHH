package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.PesoSubcriterio;

public interface PesoSubcriterioDAO{
	int insertar(PesoSubcriterio pesoSubcriterio);
	int actualizar(PesoSubcriterio pesoSubcriterio);
	int eliminar(int idPesoSubcriterio);
	ArrayList<PesoSubcriterio> listar();
}
