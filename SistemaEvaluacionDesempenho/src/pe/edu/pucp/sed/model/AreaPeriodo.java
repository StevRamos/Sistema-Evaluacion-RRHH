import java.util.Date;

public class AreaPeriodo{
	private Date fechaInicioPlan;
	private Date fechaFinPlan;
	private Date fechaInicioEval;
	private Date fechaFinEval;
	private Periodo periodo;
	private Area area;

	public Date getFechaInicioPlan(){
		return this.fechaInicioPlan;
	};

	public void setFechaInicioPlan( Date fechaInicioPlan ){
		this.fechaInicioPlan = fechaInicioPlan;
	};

	public Date getFechaFinPlan(){
		return this.fechaFinPlan;
	};

	public void setFechaFinPlan( Date fechaFinPlan ){
		this.fechaFinPlan = fechaFinPlan;
	};

	public Date getFechaInicioEval(){
		return this.fechaInicioEval;
	};

	public void setFechaInicioEval( Date fechaInicioEval ){
		this.fechaInicioEval = fechaInicioEval;
	};

	public Date getFechaFinEval(){
		return this.fechaFinEval;
	};

	public void setFechaFinEval( Date fechaFinEval ){
		this.fechaFinEval = fechaFinEval;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};

	public Area getArea(){
		return this.area;
	};

	public void setArea( Area area ){
		this.area = area;
	};

}

