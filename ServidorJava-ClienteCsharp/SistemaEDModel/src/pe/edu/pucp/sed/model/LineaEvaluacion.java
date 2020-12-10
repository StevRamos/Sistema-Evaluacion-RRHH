package pe.edu.pucp.sed.model;

import java.util.ArrayList;
import java.util.Date;

public class LineaEvaluacion {

    private int idLineaEvaluacion;
    private double notaFinal;
    private double notaAutoEval;
    private double notaPrevia;
    private String accionesAtomar;
    private ArrayList<LineaEvaluacion> sublineasEvaluacion;
    private Evaluacion evaluacion;
    private ItemPDI itemPDI;
    private PesoCriterio pesoCriterio;
    private Date fechaCumplimiento;

    public LineaEvaluacion() {
        this.sublineasEvaluacion = new ArrayList<>();
        this.evaluacion = new Evaluacion();
        this.itemPDI = new ItemPDI();
        this.pesoCriterio = new PesoCriterio();
    }

    public Date getFechaCumplimiento() {
        return fechaCumplimiento;
    }

    public void setFechaCumplimiento(Date fechaCumplimiento) {
        this.fechaCumplimiento = fechaCumplimiento;
    }

    
    
    public int getIdLineaEvaluacion() {
        return this.idLineaEvaluacion;
    }

    public void setIdLineaEvaluacion(int idLineaEvaluacion) {
        this.idLineaEvaluacion = idLineaEvaluacion;
    }

    public double getNotaFinal() {
        return this.notaFinal;
    }

    public void setNotaFinal(double notaFinal) {
        this.notaFinal = notaFinal;
    }

    public double getNotaAutoEval() {
        return this.notaAutoEval;
    }

    public void setNotaAutoEval(double notaAutoEval) {
        this.notaAutoEval = notaAutoEval;
    }

    public double getNotaPrevia() {
        return this.notaPrevia;
    }

    public void setNotaPrevia(double notaPrevia) {
        this.notaPrevia = notaPrevia;
    }

    public String getAccionesAtomar() {
        return this.accionesAtomar;
    }

    public void setAccionesAtomar(String accionesAtomar) {
        this.accionesAtomar = accionesAtomar;
    }

    public ArrayList<LineaEvaluacion> getSublineasEvaluacion() {
        return this.sublineasEvaluacion;
    }

    public void setSublineasEvaluacion(ArrayList<LineaEvaluacion> sublineasEvaluacion) {
        this.sublineasEvaluacion = sublineasEvaluacion;
    }

    public Evaluacion getEvaluacion() {
        return this.evaluacion;
    }

    ;

	public void setEvaluacion(Evaluacion evaluacion) {
        this.evaluacion = evaluacion;
    }

    public ItemPDI getItemPDI() {
        return this.itemPDI;
    }

    public void setItemPDI(ItemPDI itemPDI) {
        this.itemPDI = itemPDI;
    }

    public PesoCriterio getPesoCriterio() {
        return this.pesoCriterio;
    }

    public void setPesoCriterio(PesoCriterio pesoCriterio) {
        this.pesoCriterio = pesoCriterio;
    }

    public void calcularNotaAutoEval() {

    }

    public void calcularNotaPrevia() {

    }

    public void calcularNotaFinal() {

    }

    public void mostrarDatos() {

    }

}

