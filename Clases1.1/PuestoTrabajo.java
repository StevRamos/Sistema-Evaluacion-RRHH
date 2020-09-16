import java.util.ArrayList;

public class PuestoTrabajo{
	private int id;
	private String nombre;
	private String descripcion;
	private ListArray<PesoCriterio> pesosCriterios;
	private ListArray<Colaborador> colaboradores;
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

	public PesoCriterio getPesosCriterios(){
		return this.pesosCriterios;
	};

	public void setPesosCriterios( ListArray<PesoCriterio> pesosCriterios ){
		this.pesosCriterios.add(pesosCriterios);
	};

	public Colaborador getColaboradores(){
		return this.colaboradores;
	};

	public void setColaboradores( ListArray<Colaborador> colaboradores ){
		this.colaboradores.add(colaboradores);
	};

	public Area getArea(){
		return this.area;
	};

	public void setArea( Area area ){
		this.area = area;
	};

}

