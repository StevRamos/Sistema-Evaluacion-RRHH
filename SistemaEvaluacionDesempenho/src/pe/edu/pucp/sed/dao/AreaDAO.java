package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Area;

public interface AreaDAO{
	int insertar(Area area);
	int actualizar(Area area);
	int eliminar(int idArea);
	ArrayList<Area> listar();
}
