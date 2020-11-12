-- Para insertar un área
DELIMITER $
CREATE PROCEDURE INSERTAR_GERENCIA(
	OUT _ID_GERENCIA INT,
    IN _NOMBRE VARCHAR(100),
    IN _DESCRIPCION VARCHAR(150)
)
BEGIN
	INSERT INTO Gerencias(nombre,descripcion,activo)
    VALUES (_NOMBRE,_DESCRIPCION,1);
    SET _ID_GERENCIA = @@last_insert_id;
END $

-- Para probar insertar área
CALL INSERTAR_GERENCIA(@id_Gerencias,'RECURSOS HUMANOS','ES UNA AREA QUE SE ENCARGA DE LOS EMPLEADOS');
select * from Gerencias;

-- Para actulizar una gerencia
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_GERENCIA(
	IN _ID_GERENCIA INT,
    IN _DESCRIPCION VARCHAR(100)
)
BEGIN
	UPDATE Gerencias
    SET descripcion = _DESCRIPCION
    WHERE id_Gerencias = _ID_GERENCIA;
END$

-- Para probar actualizar  gerencia
call ACTUALIZAR_GERENCIA(1,'ES UN LUGAR DONDE SE REALIZA ACTIVIDADES PARA LOS EMPLEADOS');
select * from Gerencias;

-- Para eliminar una gerencia
DELIMITER $
CREATE PROCEDURE ELIMINAR_GERENCIA(
	IN _ID_GERENCIA INT
)
BEGIN
	UPDATE Gerencias
    SET activo = 0
    WHERE id_Gerencias = _ID_GERENCIA;
END$

-- Para probar eliminar area
call ELIMINAR_GERENCIA(2);
select * from Gerencias;

-- LISTAR Gerencias
DELIMITER $
CREATE PROCEDURE LISTAR_GERENCIAS()
BEGIN
	SELECT *
    FROM Gerencias
    WHERE activo = 1;
END $

-- Para probar listar Gerencias
call LISTAR_GERENCIAS();


-- Para insertar un PuestosTrabajo
DELIMITER $
CREATE PROCEDURE INSERTAR_PUESTO_TRABAJO(
	OUT _ID_PUESTO_TRABAJO INT,
    IN _NOMBRE VARCHAR(100),
    IN _DESCRIPCION VARCHAR(150)
)
BEGIN
	INSERT INTO PuestosTrabajo(nombre,descripcion,activo)
    VALUES (_NOMBRE,_DESCRIPCION,1);
    SET _ID_PUESTO_TRABAJO = @@last_insert_id;
END$

-- PRUEBA PARA INSERTAR PUESTO DE TRABAJOS
call INSERTAR_PUESTO_TRABAJO(@ID_PUESTO,"SUPERVISOR DE OBRAS","VERIFICA OBRAS EN CONSTRUCCION");
select * from PuestosTrabajo;

-- PARA ACTUALIZAR UN PUESTO DE TRABAJO
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_PUESTO_TRABAJO(
	IN _ID_PUESTO_TRABAJO INT,
    IN _DESCRIPCION VARCHAR(150)
)
BEGIN
	UPDATE PuestosTrabajo
    SET descripcion=_DESCRIPCION
    WHERE id_PuestosTrabajo = _ID_PUESTO_TRABAJO;
END$
-- PARA PROBAR ACTUALIZAR PUESTO DE TRABAJO
CALL ACTUALIZAR_PUESTO_TRABAJO(1,"SUPERVISA OBRAS EN CONSTRUCCIÓN");
select * from PuestosTrabajo;


-- PARA ELIMINAR UN PUESTO DE TRABAJO
DELIMITER $
CREATE PROCEDURE ELIMINAR_PUESTO_TRABAJO(
	IN _ID_PUESTO_TRABAJO INT
)
BEGIN
	UPDATE PuestosTrabajo
	SET	activo = 0
    WHERE id_PuestosTrabajo = _ID_PUESTO_TRABAJO;
END$

-- PARA POBRAR ELIMINAR PUESTOS DE TRABAJO
CALL ELIMINAR_PUESTO_TRABAJO(1);
select * from PuestosTrabajo;

