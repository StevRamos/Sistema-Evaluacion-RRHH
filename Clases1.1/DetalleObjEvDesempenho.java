public class DetalleObjEvDesempenho{
	private double logro;
	private double nota;
	private double notaAutoEval;
	private EvaluacionDesempenho evaluacion;
	private Objetivo objetivo;

	public double getLogro(){
		return this.logro;
	};

	public void setLogro( double logro ){
		this.logro = logro;
	};

	public double getNota(){
		return this.nota;
	};

	public void setNota( double nota ){
		this.nota = nota;
	};

	public double getNotaAutoEval(){
		return this.notaAutoEval;
	};

	public void setNotaAutoEval( double notaAutoEval ){
		this.notaAutoEval = notaAutoEval;
	};

	public EvaluacionDesempenho getEvaluacion(){
		return this.evaluacion;
	};

	public void setEvaluacion( EvaluacionDesempenho evaluacion ){
		this.evaluacion = evaluacion;
	};

	public Objetivo getObjetivo(){
		return this.objetivo;
	};

	public void setObjetivo( Objetivo objetivo ){
		this.objetivo = objetivo;
	};

}

