package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Gerencia{
	private int idArea;
	private String nombre;
	private String descripcion;
	private ArrayList<GerenciaPeriodo> configuracionFechas;
	private ArrayList<Colaborador> colaboradores;

	public Gerencia(){
		this.configuracionFechas = new ArrayList<GerenciaPeriodo>();
		this.colaboradores = new ArrayList<Colaborador>();
	};

	public int getIdArea(){
		return this.idArea;
	};

	public void setIdArea( int idArea ){
		this.idArea = idArea;
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

	public ArrayList<GerenciaPeriodo> getConfiguracionFechas(){
		return this.configuracionFechas;
	};

	public void setConfiguracionFechas( GerenciaPeriodo configuracionFechas ){
		this.configuracionFechas.add(configuracionFechas);
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

