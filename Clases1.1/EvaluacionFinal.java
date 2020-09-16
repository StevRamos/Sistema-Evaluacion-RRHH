import java.util.ArrayList;

public class EvaluacionFinal{
	private EvaluacionDesempenho evaluacionDesempenho;
	private EvaluacionPotencial evaluacionPotencial;
	private Periodo periodo;
	private ListArray<EscalaPerPotencial> escalaSinCalibrar;
	private ListArray<EscalaPerPotencial> escalaFinal;
	private ListArray<EscalaPerDesempenho> letraSinCalibrar;
	private ListArray<EscalaPerDesempenho> letraFinal;
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

	public EscalaPerPotencial getEscalaSinCalibrar(){
		return this.escalaSinCalibrar;
	};

	public void setEscalaSinCalibrar( ListArray<EscalaPerPotencial> escalaSinCalibrar ){
		this.escalaSinCalibrar.add(escalaSinCalibrar);
	};

	public EscalaPerPotencial getEscalaFinal(){
		return this.escalaFinal;
	};

	public void setEscalaFinal( ListArray<EscalaPerPotencial> escalaFinal ){
		this.escalaFinal.add(escalaFinal);
	};

	public EscalaPerDesempenho getLetraSinCalibrar(){
		return this.letraSinCalibrar;
	};

	public void setLetraSinCalibrar( ListArray<EscalaPerDesempenho> letraSinCalibrar ){
		this.letraSinCalibrar.add(letraSinCalibrar);
	};

	public EscalaPerDesempenho getLetraFinal(){
		return this.letraFinal;
	};

	public void setLetraFinal( ListArray<EscalaPerDesempenho> letraFinal ){
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

