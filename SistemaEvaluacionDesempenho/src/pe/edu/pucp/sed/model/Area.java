package pe.edu.pucp.sed.model;

import java.util.ArrayList;
public class Area{
	private int idArea;
	private String nombre;
	private String descripcion;
        private boolean activo;
	private ArrayList<PesoSubcriterio> pesosSubcriterio;
	private ArrayList<PesoCriterio> pesosCriterio;
	private ArrayList<PuestoTrabajo> puestosTrabajo;
	private ArrayList<AreaPeriodo> configuracionFechas;
	private ArrayList<Cupos> cupos;
	private ArrayList<Colaborador> colaboradores;

	public Area(){
		this.pesosSubcriterio = new ArrayList<PesoSubcriterio>();
		this.pesosCriterio = new ArrayList<PesoCriterio>();
		this.puestosTrabajo = new ArrayList<PuestoTrabajo>();
		this.configuracionFechas = new ArrayList<AreaPeriodo>();
		this.cupos = new ArrayList<Cupos>();
		this.colaboradores = new ArrayList<Colaborador>();
	};

        public boolean getActivo(){
            return this.activo;
        }
        
        public void setActivo(boolean activo){
            this.activo = activo;
        }
        
	public int getIdArea(){
		return this.idArea;
	};

	public void setIdArea( int idArea ){
		this.idArea = idArea;
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

	public ArrayList<PuestoTrabajo> getPuestosTrabajo(){
		return this.puestosTrabajo;
	};

	public void setPuestosTrabajo( PuestoTrabajo puestosTrabajo ){
		this.puestosTrabajo.add(puestosTrabajo);
	};

	public ArrayList<AreaPeriodo> getConfiguracionFechas(){
		return this.configuracionFechas;
	};

	public void setConfiguracionFechas( AreaPeriodo configuracionFechas ){
		this.configuracionFechas.add(configuracionFechas);
	};

	public ArrayList<Cupos> getCupos(){
		return this.cupos;
	};

	public void setCupos( Cupos cupos ){
		this.cupos.add(cupos);
	};

	public ArrayList<Colaborador> getColaboradores(){
		return this.colaboradores;
	};

	public void setColaboradores( Colaborador colaboradores ){
		this.colaboradores.add(colaboradores);
	};

	public void agregarColaborador(){

	};

	public void agregarCupo(){

	};
        
        
        
        
}

