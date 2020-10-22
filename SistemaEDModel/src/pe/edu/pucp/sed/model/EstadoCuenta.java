/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.sed.model;

/**
 *
 * @author stevramos
 */
import java.util.HashMap;

public enum EstadoCuenta{
  ACTIVO(1), INACTIVO(2), ELIMINADA(3);

  private int value;
  private static HashMap map = new HashMap<>();

  private EstadoCuenta(int value) {
      this.value = value;
  }

  static {
      for (EstadoCuenta Type : EstadoCuenta.values()) {
          map.put(Type.value, Type);
      }
  }

  public static EstadoCuenta valueOf(int Type) {
      return (EstadoCuenta) map.get(Type);
  }

  public int getValue() {
      return value;
  }

}