-- LISTAR PUESTOS DE TRABAJO
DELIMITER $
CREATE PROCEDURE LISTAR_PUESTOS_TRABAJO()
BEGIN
	SELECT *
    FROM PuestosTrabajo
    WHERE estado = 1;
END $

-- PARA PROBAR LISTAR PUESTOS DE TRABAJO
CALL LISTAR_PUESTOS_TRABAJO();

-- PARA INSERTAR UN NUEVO PERIODO
DELIMITER $
CREATE PROCEDURE INSERTAR_PERIODO(
	OUT _ID_PERIODO INT,
    IN _FECHA_INICIO DATE,
    IN _FECHA_FIN DATE,
    IN _PESO_EVAL_OBJ DOUBLE,
    IN _PESO_EVAL_COMP DOUBLE,
	IN _DIA_NOTIFICACION DATE,
	IN _HORA_NOTIFICACION TIME,
    IN _NOMBRE VARCHAR(100)
)
BEGIN
	IF _FECHA_INICIO < _FECHA_FIN THEN
		INSERT INTO Periodos(fechaInicio,fechaFin,pesoEvalObj,pesoEvalComp,
		activo,diaNotificacion,horaNotificacion,nombre)
		VALUES(_FECHA_INICIO,_FECHA_FIN,_PESO_EVAL_OBJ,_PESO_EVAL_COMP,1,
		_DIA_NOTIFICACION,_HORA_NOTIFICACION,_NOMBRE);
		SET _ID_PERIODO =  @@last_insert_id;
	ELSE
		SET _ID_PERIODO =  0;
	END IF;
END$

-- PARA PROBAR INSERTAR PERIDO
CALL INSERTAR_PERIODO(@ID_PERIODO,'2000-10-03','2004-04-03',0.5,0.5,
		'2003-10-04','00:00:00','xdd xddd2');
SELECT * FROM Periodos;

-- PARA ACTULIZAR UN PERIODO
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_PERIODO(
	IN _ID_PERIODO INT,
    IN _NEW_INI DATE,
    IN _NEW_FIN DATE
)
BEGIN
	IF _NEW_INI < _NEW_FIN THEN
		UPDATE Periodos
		SET	fechaInicio = _NEW_INI, fechaFin = _NEW_FIN 
		WHERE id_Periodo= _ID_PERIODO;
	END IF;
END$

-- PARA PROBAR ACTUALIZAR PERIODO
CALL ACTUALIZAR_PERIODO(1,'2020-09-11','2021-05-12');
SELECT * FROM Periodos;

-- ELIMINAR PERIDO
DELIMITER $
CREATE PROCEDURE ELIMINAR_PERIODO(
	IN _ID_PERIODO INT
)
BEGIN
	UPDATE Periodos 
    SET activo = 0
    WHERE id_Periodo = _ID_PERIODO;
END $

-- Para probar eliminar periodo
call ELIMINAR_PERIODO(1);
select * from Periodos;

-- PARA LISTAR PERIODOS
DELIMITER $
CREATE PROCEDURE LISTAR_PERIODO()
BEGIN
	SELECT *
    FROM Periodos
    WHERE activo = 1;
END $

-- Para probar listar periodo
CALL LISTAR_PERIODO();

-- PARA INGRESAR UN NUEVO CRITERIO
-- TIPO :0 (Competencias) y TIPO: 1(Potenciales)
DELIMITER $
CREATE PROCEDURE INSERTAR_CRITERIO(
	OUT _ID_CRITERIO INT,
	IN _ID_CRITERIOPADRE INT,
    IN _NOMBRE VARCHAR(100),
    IN _DESCRIPCION VARCHAR(150),
    IN _TIPO TINYINT
)
BEGIN
	INSERT INTO Criterios(id_CriterioPadre,nombre,descripcion,esVigente,tipo)
	VALUES(_ID_CRITERIOPADRE,_NOMBRE,_DESCRIPCION,1,_TIPO);
    SET _ID_CRITERIO = @@last_insert_id;
END $

