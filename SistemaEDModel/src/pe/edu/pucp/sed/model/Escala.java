package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Escala{
	private int idEscala;
	private String nombre;
	private boolean tipo;
	private ArrayList<Evaluacion> evaluacionesSinCalibrar;
	private ArrayList<Evaluacion> evaluacionesFinales;
	private ArrayList<Evaluacion> evaluacionesPreCupos;
	private ArrayList<EscalaPeriodo> rangos;

	public Escala(){
		this.evaluacionesSinCalibrar = new ArrayList<Evaluacion>();
		this.evaluacionesFinales = new ArrayList<Evaluacion>();
		this.evaluacionesPreCupos = new ArrayList<Evaluacion>();
		this.rangos = new ArrayList<EscalaPeriodo>();
	};

	public int getIdEscala(){
		return this.idEscala;
	};

	public void setIdEscala( int idEscala ){
		this.idEscala = idEscala;
	};

	public String getNombre(){
		return this.nombre;
	};

	public void setNombre( String nombre ){
		this.nombre = nombre;
	};

	public boolean getTipo(){
		return this.tipo;
	};

	public void setTipo( boolean tipo ){
		this.tipo = tipo;
	};

	public ArrayList<Evaluacion> getEvaluacionesSinCalibrar(){
		return this.evaluacionesSinCalibrar;
	};

	public void setEvaluacionesSinCalibrar( Evaluacion evaluacionesSinCalibrar ){
		this.evaluacionesSinCalibrar.add(evaluacionesSinCalibrar);
	};

	public ArrayList<Evaluacion> getEvaluacionesFinales(){
		return this.evaluacionesFinales;
	};

	public void setEvaluacionesFinales( Evaluacion evaluacionesFinales ){
		this.evaluacionesFinales.add(evaluacionesFinales);
	};

	public ArrayList<Evaluacion> getEvaluacionesPreCupos(){
		return this.evaluacionesPreCupos;
	};

	public void setEvaluacionesPreCupos( Evaluacion evaluacionesPreCupos ){
		this.evaluacionesPreCupos.add(evaluacionesPreCupos);
	};

	public ArrayList<EscalaPeriodo> getRangos(){
		return this.rangos;
	};

	public void setRangos( EscalaPeriodo rangos ){
		this.rangos.add(rangos);
	};

}

