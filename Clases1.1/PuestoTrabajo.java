import java.util.ArrayList;
public class PuestoTrabajo{
	private int id;
	private String nombre;
	private String descripcion;
	private ArrayList<PesoCriterio> pesosCriterios;
	private ArrayList<Colaborador> colaboradores;
	private Area area;

	public PuestoTrabajo(){
		this.pesosCriterios = new ArrayList<PesoCriterio>();
		this.colaboradores = new ArrayList<Colaborador>();
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

	public ArrayList<PesoCriterio> getPesosCriterios(){
		return this.pesosCriterios;
	};

	public void setPesosCriterios( PesoCriterio pesosCriterios ){
		this.pesosCriterios.add(pesosCriterios);
	};

	public ArrayList<Colaborador> getColaboradores(){
		return this.colaboradores;
	};

	public void setColaboradores( Colaborador colaboradores ){
		this.colaboradores.add(colaboradores);
	};

	public Area getArea(){
		return this.area;
	};

	public void setArea( Area area ){
		this.area = area;
	};

}

