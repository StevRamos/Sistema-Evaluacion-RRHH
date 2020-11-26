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

    public void setGerencia(Gerencia gerencia) {
        this.gerencia = gerencia;
    }

    public Periodo getPeriodo() {
        return periodo;
    }

    public void setPeriodo(Periodo periodo) {
        this.periodo = periodo;
    }

    public Date getFechaInicioPlan() {
        return fechaInicioPlan;
    }

    public void setFechaInicioPlan(Date fechaInicioPlan) {
        this.fechaInicioPlan = fechaInicioPlan;
    }

    public Date getFechaFinPlan() {
        return fechaFinPlan;
    }

    public void setFechaFinPlan(Date fechaFinPlan) {
        this.fechaFinPlan = fechaFinPlan;
    }

    public Date getFechaInicioPDI() {
        return fechaInicioPDI;
    }

    public void setFechaInicioPDI(Date fechaInicioPDI) {
        this.fechaInicioPDI = fechaInicioPDI;
    }

    public Date getFechaFinPDI() {
        return fechaFinPDI;
    }

    public void setFechaFinPDI(Date fechaFinPDI) {
        this.fechaFinPDI = fechaFinPDI;
    }

    public Date getFechaInicioEvalPrevD() {
        return fechaInicioEvalPrevD;
    }

    public void setFechaInicioEvalPrevD(Date fechaInicioEvalPrevD) {
        this.fechaInicioEvalPrevD = fechaInicioEvalPrevD;
    }

    public Date getFechaFinEvalPrevD() {
        return fechaFinEvalPrevD;
    }

    public void setFechaFinEvalPrevD(Date fechaFinEvalPrevD) {
        this.fechaFinEvalPrevD = fechaFinEvalPrevD;
    }

    public Date getFechaInicioEvalFinD() {
        return fechaInicioEvalFinD;
    }

    public void setFechaInicioEvalFinD(Date fechaInicioEvalFinD) {
        this.fechaInicioEvalFinD = fechaInicioEvalFinD;
    }

    public Date getFechaFinEvalFinD() {
        return fechaFinEvalFinD;
    }

    public void setFechaFinEvalFinD(Date fechaFinEvalFinD) {
        this.fechaFinEvalFinD = fechaFinEvalFinD;
    }

    public Date getFechaInicioCal() {
        return fechaInicioCal;
    }

    public void setFechaInicioCal(Date fechaInicioCal) {
        this.fechaInicioCal = fechaInicioCal;
    }

    public Date getFechaFinCal() {
        return fechaFinCal;
    }

    public void setFechaFinCal(Date fechaFinCal) {
        this.fechaFinCal = fechaFinCal;
    }

    
    
}

