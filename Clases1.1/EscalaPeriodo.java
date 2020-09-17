public abstract class EscalaPeriodo{
	private double notaMax;
	private double notaMin;
	private Periodo periodo;
	private Escala escala;

	public double getNotaMax(){
		return this.notaMax;
	};

	public void setNotaMax( double notaMax ){
		this.notaMax = notaMax;
	};

	public double getNotaMin(){
		return this.notaMin;
	};

	public void setNotaMin( double notaMin ){
		this.notaMin = notaMin;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public Escala getEscala(){
		return this.escala;
	};

	public void setEscala( Escala escala ){
		this.escala = escala;
	};

}

