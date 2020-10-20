package pe.edu.pucp.sed.model;

import java.util.Date;

public class GerenciaPeriodo{
	private Gerencia gerencia;
	private Periodo geriodo;
	private Date fechaInicioPlan;
	private Date fechaFinPlan;
	private Date fechaInicioEval;
	private Date fechaFinEval;
	private Date fechaInicioPDI;
	private Date fechaFinPDI;
	private String diaNotifacion;

	public Gerencia getGerencia(){
		return this.gerencia;
	};

	public void setGerencia( Gerencia gerencia ){
		this.gerencia = gerencia;
	};

	public Periodo getGeriodo(){
		return this.geriodo;
	};

	public void setGeriodo( Periodo geriodo ){
		this.geriodo = geriodo;
	};

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

	public Date getFechaInicioPDI(){
		return this.fechaInicioPDI;
	};

	public void setFechaInicioPDI( Date fechaInicioPDI ){
		this.fechaInicioPDI = fechaInicioPDI;
	};

	public Date getFechaFinPDI(){
		return this.fechaFinPDI;
	};

	public void setFechaFinPDI( Date fechaFinPDI ){
		this.fechaFinPDI = fechaFinPDI;
	};

	public String getDiaNotifacion(){
		return this.diaNotifacion;
	};

	public void setDiaNotifacion( String diaNotifacion ){
		this.diaNotifacion = diaNotifacion;
	};

}

