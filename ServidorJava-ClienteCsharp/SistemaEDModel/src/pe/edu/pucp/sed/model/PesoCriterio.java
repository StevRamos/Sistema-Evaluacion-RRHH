package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class PesoCriterio{
	private int idPesoCriterio;
	private double peso;
	private Periodo periodo;
	private ArrayList<LineaEvaluacion> lineasEvaluacion;
	private PuestoTrabajo puestoTrabajo;
	private Criterio criterio;

	public PesoCriterio(){
		this.lineasEvaluacion = new ArrayList<>();
                this.periodo = new Periodo();
                this.puestoTrabajo = new PuestoTrabajo();
                this.criterio = new Criterio();
	};

        public String getDescripcion() {
            return this.criterio.getDescripcion();
        }
        
        public void setDescripcion(String descripcion) {
            this.criterio.setDescripcion(descripcion);
        }
        
        public int getIdCriterio() {
           return this.criterio.getIdCriterio();
       }

        public void setIdCriterio(int idCriterio) {
            this.criterio.setIdCriterio(idCriterio);
        }
        
        public String getNombreCriterio() {
            return this.criterio.getNombre();
        }

        public void setNombreCriterio(String nombre) {
            this.criterio.setNombre(nombre);
        }

        public Criterio getCriterioPadre() {
            return this.criterio.getCriterioPadre();
        }

        public void setCriterioPadre(Criterio criterioPadre) {
            this.criterio.setCriterioPadre(criterioPadre);
        }

        public int getIdPuestoTrabajo() {
            return this.puestoTrabajo.getIdPuestoTrabajo();
        }

        public void setIdPuestoTrabajo(int idPuestoTrabajo) {
            this.puestoTrabajo.setIdPuestoTrabajo(idPuestoTrabajo);
        }

        public String getNombrePuestoTrabajo() {
            return this.puestoTrabajo.getNombre();
        }

        public void setNombrePuestoTrabajo(String nombre) {
            this.puestoTrabajo.setNombre(nombre);
        }
        
	public int getIdPesoCriterio(){
		return this.idPesoCriterio;
	};

	public void setIdPesoCriterio( int idPesoCriterio ){
		this.idPesoCriterio = idPesoCriterio;
	};

	public double getPeso(){
		return this.peso;
	};

	public void setPeso( double peso ){
		this.peso = peso;
	};

	public Periodo getPeriodo(){
		return this.periodo;
	};

	public void setPeriodo( Periodo periodo ){
		this.periodo = periodo;
	};
        
        public int getIdPeriodo() {
            return this.periodo.getIdPeriodo();
        }

        public void setIdPeriodo(int idPeriodo) {
            this.periodo.setIdPeriodo(idPeriodo);
        }

        public String getNombrePeriodo() {
            return periodo.getNombre();
        }

        public void setNombrePeriodo(String nombre) {
            this.periodo.setNombre(nombre);
        }

	public ArrayList<LineaEvaluacion> getLineasEvaluacion(){
		return this.lineasEvaluacion;
	};

	public void setLineasEvaluacion( ArrayList<LineaEvaluacion> lineasEvaluacion ){
		this.lineasEvaluacion = lineasEvaluacion;
	};

	public PuestoTrabajo getPuestoTrabajo(){
		return this.puestoTrabajo;
	};

	public void setPuestoTrabajo( PuestoTrabajo puestoTrabajo ){
		this.puestoTrabajo = puestoTrabajo;
	};

	public Criterio getCriterio(){
		return this.criterio;
	};

	public void setCriterio( Criterio criterio ){
		this.criterio = criterio;
	};

}

