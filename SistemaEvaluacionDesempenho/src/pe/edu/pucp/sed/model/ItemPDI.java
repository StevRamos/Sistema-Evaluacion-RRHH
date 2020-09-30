import java.util.ArrayList;
public class ItemPDI{
	private int idItemPDI;
	private String nombre;
	private LineaEvaluacion lineasEvaluacion;
	private ArrayList<ItemPDIPeriodo> rangos;

	public ItemPDI(){
		this.rangos = new ArrayList<ItemPDIPeriodo>();
	};

	public int getIdItemPDI(){
		return this.idItemPDI;
	};

	public void setIdItemPDI( int idItemPDI ){
		this.idItemPDI = idItemPDI;
	};

	public String getNombre(){
		return this.nombre;
	};

	public void setNombre( String nombre ){
		this.nombre = nombre;
	};

	public LineaEvaluacion getLineasEvaluacion(){
		return this.lineasEvaluacion;
	};

	public void setLineasEvaluacion( LineaEvaluacion lineasEvaluacion ){
		this.lineasEvaluacion = lineasEvaluacion;
	};

	public ArrayList<ItemPDIPeriodo> getRangos(){
		return this.rangos;
	};

	public void setRangos( ItemPDIPeriodo rangos ){
		this.rangos.add(rangos);
	};

}

