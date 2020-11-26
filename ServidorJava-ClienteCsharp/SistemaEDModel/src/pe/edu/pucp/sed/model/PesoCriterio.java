package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class PesoCriterio{
	private int idPesoCriterio;
	private double peso;
	private Periodo periodo;
	private ArrayList<LineaEvaluacion> lineasEvaluacion;
	private PuestoTrabajo puestoTrabajo;
	private Criterio criterio;

	public PesoCriterio(){
		this.lineasEvaluacion = new ArrayList<>();
                this.periodo = new Periodo();
                this.puestoTrabajo = new PuestoTrabajo();
                this.criterio = new Criterio();
	};
        

    public int getIdPesoCriterio() {
        return idPesoCriterio;
    }

    public double getPeso() {
        return peso;
    }

    public Periodo getPeriodo() {
        return periodo;
    }

    public ArrayList<LineaEvaluacion> getLineasEvaluacion() {
        return lineasEvaluacion;
    }

    public PuestoTrabajo getPuestoTrabajo() {
        return puestoTrabajo;
    }

    public Criterio getCriterio() {
        return criterio;
    }

    public void setIdPesoCriterio(int idPesoCriterio) {
        this.idPesoCriterio = idPesoCriterio;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public void setPeriodo(Periodo periodo) {
        this.periodo = periodo;
    }

    public void setLineasEvaluacion(ArrayList<LineaEvaluacion> lineasEvaluacion) {
        this.lineasEvaluacion = lineasEvaluacion;
    }

    public void setPuestoTrabajo(PuestoTrabajo puestoTrabajo) {
        this.puestoTrabajo = puestoTrabajo;
    }

    public void setCriterio(Criterio criterio) {
        this.criterio = criterio;
    }

}

