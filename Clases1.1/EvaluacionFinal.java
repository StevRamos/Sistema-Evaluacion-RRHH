import java.util.ArrayList;
public class EvaluacionFinal{
	private EvaluacionDesempenho evaluacionDesempenho;
	private EvaluacionPotencial evaluacionPotencial;
	private Periodo periodo;
	private ArrayList<EscalaPerPotencial> escalaSinCalibrar;
	private ArrayList<EscalaPerPotencial> escalaFinal;
	private ArrayList<EscalaPerDesempenho> letraSinCalibrar;
	private ArrayList<EscalaPerDesempenho> letraFinal;
	private Colaborador colaborador;

	public EvaluacionFinal(){
		this.escalaSinCalibrar = new ArrayList<EscalaPerPotencial>();
		this.escalaFinal = new ArrayList<EscalaPerPotencial>();
		this.letraSinCalibrar = new ArrayList<EscalaPerDesempenho>();
		this.letraFinal = new ArrayList<EscalaPerDesempenho>();
	};

	public EvaluacionDesempenho getEvaluacionDesempenho(){
		return this.evaluacionDesempenho;
	};

	public void setEvaluacionDesempenho( EvaluacionDesempenho evaluacionDesempenho ){
		this.evaluacionDesempenho = evaluacionDesempenho;
	};

	public EvaluacionPotencial getEvaluacionPotencial(){
		return this.evaluacionPotencial;
	};

	public void setEvaluacionPotencial( EvaluacionPotencial evaluacionPotencial ){
		this.evaluacionPotencial = evaluacionPotencial;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public ArrayList<EscalaPerPotencial> getEscalaSinCalibrar(){
		return this.escalaSinCalibrar;
	};

	public void setEscalaSinCalibrar( EscalaPerPotencial escalaSinCalibrar ){
		this.escalaSinCalibrar.add(escalaSinCalibrar);
	};

	public ArrayList<EscalaPerPotencial> getEscalaFinal(){
		return this.escalaFinal;
	};

	public void setEscalaFinal( EscalaPerPotencial escalaFinal ){
		this.escalaFinal.add(escalaFinal);
	};

	public ArrayList<EscalaPerDesempenho> getLetraSinCalibrar(){
		return this.letraSinCalibrar;
	};

	public void setLetraSinCalibrar( EscalaPerDesempenho letraSinCalibrar ){
		this.letraSinCalibrar.add(letraSinCalibrar);
	};

	public ArrayList<EscalaPerDesempenho> getLetraFinal(){
		return this.letraFinal;
	};

	public void setLetraFinal( EscalaPerDesempenho letraFinal ){
		this.letraFinal.add(letraFinal);
	};

	public Colaborador getColaborador(){
		return this.colaborador;
	};

	public void setColaborador( Colaborador colaborador ){
		this.colaborador = colaborador;
	};

	public void generarReporte(){

	};

	public void generarPDI(){

	};

	public void calcularLetra(){

	};

	public void finalizar(){

	};

}

