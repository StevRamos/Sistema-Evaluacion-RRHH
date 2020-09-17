import java.util.ArrayList;
public class EscalaPerPotencial extends EscalaPeriodo{
	private ArrayList<EvaluacionFinal> evaluaciones;

	public EscalaPerPotencial(){
		this.evaluaciones = new ArrayList<EvaluacionFinal>();
	};

	public ArrayList<EvaluacionFinal> getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( EvaluacionFinal evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

}

