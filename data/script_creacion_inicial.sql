USE [GD1C2015]

GO

-----Creacion del esquema

IF NOT EXISTS (SELECT * 
			   FROM sys.schemas 
			   WHERE name = N'SUDO') 
	BEGIN
		EXEC sys.sp_executesql N'CREATE SCHEMA [SUDO] AUTHORIZATION [gd]'
		PRINT 'Esquema SUDO creado'
	END

GO

---------------------------------------------------------------------------
			--  	Drop tablas
---------------------------------------------------------------------------
IF OBJECT_ID ('SUDO.Comprobante') IS NOT NULL DROP TABLE SUDO.Comprobante
IF OBJECT_ID ('SUDO.Deposito') IS NOT NULL DROP TABLE SUDO.Deposito
IF OBJECT_ID ('SUDO.Item') IS NOT NULL DROP TABLE SUDO.Item
IF OBJECT_ID ('SUDO.Transferencia') IS NOT NULL DROP TABLE SUDO.Transferencia
IF OBJECT_ID ('SUDO.Tarjeta') IS NOT NULL DROP TABLE SUDO.Tarjeta
IF OBJECT_ID ('SUDO.Cheque') IS NOT NULL DROP TABLE SUDO.Cheque
IF OBJECT_ID ('SUDO.Retiro') IS NOT NULL DROP TABLE SUDO.Retiro
IF OBJECT_ID ('SUDO.FacturacionCuenta') IS NOT NULL DROP TABLE SUDO.FacturacionCuenta
IF OBJECT_ID ('SUDO.Cuenta') IS NOT NULL DROP TABLE SUDO.Cuenta
IF OBJECT_ID ('SUDO.Factura') IS NOT NULL DROP TABLE SUDO.Factura
IF OBJECT_ID ('SUDO.HistorialClientesInhabilitados') IS NOT NULL DROP TABLE SUDO.HistorialClientesInhabilitados
IF OBJECT_ID ('SUDO.Cliente') IS NOT NULL DROP TABLE SUDO.Cliente
IF OBJECT_ID ('SUDO.HistorialLogin') IS NOT NULL DROP TABLE SUDO.HistorialLogin
IF OBJECT_ID ('SUDO.UsuarioXRol') IS NOT NULL DROP TABLE SUDO.UsuarioXRol
IF OBJECT_ID ('SUDO.FuncionalidadXRol') IS NOT NULL DROP TABLE SUDO.FuncionalidadXRol
IF OBJECT_ID ('SUDO.Rol') IS NOT NULL DROP TABLE SUDO.Rol
IF OBJECT_ID ('SUDO.Funcionalidad') IS NOT NULL DROP TABLE SUDO.Funcionalidad
IF OBJECT_ID ('SUDO.Usuario') IS NOT NULL DROP TABLE SUDO.Usuario
IF OBJECT_ID ('SUDO.TipoDoc') IS NOT NULL DROP TABLE SUDO.TipoDoc
IF OBJECT_ID ('SUDO.Pais') IS NOT NULL DROP TABLE SUDO.Pais
IF OBJECT_ID ('SUDO.Moneda') IS NOT NULL DROP TABLE SUDO.Moneda
IF OBJECT_ID ('SUDO.TipoCuenta') IS NOT NULL DROP TABLE SUDO.TipoCuenta
IF OBJECT_ID ('SUDO.EstadoCuenta') IS NOT NULL DROP TABLE SUDO.EstadoCuenta
IF OBJECT_ID ('SUDO.Banco') IS NOT NULL DROP TABLE SUDO.Banco
IF OBJECT_ID ('SUDO.Emisor') IS NOT NULL DROP TABLE SUDO.Emisor
IF OBJECT_ID ('SUDO.TipoMovimiento') IS NOT NULL DROP TABLE SUDO.TipoMovimiento
PRINT 'Tablas borradas'
GO

---------------------------------------------------------------------------
			--  	Creacion de tablas
---------------------------------------------------------------------------
-----------Tabla Banco-----------
CREATE TABLE SUDO.Banco ( 
	codigo		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	nombre 		varchar(255),
	direccion 	varchar(255)
);

-----------Tabla Emisor-----------
CREATE TABLE SUDO.Emisor ( 
	idEmisor 		integer IDENTITY(1,1) PRIMARY KEY,
	descripcion 	varchar(255),
);

-----------Tabla EstadoCuenta-----------
CREATE TABLE SUDO.EstadoCuenta ( 
	idEstadoCuenta 	integer IDENTITY(1,1) PRIMARY KEY,
	descripcion 	varchar(255),
);

-----------Tabla TipoCuenta-----------
CREATE TABLE SUDO.TipoCuenta ( 
	idTipoCuenta 	integer IDENTITY(1,1) PRIMARY KEY,
	nombre 			varchar(255),
	duracionEnDias 	SMALLINT NOT NULL,
	costo 			numeric(18,2) NOT NULL, 
);

-----------Tabla Moneda-----------
CREATE TABLE SUDO.Moneda ( 
	idMoneda 		integer IDENTITY(1,1) PRIMARY KEY,
	descripcion 	varchar(255),
);

-----------Tabla Pais-----------
CREATE TABLE SUDO.Pais ( 
	idPais 			numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	descripcion 	varchar(255),	
);

-----------Tabla TipoDoc-----------
CREATE TABLE SUDO.TipoDoc ( 
	idTipoDoc		numeric(18,0)IDENTITY(1,1) PRIMARY KEY,
	descripcion 	varchar(255),	
);

-----------Tabla Usuario-----------
CREATE TABLE SUDO.Usuario ( 
	idUsuario 					integer IDENTITY(1,1) PRIMARY KEY,
	userName 					varchar(255) NOT NULL UNIQUE,
	userPassword 				varchar(255) NOT NULL,
	fechaCreacion 				datetime,
	fechaDeUltimaModificacion 	datetime,
	preguntaSecreta 			varchar(255) NOT NULL,
	respuestaSecreta 			varchar(255) NOT NULL,
	cantIntentosFallidos 		TINYINT DEFAULT 0,
	estado 						BIT DEFAULT 1,
	administrador				BIT DEFAULT 0,--utilizado para mostrar opciones de administrador
);

-----------Tabla Funcionalidad-----------
CREATE TABLE SUDO.Funcionalidad ( 
	idFuncionalidad 	integer IDENTITY(1,1) PRIMARY KEY,
	nombre 				varchar(255),
);

-----------Tabla Rol-----------
CREATE TABLE SUDO.Rol ( 
	idRol 		integer IDENTITY(1,1) PRIMARY KEY,
	nombreRol 	varchar(255),
	estado 		BIT DEFAULT 1,
);

-----------Tabla Funcionalidad X Rol-----------
CREATE TABLE SUDO.FuncionalidadXRol ( 
	idRol 				integer FOREIGN KEY REFERENCES SUDO.Rol,
	idFuncionalidad 	integer FOREIGN KEY REFERENCES SUDO.Funcionalidad,
);

-----------Tabla Usuario X Rol-----------
CREATE TABLE SUDO.UsuarioXRol ( 
	idRol 		integer FOREIGN KEY REFERENCES SUDO.Rol,
	idUsuario 	integer FOREIGN KEY REFERENCES SUDO.Usuario,
);

-----------Tabla HistorialLogin-----------
CREATE TABLE SUDO.HistorialLogin ( 
	idHistorialLogin 		integer IDENTITY(1,1) PRIMARY KEY,
	userNameIngreasdo 		varchar(255) NOT NULL,
	userPasswordIngresado 	varchar(255) NOT NULL,
	fechaHora 				datetime,
	numeroIntentoFallido 	TINYINT DEFAULT 0, --si existe el useName, osea que existe el usuario, se aumenta
	estado 					BIT DEFAULT 0,
	descripcion				varchar(255)
);

-----------Tabla Cliente-----------
CREATE TABLE SUDO.Cliente ( 
	idCliente 		integer IDENTITY(1,1) PRIMARY KEY,
	idUsuario 		integer DEFAULT NULL,
	idTipoDoc		numeric(18,0) FOREIGN KEY REFERENCES SUDO.TipoDoc,
	idPais 			numeric(18,0) FOREIGN KEY REFERENCES SUDO.Pais,
	nombre 			varchar(255) NOT NULL,
	apellido 		varchar(255) NOT NULL,
	mail 			varchar(255) NOT NULL,
	fechaDeNac 		datetime,
	nroDoc			numeric(18,0) NOT NULL,
	dirNumero 		numeric(18,0),
	dirCalle 		varchar(255),
	dirPiso 		numeric(18,0),
	dirDepto 		varchar(10),
	nacionalidad	varchar(255) DEFAULT 'Argentina',
	estado 			BIT DEFAULT 1,
);

-----------Tabla HistorialClientesInhabilitados-----------
CREATE TABLE SUDO.HistorialClientesInhabilitados ( 
	idHistorial	integer IDENTITY(1,1) PRIMARY KEY,
	idCliente	integer FOREIGN KEY REFERENCES SUDO.Cliente,
	fecha 		datetime,
);

-----------Tabla Factura-----------
CREATE TABLE SUDO.Factura ( 
	numero		numeric(18,0) PRIMARY KEY,
	idCliente	integer FOREIGN KEY REFERENCES SUDO.Cliente,
	fecha 		datetime,
);

-----------Tabla Cuenta-----------
CREATE TABLE SUDO.Cuenta ( 
	nroCuenta		numeric(18,0) PRIMARY KEY,
	idCliente 		integer FOREIGN KEY REFERENCES SUDO.Cliente,
	idPais 			numeric(18,0) FOREIGN KEY REFERENCES SUDO.Pais,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda DEFAULT NULL,
	idTipoCuenta 	integer FOREIGN KEY REFERENCES SUDO.TipoCuenta DEFAULT NULL,
	idEstadoCuenta 	integer FOREIGN KEY REFERENCES SUDO.EstadoCuenta,
	saldo 			numeric(18,2) DEFAULT 0,
	fechaCreacion 	datetime NOT NULL,
	fechaCierre 	datetime
);

-----------Tabla FacturacionCuenta-----------
CREATE TABLE SUDO.FacturacionCuenta ( 
	idFactCuenta	integer IDENTITY(1,1) PRIMARY KEY,
	nroCuenta 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda DEFAULT NULL,
	fecha 			datetime,
	descripcion 	varchar(255),
	importe 		numeric(18,2) NOT NULL,
	facturado		BIT DEFAULT 0,
);

-----------Tabla Retiro-----------
CREATE TABLE SUDO.Retiro ( 
	codigo 		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	idCuenta	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	idMoneda 	integer FOREIGN KEY REFERENCES SUDO.Moneda DEFAULT NULL,
	codigoBanco numeric(18,0) FOREIGN KEY REFERENCES SUDO.Banco,
	fecha 		datetime NOT NULL,
	importe 	numeric(18,2) NOT NULL,
);

