package pe.edu.pucp.sed.model;

import java.util.ArrayList;

public class PuestoTrabajo {

    private int idPuestoTrabajo;
    private String nombre;
    private String descripcion;
    private ArrayList<PesoCriterio> pesosCriterio;
    private Gerencia gerencia;

    public void setGerencia(Gerencia gerencia) {
        this.gerencia = gerencia;
    }

    public Gerencia getGerencia() {
        return gerencia;
    }

    public PuestoTrabajo() {
        this.pesosCriterio = new ArrayList<>();
    }

    public int getIdPuestoTrabajo() {
        return this.idPuestoTrabajo;
    }

    public void setIdPuestoTrabajo(int idPuestoTrabajo) {
        this.idPuestoTrabajo = idPuestoTrabajo;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return this.descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public ArrayList<PesoCriterio> getPesosCriterio() {
        return this.pesosCriterio;
    }

    public void setPesosCriterio(ArrayList<PesoCriterio> pesosCriterio) {
        this.pesosCriterio = pesosCriterio;
    }
            
}

