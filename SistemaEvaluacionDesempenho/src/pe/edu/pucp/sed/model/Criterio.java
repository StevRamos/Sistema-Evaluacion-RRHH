package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Criterio{
	private int idCriterio;
	private String nombre;
	private String descripcion;
	private boolean esVigente;
	private int tipo;
	private ArrayList<Subcriterio> subcriterios;
	private ArrayList<PesoCriterio> pesosCriterio;

	public Criterio(){
		this.subcriterios = new ArrayList<Subcriterio>();
		this.pesosCriterio = new ArrayList<PesoCriterio>();
	};

	public int getIdCriterio(){
		return this.idCriterio;
	};

	public void setIdCriterio( int idCriterio ){
		this.idCriterio = idCriterio;
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

	public boolean getEsVigente(){
		return this.esVigente;
	};

	public void setEsVigente( boolean esVigente ){
		this.esVigente = esVigente;
	};

	public int getTipo(){
		return this.tipo;
	};

	public void setTipo( int tipo ){
		this.tipo = tipo;
	};

	public ArrayList<Subcriterio> getSubcriterios(){
		return this.subcriterios;
	};

	public void setSubcriterios( Subcriterio subcriterios ){
		this.subcriterios.add(subcriterios);
	};

	public ArrayList<PesoCriterio> getPesosCriterio(){
		return this.pesosCriterio;
	};

	public void setPesosCriterio( PesoCriterio pesosCriterio ){
		this.pesosCriterio.add(pesosCriterio);
	};

}

