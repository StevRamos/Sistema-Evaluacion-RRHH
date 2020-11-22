package pe.edu.pucp.sed.model;

import java.sql.Time;
import java.util.ArrayList;
import java.util.Date;
import java.util.logging.Logger;

public class Periodo{
    private int idPeriodo;
    private Date fechaInicio;
    private Date fechaFin;
    private Date diaNotificacion;
    private double pesoEvalObj;
    private double pesoEvalComp;
    private EstadoPeriodo estado;
    private Time horaNotificacion;
    private String nombre;
    private ArrayList<Evaluacion> evaluaciones;
    private ArrayList<PesoCriterio> pesosCriterio;
    private ArrayList<ItemPDIPeriodo> rangosPDI;
    private ArrayList<GerenciaPeriodo> configuracionFechas;
    private ArrayList<EscalaPeriodo> escalas;
    private ArrayList<Objetivo> objetivos;

    public Periodo() {
        this.evaluaciones = new ArrayList<>();
        this.pesosCriterio = new ArrayList<>();
        this.rangosPDI = new ArrayList<>();
        this.configuracionFechas = new ArrayList<>();
        this.escalas = new ArrayList<>();
        this.objetivos = new ArrayList<>();
    }

    public Periodo(Periodo per){
        idPeriodo = per.getIdPeriodo();
        fechaInicio = per.getFechaInicio();
        fechaFin = per.getFechaFin();
        diaNotificacion = per.getDiaNotificacion();
        pesoEvalObj = per.getPesoEvalObj();
        pesoEvalComp = per.getPesoEvalComp();
        estado = per.getEstado();
        horaNotificacion = per.getHoraNotificacion();
        nombre = per.getNombre();
    }

    public void setDiaNotificacion(Date diaNotificacion) {
        this.diaNotificacion = diaNotificacion;
    }

    public Date getDiaNotificacion() {
        return diaNotificacion;
    }

    public int getIdPeriodo() {
        return this.idPeriodo;
    }

    public void setIdPeriodo(int idPeriodo) {
        this.idPeriodo = idPeriodo;
    }

    public Date getFechaInicio() {
        return this.fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return this.fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }

    public double getPesoEvalObj() {
        return this.pesoEvalObj;
    }

    public void setPesoEvalObj(double pesoEvalObj) {
        this.pesoEvalObj = pesoEvalObj;
    }

    public double getPesoEvalComp() {
        return this.pesoEvalComp;
    }

    public void setPesoEvalComp(double pesoEvalComp) {
        this.pesoEvalComp = pesoEvalComp;
    }

    public EstadoPeriodo getEstado() {
        return this.estado;
    }

    public void setEstado(EstadoPeriodo estado) {
        this.estado = estado;
    }

    public Time getHoraNotificacion() {
        return this.horaNotificacion;
    }

    public void setHoraNotificacion(Time horaNotificacion) {
        this.horaNotificacion = horaNotificacion;
    }

    public ArrayList<Evaluacion> getEvaluaciones() {
        return this.evaluaciones;
    }

    public void setEvaluaciones(ArrayList<Evaluacion> evaluaciones) {
        this.evaluaciones = evaluaciones;
    }

    public ArrayList<PesoCriterio> getPesosCriterio() {
        return this.pesosCriterio;
    }

    public void setPesosCriterio(ArrayList<PesoCriterio> pesosCriterio) {
        this.pesosCriterio = pesosCriterio;
    }

    public ArrayList<ItemPDIPeriodo> getRangosPDI() {
        return this.rangosPDI;
    }

    public void setRangosPDI(ArrayList<ItemPDIPeriodo> rangosPDI) {
        this.rangosPDI = rangosPDI;
    }

    public ArrayList<GerenciaPeriodo> getConfiguracionFechas() {
        return this.configuracionFechas;
    }

    public void setConfiguracionFechas(ArrayList<GerenciaPeriodo> configuracionFechas) {
        this.configuracionFechas = configuracionFechas;
    }

    public ArrayList<EscalaPeriodo> getEscalas() {
        return this.escalas;
    }


    public void setEscalas(ArrayList<EscalaPeriodo> escalas) {
        this.escalas = escalas;
    }

    public ArrayList<Objetivo> getObjetivos() {
        return this.objetivos;
    }



    public void setObjetivos(ArrayList<Objetivo> objetivos) {
        this.objetivos = objetivos;
    }

    public void finalizar() {

    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

}