-- Para probar insertar criterio
call INSERTAR_CRITERIO(@ID_CRITERIO,null,"LIDERAZGO","LIDERAZGO",0);
call INSERTAR_CRITERIO(@ID_CRITERIO,null,"PUNTUALIDAD","PUNTUALIDAD",1);
select * from Criterios;

-- ACTUALIZAR CRITERIOS
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_CRITERIO(
	IN _ID_CRITERIO INT,
    IN _DESCRIPCION VARCHAR(150)
)
BEGIN
	UPDATE Criterios
    SET	descripcion = _DESCRIPCION
    WHERE id_Criterio= _ID_CRITERIO;
END $

-- Para probar actualizar criterio
call ACTUALIZAR_CRITERIO(1,"EVALUACION DE LIDERAZGO");
select * from Criterios;

-- ELIMINAR CRITERIO
DELIMITER $
CREATE PROCEDURE ELIMINAR_CRITERIO(
	IN _ID_CRITERIO INT
)
BEGIN
	UPDATE Criterios
    SET esVigente = 0
    WHERE id_Criterio = _ID_CRITERIO;
END $

-- PARA PROBAR ELIMINAR CRITERIOS
CALL ELIMINAR_CRITERIO(1);
SELECT * FROM Criterios

-- PARA LISTAR CRITERIOS

DELIMITER $
CREATE PROCEDURE LISTAR_CRITERIOS()
BEGIN
    SELECT a.id_Criterio, a.nombre, a.descripcion, a.tipo , b.id_Criterio id_CriterioPadre,
            b.nombre nombrePadre,b.descripcion descripcionPadre ,b.tipo tipoPadre
    FROM Criterios a inner join Criterios b on a.id_CriterioPadre = b.id_Criterio
    WHERE a.esVigente = 1;
END $

-- PARA PROBAR LISTAR CRITERIOS
CALL LISTAR_CRITERIOS();

-- PARA INSERTAR ITEMS PDI
DELIMITER $
CREATE PROCEDURE INSERTAR_ITEM_PDI(
	OUT _ID_ITEM INT,
    IN _NOMBRE VARCHAR(50)
)
BEGIN
	INSERT INTO ItemsPDI(nombre,activo)
    VALUES(_NOMBRE,1);
    SET _ID_ITEM = @@last_insert_id;
END $

-- PARA PROBAR INSERTAR ITEMS PDI
CALL INSERTAR_ITEM_PDI(@ID_ITEM,"FORTALEZA");
CALL INSERTAR_ITEM_PDI(@ID_ITEM,"DEBILIDAD");
select * from ItemsPDI;

-- PARA ACTUALIZAR ITEM PDI
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_ITEM_PDI(
	IN _ID_ITEM INT,
    IN _NOMBRE VARCHAR(100)
)
BEGIN
	UPDATE ItemsPDI
	SET nombre = _NOMBRE
    WHERE id_ItemPDI= _ID_ITEM;
END$

-- PARA PROBAR ACTUALIZAR ITEM PDI
CALL ACTUALIZAR_ITEM_PDI(1,"DEBILIDAD");
select * FROM ItemsPDI

-- ELIMINAR ITEM PDI
DELIMITER $
CREATE PROCEDURE ELIMINAR_ITEM_PDI(
	IN _ID_ITEM_PDI INT
)
BEGIN
	UPDATE ItemsPDI
    SET activo=0
    WHERE id_ItemPDI=_ID_ITEM_PDI;
END $

-- PARA PROBAR ELIMINAR ITEM PDI
CALL ELIMINAR_ITEM_PDI(1);
select * from ItemsPDI;

-- PARA INSERTAR UNA NUEVA ESCALA 
DELIMITER $
CREATE PROCEDURE INSERTAR_ESCALA(
	OUT _ID_ESCALA INT,
    IN _NOMBRE VARCHAR(100),
    IN _TIPO TINYINT
)
BEGIN
	INSERT INTO Escalas(nombre,tipo,activo)
    VALUES(_NOMBRE,_TIPO,1);
    SET _ID_ESCALA =  @@last_insert_id;
END $