-----------Tabla Cheque-----------
CREATE TABLE SUDO.Cheque ( 
	idCheque 		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	idRetiro	 	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Retiro,
	codigoBanco 	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Banco,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda DEFAULT NULL,
	fecha 			datetime,
	importe 		numeric(18,2) NOT NULL,
);

-----------Tabla Tarjeta-----------
CREATE TABLE SUDO.Tarjeta ( 
	idTarjeta 			integer IDENTITY(1,1) PRIMARY KEY,
	idCliente 			integer FOREIGN KEY REFERENCES SUDO.Cliente,
	prim12num 			varchar(20) NOT NULL,
	ult4num             varchar(4) NOT NULL,
	idEmisor 			integer FOREIGN KEY REFERENCES SUDO.Emisor,
	fechaEmision 		datetime NOT NULL,
	fechaVencimiento 	datetime NOT NULL,
	codigoSeguridad 	varchar(255) NOT NULL,
	estado 				BIT DEFAULT 1,	
);

-----------Tabla Transferencia-----------
CREATE TABLE SUDO.Transferencia ( 
	idTrans 			integer IDENTITY(1,1) PRIMARY KEY,
	nroCuentaDest 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	nroCuentaOrigen		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	idMoneda 			integer FOREIGN KEY REFERENCES SUDO.Moneda DEFAULT NULL,
	costo 				numeric(18,2),
	importe 			numeric(18,2),
	fecha 				datetime,
	facturado			BIT DEFAULT 0,
	auxFacturaNumero	numeric(18,0)
);

-----------Tabla Item (Factura)-----------
CREATE TABLE SUDO.Item ( 
	idItem				integer IDENTITY(1,1) PRIMARY KEY,
	numeroFactura		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Factura,
	idMoneda 			integer FOREIGN KEY REFERENCES SUDO.Moneda DEFAULT NULL,
	idTrans 			integer FOREIGN KEY REFERENCES SUDO.Transferencia DEFAULT NULL,
	importe 			numeric(18,2) NOT NULL,
	descripcion 		varchar(255),
	nombreTipoCuenta	varchar(255),
);

-----------Tabla Deposito-----------
CREATE TABLE SUDO.Deposito ( 
	codigo 			numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	nroCuenta 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	idTarjeta 		integer FOREIGN KEY REFERENCES SUDO.tarjeta,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda,
	importe 		numeric(18,2),
	fecha 			datetime,
);

-----------Tabla Comprobante-----------
CREATE TABLE SUDO.Comprobante ( 
	numOperacion 	numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	idDeposito 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Deposito,
	fechaIngreso 	datetime,
);

PRINT 'Tablas creadas'
GO

---------------------------------------------------------------------------
			--  	Creacion Stored Procedures --
---------------------------------------------------------------------------
--Login
--dado un userName obtiene el usuario de la tabla Usuario
IF OBJECT_ID ('SUDO.GetUser') IS NOT NULL DROP PROCEDURE SUDO.GetUser
GO
CREATE PROCEDURE SUDO.GetUser(@userName varchar(255)) AS 
	BEGIN
    	SELECT *
		FROM SUDO.Usuario
		WHERE (userName = @userName);
	END;
GO
--Registra el login de un usuario inxistente en la tabla HistorialLogin
IF OBJECT_ID ('SUDO.RegistrarLoginUsuarioInexistente') IS NOT NULL DROP PROCEDURE SUDO.RegistrarLoginUsuarioInexistente
GO
CREATE PROCEDURE SUDO.RegistrarLoginUsuarioInexistente(@userNameIng varchar(255), @userPasswordIng varchar(255), @fechaHora datetime, @descripcion varchar(255)) AS 
	BEGIN
		INSERT INTO SUDO.HistorialLogin (userNameIngreasdo, userPasswordIngresado, fechaHora, descripcion)
		VALUES(@userNameIng, @userPasswordIng, @fechaHora, @descripcion);
	END;
GO
--blockea a un usuario cambiando el bit estado a 0
IF OBJECT_ID ('SUDO.BlockearUsuario') IS NOT NULL DROP PROCEDURE SUDO.BlockearUsuario
GO
CREATE PROCEDURE SUDO.BlockearUsuario(@idUsuario integer) AS 
	BEGIN
		UPDATE SUDO.Usuario SET estado = 0
		WHERE (idUsuario = @idUsuario)
	END;
GO
--Registra el login de un usuario existente
IF OBJECT_ID ('SUDO.RegistrarLogin') IS NOT NULL DROP PROCEDURE SUDO.RegistrarLogin
GO
CREATE PROCEDURE SUDO.RegistrarLogin(@userNameIng varchar(255), @userPasswordIng varchar(255), @fechaHora datetime, @estado BIT, @numeroIntentoFallido TINYINT, @descripcion varchar(255), @idUsuario integer) AS 
	BEGIN
		INSERT INTO SUDO.HistorialLogin (userNameIngreasdo, userPasswordIngresado, fechaHora, numeroIntentoFallido, estado, descripcion)
		VALUES(@userNameIng, @userPasswordIng, @fechaHora, @numeroIntentoFallido, @estado, @descripcion);
		
		UPDATE SUDO.Usuario SET cantIntentosFallidos = @numeroIntentoFallido
		WHERE (idUsuario = @idUsuario)
	END;
GO
---------------------------------------------------------------------------
--Form seleccion de Roles y Funcionalidades
--dado un idUsuario obtiene todos sus roles y sus funcionalidades, cabe aclarar que obtiene los roles "habilitados", con estado = 1
IF OBJECT_ID ('SUDO.GetRolesXFuncionalidades') IS NOT NULL DROP PROCEDURE SUDO.GetRolesXFuncionalidades
GO
CREATE PROCEDURE SUDO.GetRolesXFuncionalidades(@idUsuario integer) AS 
	BEGIN
		SELECT idRol, nombreRol, RyF.idFuncionalidad, nombre nombreFuncionalidad
	  	FROM(SELECT RolesUsuario.nombreRol, RolesUsuario.idRol, idFuncionalidad
	  		 FROM(SELECT r.idRol, r.nombreRol
	  			  FROM SUDO.UsuarioXRol uxr JOIN SUDO.Rol r ON uxr.idRol = r.idRol
	  			  WHERE idUsuario = @idUsuario AND estado = 1) RolesUsuario
	  		 JOIN SUDO.FuncionalidadXRol FxR ON RolesUsuario.idRol = FxR.idRol) RyF
	  	JOIN SUDO.Funcionalidad f ON RyF.idFuncionalidad = f.idFuncionalidad
	  	ORDER BY idRol
	END;
GO
---------------------------------------------------------------------------
--From Rol
-- obtiene todos los roles existentes
IF OBJECT_ID ('SUDO.GetRoles') IS NOT NULL DROP PROCEDURE SUDO.GetRoles
GO
CREATE PROCEDURE SUDO.GetRoles AS 
	BEGIN
		SELECT idRol, nombreRol, estado
		FROM SUDO.Rol
	END;
GO

-- dado un idRol se cambia su estado
IF OBJECT_ID ('SUDO.ModificarEstadoRol') IS NOT NULL DROP PROCEDURE SUDO.ModificarEstadoRol
GO
CREATE PROCEDURE SUDO.ModificarEstadoRol(@idRol integer) AS 
	BEGIN
		DECLARE @Estado bit

		IF((SELECT estado FROM SUDO.Rol WHERE idRol = @idRol)=0)
			SELECT @Estado = 1
		ELSE
			SELECT @Estado = 0

		UPDATE SUDO.Rol
		SET estado = @Estado
		WHERE idRol = @idRol
	END;
GO

-- dado un idRol se cambia su nombre
IF OBJECT_ID ('SUDO.ModificarNombreRol') IS NOT NULL DROP PROCEDURE SUDO.ModificarNombreRol
GO
CREATE PROCEDURE SUDO.ModificarNombreRol(@idRol integer, @nombre varchar(255)) AS 
	BEGIN
		UPDATE SUDO.Rol
		SET nombreRol = @nombre
		WHERE idRol = @idRol
	END;
GO

-- dado un idRol obtiene sus funcionalidades
IF OBJECT_ID ('SUDO.GetFuncionalidadesDelRol') IS NOT NULL DROP PROCEDURE SUDO.GetFuncionalidadesDelRol
GO
CREATE PROCEDURE SUDO.GetFuncionalidadesDelRol(@idRol integer) AS 
	BEGIN
		SELECT F.idFuncionalidad, nombre
		FROM SUDO.Funcionalidad F JOIN (SELECT *
				   						FROM SUDO.FuncionalidadXRol
							  			WHERE idRol = @idRol) FR ON (F.idFuncionalidad =FR.idFuncionalidad )
	END;
GO

-- obtiene las funcionalidades del sitema
IF OBJECT_ID ('SUDO.GetFuncionalidadesDisponibles') IS NOT NULL DROP PROCEDURE SUDO.GetFuncionalidadesDisponibles
GO
CREATE PROCEDURE SUDO.GetFuncionalidadesDisponibles AS 
	BEGIN
		SELECT *
		FROM SUDO.Funcionalidad
	END;
GO

-- agregar o quitar una funcioonalidad del Rol
-- su la funcionalidad no existe la agrega y si existe la saca
IF OBJECT_ID ('SUDO.AgregarQuitarFuncionalidad') IS NOT NULL DROP PROCEDURE SUDO.AgregarQuitarFuncionalidad
GO
CREATE PROCEDURE SUDO.AgregarQuitarFuncionalidad (@idRol integer, @funcionalidad varchar(255)) AS
	BEGIN
		IF EXISTS(SELECT F.idFuncionalidad 
				  FROM SUDO.Funcionalidad F JOIN (SELECT *
  			  									  FROM SUDO.FuncionalidadXRol
							  					  WHERE idRol = @idRol) FR ON (F.idFuncionalidad =FR.idFuncionalidad )
		  		  WHERE F.nombre = @funcionalidad
		)
			BEGIN
				DELETE FROM SUDO.FuncionalidadXRol
				WHERE (idFuncionalidad = (SELECT F.idFuncionalidad 
										  FROM SUDO.Funcionalidad F JOIN (SELECT *
		  			  													  FROM SUDO.FuncionalidadXRol
							  											  WHERE idRol = @idRol) FR ON (F.idFuncionalidad =FR.idFuncionalidad )
										  WHERE F.nombre = @funcionalidad)
				  AND idRol = @idRol)
			END;
		ELSE
			BEGIN
				INSERT INTO SUDO.FuncionalidadXRol(idRol, idFuncionalidad)
				VALUES (@idRol,  (SELECT idFuncionalidad
							FROM SUDO.Funcionalidad
						    WHERE nombre = @funcionalidad))
			END;
	END;
