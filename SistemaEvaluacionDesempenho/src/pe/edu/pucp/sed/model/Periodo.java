package pe.edu.pucp.sed.model;

import java.util.ArrayList;
import java.util.Date;

public class Periodo{
	private int idPeriodo;
	private Date fechaInicio;
	private Date fechaFin;
	private double pesoEvalObj;
	private double pesoEvalComp;
	private ArrayList<Evaluacion> evaluaciones;
	private ArrayList<PesoSubcriterio> pesosSubcriterio;
	private ArrayList<PesoCriterio> pesosCriterio;
	private ArrayList<ItemPDIPeriodo> rangosPDI;
	private ArrayList<AreaPeriodo> configuracionFechas;
	private ArrayList<EscalaPeriodo> escalas;
	private ArrayList<Objetivo> objetivos;

	public Periodo(){
		this.evaluaciones = new ArrayList<Evaluacion>();
		this.pesosSubcriterio = new ArrayList<PesoSubcriterio>();
		this.pesosCriterio = new ArrayList<PesoCriterio>();
		this.rangosPDI = new ArrayList<ItemPDIPeriodo>();
		this.configuracionFechas = new ArrayList<AreaPeriodo>();
		this.escalas = new ArrayList<EscalaPeriodo>();
		this.objetivos = new ArrayList<Objetivo>();
	};

	public int getIdPeriodo(){
		return this.idPeriodo;
	};

	public void setIdPeriodo( int idPeriodo ){
		this.idPeriodo = idPeriodo;
	};

	public Date getFechaInicio(){
		return this.fechaInicio;
	};

	public void setFechaInicio( Date fechaInicio ){
		this.fechaInicio = fechaInicio;
	};

	public Date getFechaFin(){
		return this.fechaFin;
	};

	public void setFechaFin( Date fechaFin ){
		this.fechaFin = fechaFin;
	};

	public double getPesoEvalObj(){
		return this.pesoEvalObj;
	};

	public void setPesoEvalObj( double pesoEvalObj ){
		this.pesoEvalObj = pesoEvalObj;
	};

	public double getPesoEvalComp(){
		return this.pesoEvalComp;
	};

	public void setPesoEvalComp( double pesoEvalComp ){
		this.pesoEvalComp = pesoEvalComp;
	};

	public ArrayList<Evaluacion> getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( Evaluacion evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

	public ArrayList<PesoSubcriterio> getPesosSubcriterio(){
		return this.pesosSubcriterio;
	};

	public void setPesosSubcriterio( PesoSubcriterio pesosSubcriterio ){
		this.pesosSubcriterio.add(pesosSubcriterio);
	};

	public ArrayList<PesoCriterio> getPesosCriterio(){
		return this.pesosCriterio;
	};

	public void setPesosCriterio( PesoCriterio pesosCriterio ){
		this.pesosCriterio.add(pesosCriterio);
	};

	public ArrayList<ItemPDIPeriodo> getRangosPDI(){
		return this.rangosPDI;
	};

	public void setRangosPDI( ItemPDIPeriodo rangosPDI ){
		this.rangosPDI.add(rangosPDI);
	};

	public ArrayList<AreaPeriodo> getConfiguracionFechas(){
		return this.configuracionFechas;
	};

	public void setConfiguracionFechas( AreaPeriodo configuracionFechas ){
		this.configuracionFechas.add(configuracionFechas);
	};

	public ArrayList<EscalaPeriodo> getEscalas(){
		return this.escalas;
	};

	public void setEscalas( EscalaPeriodo escalas ){
		this.escalas.add(escalas);
	};

	public ArrayList<Objetivo> getObjetivos(){
		return this.objetivos;
	};

	public void setObjetivos( Objetivo objetivos ){
		this.objetivos.add(objetivos);
	};

	public void finalizar(){

	};

}

