package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class PuestoTrabajo{
	private int idPuestoTrabajo;
	private String nombre;
	private String descripcion;
        private boolean activo;
	private ArrayList<PesoSubcriterio> pesosSubcriterio;
	private ArrayList<PesoCriterio> pesosCriterio;
	private ArrayList<Area> areas;
	private ArrayList<Colaborador> colaboradores;

	public PuestoTrabajo(){
		this.pesosSubcriterio = new ArrayList<PesoSubcriterio>();
		this.pesosCriterio = new ArrayList<PesoCriterio>();
		this.areas = new ArrayList<Area>();
		this.colaboradores = new ArrayList<Colaborador>();
	};

        public void setActivo(boolean activo) {
            this.activo = activo;
        }

        public boolean getActivo(){
            return this.activo;
        }
        
        
	public int getIdPuestoTrabajo(){
		return this.idPuestoTrabajo;
	};

	public void setIdPuestoTrabajo( int idPuestoTrabajo ){
		this.idPuestoTrabajo = idPuestoTrabajo;
	};

	public String getNombre(){
		return this.nombre;
	};

	public void setNombre( String nombre ){
		this.nombre = nombre;
	};

	public String getDescripcion(){
		return this.descripcion;
	};

	public void setDescripcion( String descripcion ){
		this.descripcion = descripcion;
	};

	public ArrayList<PesoSubcriterio> getPesosSubcriterio(){
		return this.pesosSubcriterio;
	};

	public void setPesosSubcriterio( PesoSubcriterio pesosSubcriterio ){
		this.pesosSubcriterio.add(pesosSubcriterio);
	};

	public ArrayList<PesoCriterio> getPesosCriterio(){
		return this.pesosCriterio;
	};

	public void setPesosCriterio( PesoCriterio pesosCriterio ){
		this.pesosCriterio.add(pesosCriterio);
	};

	public ArrayList<Area> getAreas(){
		return this.areas;
	};

	public void setAreas( Area areas ){
		this.areas.add(areas);
	};

	public ArrayList<Colaborador> getColaboradores(){
		return this.colaboradores;
	};

	public void setColaboradores( Colaborador colaboradores ){
		this.colaboradores.add(colaboradores);
	};

}

