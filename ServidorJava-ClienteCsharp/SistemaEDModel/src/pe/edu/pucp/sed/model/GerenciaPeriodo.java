package pe.edu.pucp.sed.model;

import java.util.Date;

public class GerenciaPeriodo {

    private Gerencia gerencia;
    private Periodo periodo;
    private Date fechaInicioPlan;
    private Date fechaFinPlan;
    private Date fechaInicioPDI;
    private Date fechaFinPDI;
    private Date fechaInicioEvalPrevD;
    private Date fechaFinEvalPrevD;
    private Date fechaInicioEvalFinD;
    private Date fechaFinEvalFinD;
    private Date fechaInicioCal;
    private Date fechaFinCal;

    public GerenciaPeriodo() {
        this.gerencia = new Gerencia();
        this.periodo = new Periodo();
    }

    public Gerencia getGerencia() {
        return gerencia;
    }

    public Periodo getPeriodo() {
        return periodo;
    }

    public Date getFechaInicioPlan() {
        return fechaInicioPlan;
    }

    public Date getFechaFinPlan() {
        return fechaFinPlan;
    }

    public Date getFechaInicioPDI() {
        return fechaInicioPDI;
    }

    public Date getFechaFinPDI() {
        return fechaFinPDI;
    }

    public Date getFechaInicioEvalPrevD() {
        return fechaInicioEvalPrevD;
    }

    public Date getFechaFinEvalPrevD() {
        return fechaFinEvalPrevD;
    }

    public Date getFechaInicioEvalFinD() {
        return fechaInicioEvalFinD;
    }

    public Date getFechaFinEvalFinD() {
        return fechaFinEvalFinD;
    }

    public Date getFechaInicioCal() {
        return fechaInicioCal;
    }

    public Date getFechaFinCal() {
        return fechaFinCal;
    }

    public void setGerencia(Gerencia gerencia) {
        this.gerencia = gerencia;
    }

    public void setPeriodo(Periodo periodo) {
        this.periodo = periodo;
    }

    public void setFechaInicioPlan(Date fechaInicioPlan) {
        this.fechaInicioPlan = fechaInicioPlan;
    }

    public void setFechaFinPlan(Date fechaFinPlan) {
        this.fechaFinPlan = fechaFinPlan;
    }

    public void setFechaInicioPDI(Date fechaInicioPDI) {
        this.fechaInicioPDI = fechaInicioPDI;
    }

    public void setFechaFinPDI(Date fechaFinPDI) {
        this.fechaFinPDI = fechaFinPDI;
    }

    public void setFechaInicioEvalPrevD(Date fechaInicioEvalPrevD) {
        this.fechaInicioEvalPrevD = fechaInicioEvalPrevD;
    }

    public void setFechaFinEvalPrevD(Date fechaFinEvalPrevD) {
        this.fechaFinEvalPrevD = fechaFinEvalPrevD;
    }

    public void setFechaInicioEvalFinD(Date fechaInicioEvalFinD) {
        this.fechaInicioEvalFinD = fechaInicioEvalFinD;
    }

    public void setFechaFinEvalFinD(Date fechaFinEvalFinD) {
        this.fechaFinEvalFinD = fechaFinEvalFinD;
    }

    public void setFechaInicioCal(Date fechaInicioCal) {
        this.fechaInicioCal = fechaInicioCal;
    }

    public void setFechaFinCal(Date fechaFinCal) {
        this.fechaFinCal = fechaFinCal;
    }

    
}

