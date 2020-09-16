import java.util.ArrayList;

public class TipoCriterio{
	private ListArray<Criterio> criterios;
	private ListArray<Escala> escalas;

	public TipoCriterio(){
		this.criterios = new ArrayList<Criterio>();
		this.escalas = new ArrayList<Escala>();
	};

	public Criterio getCriterios(){
		return this.criterios;
	};

	public void setCriterios( ListArray<Criterio> criterios ){
		this.criterios.add(criterios);
	};

	public Escala getEscalas(){
		return this.escalas;
	};

	public void setEscalas( ListArray<Escala> escalas ){
		this.escalas.add(escalas);
	};

}