GO
---------------------------------------------------------------------------
--Form Cuenta
--obtiene todos los paises existentes en el sistema
IF OBJECT_ID ('SUDO.GetPaises') IS NOT NULL DROP PROCEDURE SUDO.GetPaises
GO
CREATE PROCEDURE SUDO.GetPaises AS 
	BEGIN
		SELECT *
		FROM SUDO.Pais
	END;
GO

--crea una cuenta
IF OBJECT_ID ('SUDO.CrearCuenta') IS NOT NULL DROP PROCEDURE SUDO.CrearCuenta
GO
CREATE PROCEDURE SUDO.CrearCuenta(@nroCuenta bigint, @idUsuario integer, @moneda varchar(255), @pais varchar(255), @tipoCuenta varchar(255), @fechaApertura varchar(255)) AS 
	BEGIN
		DECLARE @idCliente integer
		DECLARE @idPais numeric(18,0)
		DECLARE @idMoneda integer
		DECLARE @idTipoCuenta integer

		IF NOT EXISTS(SELECT * FROM SUDO.Cuenta WHERE nroCuenta = @nroCuenta)
			IF EXISTS(SELECT * FROM SUDO.Usuario WHERE idUsuario= @idUsuario)
				BEGIN
					SELECT @idCliente = idCliente
					FROM SUDO.Cliente
					WHERE @idUsuario = idUsuario

					SELECT @idPais = idPais
					FROM SUDO.Pais
					WHERE @pais = descripcion

					SELECT @idMoneda = idMoneda
					FROM SUDO.Moneda
					WHERE @moneda = descripcion

					SELECT @idTipoCuenta = idTipoCuenta
					FROM SUDO.TipoCuenta
					WHERE @tipoCuenta = nombre
					
					INSERT INTO SUDO.Cuenta (nroCuenta, idCliente, idPais, idMoneda, idTipoCuenta, idEstadoCuenta, saldo, fechaCreacion, fechaCierre)
					VALUES(@nroCuenta, @idCliente, @idPais, @idMoneda, @idTipoCuenta, 1, 0, Convert(dateTime, @fechaApertura, 121), Convert(dateTime, '2020-12-25 00:00:00.000', 121))
					
					INSERT INTO SUDO.FacturacionCuenta (nroCuenta, idMoneda, fecha, descripcion, importe)
					VALUES(@nroCuenta, @idMoneda, @fechaApertura, 'Apertura de Cuenta', 50)
				END
	END;
GO
--obtiene los Estados de las Cuentas
IF OBJECT_ID ('SUDO.GetEstadosCuenta') IS NOT NULL DROP PROCEDURE SUDO.GetEstadosCuenta
GO
CREATE PROCEDURE SUDO.GetEstadosCuenta AS 
	BEGIN
		SELECT *
		FROM SUDO.EstadoCuenta
 	END;
GO
--modifica la cuenta del correspondiente usuario, usado por el admin del sistema
IF OBJECT_ID ('SUDO.ModificarCuentaAdmin') IS NOT NULL DROP PROCEDURE SUDO.ModificarCuentaAdmin
GO
CREATE PROCEDURE SUDO.ModificarCuentaAdmin(@nroCuenta bigint, @tipoCuenta varchar(255), @estadoCuenta varchar(255)) AS 
	BEGIN
		DECLARE @idTipoCuenta integer
		DECLARE @idEstadoCuenta integer

		IF EXISTS(SELECT * FROM SUDO.Cuenta WHERE nroCuenta = @nroCuenta)
		BEGIN
			SELECT @idTipoCuenta = idTipoCuenta
			FROM SUDO.TipoCuenta
			WHERE @tipoCuenta = nombre
		
			SELECT @idEstadoCuenta = idEstadoCuenta
			FROM SUDO.EstadoCuenta
			WHERE @estadoCuenta = descripcion
		
			UPDATE SUDO.Cuenta
			SET idTipoCuenta = @idTipoCuenta, idEstadoCuenta = @idEstadoCuenta
			WHERE nroCuenta = @nroCuenta
		END
 	END;
GO


---------------------------------------------------------------------------
--Form Facturacion
-- dado un idUsuario de la tabla usuario obtiene los items a facturar
IF OBJECT_ID ('SUDO.GetTransferenciasAFacturar') IS NOT NULL DROP PROCEDURE SUDO.GetTransferenciasAFacturar
GO
CREATE PROCEDURE SUDO.GetTransferenciasAFacturar(@idUsuario integer, @idCuenta bigint) AS 
	BEGIN
		SELECT idTrans, costo, importe, B.descripcion moneda, nroCuentaDest, nroCuentaOrigen, fecha 
		FROM(
			SELECT costo, importe, T.idMoneda, nroCuentaDest, nroCuentaOrigen, fecha, idTrans
	  		FROM (SUDO.Transferencia T JOIN (SELECT nroCuenta 
	  										 FROM SUDO.Cuenta 
	  										 WHERE idCliente = @idUsuario) C ON (nroCuentaOrigen = C.nroCuenta))
			WHERE (facturado = 0) AND (@idCuenta = nroCuentaOrigen)
			) A JOIN SUDO.Moneda B ON B.idMoneda = A.idMoneda
	END;
GO

--Crea una factura en la tabla factura
IF OBJECT_ID ('SUDO.CrearFactura') IS NOT NULL DROP PROCEDURE SUDO.CrearFactura
GO
CREATE PROCEDURE SUDO.CrearFactura(@idUsuario int, @fecha varchar(255)) AS 
	BEGIN
		DECLARE @idCliente integer
		DECLARE @numeroFactura numeric(18,0)
		
		SELECT @idCliente = idCliente
		FROM SUDO.Cliente
		WHERE idUsuario = @idUsuario
		
		SELECT @numeroFactura = (MAX(numero)+1) 
		FROM SUDO.Factura
		
		INSERT INTO SUDO.Factura (numero, idCliente, fecha)
		VALUES(@numeroFactura, @idCliente, Convert(dateTime, @fecha, 121));
		
		SELECT @numeroFactura idFact
	END
GO

IF OBJECT_ID ('SUDO.FacturarTransaccion') IS NOT NULL DROP PROCEDURE SUDO.FacturarTransaccion
GO
CREATE PROCEDURE SUDO.FacturarTransaccion(@idTrans bigint, @idFact bigint) AS 
	BEGIN
		DECLARE @idMoneda integer
		DECLARE @costo numeric(18,2)
		DECLARE @nombreTipoCuenta varchar(255)
		
		SELECT @idMoneda = idMoneda, @costo = costo, @nombreTipoCuenta = nombre
		FROM(SELECT T.idMoneda, importe, idTipoCuenta
			 FROM SUDO.Transferencia T JOIN SUDO.Cuenta C ON(T.nroCuentaOrigen = C.nroCuenta)) A
		JOIN SUDO.TipoCuenta B ON (A.idTipoCuenta = B.idTipoCuenta)
	
		INSERT INTO SUDO.Item (numeroFactura, idMoneda, idTrans, importe, descripcion, nombreTipoCuenta)
		VALUES(@idFact, @idMoneda, @idTrans, @costo, 'Comisión por transferencia.', @nombreTipoCuenta);
		
		UPDATE SUDO.Transferencia
		SET facturado = 1
		WHERE idTrans = @idTrans
	END;
GO

-- Inhabilita una Cuenta
IF OBJECT_ID ('SUDO.InhabilitarCuenta') IS NOT NULL DROP PROCEDURE SUDO.InhabilitarCuenta
GO
CREATE PROCEDURE SUDO.InhabilitarCuenta(@idCuenta bigint) AS 
	BEGIN
		UPDATE SUDO.Cuenta SET idEstadoCuenta = 3
		WHERE (nroCuenta = @idCuenta)
 	END;
GO

-- dado un idUsuario de la tabla usuario obtiene los cambios de cuentas a facturar
IF OBJECT_ID ('SUDO.GetCambiosCuentaAFacturar') IS NOT NULL DROP PROCEDURE SUDO.GetCambiosCuentaAFacturar
GO
CREATE PROCEDURE SUDO.GetCambiosCuentaAFacturar(@idUsuario integer, @idCuenta bigint) AS 
	BEGIN
		SELECT idFactCuenta, nroCuenta, B.descripcion moneda, fecha, A.descripcion, importe
		FROM (
			 SELECT F.nroCuenta, fecha, descripcion, importe, idMoneda, idFactCuenta
			 FROM SUDO.FacturacionCuenta F JOIN (SELECT nroCuenta 
	  											 FROM SUDO.Cuenta 
	  											 WHERE idCliente = @idUsuario) C ON (F.nroCuenta = C.nroCuenta)
	  		 WHERE F.nroCuenta = @idCuenta
			 ) A JOIN SUDO.Moneda B ON B.idMoneda = A.idMoneda
 	END;
GO

IF OBJECT_ID ('SUDO.FacturarCambioCuenta') IS NOT NULL DROP PROCEDURE SUDO.FacturarCambioCuenta
GO
CREATE PROCEDURE SUDO.FacturarCambioCuenta(@idFactCuenta int, @idFact bigint) AS 
	BEGIN
	
		DECLARE @idMoneda integer
		DECLARE @importe numeric(18,2)
		DECLARE @nombreTipoCuenta varchar(255)
		DECLARE @descripcion varchar(255)
		
		SELECT @idMoneda = idMoneda, @importe = importe, @descripcion = descripcion, @nombreTipoCuenta = nombre
		FROM(
			SELECT a.idMoneda, importe, descripcion,idTipoCuenta
			FROM(
				SELECT idMoneda, importe, descripcion, nroCuenta
				FROM SUDO.FacturacionCuenta
				WHERE idFactCuenta = @idFactCuenta
			) a join SUDO.Cuenta b on (a.nroCuenta = b.nroCuenta)
		) a JOIN SUDO.TipoCuenta b ON (a.idTipoCuenta = b.idTipoCuenta)
		
		INSERT INTO SUDO.Item (numeroFactura, idMoneda, idTrans, importe, descripcion, nombreTipoCuenta)
		VALUES(@idFact, @idMoneda, null, @importe, @descripcion, @nombreTipoCuenta);
		
		UPDATE SUDO.FacturacionCuenta
		SET facturado = 1
		WHERE idFactCuenta = @idFactCuenta
	END;
GO

---------------------------------------------------------------------------
--Tarjetas
-- dado un idUsuario de la tabla usuario obtiene las tarjetas(que no se han dado de baja) que pertenecen al mismo
IF OBJECT_ID ('SUDO.GetTarjetas') IS NOT NULL DROP PROCEDURE SUDO.GetTarjetas
GO
CREATE PROCEDURE SUDO.GetTarjetas(@idUsuario integer) AS 
	BEGIN
		SELECT idTarjeta, estado, E.descripcion, fechaVencimiento, fechaEmision, ult4num
	  	FROM (SELECT idTarjeta ,ult4num, fechaEmision, fechaVencimiento, estado, idEmisor
	  		  FROM(SELECT idCliente
			 	   FROM SUDO.Cliente
			 	   WHERE idUsuario = @idUsuario)idCliente
	  		  JOIN SUDO.Tarjeta c  ON idCliente.idCliente = c.idCliente) H
	    JOIN SUDO.Emisor E ON E.idEmisor = H.idEmisor
	    WHERE estado = 1
	END;
