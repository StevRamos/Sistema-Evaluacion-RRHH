import java.util.Date;

public class Objetivo{
	private int id;
	private String descripcion;
	private boolean estado;
	private Date fechaFormulacion;
	private Date fechaAprobacion;
	private double meta;
	private char unidadMedida;
	private String observacion;
	private DetalleObjEvDesempenho detalleObjetivo;
	private Colaborador colaborador;
	private Periodo periodo;

	public int getId(){
		return this.id;
	};

	public void setId( int id ){
		this.id = id;
	};

	public String getDescripcion(){
		return this.descripcion;
	};

	public void setDescripcion( String descripcion ){
		this.descripcion = descripcion;
	};

	public boolean getEstado(){
		return this.estado;
	};

	public void setEstado( boolean estado ){
		this.estado = estado;
	};

	public Date getFechaFormulacion(){
		return this.fechaFormulacion;
	};

	public void setFechaFormulacion( Date fechaFormulacion ){
		this.fechaFormulacion = fechaFormulacion;
	};

	public Date getFechaAprobacion(){
		return this.fechaAprobacion;
	};

	public void setFechaAprobacion( Date fechaAprobacion ){
		this.fechaAprobacion = fechaAprobacion;
	};

	public double getMeta(){
		return this.meta;
	};

	public void setMeta( double meta ){
		this.meta = meta;
	};

	public char getUnidadMedida(){
		return this.unidadMedida;
	};

	public void setUnidadMedida( char unidadMedida ){
		this.unidadMedida = unidadMedida;
	};

	public String getObservacion(){
		return this.observacion;
	};

	public void setObservacion( String observacion ){
		this.observacion = observacion;
	};

	public DetalleObjEvDesempenho getDetalleObjetivo(){
		return this.detalleObjetivo;
	};

	public void setDetalleObjetivo( DetalleObjEvDesempenho detalleObjetivo ){
		this.detalleObjetivo = detalleObjetivo;
	};

	public Colaborador getColaborador(){
		return this.colaborador;
	};

	public void setColaborador( Colaborador colaborador ){
		this.colaborador = colaborador;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public void mostrarDatos(){

	};

	public void denegar(){

	};

	public void aprobar(){

	};

}

