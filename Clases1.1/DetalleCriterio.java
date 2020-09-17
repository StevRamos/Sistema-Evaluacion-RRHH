import java.util.ArrayList;
public class DetalleCriterio{
	private double nota;
	private double notaAutoEval;
	private PesoCriterio pesoCriterio;
	private Evaluacion evaluacion;
	private ArrayList<DetalleSubcriterio> detallesSubcriterio;

	public DetalleCriterio(){
		this.detallesSubcriterio = new ArrayList<DetalleSubcriterio>();
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

	public PesoCriterio getPesoCriterio(){
		return this.pesoCriterio;
	};

	public void setPesoCriterio( PesoCriterio pesoCriterio ){
		this.pesoCriterio = pesoCriterio;
	};

	public Evaluacion getEvaluacion(){
		return this.evaluacion;
	};

	public void setEvaluacion( Evaluacion evaluacion ){
		this.evaluacion = evaluacion;
	};

	public ArrayList<DetalleSubcriterio> getDetallesSubcriterio(){
		return this.detallesSubcriterio;
	};

	public void setDetallesSubcriterio( DetalleSubcriterio detallesSubcriterio ){
		this.detallesSubcriterio.add(detallesSubcriterio);
	};

	public void calcularNotaAutoEval(){

	};

	public void mostrarDatos(){

	};

}