-- PARA PROBAR ESCALA
CALL INSERTAR_ESCALA(@ID_ESCALA,"A",0);
CALL INSERTAR_ESCALA(@ID_ESCALA,"B",0);
CALL INSERTAR_ESCALA(@ID_ESCALA,"C",0); 
CALL INSERTAR_ESCALA(@ID_ESCALA,"D",0);
CALL INSERTAR_ESCALA(@ID_ESCALA,"E",0);
CALL INSERTAR_ESCALA(@ID_ESCALA,"MEDIO",1);
CALL INSERTAR_ESCALA(@ID_ESCALA,"BAJO",1);
CALL INSERTAR_ESCALA(@ID_ESCALA,"ATO",1);
SELECT * FROM Escalas;


-- ACTUALIZAR ESCALAS
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_ESCALA(
	IN _ID_ESCALA INT,
    IN _NOMBRE VARCHAR(100)
)
BEGIN
	UPDATE Escalas
    SET	nombre = _NOMBRE
    WHERE id_Escala=_ID_ESCALA;
END$

-- PARA PROBAR ACTUALIZAR ESCALA
CALL ACTUALIZAR_ESCALA(20,"MUY ALTO");
select * from Escalas;

-- ELIMINAR ESCALA
DELIMITER $
CREATE PROCEDURE ELIMINAR_ESCALA(
	IN _ID_ESCALA INT
)
BEGIN
	UPDATE Escalas
    SET activo = 0
    WHERE id_Escala= _ID_ESCALA;
END $

-- PARA PROBAR ELIMINAR ESCALA
CALL ELIMINAR_ESCALA(13);

-- LISTAR ESCALAS
DELIMITER $
CREATE PROCEDURE LISTAR_ESCALA()
BEGIN
	SELECT *
    FROM Escalas
    WHERE activo = 1;
END $

-- PARA PRIBAR LISTAR ESCALAS
CALL LISTAR_ESCALA();


-- Para INSERTAR PESO CRITERIOS
DELIMITER $
CREATE PROCEDURE INSERTAR_PESO_CRITERIO(
	OUT _ID_PESO_CRITERIO INT,
    IN _ID_PERIODO INT,
    IN _ID_PUESTO_TRABAJO INT,
    IN _ID_CRITERIO INT,
    IN _PESO DOUBLE
)
BEGIN
	INSERT INTO PesosCriterios(id_PuestosTrabajo,id_Periodo,id_Criterio,peso,activo)
    VALUES (_ID_PUESTO_TRABAJO,_ID_PERIODO,_ID_CRITERIO,_PESO,1);
    SET _ID_PESO_CRITERIO = @@last_insert_id;
END $

-- PARA PROBAR PESOS CRITERIO
CALL INSERTAR_PESO_CRITERIO(@ID_PESO_CRITERIO,1,1,1,0.4);
CALL INSERTAR_PESO_CRITERIO(@ID_PESO_CRITERIO,1,1,2,0.3);
SELECT * FROM PesosCriterios;

-- PARA INSERTAR LINEA EVALUACION
DELIMITER $
CREATE PROCEDURE INSERTAR_LINEA_EVALUACION(
	OUT _ID_LINEA_EVALUACION INT,
    IN _ID_PESO_CRITERIO INT,
    IN _ID_EVALUACION INT,
    IN _ID_ITEM INT
)
BEGIN
	INSERT INTO LineasEvaluacion(id_Evaluacion,id_PesoCriterio,id_ItemPDI,activo)
    VALUES(_ID_EVALUACION,_ID_PESO_CRITERIO,_ID_ITEM,1);
    SET _ID_LINEA_EVALUACION = @@last_insert_id ;
END $

-- PARA PROBAR INSERTAR LINEA DE EVALUACION
CALL INSERTAR_LINEA_EVALUACION(@ID_LINEA_EVAL,2,1,1);
CALL INSERTAR_LINEA_EVALUACION(@ID_LINEA_EVAL,4,1,1);
SELECT * FROM LineasEvaluacion;

