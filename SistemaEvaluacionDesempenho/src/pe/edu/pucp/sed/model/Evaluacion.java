import java.util.ArrayList;
public class Evaluacion{
	private int idEvaluacion;
	private Colaborador colaborador;
	private Escala escalaSinCalibrar;
	private Escala escalaFinal;
	private Periodo periodo;
	private ArrayList<LineaEvaluacion> lineasEvaluacion;

	public Evaluacion(){
		this.lineasEvaluacion = new ArrayList<LineaEvaluacion>();
	};

	public int getIdEvaluacion(){
		return this.idEvaluacion;
	};

	public void setIdEvaluacion( int idEvaluacion ){
		this.idEvaluacion = idEvaluacion;
	};

	public Colaborador getColaborador(){
		return this.colaborador;
	};

	public void setColaborador( Colaborador colaborador ){
		this.colaborador = colaborador;
	};

	public Escala getEscalaSinCalibrar(){
		return this.escalaSinCalibrar;
	};

	public void setEscalaSinCalibrar( Escala escalaSinCalibrar ){
		this.escalaSinCalibrar = escalaSinCalibrar;
	};

	public Escala getEscalaFinal(){
		return this.escalaFinal;
	};

	public void setEscalaFinal( Escala escalaFinal ){
		this.escalaFinal = escalaFinal;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public ArrayList<LineaEvaluacion> getLineasEvaluacion(){
		return this.lineasEvaluacion;
	};

	public void setLineasEvaluacion( LineaEvaluacion lineasEvaluacion ){
		this.lineasEvaluacion.add(lineasEvaluacion);
	};

	public void calcularNota(){

	};

	public void mostrarDatos(){

	};

}

