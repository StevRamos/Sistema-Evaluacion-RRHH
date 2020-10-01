package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Cupos;

public interface CuposDAO{
	int insertar(Cupos cupos);
	int actualizar(Cupos cupos);
	int eliminar(int idCupos);
	ArrayList<Cupos> listar();
}
