package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Subcriterio{
	private int idSubcriterio;
	private String nombre;
	private String descripcion;
	private boolean esVigente;
	private int tipo;
	private ArrayList<PesoSubcriterio> pesosSubcriterio;
	private Criterio criterio;

	public Subcriterio(){
		this.pesosSubcriterio = new ArrayList<PesoSubcriterio>();
	};

	public int getIdSubcriterio(){
		return this.idSubcriterio;
	};

	public void setIdSubcriterio( int idSubcriterio ){
		this.idSubcriterio = idSubcriterio;
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

	public ArrayList<PesoSubcriterio> getPesosSubcriterio(){
		return this.pesosSubcriterio;
	};

	public void setPesosSubcriterio( PesoSubcriterio pesosSubcriterio ){
		this.pesosSubcriterio.add(pesosSubcriterio);
	};

	public Criterio getCriterio(){
		return this.criterio;
	};

	public void setCriterio( Criterio criterio ){
		this.criterio = criterio;
	};

}

