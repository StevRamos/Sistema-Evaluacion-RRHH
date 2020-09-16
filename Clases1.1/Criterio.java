import java.util.ArrayList;

public class Criterio{
	private int id;
	private String nombre;
	private String descripcion;
	private boolean esVigente;
	private ListArray<Subcriterio> subcriterios;
	private ListArray<PesoCriterio> pesosCriterios;
	private TipoCriterio tipo;

	public Criterio(){
		this.subcriterios = new ArrayList<Subcriterio>();
		this.pesosCriterios = new ArrayList<PesoCriterio>();
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

	public String getDescripcion(){
		return this.descripcion;
	};

	public void setDescripcion( String descripcion ){
		this.descripcion = descripcion;
	};

	public boolean getEsVigente(){
		return this.esVigente;
	};

	public void setEsVigente( boolean esVigente ){
		this.esVigente = esVigente;
	};

	public Subcriterio getSubcriterios(){
		return this.subcriterios;
	};

	public void setSubcriterios( ListArray<Subcriterio> subcriterios ){
		this.subcriterios.add(subcriterios);
	};

	public PesoCriterio getPesosCriterios(){
		return this.pesosCriterios;
	};

	public void setPesosCriterios( ListArray<PesoCriterio> pesosCriterios ){
		this.pesosCriterios.add(pesosCriterios);
	};

	public TipoCriterio getTipo(){
		return this.tipo;
	};

	public void setTipo( TipoCriterio tipo ){
		this.tipo = tipo;
	};

}