GO
-- dado una tarjeta realiza una baja logica
IF OBJECT_ID ('SUDO.DesasociarTarjeta') IS NOT NULL DROP PROCEDURE SUDO.DesasociarTarjeta
GO
CREATE PROCEDURE SUDO.DesasociarTarjeta(@idTarjeta bigint) AS 
	BEGIN
		UPDATE SUDO.Tarjeta
		SET estado = 0
		WHERE idTarjeta = @idTarjeta
	END;
GO
--Nueva Tarjeta
--obtiene los emisores de tarjetas
IF OBJECT_ID ('SUDO.GetEmisores') IS NOT NULL DROP PROCEDURE SUDO.GetEmisores
GO
CREATE PROCEDURE SUDO.GetEmisores AS 
	BEGIN
		select descripcion
		from SUDO.Emisor
	END;
GO
--asocia una nueva tarjeta al cliente
IF OBJECT_ID ('SUDO.AsociarTarjeta') IS NOT NULL DROP PROCEDURE SUDO.AsociarTarjeta
GO
CREATE PROCEDURE SUDO.AsociarTarjeta(@numero VARCHAR(16), @emisorDesc varchar(255), @fechaEmision datetime, @fechaVencimiento datetime, @codigoSeguridad varchar(255), @idUser integer) AS 
	BEGIN
		IF NOT EXISTS(SELECT @numero 
			  		  FROM SUDO.Tarjeta WHERE (prim12num + ult4num) = @numero)
			BEGIN     
				DECLARE @idCliente int
				DECLARE @idEmisor int

				SELECT @idEmisor = idEmisor
				FROM SUDO.Emisor
				WHERE descripcion = @emisorDesc

				SELECT @idCliente = idCliente
				FROM SUDO.Cliente
				WHERE idUsuario = @idUser
				
				INSERT INTO SUDO.Tarjeta (idCliente, prim12num, ult4num, idEmisor, fechaEmision, fechaVencimiento, codigoSeguridad)
				VALUES(@idCliente, SUDO.EncriptarSHA1(SUDO.GetPrim12Num(@numero)), SUDO.GetUlt4Num(@numero), @idEmisor,Convert(dateTime, @fechaEmision, 121),Convert(dateTime, @fechaVencimiento, 121), SUDO.EncriptarSHA1(@codigoSeguridad));
			END;
	END;
GO
---------------------------------------------------------------------------
--Depositos
--registra un deposito, verificando el saldo de la cuenta
IF OBJECT_ID ('SUDO.CrearDeposito') IS NOT NULL DROP PROCEDURE SUDO.CrearDeposito
GO
CREATE PROCEDURE SUDO.CrearDeposito(@idTarjeta bigint, @moneda varchar(255), @importe bigint, @fecha datetime, @nroCuenta bigint) AS 
	BEGIN
		DECLARE @saldo numeric(18,2)
		DECLARE @idMoneda integer
		
		SELECT @saldo = saldo
		FROM SUDO.Cuenta
		WHERE nroCuenta = @nroCuenta
		
		SELECT @idMoneda = idMoneda
		FROM SUDO.Moneda
		WHERE descripcion = @moneda
		
		IF (@saldo > @importe)
			BEGIN 
				INSERT INTO SUDO.Deposito (nroCuenta, idTarjeta, idMoneda, importe, fecha)
				VALUES(@nroCuenta, @idTarjeta, @idMoneda , @importe, Convert(dateTime, @fecha, 121));
				UPDATE SUDO.Cuenta SET saldo = @importe + @saldo
				WHERE (nroCuenta = @nroCuenta)    
			END;
	END;
GO
---------------------------------------------------------------------------
--Retiros
--Registra un retiro, verificando el saldo de la cuenta y el dni
IF OBJECT_ID ('SUDO.CrearRetiro') IS NOT NULL DROP PROCEDURE SUDO.CrearRetiro
GO
CREATE PROCEDURE SUDO.CrearRetiro(@nroCuenta bigint, @fecha datetime, @moneda varchar(255), @importe bigint, @nombreBanco varchar(255), @nroDoc numeric(18,0)) AS 
	BEGIN
		DECLARE @saldo numeric(18,2)
		DECLARE @idMoneda integer
		DECLARE @codigoBanco numeric(18,0)
		DECLARE @nroDocCliente numeric(18,0)
		DECLARE @idCliente integer

		SELECT @saldo = saldo, @idCliente = idCliente
		FROM SUDO.Cuenta
		WHERE nroCuenta = @nroCuenta
		
		SELECT @idMoneda = idMoneda
		FROM SUDO.Moneda
		WHERE descripcion = @moneda

		SELECT @codigoBanco = codigo
		FROM SUDO.Banco
		WHERE nombre = @nombreBanco

		SELECT @nroDocCliente = nroDoc
		FROM SUDO.Cliente
		WHERE idCliente = @idCliente
		
		IF (@saldo > @importe AND @nroDoc = @nroDocCliente)
			BEGIN 
				INSERT INTO SUDO.Retiro (idCuenta, idMoneda, codigoBanco, importe, fecha)
				VALUES(@nroCuenta, @idMoneda , @codigoBanco, @importe, Convert(dateTime, @fecha, 121));
				UPDATE SUDO.Cuenta SET saldo = @saldo - @importe
				WHERE (nroCuenta = @nroCuenta)
			END;
	END;
GO
---------------------------------------------------------------------------
--Form Transferencias
-- registra una transferencia, verificando el saldo de la cuenta y si la cuenta no esta "Pendiente de activacion" o "Cerrada"
IF OBJECT_ID ('SUDO.CrearTransferencia') IS NOT NULL DROP PROCEDURE SUDO.CrearTransferencia
GO
CREATE PROCEDURE SUDO.CrearTransferencia(@nroCuentaOrigen bigint, @importe bigint, @moneda varchar(255), @nroCuentaDest bigint, @fecha datetime) AS 
	BEGIN
		DECLARE @saldoOrigen numeric(18,2)
		DECLARE @saldoDest numeric(18,2)
		DECLARE @costo numeric(18,2)
		DECLARE @idMoneda integer
		DECLARE @codigoBanco numeric(18,0)
		DECLARE @nroDocCliente numeric(18,0)
		DECLARE @idCliente integer

		DECLARE @existeCuentaDest BIT
		SELECT @existeCuentaDest = 0
		IF EXISTS(SELECT *
		     	  FROM SUDO.Cuenta
				  WHERE nroCuenta = @nroCuentaDest)
		SELECT @existeCuentaDest = 1;
				
		SELECT @saldoOrigen = saldo, @costo = t.costo 
		FROM SUDO.Cuenta c JOIN SUDO.TipoCuenta t ON c.idTipoCuenta = t.idTipoCuenta
		WHERE (nroCuenta = @nroCuentaOrigen)

		SELECT @saldoDest = saldo
		FROM SUDO.Cuenta c JOIN SUDO.EstadoCuenta e ON c.idEstadoCuenta = e.idEstadoCuenta
		WHERE (c.nroCuenta = @nroCuentaDest)AND(e.descripcion != 'Cerrada')AND (e.descripcion != 'Pendiente de activacion')

		SELECT @idMoneda = idMoneda
		FROM SUDO.Moneda
		WHERE descripcion = @moneda

		IF(@nroCuentaOrigen = @nroCuentaDest)
			SELECT @costo = 0

		IF(@saldoOrigen > @importe AND @existeCuentaDest = 1)				 
		BEGIN 
			SET IDENTITY_INSERT SUDO.Transferencia ON
				INSERT INTO SUDO.Transferencia (nroCuentaDest, nroCuentaOrigen, idMoneda, costo, importe, fecha)
				VALUES(@nroCuentaDest, @nroCuentaOrigen , @idMoneda, @costo, @importe ,Convert(dateTime, @fecha, 121));
			SET IDENTITY_INSERT SUDO.Transferencia OFF

			UPDATE SUDO.Cuenta SET saldo = @saldoOrigen - @importe
			WHERE (nroCuenta = @nroCuentaOrigen)
			UPDATE SUDO.Cuenta SET saldo = @saldoDest + @importe
			WHERE (nroCuenta = @nroCuentaDest)
		END;
	END;
GO
---------------------------------------------------------------------------
--Form Consulta Saldo
--dado un numero de cuenta obtiene las ultimas 10 transferencias
IF OBJECT_ID ('SUDO.GetUltimas10Transferencias') IS NOT NULL DROP PROCEDURE SUDO.GetUltimas10Transferencias
GO
CREATE PROCEDURE SUDO.GetUltimas10Transferencias(@nroCuenta bigint) AS 
	BEGIN
		select TOP 10 idTrans, fecha, importe, costo, nroCuentaDest
		from SUDO.Transferencia
		where nroCuentaOrigen = @nroCuenta
		order by fecha desc
	END;
GO
--dado un numero de cuenta obtiene los ultimos 5 retiros
IF OBJECT_ID ('SUDO.GetUltimos5Retiros') IS NOT NULL DROP PROCEDURE SUDO.GetUltimos5Retiros
GO
CREATE PROCEDURE SUDO.GetUltimos5Retiros(@nroCuenta bigint) AS 
	BEGIN
		SELECT idCheque, codigo, c.fecha ,c.importe
	    FROM SUDO.Cheque c JOIN (SELECT TOP 5 codigo, fecha, importe
				  		 		 FROM SUDO.Retiro 
				 				 WHERE idCuenta = @nroCuenta
								 ORDER BY fecha desc) n
		ON n.codigo = c.idRetiro
	END;
GO
----dado un numero de cuenta obtiene los ultimos 5 depositos
IF OBJECT_ID ('SUDO.GetUltimos5depositos') IS NOT NULL DROP PROCEDURE SUDO.GetUltimos5depositos
GO
CREATE PROCEDURE SUDO.GetUltimos5depositos(@nroCuenta bigint) AS 
	BEGIN
		SELECT TOP 5 codigo, fecha, importe, ult4num
		FROM SUDO.Deposito D join SUDO.Tarjeta T ON (D.idTarjeta = T.idTarjeta)
		WHERE nroCuenta = @nroCuenta
		ORDER BY fecha desc
	END;
