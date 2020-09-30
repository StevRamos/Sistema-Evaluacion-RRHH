import java.util.ArrayList;
public class LineaEvaluacion{
	private int idLineaEvaluacion;
	private double notaFinal;
	private double notaAutoEval;
	private double notaPrevia;
	private PesoCriterio peso;
	private ArrayList<LineaCriterio> lineasCriterio;
	private ItemPDI itemPDI;
	private Evaluacion evaluacion;

	public LineaEvaluacion(){
		this.lineasCriterio = new ArrayList<LineaCriterio>();
	};

	public int getIdLineaEvaluacion(){
		return this.idLineaEvaluacion;
	};

	public void setIdLineaEvaluacion( int idLineaEvaluacion ){
		this.idLineaEvaluacion = idLineaEvaluacion;
	};

	public double getNotaFinal(){
		return this.notaFinal;
	};

	public void setNotaFinal( double notaFinal ){
		this.notaFinal = notaFinal;
	};

	public double getNotaAutoEval(){
		return this.notaAutoEval;
	};

	public void setNotaAutoEval( double notaAutoEval ){
		this.notaAutoEval = notaAutoEval;
	};

	public double getNotaPrevia(){
		return this.notaPrevia;
	};

	public void setNotaPrevia( double notaPrevia ){
		this.notaPrevia = notaPrevia;
	};

	public PesoCriterio getPeso(){
		return this.peso;
	};

	public void setPeso( PesoCriterio peso ){
		this.peso = peso;
	};

	public ArrayList<LineaCriterio> getLineasCriterio(){
		return this.lineasCriterio;
	};

	public void setLineasCriterio( LineaCriterio lineasCriterio ){
		this.lineasCriterio.add(lineasCriterio);
	};

	public ItemPDI getItemPDI(){
		return this.itemPDI;
	};

	public void setItemPDI( ItemPDI itemPDI ){
		this.itemPDI = itemPDI;
	};

	public Evaluacion getEvaluacion(){
		return this.evaluacion;
	};

	public void setEvaluacion( Evaluacion evaluacion ){
		this.evaluacion = evaluacion;
	};

	public void calcularNotaAutoEval(){

	};

	public void mostrarDatos(){

	};

}

