package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class EscalaPeriodo{
	private double notaMax;
	private double notaMin;
	private Escala escala;
	private Periodo periodo;
	private ArrayList<Cupos> cupos;

	public EscalaPeriodo(){
		this.cupos = new ArrayList<Cupos>();
	};

	public double getNotaMax(){
		return this.notaMax;
	};

	public void setNotaMax( double notaMax ){
		this.notaMax = notaMax;
	};

	public double getNotaMin(){
		return this.notaMin;
	};

	public void setNotaMin( double notaMin ){
		this.notaMin = notaMin;
	};

	public Escala getEscala(){
		return this.escala;
	};

	public void setEscala( Escala escala ){
		this.escala = escala;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public ArrayList<Cupos> getCupos(){
		return this.cupos;
	};

	public void setCupos( Cupos cupos ){
		this.cupos.add(cupos);
	};

}
