import java.util.ArrayList;

public class Escala{
	private int id;
	private String nombre;
	private TipoCriterio tipoCriterio;
	private ListArray<EscalaPeriodo> rangos;

	public Escala(){
		this.rangos = new ArrayList<EscalaPeriodo>();
	};

	public int getId(){
		return this.id;
	};

	public void setId( int id ){
		this.id = id;
	};

	public String getNombre(){
		return this.nombre;
	};

	public void setNombre( String nombre ){
		this.nombre = nombre;
	};

	public TipoCriterio getTipoCriterio(){
		return this.tipoCriterio;
	};

	public void setTipoCriterio( TipoCriterio tipoCriterio ){
		this.tipoCriterio = tipoCriterio;
	};

	public EscalaPeriodo getRangos(){
		return this.rangos;
	};

	public void setRangos( ListArray<EscalaPeriodo> rangos ){
		this.rangos.add(rangos);
	};

}

