import java.util.ArrayList;
public class Subcriterio{
	private int id;
	private String nombre;
	private String descripcion;
	private boolean esVigente;
	private ArrayList<PesoSubcriterio> pesosSubcriterios;
	private Criterio criterio;

	public Subcriterio(){
		this.pesosSubcriterios = new ArrayList<PesoSubcriterio>();
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

	public ArrayList<PesoSubcriterio> getPesosSubcriterios(){
		return this.pesosSubcriterios;
	};

	public void setPesosSubcriterios( PesoSubcriterio pesosSubcriterios ){
		this.pesosSubcriterios.add(pesosSubcriterios);
	};

	public Criterio getCriterio(){
		return this.criterio;
	};

	public void setCriterio( Criterio criterio ){
		this.criterio = criterio;
	};

}

