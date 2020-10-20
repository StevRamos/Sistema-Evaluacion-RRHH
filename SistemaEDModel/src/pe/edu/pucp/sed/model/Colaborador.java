package pe.edu.pucp.sed.model;

import java.util.ArrayList;
import java.util.Date;

public class Colaborador{
	private int idColaborador;
	private String nombres;
	private String apellidos;
	private String direccion;
	private String dni;
	private String correo;
	private String telefono;
	private Date fechaNac;
	private String contrasena;
	private EstadoCuenta estadoCuenta;
	private boolean esAdmin;
	private ArrayList<Objetivo> objetivos;
	private ArrayList<Evaluacion> evaluaciones;
	private PuestoTrabajo puestoTrabajo;
	private Gerencia gerencia;
	private Colaborador jefe;
	private ArrayList<Colaborador> subordinados;

	public Colaborador(){
		this.objetivos = new ArrayList<>();
		this.evaluaciones = new ArrayList<>();
		this.subordinados = new ArrayList<>();
                this.puestoTrabajo = new PuestoTrabajo();
                this.gerencia = new Gerencia();
                this.jefe = new Colaborador();
	};

	public int getIdColaborador(){
		return this.idColaborador;
	};

	public void setIdColaborador( int idColaborador ){
		this.idColaborador = idColaborador;
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

	public String getDni(){
		return this.dni;
	};

	public void setDni( String dni ){
		this.dni = dni;
	};

	public String getCorreo(){
		return this.correo;
	};

	public void setCorreo( String correo ){
		this.correo = correo;
	};

	public String getTelefono(){
		return this.telefono;
	};

	public void setTelefono( String telefono ){
		this.telefono = telefono;
	};

	public Date getFechaNac(){
		return this.fechaNac;
	};

	public void setFechaNac( Date fechaNac ){
		this.fechaNac = fechaNac;
	};

	public String getContrasena(){
		return this.contrasena;
	};

	public void setContrasena( String contrasena ){
		this.contrasena = contrasena;
	};

	public EstadoCuenta getEstadoCuenta(){
		return this.estadoCuenta;
	};

	public void setEstadoCuenta( EstadoCuenta estadoCuenta ){
		this.estadoCuenta = estadoCuenta;
	};

	public boolean getEsAdmin(){
		return this.esAdmin;
	};

	public void setEsAdmin( boolean esAdmin ){
		this.esAdmin = esAdmin;
	};

	public ArrayList<Objetivo> getObjetivos(){
		return this.objetivos;
	};

	public void setObjetivos( Objetivo objetivos ){
		this.objetivos.add(objetivos);
	};

	public ArrayList<Evaluacion> getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( Evaluacion evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

	public PuestoTrabajo getPuestoTrabajo(){
		return this.puestoTrabajo;
	};

	public void setPuestoTrabajo( PuestoTrabajo puestoTrabajo ){
		this.puestoTrabajo = puestoTrabajo;
	};

	public Gerencia getGerencia(){
		return this.gerencia;
	};

	public void setGerencia( Gerencia gerencia ){
		this.gerencia = gerencia;
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

