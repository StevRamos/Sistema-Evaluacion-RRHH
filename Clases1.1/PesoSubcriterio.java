import java.util.ArrayList;

public class PesoSubcriterio{
	private double peso;
	private Subcriterio subcriterio;
	private PesoCriterio pesoCriterio;
	private ListArray<DetalleSubcriterio> detallesSubcriterio;

	public PesoSubcriterio(){
		this.detallesSubcriterio = new ArrayList<DetalleSubcriterio>();
	};

	public double getPeso(){
		return this.peso;
	};

	public void setPeso( double peso ){
		this.peso = peso;
	};

	public Subcriterio getSubcriterio(){
		return this.subcriterio;
	};

	public void setSubcriterio( Subcriterio subcriterio ){
		this.subcriterio = subcriterio;
	};

	public PesoCriterio getPesoCriterio(){
		return this.pesoCriterio;
	};

	public void setPesoCriterio( PesoCriterio pesoCriterio ){
		this.pesoCriterio = pesoCriterio;
	};

	public DetalleSubcriterio getDetallesSubcriterio(){
		return this.detallesSubcriterio;
	};

	public void setDetallesSubcriterio( ListArray<DetalleSubcriterio> detallesSubcriterio ){
		this.detallesSubcriterio.add(detallesSubcriterio);
	};

}