-- PARA ACTUALIZAR LINEA DE EVALUACION
DELIMITER $
CREATE PROCEDURE ACTUALIZAR_LINEA_EVALUACION(
	IN _ID_LINEA_EVALUACION INT,
    IN _NOTA_AUTO DOUBLE,
    IN _NOTA_PREV DOUBLE,
    IN _NOTA_FINAL DOUBLE,
	IN _ACCIONES VARCHAR(500)
)
BEGIN
	IF (_NOTA_AUTO IS NOT NULL) THEN
		UPDATE LineasEvaluacion
        SET notaAutoEval = _NOTA_AUTO
        WHERE id_Evaluacion=_ID_LINEA_EVALUACION;
    END IF;
    
    IF (_NOTA_PREV IS NOT NULL) THEN
		UPDATE LineasEvaluacion
        SET notaPrevia = _NOTA_PREV
        WHERE id_Evaluacion=_ID_LINEA_EVALUACION;
    END IF;
    
    IF (_NOTA_FINAL IS NOT NULL) THEN
		UPDATE LineasEvaluacion
        SET notaFinal = _NOTA_FINAL
        WHERE id_Evaluacion=_ID_LINEA_EVALUACION;
    END IF;
	IF _ACCIONES IS NULL THEN
		SET _ACCIONES = "";
	END IF;
	
	UPDATE LineasEvaluacion
	SET acccionesAtomar = _ACCIONES
	WHERE id_Evaluacion=_ID_LINEA_EVALUACION;
END$

-- PARA PROBAR LA ACTUALIZAR LINEA EVALUACION
CALL ACTUALIZAR_LINEA_EVALUACION(1,15,NULL,NULL);

-- PARA ELIMINAR UNA LINEA DE EVALUACION
DELIMITER $
CREATE PROCEDURE ELIMINAR_LINEA_EVAL(
	IN _ID_LINEA_EVAL INT
)
BEGIN
	UPDATE LineasEvaluacion
    SET	activo=0
    WHERE id_Evaluacion =  _ID_LINEA_EVAL;
END $

-- PARA PROBAR ELIMINAR LINEA DE EVALUACION
CALL ELIMINAR_LINEA_EVAL(1);
select * from LineasEvaluacion;

-- PARA LISTAR LINEA DE EVALUACION
DELIMITER $
CREATE PROCEDURE LISTAR_LINEA_EVAL()
BEGIN
	SELECT *
    FROM LineasEvaluacion
    WHERE activo = 1;
END$

-- PARA PROBAR LISTAR LINEA DE EVALUACION
CALL LISTAR_LINEA_EVAL();


-- Objetivos: 
DELIMITER $
CREATE PROCEDURE INSERTAR_OBJETIVO(
	OUT _ID_OBJETIVO INT, 
    IN FID_COLABORADOR INT, 
    IN _DESCRIPCION VARCHAR(200), 
    IN _META DOUBLE, 
    IN _UNIDADMEDIDA VARCHAR(50),
    IN _PESO DOUBLE
)
BEGIN
	-- Estado es 0, significa por aprobar 
	INSERT INTO Objetivos(id_Colaborador,descripcion,estado,fechaFormulacion,
						meta,unidadMedida,peso,activo)
	VALUES(FID_COLABORADOR,_DESCRIPCION,0,CURDATE(),_META,_UNIDADMEDIDA,_PESO,1); 
    SET _ID_OBJETIVO = @@last_insert_id; 
END$


DELIMITER $
CREATE PROCEDURE ELIMINAR_OBJETIVO( 
    IN _ID_OBJETIVO INT
)
BEGIN
	UPDATE Objetivos 
    SET activo = 0 
    WHERE id_Objetivo = _ID_OBJETIVO; 
END$


