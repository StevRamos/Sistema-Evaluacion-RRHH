import java.util.ArrayList;
public class EvaluacionDesempenho extends Evaluacion{
	private double notaEvalObj;
	private double notaEvalCompetencia;
	private double notaAutoEvalComp;
	private double notaAutoEvalObj;
	private ArrayList<DetalleObjEvDesempenho> detallesObjetivos;
	private EvaluacionFinal evaluacionFinal;

	public EvaluacionDesempenho(){
		this.detallesObjetivos = new ArrayList<DetalleObjEvDesempenho>();
	};

	public double getNotaEvalObj(){
		return this.notaEvalObj;
	};

	public void setNotaEvalObj( double notaEvalObj ){
		this.notaEvalObj = notaEvalObj;
	};

	public double getNotaEvalCompetencia(){
		return this.notaEvalCompetencia;
	};

	public void setNotaEvalCompetencia( double notaEvalCompetencia ){
		this.notaEvalCompetencia = notaEvalCompetencia;
	};

	public double getNotaAutoEvalComp(){
		return this.notaAutoEvalComp;
	};

	public void setNotaAutoEvalComp( double notaAutoEvalComp ){
		this.notaAutoEvalComp = notaAutoEvalComp;
	};

	public double getNotaAutoEvalObj(){
		return this.notaAutoEvalObj;
	};

	public void setNotaAutoEvalObj( double notaAutoEvalObj ){
		this.notaAutoEvalObj = notaAutoEvalObj;
	};

	public ArrayList<DetalleObjEvDesempenho> getDetallesObjetivos(){
		return this.detallesObjetivos;
	};

	public void setDetallesObjetivos( DetalleObjEvDesempenho detallesObjetivos ){
		this.detallesObjetivos.add(detallesObjetivos);
	};

	public EvaluacionFinal getEvaluacionFinal(){
		return this.evaluacionFinal;
	};

	public void setEvaluacionFinal( EvaluacionFinal evaluacionFinal ){
		this.evaluacionFinal = evaluacionFinal;
	};

	public void calcularNotaEvalCompetencia(){

	};

	public void calcularNotaEvalObjetivo(){

	};

}

