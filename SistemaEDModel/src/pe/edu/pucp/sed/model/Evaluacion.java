package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Evaluacion{
	private int idEvaluacion;
	private String observaciones;
	private double notaAutoEval;
	private double notaFinal;
	private boolean tipo;
	private EstadoEvaluacion estado;
	private int estadoPDI;
	private ArrayList<LineaEvaluacion> lineasEvaluacion;
	private Colaborador colaborador;
	private Periodo periodo;

	public Evaluacion(){
		this.lineasEvaluacion = new ArrayList<LineaEvaluacion>();
                this.colaborador = new Colaborador();
                this.periodo = new Periodo();
	};

	public int getIdEvaluacion(){
		return this.idEvaluacion;
	};

	public void setIdEvaluacion( int idEvaluacion ){
		this.idEvaluacion = idEvaluacion;
	};

	public String getObservaciones(){
		return this.observaciones;
	};

	public void setObservaciones( String observaciones ){
		this.observaciones = observaciones;
	};

	public double getNotaAutoEval(){
		return this.notaAutoEval;
	};

	public void setNotaAutoEval( double notaAutoEval ){
		this.notaAutoEval = notaAutoEval;
	};

	public double getNotaFinal(){
		return this.notaFinal;
	};

	public void setNotaFinal( double notaFinal ){
		this.notaFinal = notaFinal;
	};

	public boolean getTipo(){
		return this.tipo;
	};

	public void setTipo( boolean tipo ){
		this.tipo = tipo;
	};

	public EstadoEvaluacion getEstado(){
		return this.estado;
	};

	public void setEstado( EstadoEvaluacion estado ){
		this.estado = estado;
	};

	public int getEstadoPDI(){
		return this.estadoPDI;
	};

	public void setEstadoPDI( int estadoPDI ){
		this.estadoPDI = estadoPDI;
	};

	public ArrayList<LineaEvaluacion> getLineasEvaluacion(){
		return this.lineasEvaluacion;
	};

	public void setLineasEvaluacion( LineaEvaluacion lineasEvaluacion ){
		this.lineasEvaluacion.add(lineasEvaluacion);
	};

	public Colaborador getColaborador(){
		return this.colaborador;
	};

	public void setColaborador( Colaborador colaborador ){
		this.colaborador = colaborador;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public void calcularNotaAutoEval(){

	};

	public void calcularNotaFinal(){

	};

	public void mostrarDatos(){

	};

}

