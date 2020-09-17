import java.util.ArrayList;
import java.util.Date;

public class Periodo{
	private int id;
	private Date fechaInicio;
	private Date fechaFin;
	private ArrayList<EvaluacionFinal> evaluaciones;
	private ArrayList<PesoCriterio> pesosCriterios;
	private ArrayList<EscalaPeriodo> escalasPeriodo;
	private ArrayList<Objetivo> objetivos;

	public Periodo(){
		this.evaluaciones = new ArrayList<EvaluacionFinal>();
		this.pesosCriterios = new ArrayList<PesoCriterio>();
		this.escalasPeriodo = new ArrayList<EscalaPeriodo>();
		this.objetivos = new ArrayList<Objetivo>();
	};

	public int getId(){
		return this.id;
	};

	public void setId( int id ){
		this.id = id;
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

	public ArrayList<EvaluacionFinal> getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( EvaluacionFinal evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

	public ArrayList<PesoCriterio> getPesosCriterios(){
		return this.pesosCriterios;
	};

	public void setPesosCriterios( PesoCriterio pesosCriterios ){
		this.pesosCriterios.add(pesosCriterios);
	};

	public ArrayList<EscalaPeriodo> getEscalasPeriodo(){
		return this.escalasPeriodo;
	};

	public void setEscalasPeriodo( EscalaPeriodo escalasPeriodo ){
		this.escalasPeriodo.add(escalasPeriodo);
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

