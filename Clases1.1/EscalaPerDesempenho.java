import java.util.ArrayList;
public class EscalaPerDesempenho{
	private ArrayList<Cupos> cupos;
	private ArrayList<EvaluacionFinal> evaluaciones;

	public EscalaPerDesempenho(){
		this.cupos = new ArrayList<Cupos>();
		this.evaluaciones = new ArrayList<EvaluacionFinal>();
	};

	public ArrayList<Cupos> getCupos(){
		return this.cupos;
	};

	public void setCupos( Cupos cupos ){
		this.cupos.add(cupos);
	};

	public ArrayList<EvaluacionFinal> getEvaluaciones(){
		return this.evaluaciones;
	};

	public void setEvaluaciones( EvaluacionFinal evaluaciones ){
		this.evaluaciones.add(evaluaciones);
	};

}

