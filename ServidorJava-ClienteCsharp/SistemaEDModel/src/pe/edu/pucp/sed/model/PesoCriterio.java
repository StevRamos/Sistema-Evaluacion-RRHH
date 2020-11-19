package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class PesoCriterio{
	private int idPesoCriterio;
	private double peso;
	private Periodo periodo;
	private ArrayList<LineaEvaluacion> lineasEvaluacion;
	private PuestoTrabajo puestoTrabajo;
	private Criterio criterio;

	public PesoCriterio(){
		this.lineasEvaluacion = new ArrayList<>();
                this.periodo = new Periodo();
                this.puestoTrabajo = new PuestoTrabajo();
                this.criterio = new Criterio();
	};

	public int getIdPesoCriterio(){
		return this.idPesoCriterio;
	};

	public void setIdPesoCriterio( int idPesoCriterio ){
		this.idPesoCriterio = idPesoCriterio;
	};

	public double getPeso(){
		return this.peso;
	};

	public void setPeso( double peso ){
		this.peso = peso;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public ArrayList<LineaEvaluacion> getLineasEvaluacion(){
		return this.lineasEvaluacion;
	};

	public void setLineasEvaluacion( ArrayList<LineaEvaluacion> lineasEvaluacion ){
		this.lineasEvaluacion = lineasEvaluacion;
	};

	public PuestoTrabajo getPuestoTrabajo(){
		return this.puestoTrabajo;
	};

	public void setPuestoTrabajo( PuestoTrabajo puestoTrabajo ){
		this.puestoTrabajo = puestoTrabajo;
	};

	public Criterio getCriterio(){
		return this.criterio;
	};

	public void setCriterio( Criterio criterio ){
		this.criterio = criterio;
	};

}

