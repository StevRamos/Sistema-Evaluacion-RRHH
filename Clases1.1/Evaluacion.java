import java.util.ArrayList;
import java.util.Date;

public class Evaluacion{
	private int id;
	private Date fechaInicio;
	private Date fechaFin;
	private double notaSinCalibrar;
	private double notaFinal;
	private String observaciones;
	private ArrayList<DetalleCriterio> detallesCriterio;

	public Evaluacion(){
		this.detallesCriterio = new ArrayList<DetalleCriterio>();
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

	public double getNotaSinCalibrar(){
		return this.notaSinCalibrar;
	};

	public void setNotaSinCalibrar( double notaSinCalibrar ){
		this.notaSinCalibrar = notaSinCalibrar;
	};

	public double getNotaFinal(){
		return this.notaFinal;
	};

	public void setNotaFinal( double notaFinal ){
		this.notaFinal = notaFinal;
	};

	public String getObservaciones(){
		return this.observaciones;
	};

	public void setObservaciones( String observaciones ){
		this.observaciones = observaciones;
	};

	public ArrayList<DetalleCriterio> getDetallesCriterio(){
		return this.detallesCriterio;
	};

	public void setDetallesCriterio( DetalleCriterio detallesCriterio ){
		this.detallesCriterio.add(detallesCriterio);
	};

	public void calcularNota(){

	};

	public void mostrarDatos(){

	};

}

