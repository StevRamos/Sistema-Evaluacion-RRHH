package pe.edu.pucp.sed.model;

public class EscalaPeriodo{
	private double notaMax;
	private double notaMin;
	private Escala escala;
	private Periodo periodo;

        public EscalaPeriodo(){
            this.escala = new Escala();
            this.periodo = new Periodo();
        }
        
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

	public Escala getEscala(){
		return this.escala;
	};

	public void setEscala( Escala escala ){
		this.escala = escala;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

}