GO
---------------------------------------------------------------------------
--Form Listado Estadistico
--obtiene el listado 1
IF OBJECT_ID ('SUDO.GetListado1') IS NOT NULL DROP PROCEDURE SUDO.GetListado1
GO
CREATE PROCEDURE SUDO.GetListado1(@fechaInicio varchar(255), @fechaFin varchar(255)) AS 
	BEGIN
		SELECT TOP 5 A.idCliente, userName, Count(A.idCliente) cant
		FROM (SELECT idCliente
			  FROM SUDO.HistorialClientesInhabilitados
			  WHERE fecha BETWEEN Convert(dateTime, @fechaInicio, 121) AND Convert(dateTime, @fechaFin, 121)
			  )A JOIN (SELECT C.idCliente, userName
					   FROM SUDO.Cliente C JOIN SUDO.Usuario U ON C.idUsuario = U.idUsuario) C 
			  ON (A.idCliente = C.idCliente)
		GROUP BY A.idCliente, userName
		ORDER BY cant DESC
	END;
GO
--obtiene el listado 2
IF OBJECT_ID ('SUDO.GetListado2') IS NOT NULL DROP PROCEDURE SUDO.GetListado2
GO
CREATE PROCEDURE SUDO.GetListado2(@fechaInicio varchar(255), @fechaFin varchar(255)) AS 
	BEGIN
		SELECT idCliente, userName, cant
		FROM(
			SELECT TOP 5 C.idUsuario, cant, C.idCliente 
			FROM (SELECT idCliente, Count(nroCuentaOrigen) cant
				  FROM (SELECT nroCuentaOrigen
						FROM SUDO.Transferencia 
						WHERE (fecha BETWEEN Convert(dateTime, @fechaInicio, 121) AND Convert(dateTime, @fechaFin , 121))AND(facturado = 1)
				  )A JOIN SUDO.Cuenta C ON (nroCuentaOrigen = nroCuenta)
				  GROUP BY idCliente) T
				  JOIN SUDO.Cliente C ON (T.idCliente = C.idCliente)
				  ORDER BY cant DESC
			) A JOIN SUDO.Usuario U ON (A.idUsuario= U.idUsuario)
	END;
GO
--obtiene el listado 3
IF OBJECT_ID ('SUDO.GetListado3') IS NOT NULL DROP PROCEDURE SUDO.GetListado3
GO
CREATE PROCEDURE SUDO.GetListado3(@fechaInicio varchar(255), @fechaFin varchar(255)) AS 
	BEGIN
		SELECT A.idCliente, userName, cant
		FROM(
			SELECT TOP 5 C.idUsuario, cant , C.idCliente 
			FROM (SELECT idCliente, Count(nroCuentaOrigen) cant
				  FROM (SELECT nroCuentaOrigen
						FROM SUDO.Transferencia 
						WHERE (fecha BETWEEN Convert(dateTime, '2016-01-05 00:00:00.000', 121) AND Convert(dateTime, '2016-01-07 00:00:00.000' , 121))AND(nroCuentaOrigen = nroCuentaDest)
				  )A JOIN SUDO.Cuenta C ON (nroCuentaOrigen = nroCuenta)
				  GROUP BY idCliente) T
				  JOIN SUDO.Cliente C ON (T.idCliente = C.idCliente)
				  ORDER BY cant DESC
			) A JOIN SUDO.Usuario U ON (A.idUsuario= U.idUsuario)
	END;
GO
--obtiene el listado 4
IF OBJECT_ID ('SUDO.GetListado4') IS NOT NULL DROP PROCEDURE SUDO.GetListado4
GO
CREATE PROCEDURE SUDO.GetListado4(@fechaInicio varchar(255), @fechaFin varchar(255)) AS 
	BEGIN
		SELECT descripcion, cantidad
		FROM(
			SELECT TOP 5 idPais, sum(cant) cantidad
			FROM
			(
				SELECT C.idPais, Count(importe) cant
				FROM (SELECT fecha, idCuenta, importe FROM SUDO.Retiro WHERE fecha BETWEEN Convert(dateTime, @fechaInicio, 121) AND Convert(dateTime, @fechaFin, 121)) R
					 JOIN SUDO.Cuenta C ON C.nroCuenta = R.idCuenta
				GROUP BY idPais
			UNION
				SELECT C.idPais, Count(importe) cant
				FROM (SELECT fecha, nroCuenta, importe FROM SUDO.Deposito WHERE fecha BETWEEN Convert(dateTime, @fechaInicio, 121) AND Convert(dateTime, @fechaFin, 121)) R
					 JOIN SUDO.Cuenta C ON C.nroCuenta = R.nroCuenta
				GROUP BY idPais
			)A
			GROUP BY idPais
			ORDER BY cantidad DESC
			) t1 JOIN SUDO.Pais p ON (t1.idPais = p.idPais)
	END;
GO
--obtiene el listado 5
IF OBJECT_ID ('SUDO.GetListado5') IS NOT NULL DROP PROCEDURE SUDO.GetListado5
GO
CREATE PROCEDURE SUDO.GetListado5(@fechaInicio varchar(255), @fechaFin varchar(255)) AS 
	BEGIN
		SELECT nombre, total
		FROM SUDO.TipoCuenta T JOIN(
			SELECT nombreTipoCuenta, SUM(importe) total
			FROM(SELECT numero
			     FROM SUDO.Factura
				 WHERE (fecha BETWEEN Convert(dateTime, @fechaInicio, 121) AND Convert(dateTime, @fechaFin , 121))
			) A JOIN SUDO.Item I ON (A.numero = I.numeroFactura)
			GROUP BY nombreTipoCuenta )A
		ON (T.nombre = A.nombreTipoCuenta)	
	END;
GO

---------------------------------------------------------------------------
--Procedures utilizados en varias funcionalidades
--obtiene las monedas existentes
IF OBJECT_ID ('SUDO.GetMonedas') IS NOT NULL DROP PROCEDURE SUDO.GetMonedas
GO
CREATE PROCEDURE SUDO.GetMonedas AS 
	BEGIN
		select descripcion
		from SUDO.Moneda
	END;
GO
--Obtiene las tarjetas que no se han dado de baja de un cliente
IF OBJECT_ID ('SUDO.GetTarjetasCliente') IS NOT NULL DROP PROCEDURE SUDO.GetTarjetasCliente
GO
CREATE PROCEDURE SUDO.GetTarjetasCliente(@idUsuario integer) AS 
	BEGIN
		SELECT idTarjeta, E.descripcion, fechaVencimiento, ult4num
	  	FROM (SELECT idTarjeta ,ult4num, fechaVencimiento, idEmisor, estado
	  		  FROM(SELECT idCliente
			 	   FROM SUDO.Cliente
			 	   WHERE idUsuario = @idUsuario)idCliente
	  		  JOIN SUDO.Tarjeta c  ON idCliente.idCliente = c.idCliente) H
	    JOIN SUDO.Emisor E ON E.idEmisor = H.idEmisor
	    WHERE estado = 1
	END;
GO
--obtiene las cuentas de un cliente
IF OBJECT_ID ('SUDO.GetCuentas') IS NOT NULL DROP PROCEDURE SUDO.GetCuentas
GO
CREATE PROCEDURE SUDO.GetCuentas(@idUsuario integer) AS 
	BEGIN
		SELECT nroCuenta, descripcion
		FROM SUDO.EstadoCuenta e join (SELECT nroCuenta, idEstadoCuenta
						       		   FROM SUDO.Cuenta c join (SELECT idCliente
							   		   							FROM SUDO.Cliente
							   		   							WHERE idUsuario = @idUsuario) idC
							   		   ON (idC.idCliente = c.idCliente)) cc
		ON (e.idEstadoCuenta = cc.idEstadoCuenta)
	END;
GO
--obtiene los bancos existentes
IF OBJECT_ID ('SUDO.GetBancos') IS NOT NULL DROP PROCEDURE SUDO.GetBancos
GO
CREATE PROCEDURE SUDO.GetBancos AS 
	BEGIN
		select nombre
		from SUDO.Banco
	END;
GO
-- obtiene el saldo de una cuenta
IF OBJECT_ID ('SUDO.GetSaldo') IS NOT NULL DROP PROCEDURE SUDO.GetSaldo
GO
CREATE PROCEDURE SUDO.GetSaldo(@nroCuenta bigint) AS 
	BEGIN
		SELECT saldo
		FROM SUDO.Cuenta
		WHERE nroCuenta = @nroCuenta
	END;
GO
--asigna el tipo de moneda a las tablas Deposito, Retiro, Transferencia, Cheque, Item, Cuenta
IF OBJECT_ID ('SUDO.UpdateIdMoneda') IS NOT NULL DROP PROCEDURE SUDO.UpdateIdMoneda
GO
CREATE PROCEDURE SUDO.UpdateIdMoneda(@descripcionMoneda varchar(255)) AS 
	BEGIN
		DECLARE @idMoneda integer
		SELECT @idMoneda = idMoneda
		FROM SUDO.Moneda
		WHERE (descripcion = 'Dolar')

		UPDATE SUDO.Deposito SET idMoneda = @idMoneda
		UPDATE SUDO.Retiro SET idMoneda = @idMoneda
		UPDATE SUDO.Transferencia SET idMoneda = @idMoneda
		UPDATE SUDO.Cheque SET idMoneda = @idMoneda
		UPDATE SUDO.Item SET idMoneda = @idMoneda
		UPDATE SUDO.Cuenta SET idMoneda = @idMoneda
	END;
GO
--obtiene los tipos de cuenta existentes
IF OBJECT_ID ('SUDO.GetTiposCuenta') IS NOT NULL DROP PROCEDURE SUDO.GetTiposCuenta
GO
CREATE PROCEDURE SUDO.GetTiposCuenta AS 
	BEGIN
		SELECT idTipoCuenta, nombre
	  	FROM SUDO.TipoCuenta
	END;
GO
--STORED PROCEDURE PARA MOSTRAR LISTADO DE LOS ROLES DEL SISTEMA
IF OBJECT_ID ('SUDO.SP_LISTAR_ROLES') IS NOT NULL DROP PROCEDURE SUDO.SP_LISTAR_ROLES
GO
CREATE PROCEDURE SUDO.SP_LISTAR_ROLES AS
	BEGIN
		SELECT idRol, nombreRol FROM SUDO.Rol
	END;
GO 
---------------------------------------------------------------------------
--procesos utilizados para la creacion y migracion de la base de datos
--retorna obtiene el saldo inicial de la cuenta, aplicando la ecuacion esplicada en el archivo Estrategia.pdf
IF OBJECT_ID ('SUDO.EncriptarSHA1') IS NOT NULL DROP FUNCTION SUDO.EncriptarSHA1;
GO
CREATE FUNCTION SUDO.EncriptarSHA1(@str12 varchar(12))RETURNS varchar(255) AS 
BEGIN
	RETURN HASHBYTES('SHA1', @str12)
END;
GO

