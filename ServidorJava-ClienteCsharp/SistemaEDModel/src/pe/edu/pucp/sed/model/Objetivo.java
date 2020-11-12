package pe.edu.pucp.sed.model;

import java.util.Date;

public class Objetivo {

    private int idObjetivo;
    private String descripcion;
    private boolean estado;
    private Date fechaFormulacion;
    private Date fechaAprobacion;
    private double meta;
    private String unidadMedida;
    private String observacion;
    private double peso;
    private double notaPrevia;
    private double notaAutoEval;
    private double notaFinal;
    private Colaborador colaborador;
    private EvaluacionDesempenho evaluacion;
    private Periodo periodo;

    public Objetivo() {
        this.colaborador = new Colaborador();
        this.evaluacion = new EvaluacionDesempenho();
        this.periodo = new Periodo();
    }

    public int getIdObjetivo() {
        return this.idObjetivo;
    }

    ;

	public void setIdObjetivo(int idObjetivo) {
        this.idObjetivo = idObjetivo;
    }

    ;

	public String getDescripcion() {
        return this.descripcion;
    }

    ;

	public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    ;

	public boolean getEstado() {
        return this.estado;
    }

    ;

	public void setEstado(boolean estado) {
        this.estado = estado;
    }

    ;

	public Date getFechaFormulacion() {
        return this.fechaFormulacion;
    }

    ;

	public void setFechaFormulacion(Date fechaFormulacion) {
        this.fechaFormulacion = fechaFormulacion;
    }

    ;

	public Date getFechaAprobacion() {
        return this.fechaAprobacion;
    }

    ;

	public void setFechaAprobacion(Date fechaAprobacion) {
        this.fechaAprobacion = fechaAprobacion;
    }

    ;

	public double getMeta() {
        return this.meta;
    }

    ;

	public void setMeta(double meta) {
        this.meta = meta;
    }

    ;

	public String getUnidadMedida() {
        return this.unidadMedida;
    }

    ;

	public void setUnidadMedida(String unidadMedida) {
        this.unidadMedida = unidadMedida;
    }

    ;

	public String getObservacion() {
        return this.observacion;
    }

    ;

	public void setObservacion(String observacion) {
        this.observacion = observacion;
    }

    ;

	public double getPeso() {
        return this.peso;
    }

    ;

	public void setPeso(double peso) {
        this.peso = peso;
    }

    ;

	public double getNotaPrevia() {
        return this.notaPrevia;
    }

    ;

	public void setNotaPrevia(double notaPrevia) {
        this.notaPrevia = notaPrevia;
    }

    ;

	public double getNotaAutoEval() {
        return this.notaAutoEval;
    }

    ;

	public void setNotaAutoEval(double notaAutoEval) {
        this.notaAutoEval = notaAutoEval;
    }

    ;

	public double getNotaFinal() {
        return this.notaFinal;
    }

    ;

	public void setNotaFinal(double notaFinal) {
        this.notaFinal = notaFinal;
    }

    ;

	public Colaborador getColaborador() {
        return this.colaborador;
    }

    ;

	public void setColaborador(Colaborador colaborador) {
        this.colaborador = colaborador;
    }

    ;

	public EvaluacionDesempenho getEvaluacion() {
        return this.evaluacion;
    }

    ;

	public void setEvaluacion(EvaluacionDesempenho evaluacion) {
        this.evaluacion = evaluacion;
    }

    ;

	public Periodo getPeriodo() {
        return this.periodo;
    }

    ;

	public void setPeriodo(Periodo periodo) {
        this.periodo = periodo;
    }

    ;

	public void mostrarDatos() {

    }

    ;

	public void denegar() {

    }

    ;

	public void aprobar() {

    }
;

}
