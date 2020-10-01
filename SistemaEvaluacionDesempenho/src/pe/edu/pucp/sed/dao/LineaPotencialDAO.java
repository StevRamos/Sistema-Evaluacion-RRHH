package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.LineaPotencial;

public interface LineaPotencialDAO{
	int insertar(LineaPotencial lineaPotencial);
	int actualizar(LineaPotencial lineaPotencial);
	int eliminar(int idLineaPotencial);
	ArrayList<LineaPotencial> listar();
}
