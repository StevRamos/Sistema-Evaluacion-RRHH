import java.util.ArrayList;

public class EscalaPerDesempenho{
	private ListArray<Cupos> cupos;
	private ListArray<EvaluacionFinal> evaluaciones;

	public EscalaPerDesempenho(){
		this.cupos = new ArrayList<Cupos>();
		this.evaluaciones = new ArrayList<EvaluacionFinal>();
	};

	public Cupos getCupos(){
		return this.cupos;
	};

	public void setCupos( ListArray<Cupos> cupos ){
		this.cupos.add(cupos);
	};

	public EvaluacionFinal getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( ListArray<EvaluacionFinal> evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

}