IF OBJECT_ID ('SUDO.GetSaldoInicial') IS NOT NULL DROP FUNCTION SUDO.GetSaldoInicial;
GO
CREATE FUNCTION SUDO.GetSaldoInicial(@nroCuenta bigint)RETURNS bigint AS 
BEGIN
	DECLARE @sumaDeposito bigint
	DECLARE @sumaRetiro bigint
	DECLARE @sumaImporteTransferenciaEgreso bigint
	DECLARE @sumaImporteTransferenciaIngreso bigint
	
	SELECT @sumaDeposito = SUM(importe)
	FROM SUDO.Deposito 
	WHERE nroCuenta = @nroCuenta
	
	SELECT @sumaRetiro = SUM(importe)
	FROM SUDO.Retiro
	WHERE idCuenta = @nroCuenta
	
	SELECT @sumaImporteTransferenciaEgreso = SUM(importe)
	FROM SUDO.Transferencia
	WHERE nroCuentaDest = @nroCuenta
	
	SELECT	@sumaImporteTransferenciaIngreso = SUM(importe)
	FROM SUDO.Transferencia
	WHERE nroCuentaOrigen = @nroCuenta

	RETURN @sumaDeposito - @sumaRetiro - @sumaImporteTransferenciaEgreso + @sumaImporteTransferenciaIngreso;
END;
GO
--asocia la tabla Funcionalidad con la tabla Rol
IF OBJECT_ID ('SUDO.AsociarFuncionalidadXRol') IS NOT NULL DROP PROCEDURE SUDO.AsociarFuncionalidadXRol
GO
CREATE PROCEDURE SUDO.AsociarFuncionalidadXRol(@NombreRol VARCHAR(255), @NombreFuncionalidad VARCHAR(255)) AS
	BEGIN
		INSERT INTO SUDO.FuncionalidadXRol(idRol, idFuncionalidad)
			SELECT r.idRol, f.idFuncionalidad
			FROM SUDO.Rol r JOIN SUDO.Funcionalidad f ON (r.nombreRol = @NombreRol AND f.nombre = @NombreFuncionalidad)
	END;
GO
--asocia la tabla Usuario con la tabla Rol
IF OBJECT_ID ('SUDO.AsociarUsuarioXRol') IS NOT NULL DROP PROCEDURE SUDO.AsociarUsuarioXRol
GO
CREATE PROCEDURE SUDO.AsociarUsuarioXRol(@UserName VARCHAR(255), @NombreRol VARCHAR(255)) AS
	BEGIN
		INSERT INTO SUDO.UsuarioXRol(idRol, idUsuario)
			SELECT r.idRol, u.idUsuario
			FROM SUDO.Rol r JOIN SUDO.Usuario u ON (r.nombreRol = @NombreRol AND u.userName = @UserName)
	END;
GO
--crea un nuevo estado de cuenta
IF OBJECT_ID ('SUDO.NuevoEstadoCuentaDesc') IS NOT NULL DROP PROCEDURE SUDO.NuevoEstadoCuentaDesc
GO
CREATE PROC SUDO.NuevoEstadoCuentaDesc @Desc VARCHAR(25) AS
	BEGIN
		INSERT INTO SUDO.EstadoCuenta(descripcion)
			VALUES(@Desc)
	END;
GO
--crea una nueva funcionalidad
IF OBJECT_ID ('SUDO.AgregarFuncionalidadNombre') IS NOT NULL DROP PROCEDURE SUDO.AgregarFuncionalidadNombre
GO
CREATE PROC SUDO.AgregarFuncionalidadNombre(@Nombre VARCHAR(40)) AS
	BEGIN
		INSERT INTO SUDO.Funcionalidad(nombre)
			VALUES(@Nombre)
	END;
GO
--crea un nuevo tipo de cuenta
IF OBJECT_ID ('SUDO.NuevoTipoCuenta') IS NOT NULL DROP PROCEDURE SUDO.NuevoTipoCuenta
GO
CREATE PROC SUDO.NuevoTipoCuenta(@Nombre VARCHAR(50), @Duracion SMALLINT, @Costo NUMERIC(10,2)) AS
	BEGIN
		INSERT INTO SUDO.TipoCuenta(nombre, duracionEnDias, costo)
			VALUES(@Nombre, @Duracion, @Costo)
	END;
GO
--crea un nuevo rol
IF OBJECT_ID ('SUDO.NuevoRol') IS NOT NULL DROP PROCEDURE SUDO.NuevoRol
GO
CREATE PROCEDURE SUDO.NuevoRol(@Nombre VARCHAR(255), @Estado BIT) AS
	BEGIN
		INSERT INTO SUDO.Rol(nombreRol, estado)
			VALUES(@Nombre, @Estado)
	END;
GO
--crea un nuevo usuario
IF OBJECT_ID ('SUDO.NuevoUsuario') IS NOT NULL DROP PROCEDURE SUDO.NuevoUsuario
GO
CREATE PROCEDURE SUDO.NuevoUsuario(@UserName VARCHAR(255), @Password VARCHAR(255), @FechaCreacion datetime, @FechaDeUltimaModificacion datetime, @PreguntaSecreta VARCHAR(255), @CantIntentosFallidos TINYINT, @Estado BIT, @Administrador BIT) AS
	BEGIN
		INSERT INTO SUDO.Usuario(userName, userPassword, fechaCreacion, fechaDeUltimaModificacion, preguntaSecreta, respuestaSecreta, cantIntentosFallidos, estado, administrador)
		VALUES(@UserName, ISNULL (@Password , '5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c='),
			   ISNULL (@FechaCreacion , GETDATE()), ISNULL (@FechaDeUltimaModificacion , GETDATE()),
			   @PreguntaSecreta, '6QWKsZj2kI9wIRGwwPtbNvmdAFVFIYhsQOKJGzSdx6E=', @CantIntentosFallidos, @Estado,
			   @Administrador)
	END;
GO

---------------------------------------------------------------------------
			--  	Creacion de triggers
---------------------------------------------------------------------------
IF OBJECT_ID ('SUDO.OnInsertDeposito', 'TR') IS NOT NULL DROP TRIGGER SUDO.OnInsertDeposito;		
GO
CREATE TRIGGER SUDO.OnInsertDeposito
ON SUDO.Deposito
AFTER INSERT
AS 
	BEGIN
		DECLARE @idDeposito numeric(18,0)
		DECLARE @fechaIngreso datetime
		
		SELECT @idDeposito = codigo, @fechaIngreso = fecha
		FROM inserted;
		
		INSERT INTO SUDO.Comprobante(idDeposito, fechaIngreso)
		VALUES(@idDeposito, @fechaIngreso);
	END;
GO

---------------------------------------------------------------------------
			--  	Creacion de datos
---------------------------------------------------------------------------

-----------Creacion de los 11 nombres de Funcionalidad-----------
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'ABM de rol'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'ABM de usuario'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'ABM de cliente'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'ABM de cuenta'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'consulta saldos'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'asociar/desasociar tarjetas de credito'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'depositos'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'retiro'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'transferencias'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'facturacion'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'listado estadistico'

PRINT 'Tabla SUDO.Funcionalidad creacion de los 11 nombres de Funcionalidad'
GO

-----------Creacion de roles-----------
-----------Creacion Administrador General-----------
EXEC SUDO.NuevoRol @Nombre = 'Administrador General', @Estado = 1

EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'ABM de rol'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'ABM de usuario'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'ABM de cliente'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'ABM de cuenta'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'asociar/desasociar tarjetas de credito'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'depositos'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'retiro'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'transferencias'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'facturacion'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'consulta saldos'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador General', @NombreFuncionalidad  = 'listado estadistico'

PRINT 'Tabla SUDO.rol creacion de rol Administrador General'
GO
-----------Creacion Administrador-----------
EXEC SUDO.NuevoRol @Nombre = 'Administrador', @Estado = 1

EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador', @NombreFuncionalidad  = 'ABM de usuario'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador', @NombreFuncionalidad  = 'ABM de cliente'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador', @NombreFuncionalidad  = 'ABM de cuenta'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador', @NombreFuncionalidad  = 'facturacion'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador', @NombreFuncionalidad  = 'consulta saldos'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador', @NombreFuncionalidad  = 'listado estadistico'

PRINT 'Tabla SUDO.rol creacion de rol Administrador'
GO

-----------Creacion Cliente-----------
EXEC SUDO.NuevoRol @Nombre = 'Cliente', @Estado = 1

EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Cliente', @NombreFuncionalidad  = 'ABM de cuenta'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Cliente', @NombreFuncionalidad  = 'depositos'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Cliente', @NombreFuncionalidad  = 'retiro'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Cliente', @NombreFuncionalidad  = 'transferencias'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Cliente', @NombreFuncionalidad  = 'facturacion'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Cliente', @NombreFuncionalidad  = 'consulta saldos'
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Cliente', @NombreFuncionalidad  = 'asociar/desasociar tarjetas de credito'

PRINT 'Tabla SUDO.rol creacion de rol Cliente'
GO
-----------Creacion Moneda 'Dolar'-----------
EXEC SUDO.NuevaMonedaDesc @Desc = 'Dolar'

PRINT 'Tabla SUDO.Moneda creacion moneda Dolar'
GO

-----------Creacion de los 4 EstadoCuenta-----------
EXEC SUDO.NuevoEstadoCuentaDesc @Desc = 'Pendiente de activacion'
EXEC SUDO.NuevoEstadoCuentaDesc @Desc = 'Cerrada'
EXEC SUDO.NuevoEstadoCuentaDesc @Desc = 'Inhabilitada'
EXEC SUDO.NuevoEstadoCuentaDesc @Desc = 'Habilitada'

PRINT 'Tabla SUDO.EstadoCuenta creacion de 4 EstadoCuenta creados'
GO

-----------Creacion de los 4 TipoCuenta-----------
EXEC SUDO.NuevoTipoCuenta @Nombre = 'Oro', @Duracion = 1456, @Costo = 300     --4 AÑOS
EXEC SUDO.NuevoTipoCuenta @Nombre = 'Plata', @Duracion = 1092, @Costo = 200   --3 AÑOS
EXEC SUDO.NuevoTipoCuenta @Nombre = 'Bronce', @Duracion = 728, @Costo = 100   --2 AÑOS
EXEC SUDO.NuevoTipoCuenta @Nombre = 'Gratuita', @Duracion = 1820 , @Costo = 0  --5 AÑOS

PRINT 'Tabla SUDO.TipoCuenta creacion de los 4 TipoCuenta'
GO

---------------------------------------------------------------------------
			--  	Migracion de datos
---------------------------------------------------------------------------
-----------Migracion EstadoCuenta-----------
INSERT INTO SUDO.EstadoCuenta(descripcion)
	SELECT DISTINCT Cuenta_Estado
	  FROM gd_esquema.Maestra
	 WHERE Cuenta_Estado IS NOT NULL

PRINT 'Tabla SUDO.EstadoCuenta Migrada'
GO

