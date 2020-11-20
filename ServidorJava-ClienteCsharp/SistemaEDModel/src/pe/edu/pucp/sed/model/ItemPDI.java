package pe.edu.pucp.sed.model;

import java.util.ArrayList;

public class ItemPDI {

    private int idItemPDI;
    private String nombre;
    private ArrayList<LineaEvaluacion> lineasEvaluacion;
    private ArrayList<ItemPDIPeriodo> rangos;

    public ItemPDI() {
        this.lineasEvaluacion = new ArrayList<>();
        this.rangos = new ArrayList<>();
    }

    public int getIdItemPDI() {
        return this.idItemPDI;
    }

    public void setIdItemPDI(int idItemPDI) {
        this.idItemPDI = idItemPDI;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public ArrayList<LineaEvaluacion> getLineasEvaluacion() {
        return this.lineasEvaluacion;
    }

    public void setLineasEvaluacion(ArrayList<LineaEvaluacion> lineasEvaluacion) {
        this.lineasEvaluacion = lineasEvaluacion;
    }

    public ArrayList<ItemPDIPeriodo> getRangos() {
        return this.rangos;
    }

    public void setRangos(ArrayList<ItemPDIPeriodo>  rangos) {
        this.rangos = rangos;
    }

}

