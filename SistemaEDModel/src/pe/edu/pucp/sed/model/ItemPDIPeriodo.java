package pe.edu.pucp.sed.model;

public class ItemPDIPeriodo{
	private double notaMin;
	private double notaMax;
	private ItemPDI itemPDI;
	private Periodo periodo;

	public double getNotaMin(){
		return this.notaMin;
	};

	public void setNotaMin( double notaMin ){
		this.notaMin = notaMin;
	};

	public double getNotaMax(){
		return this.notaMax;
	};

	public void setNotaMax( double notaMax ){
		this.notaMax = notaMax;
	};

	public ItemPDI getItemPDI(){
		return this.itemPDI;
	};

	public void setItemPDI( ItemPDI itemPDI ){
		this.itemPDI = itemPDI;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

}

