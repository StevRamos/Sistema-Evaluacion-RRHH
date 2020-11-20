package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Gerencia{
    private int idGerencia;
    private String nombre;
    private String descripcion;
    private ArrayList<GerenciaPeriodo> configuracionFechas;
    private ArrayList<Colaborador> colaboradores;
    private Periodo periodo;

    public Gerencia() {
        this.configuracionFechas = new ArrayList<>();
        this.colaboradores = new ArrayList<>();
        this.periodo = new Periodo();
    }

    public int getIdGerencia() {
        return this.idGerencia;
    }

    public void setIdGerencia(int idGerencia) {
        this.idGerencia = idGerencia;
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

    public ArrayList<GerenciaPeriodo> getConfiguracionFechas() {
        return this.configuracionFechas;
    }

    public void setConfiguracionFechas(ArrayList<GerenciaPeriodo> configuracionFechas) {
        this.configuracionFechas = configuracionFechas;
    }

    public ArrayList<Colaborador> getColaboradores() {
        return colaboradores;
    }

    public void setColaboradores(ArrayList<Colaborador> colaboradores) {
        this.colaboradores = colaboradores;
    }

    public void agregarColaborador() {

    }

    public void agregarCupo() {

    }

    public Periodo getPeriodo() {
        return periodo;
    }

    public void setPeriodo(Periodo periodo) {
        this.periodo = periodo;
    }

}