DELIMITER $
CREATE PROCEDURE ACTUALIZAR_OBJETIVO( 
    IN _ID_OBJETIVO INT, 
    IN _DESCRIPCION VARCHAR(200), 
    IN _META DOUBLE, 
    IN _UNIDADMEDIDA VARCHAR(50),
    IN _PESO DOUBLE, 
    IN _ESTADO INT,
    IN _OBSERVACION VARCHAR(200),
    IN _NOTAAUTOEVAL DOUBLE, 
    IN _NOTAPREVIA DOUBLE, 
    IN _NOTAFINAL DOUBLE, 
    IN _ID_EVALUACION INT
    
)
BEGIN
	IF (_DESCRIPCION IS NOT NULL) THEN 
		UPDATE Objetivos SET descripcion = _DESCRIPCION WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF;
    IF (_META IS NOT NULL) THEN 
		UPDATE Objetivos SET meta = _META WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 
    IF (_UNIDADMEDIDA IS NOT NULL) THEN 
		UPDATE Objetivos SET unidadMedida = _UNIDADMEDIDA WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 
    IF (_PESO IS NOT NULL) THEN 
		UPDATE Objetivos SET peso = _PESO WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 
    IF (_ESTADO IS NOT NULL) THEN 
		UPDATE Objetivos SET estado = _ESTADO WHERE  id_Objetivo = _ID_OBJETIVO; 
        IF (_ESTADO = 1) THEN 
			UPDATE Objetivos SET fechaAprobacion = CURDATE() WHERE  id_Objetivo = _ID_OBJETIVO;  
        END IF; 
    END IF; 
    IF (_NOTAAUTOEVAL IS NOT NULL) THEN 
		UPDATE Objetivos SET notaAutoEval = _NOTAAUTOEVAL WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 
    IF (_NOTAPREVIA IS NOT NULL) THEN 
		UPDATE Objetivos SET notaPrevia = _NOTAPREVIA WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 
    IF (_NOTAFINAL IS NOT NULL) THEN 
		UPDATE Objetivos SET notaFinal = _NOTAFINAL WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 
    IF (_ID_EVALUACION IS NOT NULL) THEN 
		UPDATE Objetivos SET id_Evaluacion = _ID_EVALUACION WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 
	IF (_OBSERVACION IS NOT NULL) THEN 
		UPDATE Objetivos SET observacion = _OBSERVACION WHERE  id_Objetivo = _ID_OBJETIVO; 
    END IF; 

    
    
END$

DELIMITER $ 
CREATE PROCEDURE LISTAR_OBJETIVOS(
)
BEGIN 
	SELECT * FROM Objetivos WHERE ACTIVO = 1;
END$

-- Colaboradores 

DELIMITER $
CREATE PROCEDURE INSERTAR_COLABORADOR(
	OUT _ID_COLABORADOR INT ,
    IN _DNI VARCHAR(10), 
    IN _NOMBRES VARCHAR(100),
    IN _APELLIDOS VARCHAR(100),
    IN _DIRECCION VARCHAR(200),
    IN _CORREO VARCHAR(45), 
    IN _TELEFONO VARCHAR(12), 
    IN _FECHANAC DATE,
    IN _ID_JEFE INT,
	IN _CONTRASEÑA VARCHAR(150),
	IN _ESTADOCUENTA TINYINT,
	IN _ESADMIN TINYINT(1)
)
BEGIN 
	INSERT INTO Colaboradores(dni,nombres,apellidos,direccion,correo,
	telefono,fechaNac,id_Jefe, contraseña, estadoCuenta,esAdmin) 
    VALUES(_DNI,_NOMBRES,_APELLIDOS,_DIRECCION,_CORREO,_TELEFONO,
	_FECHANAC,_ID_JEFE,_CONTRASEÑA,_ESTADOCUENTA,_ESADMIN); 
    SET _ID_COLABORADOR = @@last_insert_id; 
END$


DELIMITER $
CREATE PROCEDURE ACTUALIZAR_COLABORADOR(
    IN _ID_COLABORADOR INT, 
    IN _DIRECCION VARCHAR(200),
    IN _CORREO VARCHAR(45), 
    IN _TELEFONO VARCHAR(12), 
    IN _FECHANAC DATE,
    IN _ID_JEFE INT
)
BEGIN
	IF (_DIRECCION IS NOT NULL) THEN 
		UPDATE Colaboradores SET direccion = _DIRECCION WHERE id_Colaborador = _ID_COLABORADOR; 
    END IF; 
	IF (_CORREO IS NOT NULL) THEN 
		UPDATE Colaboradores SET correo = _CORREO WHERE id_Colaborador = _ID_COLABORADOR; 
    END IF; 
	IF (_TELEFONO IS NOT NULL) THEN 
		UPDATE Colaboradores SET telefono = _TELEFONO WHERE id_Colaborador = _ID_COLABORADOR; 
    END IF; 
	IF (_FECHANAC IS NOT NULL) THEN 
		UPDATE Colaboradores SET fechaNac = _FECHANAC WHERE id_Colaborador = _ID_COLABORADOR; 
    END IF; 
	IF (_ID_JEFE IS NOT NULL) THEN 
		UPDATE Colaboradores SET id_Jefe = _ID_JEFE WHERE id_Colaborador = _ID_COLABORADOR; 
    END IF; 
    
    
