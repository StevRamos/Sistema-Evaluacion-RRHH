public class EvaluacionPotencial extends Evaluacion{
	private double notaAutoEval;
	private EvaluacionFinal evaluacionFinal;

	public double getNotaAutoEval(){
		return this.notaAutoEval;
	};

	public void setNotaAutoEval( double notaAutoEval ){
		this.notaAutoEval = notaAutoEval;
	};

	public EvaluacionFinal getEvaluacionFinal(){
		return this.evaluacionFinal;
	};

	public void setEvaluacionFinal( EvaluacionFinal evaluacionFinal ){
		this.evaluacionFinal = evaluacionFinal;
	};

}

