package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.PuestoTrabajo;

public interface PuestoTrabajoDAO{
	int insertar(PuestoTrabajo puestoTrabajo);
	int actualizar(PuestoTrabajo puestoTrabajo);
	int eliminar(int idPuestoTrabajo);
	ArrayList<PuestoTrabajo> listar(String nombreGerencia);
}
