using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEDInterfaces
{
    public static class Mensaje
    {

        public static string TituloRegistroObjetivos(String nombreColab)
        {
            String titulo;
            titulo = "Sistema de Evaluacion: El colaborador " + nombreColab + " ha registrado sus objetivos"; 
            return titulo; 
        }

        public static string TituloRevisionObjetivos()
        {
            String titulo;
            titulo = "Sistema de Evaluacion: Su jefe ha realizado la revisión de sus objetivos";
            return titulo; 
        }

        public static string CuerpoRegistroObjetivos(String nombreJefe,String nombreColab, int dni)
        {
            String mensaje;

            mensaje = "Estimado(a) " + nombreJefe + ":\n\n" +
                      "El proposito del presente correo es informarle que " +
                      "el colaborador "+ nombreColab + " con dni " + dni.ToString() +
                      " ha realizado el registro de sus objetivos en el sistema de evaluación " +
                      "y se encuentra esperando a que usted realice la revisión de los mismos."; 

            return mensaje; 
        }

        public static string CuerpoRevisionObjetivos(String nombreColab)
        {
            String mensaje;

            mensaje = "Estimado(a) " + nombreColab + ":\n\n" +
                      "El proposito del presente correo es informarle que " +
                      "su jefe ha realizado la revisión de sus objetivos, le pedimos encarecidamente ingrese " +
                      "al sistema para hacer la verificación y llevar a cabo las posibles correcciones.";

            return mensaje;
        }
    }
}
