import java.util.ArrayList;

public class EscalaPerPotencial{
	private ListArray<EvaluacionFinal> evaluaciones;

	public EscalaPerPotencial(){
		this.evaluaciones = new ArrayList<EvaluacionFinal>();
	};

	public EvaluacionFinal getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( ListArray<EvaluacionFinal> evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

}

