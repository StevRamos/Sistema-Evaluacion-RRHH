package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.ItemPDIPeriodo;

public interface ItemPDIPeriodoDAO{
	int insertar(ItemPDIPeriodo itemPDIPeriodo);
	int actualizar(ItemPDIPeriodo itemPDIPeriodo);
	int eliminar(int idItemPDIPeriodo);
	ArrayList<ItemPDIPeriodo> listar();
}
