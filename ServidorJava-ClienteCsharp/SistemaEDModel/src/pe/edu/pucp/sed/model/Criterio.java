package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Criterio{
    private int idCriterio;
    private String nombre;
    private String descripcion;
    private int tipo;
    private Criterio criterioPadre;
    private ArrayList<Criterio> criterios;
    private ArrayList<PesoCriterio> pesoscriterios;

    public ArrayList<PesoCriterio> getPesoscriterios() {
        return pesoscriterios;
    }

    public void setPesoscriterios(ArrayList<PesoCriterio> pesoscriterios) {
        this.pesoscriterios = pesoscriterios;
    }
    
    public Criterio() {
        this.criterios = new ArrayList<>();
        this.pesoscriterios = new ArrayList<>();
        //this.criterioPadre = new Criterio();
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getIdCriterio() {
        return this.idCriterio;
    }

    public void setIdCriterio(int idCriterio) {
        this.idCriterio = idCriterio;
    }

    public String getNombre() {
        return this.nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getTipo() {
        return this.tipo;
    }

    public void setTipo(int tipo) {
        this.tipo = tipo;
    }

    public Criterio getCriterioPadre() {
        return this.criterioPadre;
    }

    public void setCriterioPadre(Criterio criterioPadre) {
        this.criterioPadre = criterioPadre;
    }

    public ArrayList<Criterio> getCriterios() {
        return this.criterios;
    }

    public void setCriterios(ArrayList<Criterio> criterios) {
        this.criterios = criterios;
    }

}

