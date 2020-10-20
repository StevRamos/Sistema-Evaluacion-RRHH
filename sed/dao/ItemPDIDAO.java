package pe.edu.pucp.sed.dao;

import java.util.ArrayList;
import pe.edu.pucp.sed.model.ItemPDI;

public interface ItemPDIDAO{
	int insertar(ItemPDI itemPDI);
	int actualizar(ItemPDI itemPDI);
	int eliminar(int idItemPDI);
	ArrayList<ItemPDI> listar();
}
