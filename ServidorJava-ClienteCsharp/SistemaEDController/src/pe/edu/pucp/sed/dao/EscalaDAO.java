package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.Escala;

public interface EscalaDAO{
	int insertar(Escala escala);
	int actualizar(Escala escala);
	int eliminar(int idEscala);
	ArrayList<Escala> listar();
}
