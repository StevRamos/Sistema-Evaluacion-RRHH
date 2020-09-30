import java.util.ArrayList;
public class PesoCriterio{
	private int idPesoCriterio;
	private double peso;
	private ArrayList<LineaEvaluacion> lineasEvaluacion;
	private Criterio criterio;
	private PuestoTrabajo puestoTrabajo;
	private Area area;
	private Periodo periodo;

	public PesoCriterio(){
		this.lineasEvaluacion = new ArrayList<LineaEvaluacion>();
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

	public ArrayList<LineaEvaluacion> getLineasEvaluacion(){
		return this.lineasEvaluacion;
	};

	public void setLineasEvaluacion( LineaEvaluacion lineasEvaluacion ){
		this.lineasEvaluacion.add(lineasEvaluacion);
	};

	public Criterio getCriterio(){
		return this.criterio;
	};

	public void setCriterio( Criterio criterio ){
		this.criterio = criterio;
	};

	public PuestoTrabajo getPuestoTrabajo(){
		return this.puestoTrabajo;
	};

	public void setPuestoTrabajo( PuestoTrabajo puestoTrabajo ){
		this.puestoTrabajo = puestoTrabajo;
	};

	public Area getArea(){
		return this.area;
	};

	public void setArea( Area area ){
		this.area = area;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public void calcularPeso(){

	};

}