-----------Migracion Pais-----------
SET IDENTITY_INSERT SUDO.Pais ON

	INSERT INTO SUDO.Pais(idPais, descripcion)
		SELECT * 
		FROM (
			 SELECT DISTINCT Cli_Pais_Codigo, Cli_Pais_Desc 
			   FROM gd_esquema.Maestra 
			  WHERE Cli_Pais_Codigo IS NOT NULL
			  UNION
			 SELECT DISTINCT Cuenta_Pais_Codigo, Cuenta_Pais_Desc 
			   FROM gd_esquema.Maestra
			  WHERE Cuenta_Pais_Codigo IS NOT NULL
			) AS p

SET IDENTITY_INSERT SUDO.Pais OFF

PRINT 'Tabla SUDO.Pais Migrada'
GO

-----------Migracion TipoDoc-----------
SET IDENTITY_INSERT SUDO.TipoDoc ON

	INSERT INTO SUDO.TipoDoc(idTipoDoc, descripcion)
		SELECT DISTINCT Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc 
		  FROM gd_esquema.Maestra
		  WHERE Cli_Tipo_Doc_Cod IS NOT NULL

SET IDENTITY_INSERT SUDO.TipoDoc OFF

PRINT 'Tabla SUDO.TipoDoc Migrada'
GO

-----------Migracion Cliente-----------
INSERT INTO SUDO.Cliente( nombre, apellido, mail, fechaDeNac, idTipoDoc, nroDoc, dirCalle, dirNumero, dirPiso, dirDepto, idPais)
	SELECT Cli_Nombre, Cli_apellido, Cli_Mail, Cli_Fecha_Nac, idTipoDoc, Cli_Nro_Doc, Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Pais_Codigo
		FROM (
			SELECT DISTINCT Cli_Nro_Doc, Cli_Nombre, Cli_apellido, Cli_Mail, Cli_Fecha_Nac, idTipoDoc, Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Pais_Codigo
			FROM gd_esquema.Maestra m 
			JOIN SUDO.TipoDoc d ON m.Cli_Tipo_Doc_Cod = d.idTipoDoc
			WHERE Cli_Tipo_Doc_Cod IS NOT NULL
		) m_td 
	JOIN SUDO.Pais P ON (m_td.Cli_Pais_Codigo = P.idPais)

PRINT 'Tabla SUDO.Cliente Migrada'
GO

-----------Migracion Factura-----------
INSERT INTO SUDO.Factura(numero, fecha, idCliente)
	SELECT DISTINCT Factura_Numero, Factura_Fecha, c.idCliente
	FROM gd_esquema.Maestra m 
	JOIN SUDO.Cliente c ON m.Cli_Nro_Doc = c.nroDoc AND m.Cli_Tipo_Doc_Cod = c.idTipoDoc
	WHERE Factura_Numero IS NOT NULL

PRINT 'Tabla SUDO.Factura Migrada'
GO

-----------Migracion Emisor Tarjeta -----------
INSERT INTO SUDO.Emisor (descripcion)
	SELECT DISTINCT Tarjeta_Emisor_Descripcion
	FROM gd_esquema.Maestra m 
	WHERE Tarjeta_Emisor_Descripcion IS NOT NULL

PRINT 'Tabla SUDO.Emisor Migrada'
GO

-----------Migracion Tarjeta-----------
IF OBJECT_ID ('SUDO.GetUlt4Num') IS NOT NULL DROP FUNCTION SUDO.GetUlt4Num;
GO
CREATE FUNCTION SUDO.GetUlt4Num(@numero varchar(16))RETURNS varchar(4) AS 
BEGIN
	RETURN SUBSTRING(@numero, DATALENGTH(@numero)-3, 4)
END;
GO
IF OBJECT_ID ('SUDO.GetPrim12Num') IS NOT NULL DROP FUNCTION SUDO.GetPrim12Num;
GO
CREATE FUNCTION SUDO.GetPrim12Num(@numero varchar(16))RETURNS varchar(12) AS 
BEGIN
	RETURN SUBSTRING(@numero, 1, 12)
END;
GO

INSERT INTO SUDO.Tarjeta(ult4num, prim12num, fechaEmision, fechaVencimiento, codigoSeguridad, idEmisor, idCliente)
	SELECT SUDO.GetUlt4Num(Tarjeta_Numero), SUDO.GetPrim12Num(Tarjeta_Numero), Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, SUDO.EncriptarSHA1(Tarjeta_Codigo_Seg), idEmisor, idCliente
	FROM (SELECT DISTINCT Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Codigo_Seg, Tarjeta_Emisor_Descripcion, c.idCliente
		  FROM gd_esquema.Maestra m 
		  JOIN SUDO.Cliente c ON m.Cli_Nro_Doc = c.nroDoc AND m.Cli_Tipo_Doc_Cod = c.idTipoDoc
		  WHERE Tarjeta_Numero IS NOT NULL
		  ) m
	JOIN SUDO.Emisor e ON e.descripcion = Tarjeta_Emisor_Descripcion

PRINT 'Tabla SUDO.Tarjeta Migrada'
GO

-----------Migracion Cuenta-----------
INSERT INTO SUDO.Cuenta(nroCuenta, fechaCreacion, fechaCierre, idPais, idEstadoCuenta, idCliente)
	SELECT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, idPais, idEstadoCuenta, idCliente
	FROM ( SELECT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, descEstadoCuenta, idPais, idCliente
		   FROM ( SELECT DISTINCT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, Cuenta_Pais_Codigo, (ISNULL ( m.Cuenta_Estado , 'Habilitada')) descEstadoCuenta, idCliente
	  			  FROM gd_esquema.Maestra m 
				  JOIN SUDO.Cliente c ON ((m.Cli_Nro_Doc = c.nroDoc) AND (m.Cli_Tipo_Doc_Cod = c.idTipoDoc))
				  WHERE Cuenta_Numero is not null
	  			) m_c 
		   JOIN SUDO.Pais p ON (m_c.Cuenta_Pais_Codigo = p.idPais)
		) m_c_p 
	JOIN SUDO.EstadoCuenta ec ON (m_c_p.descEstadoCuenta = ec.descripcion)

UPDATE SUDO.Cuenta SET idTipoCuenta = (SELECT idTipoCuenta
										FROM SUDO.TipoCuenta
										WHERE (nombre = 'Gratuita')),
						fechaCierre = DATEADD (day ,
											  (SELECT duracionEnDias
											   FROM SUDO.TipoCuenta
											   WHERE (nombre = 'Gratuita')) ,
											   Convert(dateTime, '2016-01-01 00:00:00.000', 121))

-- SELECT * FROM SUDO.Cuenta 
PRINT 'Tabla SUDO.Cuenta Migrada'
GO

-----------Migracion Banco-----------
SET IDENTITY_INSERT SUDO.Banco ON

	INSERT INTO SUDO.Banco(codigo, nombre, direccion)
		SELECT DISTINCT Banco_Cogido, Banco_Nombre, Banco_Direccion 
		FROM gd_esquema.Maestra 
		WHERE Banco_Cogido IS NOT NULL

SET IDENTITY_INSERT SUDO.Banco OFF

-- SELECT * FROM SUDO.Banco 
PRINT 'Tabla SUDO.Banco Migrada'
GO

-----------Migracion Retiro-----------
SET IDENTITY_INSERT SUDO.Retiro ON

	INSERT INTO SUDO.Retiro(codigo, fecha, importe, idCuenta, codigoBanco)
		SELECT DISTINCT Retiro_Codigo, Retiro_Fecha, Retiro_Importe, nroCuenta, Banco_Cogido
	    FROM gd_esquema.Maestra m 
		JOIN SUDO.Cuenta c ON m.Cuenta_Numero = c.nroCuenta
		WHERE Retiro_Codigo IS NOT NULL

SET IDENTITY_INSERT SUDO.Retiro OFF

-- SELECT * FROM SUDO.Retiro 
PRINT 'Tabla SUDO.Retiro Migrada'
GO

-----------Migracion Cheque-----------
SET IDENTITY_INSERT SUDO.Cheque ON

	INSERT INTO SUDO.Cheque(idCheque, idRetiro ,fecha, importe, codigoBanco)
		SELECT DISTINCT Cheque_Numero, Retiro_Codigo, Cheque_Fecha, Cheque_Importe, Banco_Cogido 
		FROM gd_esquema.Maestra 
		WHERE Cheque_Numero IS NOT NULL

SET IDENTITY_INSERT SUDO.Cheque OFF

-- SELECT * FROM SUDO.Cheque 
PRINT 'Tabla SUDO.Cheque Migrada'
GO

-----------Migracion Deposito-----------
SET IDENTITY_INSERT SUDO.Deposito ON

	INSERT INTO SUDO.Deposito(codigo, fecha, importe, nroCuenta, idTarjeta)
	SELECT Deposito_Codigo, Deposito_Fecha, Deposito_Importe, nroCuenta, idTarjeta
	FROM (SELECT DISTINCT Deposito_Codigo, Deposito_Fecha, Deposito_Importe, nroCuenta ,Tarjeta_Numero
		  FROM gd_esquema.Maestra m 
		  JOIN SUDO.Cuenta c on m.Cuenta_Numero = c.nroCuenta
		  WHERE Deposito_Codigo IS NOT NULL
		 ) m_c 
	JOIN SUDO.Tarjeta t on m_c.Tarjeta_Numero = (t.prim12num + t.ult4num)

SET IDENTITY_INSERT SUDO.Deposito OFF

-- SELECT * FROM SUDO.Deposito -- 25.285
PRINT 'Tabla SUDO.Deposito Migrada'
GO

-----------Migracion Transferencia-----------
INSERT INTO SUDO.Transferencia(fecha, importe, costo, nroCuentaOrigen, nroCuentaDest, auxFacturaNumero)
	SELECT Transf_Fecha, Trans_Importe, Trans_Costo_Trans, m_c.nroCuenta, c2.nroCuenta, Factura_Numero
	FROM(SELECT Cuenta_Dest_Numero, Transf_Fecha, Trans_Importe, Trans_Costo_Trans, Cuenta_Dest_Estado, Cuenta_Dest_Fecha_Cierre, Cuenta_Dest_Fecha_Creacion, Cuenta_Dest_Pais_Codigo, nroCuenta, Factura_Numero
		 FROM gd_esquema.Maestra m join SUDO.Cuenta c on (m.Cuenta_Numero = c.nroCuenta)
		 WHERE Cuenta_Dest_Numero IS NOT NULL
	)m_c join SUDO.Cuenta c2 on ((m_c.Cuenta_Dest_Numero = c2.nroCuenta)AND(m_c.Cuenta_Dest_Fecha_Creacion = c2.fechaCreacion)AND(m_c.Cuenta_Dest_Pais_Codigo = c2.idPais))


PRINT 'Tabla SUDO.Transferencia Migrada'
GO

