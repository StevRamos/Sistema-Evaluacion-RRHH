package pe.edu.pucp.sed.model;

public class LineaPotencial{
	private boolean cumplioAutoEval;
	private boolean cumplioPrevia;
	private boolean cumplioFinal;

	public boolean getCumplioAutoEval(){
		return this.cumplioAutoEval;
	};

	public void setCumplioAutoEval( boolean cumplioAutoEval ){
		this.cumplioAutoEval = cumplioAutoEval;
	};

	public boolean getCumplioPrevia(){
		return this.cumplioPrevia;
	};

	public void setCumplioPrevia( boolean cumplioPrevia ){
		this.cumplioPrevia = cumplioPrevia;
	};

	public boolean getCumplioFinal(){
		return this.cumplioFinal;
	};

	public void setCumplioFinal( boolean cumplioFinal ){
		this.cumplioFinal = cumplioFinal;
	};

}

