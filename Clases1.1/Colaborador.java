import java.util.ArrayList;
import java.util.Date;

public class Colaborador{
	private int id;
	private String nombres;
	private String apellidos;
	private String direccion;
	private int dni;
	private String correo;
	private int telefono;
	private Date fechaNac;
	private ArrayList<Objetivo> objetivos;
	private ArrayList<EvaluacionFinal> evaluaciones;
	private PuestoTrabajo puestoTrabajo;
	private Area area;
	private Colaborador jefe;
	private ArrayList<Colaborador> subordinados;

	public Colaborador(){
		this.objetivos = new ArrayList<Objetivo>();
		this.evaluaciones = new ArrayList<EvaluacionFinal>();
		this.subordinados = new ArrayList<Colaborador>();
	};

	public int getId(){
		return this.id;
	};

	public void setId( int id ){
		this.id = id;
	};

	public String getNombres(){
		return this.nombres;
	};

	public void setNombres( String nombres ){
		this.nombres = nombres;
	};

	public String getApellidos(){
		return this.apellidos;
	};

	public void setApellidos( String apellidos ){
		this.apellidos = apellidos;
	};

	public String getDireccion(){
		return this.direccion;
	};

	public void setDireccion( String direccion ){
		this.direccion = direccion;
	};

	public int getDni(){
		return this.dni;
	};

	public void setDni( int dni ){
		this.dni = dni;
	};

	public String getCorreo(){
		return this.correo;
	};

	public void setCorreo( String correo ){
		this.correo = correo;
	};

	public int getTelefono(){
		return this.telefono;
	};

	public void setTelefono( int telefono ){
		this.telefono = telefono;
	};

	public Date getFechaNac(){
		return this.fechaNac;
	};

	public void setFechaNac( Date fechaNac ){
		this.fechaNac = fechaNac;
	};

	public ArrayList<Objetivo> getObjetivos(){
		return this.objetivos;
	};

	public void setObjetivos( Objetivo objetivos ){
		this.objetivos.add(objetivos);
	};

	public ArrayList<EvaluacionFinal> getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( EvaluacionFinal evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

	public PuestoTrabajo getPuestoTrabajo(){
		return this.puestoTrabajo;
	};

	public void setPuestoTrabajo( PuestoTrabajo puestoTrabajo ){
		this.puestoTrabajo = puestoTrabajo;
	};

	public Area getArea(){
		return this.area;
	};

	public void setArea( Area area ){
		this.area = area;
	};

	public Colaborador getJefe(){
		return this.jefe;
	};

	public void setJefe( Colaborador jefe ){
		this.jefe = jefe;
	};

	public ArrayList<Colaborador> getSubordinados(){
		return this.subordinados;
	};

	public void setSubordinados( Colaborador subordinados ){
		this.subordinados.add(subordinados);
	};

	public void crearUsuario(){

	};

	public void agregarObjetivo(){

	};

	public void colocoObjetivos(){

	};

	public void esJefe(){

	};

	public void mostrarSubordinados(){

	};

	public void realizarAutoEvaluacionObj(){

	};

	public void realizarAutoEvaluacionComp(){

	};

}

