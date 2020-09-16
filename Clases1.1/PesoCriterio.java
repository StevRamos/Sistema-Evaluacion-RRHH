import java.util.ArrayList;

public class PesoCriterio{
	private double peso;
	private ListArray<DetalleCriterio> detallesCriterio;
	private Criterio criterio;
	private PuestoTrabajo puestoTrabajo;
	private Area area;
	private Periodo periodo;

	public PesoCriterio(){
		this.detallesCriterio = new ArrayList<DetalleCriterio>();
	};

	public double getPeso(){
		return this.peso;
	};

	public void setPeso( double peso ){
		this.peso = peso;
	};

	public DetalleCriterio getDetallesCriterio(){
		return this.detallesCriterio;
	};

	public void setDetallesCriterio( ListArray<DetalleCriterio> detallesCriterio ){
		this.detallesCriterio.add(detallesCriterio);
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