END$

DELIMITER $
CREATE PROCEDURE ELIMINAR_COLABORADOR(
	IN _ID_COLABORADOR INT
)
BEGIN
	UPDATE Colaboradores SET activo=0 WHERE id_Colaborador = _ID_COLABORADOR; 
END$

DELIMITER $
CREATE PROCEDURE LISTAR_COLABORADORES(
)
BEGIN
	SELECT * FROM Colaboradores WHERE ACTIVO = 1; 
END$

-- EvaluacionDesempenho

DELIMITER $
CREATE PROCEDURE INSERTAR_EVALUACIONDESEMPENHO(
	OUT _ID_EVALUACION INT, 
    IN _ID_COLABORADOR INT,
    IN _ID_PERIODO INT 

)
BEGIN
	INSERT INTO Evaluaciones(id_Colaborador, id_Periodo,activo) 
    VALUES (_ID_COLABORADOR, _ID_PERIODO,1); 
    SET _ID_EVALUACION = @@last_insert_id; 
    INSERT INTO EvaluacionesDesempenho(id_Evaluacion) 
    VALUES(_ID_EVALUACION); 
END$

DELIMITER $
CREATE PROCEDURE ACTUALIZAR_EVALUACIONDESEMPENHO(
	IN _ID_EVALUACION INT, 
    IN _OBSERVACIONESCOMP VARCHAR(100), 
    IN _NOTAAUTOEVALCOMP DOUBLE, 
    IN _NOTAPREVIACOMP DOUBLE, 
    IN _NOTAFINALCOMP DOUBLE, 
    IN _OBSERVACIONESOBJ VARCHAR(100), 
    IN _NOTAAUTOEVALOBJ DOUBLE, 
    IN _NOTAPREVIAOBJ DOUBLE, 
    IN _NOTAFINALOBJ DOUBLE
)
BEGIN 
	IF (_OBSERVACIONESCOMP IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET observacionesComp = _OBSERVACIONESCOMP WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
	IF (_NOTAAUTOEVALCOMP IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET notaAutoEvalComp = _NOTAAUTOEVALCOMP WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
	IF (_NOTAPREVIACOMP IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET notaPreviaComp = _NOTAPREVIACOMP WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
	IF (_NOTAFINALCOMP IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET notaFinalComp = _NOTAFINALCOMP WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
	IF (_OBSERVACIONESOBJ IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET observacionesObj = _OBSERVACIONESOBJ WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
    IF (_NOTAAUTOEVALOBJ IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET notaAutoEvalObj = _NOTAAUTOEVALOBJ WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
    IF (_NOTAPREVIAOBJ IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET notaPreviaObj = _NOTAPREVIAOBJ WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
    IF (_NOTAFINALOBJ IS NOT NULL) THEN 
		UPDATE EvaluacionesDesempenho SET notaFinalObj = _NOTAFINALOBJ WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF; 
    
END$

DELIMITER $
CREATE PROCEDURE LISTAR_EVALUACIONDESEMPENHO(
)
BEGIN
	SELECT *  FROM Evaluaciones as e INNER JOIN  EvaluacionesDesempenho as ed ON e.id_Evaluacion = ed.id_Evaluacion
	WHERE activo=1; 
END $

-- Evaluaciones

DELIMITER $
CREATE PROCEDURE INSERTAR_EVALUACION(
	OUT _ID_EVALUACION INT, 
    IN _ID_COLABORADOR INT,
    IN _ID_PERIODO INT 
	IN _ID_ESCALAPRECUPOS INT,
	IN _ID_ESCALASINCALIBRAR INT,
	IN _ID_ESCALAFINAL INT
)
BEGIN
	INSERT INTO Evaluaciones(id_Colaborador,id_Periodo,id_EscalaPreCupos,
		id_EscalaSinCalibrar, id_EscalaFinal,activo) 
    VALUES (_ID_COLABORADOR, _ID_PERIODO,_ID_ESCALAPRECUPOS,
		,_ID_ESCALASINCALIBRAR,_ID_ESCALAFINAL, 1); 
    SET _ID_EVALUACION = @@last_insert_id;
END$

DELIMITER $
CREATE PROCEDURE ACTUALIZAR_EVALUACION(
	IN _ID_EVALUACION INT, 
    IN _ESTADOPDI INT,
	IN _OBSERVACIONES VARCHAR(200),
	IN _NOTAAUTOEVAL DOUBLE,
	IN _NOTAFINAL DOUBLE,
	IN _TIPO TINYINT(1)
)
BEGIN 
	IF (_ESTADOPDI IS NOT NULL) THEN 
		UPDATE Evaluaciones SET estadoPDI = _ESTADOPDI WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF;
	IF (_OBSERVACIONES IS NOT NULL) THEN 
		UPDATE Evaluaciones SET observaciones = _OBSERVACIONES WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF;
	IF (_NOTAAUTOEVAL IS NOT NULL) THEN 
		UPDATE Evaluaciones SET notaAutoEval = _NOTAAUTOEVAL WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF;
	IF (_NOTAFINAL IS NOT NULL) THEN 
		UPDATE Evaluaciones SET notaFinal = _NOTAFINAL WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF;
	IF (_TIPO IS NOT NULL) THEN 
		UPDATE Evaluaciones SET tipo = _TIPO WHERE id_Evaluacion = _ID_EVALUACION; 
    END IF;
    
END$

DELIMITER $
CREATE PROCEDURE LISTAR_EVALUACION(
)
BEGIN
	SELECT *  FROM Evaluaciones
	WHERE activo=1; 
END $

DELIMITER $ 
CREATE PROCEDURE ELIMINAR_EVALUACION(
	IN _ID_EVALUACION INT 
)
BEGIN
	UPDATE Evaluaciones SET activo = 0 WHERE id_Evaluacion = _ID_EVALUACION;  
END$


-- -------------
-- Pruebas: 
-- -------------

-- Colaboradores: 

CALL INSERTAR_COLABORADOR(@ID,'12345678','Rodrigo Alfredo','Rodriguez Lopez',
							'Avenida Bolivar 1158', 'rodrigo.lopez@gmail.com','999123666',
							'1990-07-24',NULL); 
                            
CALL INSERTAR_COLABORADOR(@ID,'12345671','Rodrigo Luis','Rodriguez Fernandez',
							'Avenida Bolivar 1159', 'rodrigo.fernandez@gmail.com','999124666',
							'1995-07-24',NULL); 

CALL ELIMINAR_COLABORADOR(2); 
CALL LISTAR_COLABORADORES();

-- Objetivos:                             
CALL INSERTAR_OBJETIVO(@ID,1,'Vender 2000 laptops para fin de anho',2000.00,'Laptops vendidas',0.4); 
CALL INSERTAR_OBJETIVO(@ID,1,'Vender 100 tablets para fin de anho',2000.00,'Laptops vendidas',0.2); 
CALL ELIMINAR_OBJETIVO(1);
CALL ACTUALIZAR_OBJETIVO(2,'Vender 50 tablets',50,'Tablets vendidas',0.3,1,'Objetivo correcto',NULL,NULL,NULL,NULL);
CALL LISTAR_OBJETIVOS();


SELECT * FROM Colaboradores;

-- Evaluaciones Desempenho: 

CALL INSERTAR_EVALUACIONDESEMPENHO(@ID,1,1); 
CALL LISTAR_EVALUACIONDESEMPENHO();
CALL ACTUALIZAR_EVALUACIONDESEMPENHO(1,13,13,'Sobresaliente',0.9,1.0,1.0,'Buen cumplimiento de objetivos',0.7,0.8,0.8); 
CALL ELIMINAR_EVALUACIONDESEMPENHO(1);





