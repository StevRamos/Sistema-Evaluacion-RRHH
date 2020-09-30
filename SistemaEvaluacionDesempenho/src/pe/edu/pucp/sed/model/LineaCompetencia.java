package pe.edu.pucp.sed.model;

public class LineaCompetencia{
	private double nota;
	private double notaAutoEval;
	private double notaPrevia;

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

	public double getNotaPrevia(){
		return this.notaPrevia;
	};

	public void setNotaPrevia( double notaPrevia ){
		this.notaPrevia = notaPrevia;
	};

}

