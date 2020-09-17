import java.util.ArrayList;
public class TipoCriterio{
	private ArrayList<Criterio> criterios;
	private ArrayList<Escala> escalas;

	public TipoCriterio(){
		this.criterios = new ArrayList<Criterio>();
		this.escalas = new ArrayList<Escala>();
	};

	public ArrayList<Criterio> getCriterios(){
		return this.criterios;
	};

	public void setCriterios( Criterio criterios ){
		this.criterios.add(criterios);
	};

	public ArrayList<Escala> getEscalas(){
		return this.escalas;
	};

	public void setEscalas( Escala escalas ){
		this.escalas.add(escalas);
	};

}

