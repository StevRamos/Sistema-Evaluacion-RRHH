import java.util.ArrayList;

public class Periodo{
	private int id;
	private Date fechaInicio;
	private Date fechaFin;
	private ListArray<EvaluacionFinal> evaluaciones;
	private ListArray<PesoCriterio> pesosCriterios;
	private ListArray<EscalaPeriodo> escalasPeriodo;
	private ListArray<Objetivo> objetivos;

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

	public EvaluacionFinal getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( ListArray<EvaluacionFinal> evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

	public PesoCriterio getPesosCriterios(){
		return this.pesosCriterios;
	};

	public void setPesosCriterios( ListArray<PesoCriterio> pesosCriterios ){
		this.pesosCriterios.add(pesosCriterios);
	};

	public EscalaPeriodo getEscalasPeriodo(){
		return this.escalasPeriodo;
	};

	public void setEscalasPeriodo( ListArray<EscalaPeriodo> escalasPeriodo ){
		this.escalasPeriodo.add(escalasPeriodo);
	};

	public Objetivo getObjetivos(){
		return this.objetivos;
	};

	public void setObjetivos( ListArray<Objetivo> objetivos ){
		this.objetivos.add(objetivos);
	};

	public void finalizar(){

	};

}

