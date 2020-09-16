import java.util.ArrayList;

public class Area{
	private int id;
	private String nombre;
	private String descripcion;
	private ListArray<PesoCriterio> pesosCriterios;
	private ListArray<PuestoTrabajo> puestosTrabajo;
	private ListArray<Cupos> cupos;
	private ListArray<Colaborador> colaboradores;

	public Area(){
		this.pesosCriterios = new ArrayList<PesoCriterio>();
		this.puestosTrabajo = new ArrayList<PuestoTrabajo>();
		this.cupos = new ArrayList<Cupos>();
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

	public PuestoTrabajo getPuestosTrabajo(){
		return this.puestosTrabajo;
	};

	public void setPuestosTrabajo( ListArray<PuestoTrabajo> puestosTrabajo ){
		this.puestosTrabajo.add(puestosTrabajo);
	};

	public Cupos getCupos(){
		return this.cupos;
	};

	public void setCupos( ListArray<Cupos> cupos ){
		this.cupos.add(cupos);
	};

	public Colaborador getColaboradores(){
		return this.colaboradores;
	};

	public void setColaboradores( ListArray<Colaborador> colaboradores ){
		this.colaboradores.add(colaboradores);
	};

	public void agregarColaborador(){

	};

	public void agregarCupo(){

	};

}

