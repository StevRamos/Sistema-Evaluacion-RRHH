import java.util.ArrayList;
public class Area{
	private int id;
	private String nombre;
	private String descripcion;
	private ArrayList<PesoCriterio> pesosCriterios;
	private ArrayList<PuestoTrabajo> puestosTrabajo;
	private ArrayList<Cupos> cupos;
	private ArrayList<Colaborador> colaboradores;

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

	public ArrayList<PesoCriterio> getPesosCriterios(){
		return this.pesosCriterios;
	};

	public void setPesosCriterios( PesoCriterio pesosCriterios ){
		this.pesosCriterios.add(pesosCriterios);
	};

	public ArrayList<PuestoTrabajo> getPuestosTrabajo(){
		return this.puestosTrabajo;
	};

	public void setPuestosTrabajo( PuestoTrabajo puestosTrabajo ){
		this.puestosTrabajo.add(puestosTrabajo);
	};

	public ArrayList<Cupos> getCupos(){
		return this.cupos;
	};

	public void setCupos( Cupos cupos ){
		this.cupos.add(cupos);
	};

	public ArrayList<Colaborador> getColaboradores(){
		return this.colaboradores;
	};

	public void setColaboradores( Colaborador colaboradores ){
		this.colaboradores.add(colaboradores);
	};

	public void agregarColaborador(){

	};

	public void agregarCupo(){

	};

}

