package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class EvaluacionDesempenho extends Evaluacion{
	private String observacionesComp;
	private double notaAutoEvalComp;
	private double notaPreviaComp;
	private double notaFinalComp;
	private String observacionesObj;
	private double notaAutoEvalObj;
	private double notaPreviaObj;
	private double notaFinalObj;
	private double notaPrevia;
	private ArrayList<Objetivo> objetivos;

	public EvaluacionDesempenho(){
                super();
		this.objetivos = new ArrayList<>();
	};

	public String getObservacionesComp(){
		return this.observacionesComp;
	};

	public void setObservacionesComp( String observacionesComp ){
		this.observacionesComp = observacionesComp;
	};

	public double getNotaAutoEvalComp(){
		return this.notaAutoEvalComp;
	};

	public void setNotaAutoEvalComp( double notaAutoEvalComp ){
		this.notaAutoEvalComp = notaAutoEvalComp;
	};

	public double getNotaPreviaComp(){
		return this.notaPreviaComp;
	};

	public void setNotaPreviaComp( double notaPreviaComp ){
		this.notaPreviaComp = notaPreviaComp;
	};

	public double getNotaFinalComp(){
		return this.notaFinalComp;
	};

	public void setNotaFinalComp( double notaFinalComp ){
		this.notaFinalComp = notaFinalComp;
	};

	public String getObservacionesObj(){
		return this.observacionesObj;
	};

	public void setObservacionesObj( String observacionesObj ){
		this.observacionesObj = observacionesObj;
	};

	public double getNotaAutoEvalObj(){
		return this.notaAutoEvalObj;
	};

	public void setNotaAutoEvalObj( double notaAutoEvalObj ){
		this.notaAutoEvalObj = notaAutoEvalObj;
	};

	public double getNotaPreviaObj(){
		return this.notaPreviaObj;
	};

	public void setNotaPreviaObj( double notaPreviaObj ){
		this.notaPreviaObj = notaPreviaObj;
	};

	public double getNotaFinalObj(){
		return this.notaFinalObj;
	};

	public void setNotaFinalObj( double notaFinalObj ){
		this.notaFinalObj = notaFinalObj;
	};

	public double getNotaPrevia(){
		return this.notaPrevia;
	};

	public void setNotaPrevia( double notaPrevia ){
		this.notaPrevia = notaPrevia;
	};

	public ArrayList<Objetivo> getObjetivos(){
		return this.objetivos;
	};

	public void setObjetivos( Objetivo objetivos ){
		this.objetivos.add(objetivos);
	};

	public void calcularNotaEvalCompetencia(){

	};

	public void calcularNotaEvalObjetivo(){

	};

	public void calcularNotaPreviaCompetencia(){

	};

	public void calcularNotaPreviaObjetivo(){

	};

	public void calcularNotaPrevia(){

	};

}

