/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.model;

/**
 *
 * @author Jorge Miguel Baca
 */
public class Usuario {
    
    private int idUsuario;
    private String contrasenha;
    private String contrasenhaAnterior;
    private int estadoCuenta;
    private int nivelAcceso;

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public void setContrasenha(String contrasenha) {
        this.contrasenha = contrasenha;
    }

    public void setContrasenhaAnterior(String contrasenhaAnterior) {
        this.contrasenhaAnterior = contrasenhaAnterior;
    }

    public void setEstadoCuenta(int estadoCuenta) {
        this.estadoCuenta = estadoCuenta;
    }

    public void setNivelAcceso(int nivelAcceso) {
        this.nivelAcceso = nivelAcceso;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public String getContrasenha() {
        return contrasenha;
    }

    public String getContrasenhaAnterior() {
        return contrasenhaAnterior;
    }

    public int getEstadoCuenta() {
        return estadoCuenta;
    }

    public int getNivelAcceso() {
        return nivelAcceso;
    }
    
    
    
}
