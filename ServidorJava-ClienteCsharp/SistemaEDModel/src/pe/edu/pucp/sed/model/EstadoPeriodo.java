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

public enum EstadoPeriodo{
  ELIMINADO(0), CREADO(1), ENPROGRESO(2), FINALIZADO(3);

  private int value;
  private static HashMap map = new HashMap<>();

  private EstadoPeriodo(int value) {
      this.value = value;
  }

  static {
      for (EstadoPeriodo Type : EstadoPeriodo.values()) {
          map.put(Type.value, Type);
      }
  }

  public static EstadoPeriodo valueOf(int Type) {
      return (EstadoPeriodo) map.get(Type);
  }

  public int getValue() {
      return value;
  }

}