-----------Migracion Item-----------
INSERT INTO SUDO.Item(numeroFactura, importe, descripcion, idTrans,nombreTipoCuenta)
SELECT Factura_Numero, Item_Factura_Importe, Item_Factura_Descr, idTrans , 'Gratuita'
FROM (select Factura_Numero, Item_Factura_Descr, Item_Factura_Importe, Cuenta_Numero, Cuenta_Dest_Numero, Transf_Fecha, Trans_Importe
	  from gd_esquema.Maestra
	  where Item_Factura_Descr IS NOT NULL AND Item_Factura_Importe IS NOT NULL)I
JOIN SUDO.Transferencia T ON  (T.nroCuentaOrigen = I.Cuenta_Numero AND T.nroCuentaDest = I.Cuenta_Dest_Numero AND T.fecha = I.Transf_Fecha AND T.importe = I.Trans_Importe AND I.Factura_Numero = T.auxFacturaNumero)

PRINT 'Tabla SUDO.Item Migrada'
GO

-----------Actialiso la Facturacion de transferencia-----------
DECLARE @idTrans integer
DECLARE @auxFacturaNumero numeric(18,0)
DECLARE @facturado BIT

DECLARE CursorTransferencia CURSOR FOR (SELECT idTrans, auxFacturaNumero, facturado
							  			FROM SUDO.Transferencia)
OPEN CursorTransferencia FETCH NEXT FROM CursorTransferencia INTO @idTrans, @auxFacturaNumero, @facturado

WHILE (@@FETCH_STATUS = 0)
	BEGIN
		SELECT @facturado = 0
		IF EXISTS (SELECT *
				   FROM SUDO.Transferencia
				   WHERE auxFacturaNumero IS NOT NULL AND idTrans = @idTrans)
				   SELECT @facturado = 1
	
		UPDATE SUDO.Transferencia SET facturado = @facturado
		
		WHERE CURRENT OF CursorTransferencia;									 
		FETCH NEXT FROM CursorTransferencia INTO @idTrans, @auxFacturaNumero, @facturado
	END
CLOSE CursorTransferencia
DEALLOCATE CursorTransferencia

--elimino la columna auxiliar de SUDO.Transferencia
ALTER TABLE SUDO.Transferencia DROP COLUMN auxFacturaNumero;
GO


-----------Creacion de Usuarios y creacion de la relacion con los clientes-----------
DECLARE @idUsuario numeric(18,0)
DECLARE @mail varchar(255)

DECLARE CursorCli CURSOR FOR (SELECT mail, idUsuario
							  FROM SUDO.Cliente)
OPEN CursorCli FETCH NEXT FROM CursorCli INTO @Mail, @idUsuario
WHILE (@@FETCH_STATUS = 0)
	BEGIN
		EXEC SUDO.NuevoUsuario @UserName= @Mail, @Password= NULL, @FechaCreacion= NULL, @FechaDeUltimaModificacion= NULL,
							   @PreguntaSecreta='quien?', @CantIntentosFallidos= 0, @Estado= 1, @Administrador = 0
		EXEC SUDO.AsociarUsuarioXRol @NombreRol = 'Cliente', @UserName= @Mail
		UPDATE SUDO.Cliente SET idUsuario =	(SELECT TOP(1) idUsuario
											 FROM SUDO.Usuario
											 ORDER BY idUsuario DESC)
		WHERE CURRENT OF CursorCli;									 
		FETCH NEXT FROM CursorCli INTO @Mail, @idUsuario
	END
CLOSE CursorCli
DEALLOCATE CursorCli

PRINT 'Usuarios creados y relacionados con Cliente'
GO
-----------Actualizo el saldo de las cuentas con la ecuacion:-----------
-----------SALDO = sumaDeposito - sumaRetiro + sumaImporteTransferenciaEgreso + sumaImporteTransferenciaIngreso - sumaCostoTransferencia -----------
-----------cabe destacar que como el costo de transferencia para todas las CUENTAS es 0 no se tiene en cuenta
DECLARE @idCuenta numeric(18,0)
DECLARE @saldo numeric(18,2)

DECLARE CursorCuenta CURSOR FOR (SELECT nroCuenta, saldo
							  	 FROM SUDO.Cuenta)
OPEN CursorCuenta FETCH NEXT FROM CursorCuenta INTO @idCuenta, @saldo

WHILE (@@FETCH_STATUS = 0)
	BEGIN
		UPDATE SUDO.Cuenta SET saldo =SUDO.GetSaldoInicial(@idCuenta)
		
		WHERE CURRENT OF CursorCuenta;									 
		FETCH NEXT FROM CursorCuenta INTO @idCuenta, @saldo
	END
CLOSE CursorCuenta
DEALLOCATE CursorCuenta

PRINT 'Saldo de cuentas calculado'
GO

EXEC SUDO.UpdateIdMoneda @descripcionMoneda = 'Dolar'
GO

-- Encripto los primeros 12 numeros de la tarjeta --

UPDATE SUDO.Tarjeta SET prim12num = SUDO.EncriptarSHA1(prim12num)

-------------Creacion de AK cliente x mail

USE [GD1C2015]
GO
-- Find an existing index named AK_UnitMeasure_Name and delete it if found
IF EXISTS (SELECT name from sys.indexes
           WHERE name = N'AK_Cliente_mail') 
   DROP INDEX AK_Cliente_mail ON [SUDO].[Cliente];
GO
-- Create a unique index called AK_UnitMeasure_Name
-- on the Production.UnitMeasure table using the Name column.
CREATE UNIQUE INDEX AK_Cliente_mail 
   ON [SUDO].[Cliente] ([mail]); 
GO

PRINT 'Indice unique Cliente por mail creada'
GO

--se declara a lo ultimo por que si se declara antes de migrar los datos a la tabla retiro y antes de migrar la tabla cheque
--se duplicarian los cheques
IF OBJECT_ID ('SUDO.OnInsertRetiro', 'TR') IS NOT NULL DROP TRIGGER SUDO.OnInsertRetiro;			
GO
CREATE TRIGGER SUDO.OnInsertRetiro
ON SUDO.Retiro
AFTER INSERT
AS 
	BEGIN
		DECLARE @idRetiro numeric(18,0)
		DECLARE @codigoBanco numeric(18,0)
		DECLARE @idMoneda integer
		DECLARE @fechaIngreso datetime
		DECLARE @importe numeric(18,2)
	
		SELECT @idRetiro = codigo, @codigoBanco = codigoBanco, @idMoneda=idMoneda, @fechaIngreso = fecha, @importe=importe
		FROM inserted;
		
		INSERT INTO SUDO.Cheque(idRetiro, codigoBanco, idMoneda, fecha, importe)
		VALUES(@idRetiro, @codigoBanco, @idMoneda, @fechaIngreso, @importe);
	END;
GO

-----------Creacion de los Usuarios-----------
EXEC SUDO.NuevoUsuario @UserName= 'admin', @Password= NULL, @FechaCreacion= NULL, @FechaDeUltimaModificacion= NULL,@PreguntaSecreta='quien?', @CantIntentosFallidos= 0, @Estado= 1, @Administrador = 1

EXEC SUDO.AsociarUsuarioXRol @NombreRol = 'Administrador General', @UserName= 'admin'

PRINT 'Tabla SUDO.Usuario creacion de Usuarios'
GO

--Stores Procedures para agregar al script inicial
-------------------------------------------------------------------------------------------------------------
--LISTA LOS USUARIOS .
-------------------------------------------------------------------------------------------------------------
--Referencias False = 0 | True = 1
-------------------------------------------------------------------------------------------------------------

IF OBJECT_ID ('SUDO.SP_LISTADO_USUARIOS') IS NOT NULL DROP PROCEDURE SUDO.SP_LISTADO_USUARIOS
GO
CREATE PROCEDURE SUDO.SP_LISTADO_USUARIOS(
	@USUARIO     	VARCHAR(255) = NULL,
    @ROL   			INTEGER = NULL, 
	@FECHAALTA		DATETIME = NULL,
	@FECHAMODIF		DATETIME = NULL
			 
) AS
BEGIN

	SELECT U.idUsuario as id, U.userName AS Usuario, U.fechaCreacion AS fechaCreacion, U.fechaDeUltimaModificacion AS fechaUltimaModificacion
     FROM SUDO.Usuario as U
	 LEFT JOIN SUDO.UsuarioXRol as UR on UR.idUsuario = U.idUsuario
	 WHERE ( @USUARIO     IS NULL OR (RTRIM(U.userName)     LIKE RTRIM(@USUARIO) + '%')) 
		AND ( @ROL     	  IS NULL OR ( UR.idRol = @ROL )) 
		AND ( @FECHAALTA  IS NULL OR (Convert(date, U.fechaCreacion, 121)) = (Convert(date, @FECHAALTA, 121)))
		AND ( @FECHAMODIF  IS NULL OR (Convert(date, U.fechaDeUltimaModificacion, 121)) = (Convert(date, @FECHAMODIF, 121)))
     ORDER BY U.fechaDeUltimaModificacion
END
GO

------------------------------------------------------------------------------------------------------------------------------------

--STORED PROCEDURE PARA ALTA DE USUARIO
IF OBJECT_ID ('SUDO.SP_ALTA_USUARIO') IS NOT NULL DROP PROCEDURE SUDO.SP_ALTA_USUARIO 
GO
CREATE PROCEDURE SUDO.SP_ALTA_USUARIO  
--PARAMETROS DE ENTRADA
  @USUARIO				VARCHAR(255),
  @ROL					INTEGER,
  @PASSWORD				VARCHAR(255),
  @FECHACREA			DATETIME,
  @FECHAMODIF   		DATETIME,
  @PREGUNTASECRETA  	VARCHAR(255),
  @RTASECRETA  			VARCHAR(255), 
  @CANTINTENTOSFALL		TINYINT,
  @ESTADO				BIT,
--PARAMETRO DE SALIDA
  @VALOR     INT OUTPUT 

AS
SET NOCOUNT ON 
SET ANSI_WARNINGS OFF 

DECLARE @IDUSER     INT
DECLARE @EXISTE_USER INT

SET @EXISTE_USER = 0

BEGIN TRAN

	SELECT * FROM SUDO.Usuario
	 WHERE userName     = @USUARIO

	SET @EXISTE_USER = @@ROWCOUNT

	IF @EXISTE_USER = 0

		BEGIN 	
			INSERT INTO SUDO.Usuario (userName, userPassword, fechaCreacion, fechaDeUltimaModificacion, preguntaSecreta, respuestaSecreta, cantIntentosFallidos, estado)
 				 VALUES (@USUARIO, @PASSWORD, @FECHACREA, @FECHAMODIF, @PREGUNTASECRETA, @RTASECRETA, @CANTINTENTOSFALL, @ESTADO)
			
			INSERT INTO SUDO.UsuarioXRol(idRol, idUsuario)
				VALUES((SELECT MAX(idUsuario) FROM SUDO.Usuario), @ROL)
			SET @VALOR = 0
		    COMMIT TRAN
        END 
		
		
  
	ELSE

		BEGIN 
			SET @VALOR = 1
            ROLLBACK TRAN
        END
GO