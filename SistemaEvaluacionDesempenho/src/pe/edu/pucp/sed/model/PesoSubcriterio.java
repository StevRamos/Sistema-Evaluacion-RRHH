package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class PesoSubcriterio{
	private int idPesoSubcriterio;
	private double peso;
	private ArrayList<LineaCriterio> lineasCriterio;
	private PuestoTrabajo puestoTrabajo;
	private Subcriterio subcriterio;
	private Periodo periodo;
	private Area area;

	public PesoSubcriterio(){
		this.lineasCriterio = new ArrayList<LineaCriterio>();
	};

	public int getIdPesoSubcriterio(){
		return this.idPesoSubcriterio;
	};

	public void setIdPesoSubcriterio( int idPesoSubcriterio ){
		this.idPesoSubcriterio = idPesoSubcriterio;
	};

	public double getPeso(){
		return this.peso;
	};

	public void setPeso( double peso ){
		this.peso = peso;
	};

	public ArrayList<LineaCriterio> getLineasCriterio(){
		return this.lineasCriterio;
	};

	public void setLineasCriterio( LineaCriterio lineasCriterio ){
		this.lineasCriterio.add(lineasCriterio);
	};

	public PuestoTrabajo getPuestoTrabajo(){
		return this.puestoTrabajo;
	};

	public void setPuestoTrabajo( PuestoTrabajo puestoTrabajo ){
		this.puestoTrabajo = puestoTrabajo;
	};

	public Subcriterio getSubcriterio(){
		return this.subcriterio;
	};

	public void setSubcriterio( Subcriterio subcriterio ){
		this.subcriterio = subcriterio;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public Area getArea(){
		return this.area;
	};

	public void setArea( Area area ){
		this.area = area;
	};

}

