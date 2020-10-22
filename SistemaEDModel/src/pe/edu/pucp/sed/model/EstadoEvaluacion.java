/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.model;

import java.util.HashMap;

/**
 *
 * @author stevramos
 */

public enum EstadoEvaluacion{
  ACTIVO(1), INACTIVO(2), ELIMINADA(3);

  private int value;
  private static HashMap map = new HashMap<>();

  private EstadoEvaluacion(int value) {
      this.value = value;
  }

  static {
      for (EstadoEvaluacion Type : EstadoEvaluacion.values()) {
          map.put(Type.value, Type);
      }
  }

  public static EstadoEvaluacion valueOf(int Type) {
      return (EstadoEvaluacion) map.get(Type);
  }

  public int getValue() {
      return value;
  }

}



