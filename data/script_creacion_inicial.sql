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
IF OBJECT_ID ('SUDO.Transferencia') IS NOT NULL DROP TABLE SUDO.Transferencia
IF OBJECT_ID ('SUDO.Tarjeta') IS NOT NULL DROP TABLE SUDO.Tarjeta
IF OBJECT_ID ('SUDO.Retiro') IS NOT NULL DROP TABLE SUDO.Retiro
IF OBJECT_ID ('SUDO.Cuenta') IS NOT NULL DROP TABLE SUDO.Cuenta
IF OBJECT_ID ('SUDO.Cheque') IS NOT NULL DROP TABLE SUDO.Cheque
IF OBJECT_ID ('SUDO.Item') IS NOT NULL DROP TABLE SUDO.Item
IF OBJECT_ID ('SUDO.Factura') IS NOT NULL DROP TABLE SUDO.Factura
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
IF OBJECT_ID ('SUDO.HistorialMovimiento') IS NOT NULL DROP TABLE SUDO.HistorialMovimiento
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

-----------Tabla EstadoCuenta-----------
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
	idPais 		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
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

-----------Tabla Factura-----------
CREATE TABLE SUDO.Factura ( 
	numero		numeric(18,0) PRIMARY KEY,
	idCliente	integer FOREIGN KEY REFERENCES SUDO.Cliente,
	fecha 		datetime,
);

-----------Tabla Item (Factura)-----------
CREATE TABLE SUDO.Item ( 
	idItem			integer IDENTITY(1,1) PRIMARY KEY,
	numeroFactura	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Factura,
	importe 		numeric(18,2) NOT NULL,
	descripcion 	varchar(255),
	
);

-----------Tabla Cheque-----------
CREATE TABLE SUDO.Cheque ( 
	idCheque 		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	codigoBanco 	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Banco,
	fecha 			datetime,
	importe 		numeric(18,2) NOT NULL,
);

-----------Tabla Cuenta-----------
CREATE TABLE SUDO.Cuenta ( 
	nroCuenta		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	idCliente 		integer FOREIGN KEY REFERENCES SUDO.Cliente,
	idPais 			numeric(18,0) FOREIGN KEY REFERENCES SUDO.Pais,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda DEFAULT NULL,
	idTipoCuenta 	integer FOREIGN KEY REFERENCES SUDO.TipoCuenta DEFAULT NULL,
	idEstadoCuenta 	integer FOREIGN KEY REFERENCES SUDO.EstadoCuenta,
	saldo 			numeric(18,2) DEFAULT 0,
	fechaCreacion 	datetime NOT NULL,
	fechaCierre 	datetime,
	estado 			BIT DEFAULT 1,
);

-----------Tabla Retiro-----------
CREATE TABLE SUDO.Retiro ( 
	codigo 		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	idCheque 	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cheque,
	idCuenta	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	fecha 		datetime NOT NULL,
	importe 	numeric(18,2) NOT NULL,
);

-----------Tabla Tarjeta-----------
CREATE TABLE SUDO.Tarjeta ( 
	idTarjeta 			integer IDENTITY(1,1) PRIMARY KEY,
	idCliente 			integer FOREIGN KEY REFERENCES SUDO.Cliente,
	numero 				numeric(16) NOT NULL UNIQUE,
	idEmisor 			integer FOREIGN KEY REFERENCES SUDO.Emisor,
	fechaEmision 		datetime NOT NULL,
	fechaVencimiento 	datetime NOT NULL,
	codigoSeguridad 	varchar(3) NOT NULL,
	estado 				BIT DEFAULT 1,	
);

-----------Tabla Transferencia-----------
CREATE TABLE SUDO.Transferencia ( 
	idTrans 		integer IDENTITY(1,1) PRIMARY KEY,
	nroCuentaDest 	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	nroCuentaOrigen	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	costo 			numeric(18,2),
	importe 		numeric(18,2),
	fecha 			datetime,
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
			--  	Drop procedures y funciones
---------------------------------------------------------------------------
IF OBJECT_ID ('SUDO.NuevaMonedaDesc') IS NOT NULL DROP PROCEDURE SUDO.NuevaMonedaDesc
IF OBJECT_ID ('SUDO.NuevoEstadoCuentaDesc') IS NOT NULL DROP PROCEDURE SUDO.NuevoEstadoCuentaDesc
IF OBJECT_ID ('SUDO.AgregarFuncionalidadNombre') IS NOT NULL DROP PROCEDURE SUDO.AgregarFuncionalidadNombre
IF OBJECT_ID ('SUDO.NuevoTipoCuenta') IS NOT NULL DROP PROCEDURE SUDO.NuevoTipoCuenta
IF OBJECT_ID ('SUDO.NuevoRol') IS NOT NULL DROP PROCEDURE SUDO.NuevoRol
IF OBJECT_ID ('SUDO.AsociarFuncionalidadXRol') IS NOT NULL DROP PROCEDURE SUDO.AsociarFuncionalidadXRol
IF OBJECT_ID ('SUDO.AsociarUsuarioXRol') IS NOT NULL DROP PROCEDURE SUDO.AsociarUsuarioXRol
IF OBJECT_ID ('SUDO.NuevoUsuario') IS NOT NULL DROP PROCEDURE SUDO.NuevoUsuario
IF OBJECT_ID ('SUDO.GetUser') IS NOT NULL DROP PROCEDURE SUDO.GetUser
IF OBJECT_ID ('SUDO.RegistrarLogin') IS NOT NULL DROP PROCEDURE SUDO.RegistrarLogin
IF OBJECT_ID ('SUDO.RegistrarLoginUsuarioInexistente') IS NOT NULL DROP PROCEDURE SUDO.RegistrarLoginUsuarioInexistente
IF OBJECT_ID ('SUDO.BlockearUsuario') IS NOT NULL DROP PROCEDURE SUDO.BlockearUsuario
IF OBJECT_ID ('SUDO.GetRolesXFuncionalidades') IS NOT NULL DROP PROCEDURE SUDO.GetRolesXFuncionalidades
IF OBJECT_ID ('SUDO.GetCuentas') IS NOT NULL DROP PROCEDURE SUDO.GetCuentas
IF OBJECT_ID ('SUDO.GetSaldo') IS NOT NULL DROP PROCEDURE SUDO.GetSaldo
IF OBJECT_ID ('SUDO.GetUltimos5depositos') IS NOT NULL DROP PROCEDURE SUDO.GetUltimos5depositos
IF OBJECT_ID ('SUDO.GetUltimos5Retiros') IS NOT NULL DROP PROCEDURE SUDO.GetUltimos5Retiros
IF OBJECT_ID ('SUDO.GetUltimas10Transferencias') IS NOT NULL DROP PROCEDURE SUDO.GetUltimas10Transferencias
IF OBJECT_ID ('SUDO.GetTarjetas') IS NOT NULL DROP PROCEDURE SUDO.GetTarjetas
IF OBJECT_ID ('SUDO.GetEmisores') IS NOT NULL DROP PROCEDURE SUDO.GetEmisores
IF OBJECT_ID ('SUDO.ExisteNumeroTarjeta') IS NOT NULL DROP PROCEDURE SUDO.ExisteNumeroTarjeta
IF OBJECT_ID ('SUDO.AsociarTarjeta') IS NOT NULL DROP PROCEDURE SUDO.AsociarTarjeta
IF OBJECT_ID ('SUDO.DesasociarTarjeta') IS NOT NULL DROP PROCEDURE SUDO.DesasociarTarjeta
IF OBJECT_ID ('SUDO.GetMonedas') IS NOT NULL DROP PROCEDURE SUDO.GetMonedas
IF OBJECT_ID ('SUDO.GetTarjetasCliente') IS NOT NULL DROP PROCEDURE SUDO.GetTarjetasCliente

IF OBJECT_ID ('SUDO.GetSaldoInicial') IS NOT NULL DROP FUNCTION SUDO.GetSaldoInicial;

PRINT 'Procesos y funciones borrados'
GO

---------------------------------------------------------------------------
			--  	Creacion Stored Procedures y funciones
---------------------------------------------------------------------------
CREATE PROCEDURE SUDO.DesasociarTarjeta(@idTarjeta bigint) AS 
	BEGIN
		UPDATE SUDO.Tarjeta
		SET estado = 0
		WHERE idTarjeta = @idTarjeta
	END;
GO
CREATE PROCEDURE SUDO.AsociarTarjeta(@numero bigint, @emisorDesc varchar(255), @fechaEmision varchar(255), @fechaVencimiento varchar(255), @codigoSeguridad varchar(255), @idUser integer) AS 
	BEGIN
		DECLARE @idCliente int
		DECLARE @idEmisor int

		SELECT @idEmisor = idEmisor
		FROM SUDO.Emisor
		WHERE descripcion = @emisorDesc

		SELECT @idCliente = idCliente
		FROM SUDO.Cliente
		WHERE idUsuario = @idUser

		INSERT INTO SUDO.Tarjeta (idCliente, numero, idEmisor, fechaEmision, fechaVencimiento, codigoSeguridad)
		VALUES(@idCliente, @numero, @idEmisor,Convert(dateTime, @fechaEmision, 121),Convert(dateTime, @fechaVencimiento, 121), @codigoSeguridad);
	END;
GO
CREATE PROCEDURE SUDO.GetTarjetas(@idUsuario integer) AS 
	BEGIN
		SELECT idTarjeta, estado, E.descripcion, fechaVencimiento, fechaEmision, SUBSTRING(CONVERT(varchar(20), numero), DATALENGTH(CONVERT(varchar(20),numero))-3, 4) ult4NumTarj
	  	FROM (SELECT idTarjeta ,numero, fechaEmision, fechaVencimiento, estado, idEmisor
	  		  FROM(SELECT idCliente
			 	   FROM SUDO.Cliente
			 	   WHERE idUsuario = @idUsuario)idCliente
	  		  JOIN SUDO.Tarjeta c  ON idCliente.idCliente = c.idCliente) H
	    JOIN SUDO.Emisor E ON E.idEmisor = H.idEmisor
	    WHERE estado = 1
	END;
GO
CREATE PROCEDURE SUDO.GetTarjetasCliente(@idUsuario integer) AS 
	BEGIN
		SELECT idTarjeta, E.descripcion, fechaVencimiento, SUBSTRING(CONVERT(varchar(20), numero), DATALENGTH(CONVERT(varchar(20),numero))-3, 4) ult4NumTarj
	  	FROM (SELECT idTarjeta ,numero, fechaVencimiento, idEmisor, estado
	  		  FROM(SELECT idCliente
			 	   FROM SUDO.Cliente
			 	   WHERE idUsuario = @idUsuario)idCliente
	  		  JOIN SUDO.Tarjeta c  ON idCliente.idCliente = c.idCliente) H
	    JOIN SUDO.Emisor E ON E.idEmisor = H.idEmisor
	    WHERE estado = 1
	END;
GO
CREATE PROCEDURE SUDO.ExisteNumeroTarjeta(@numero bigint) AS 
	BEGIN
		select idTarjeta
		from SUDO.Tarjeta
		where numero = @numero AND estado = 1
	END;
GO
CREATE PROCEDURE SUDO.GetEmisores AS 
	BEGIN
		select descripcion
		from SUDO.Emisor
	END;
GO
CREATE PROCEDURE SUDO.GetMonedas AS 
	BEGIN
		select descripcion
		from SUDO.Moneda
	END;
GO
CREATE PROCEDURE SUDO.GetCuentas(@idUsuario integer) AS 
	BEGIN
		select nroCuenta
		from SUDO.Cuenta c join (Select idCliente
								 from SUDO.Cliente
								 where idUsuario = @idUsuario)idCliente ON (idCliente.idCliente = c.idCliente)
	END;
GO
CREATE PROCEDURE SUDO.GetUltimas10Transferencias(@nroCuenta bigint) AS 
	BEGIN
		select TOP 10 idTrans, fecha, importe, costo, nroCuentaDest
		from SUDO.Transferencia
		where nroCuentaOrigen = @nroCuenta
		order by fecha desc
	END;
GO
CREATE PROCEDURE SUDO.GetUltimos5Retiros(@nroCuenta bigint) AS 
	BEGIN
		select TOP 5 codigo, fecha, importe, idCheque
		from SUDO.Retiro
		where idCuenta = @nroCuenta
		order by fecha desc
	END;
GO
CREATE PROCEDURE SUDO.GetUltimos5depositos(@nroCuenta bigint) AS 
	BEGIN
		select TOP 5 codigo, fecha, importe, SUBSTRING(CONVERT(varchar(20),T.numero), DATALENGTH(CONVERT(varchar(20),T.numero))-3, 4) ult4NumTarj
		from SUDO.Deposito D join SUDO.Tarjeta T ON (D.idTarjeta = T.idTarjeta)
		where nroCuenta = @nroCuenta
		order by fecha desc
	END;
GO
CREATE PROCEDURE SUDO.GetSaldo(@nroCuenta bigint) AS 
	BEGIN
		select saldo
		from SUDO.Cuenta
		where nroCuenta = @nroCuenta
	END;
GO
CREATE PROCEDURE SUDO.RegistrarLoginUsuarioInexistente(@userNameIng varchar(255), @userPasswordIng varchar(255), @fechaHora datetime, @descripcion varchar(255)) AS 
	BEGIN
		INSERT INTO SUDO.HistorialLogin (userNameIngreasdo, userPasswordIngresado, fechaHora, descripcion)
		VALUES(@userNameIng, @userPasswordIng, @fechaHora, @descripcion);
	END;
GO
CREATE PROCEDURE SUDO.BlockearUsuario(@idUsuario integer) AS 
	BEGIN
		UPDATE SUDO.Usuario SET estado = 0
		WHERE (idUsuario = @idUsuario)
	END;
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
CREATE PROCEDURE SUDO.RegistrarLogin(@userNameIng varchar(255), @userPasswordIng varchar(255), @fechaHora datetime, @estado BIT, @numeroIntentoFallido TINYINT, @descripcion varchar(255), @idUsuario integer) AS 
	BEGIN
		INSERT INTO SUDO.HistorialLogin (userNameIngreasdo, userPasswordIngresado, fechaHora, numeroIntentoFallido, estado, descripcion)
		VALUES(@userNameIng, @userPasswordIng, @fechaHora, @numeroIntentoFallido, @estado, @descripcion);
		
		UPDATE SUDO.Usuario SET cantIntentosFallidos = @numeroIntentoFallido
		WHERE (idUsuario = @idUsuario)
	END;
GO
CREATE PROCEDURE SUDO.GetUser(@userName varchar(255)) AS 
	BEGIN
    	SELECT *
		FROM SUDO.Usuario
		WHERE (userName = @userName);
	END;
GO
CREATE PROCEDURE SUDO.AsociarFuncionalidadXRol(@NombreRol VARCHAR(255), @NombreFuncionalidad VARCHAR(255)) AS
	BEGIN
		INSERT INTO SUDO.FuncionalidadXRol(idRol, idFuncionalidad)
			SELECT r.idRol, f.idFuncionalidad
			FROM SUDO.Rol r JOIN SUDO.Funcionalidad f ON (r.nombreRol = @NombreRol AND f.nombre = @NombreFuncionalidad)
	END;
GO
CREATE PROCEDURE SUDO.AsociarUsuarioXRol(@UserName VARCHAR(255), @NombreRol VARCHAR(255)) AS
	BEGIN
		INSERT INTO SUDO.UsuarioXRol(idRol, idUsuario)
			SELECT r.idRol, u.idUsuario
			FROM SUDO.Rol r JOIN SUDO.Usuario u ON (r.nombreRol = @NombreRol AND u.userName = @UserName)
	END;
GO
CREATE PROC SUDO.NuevaMonedaDesc @Desc VARCHAR(15) AS
	BEGIN
		INSERT INTO SUDO.Moneda(descripcion)
			VALUES(@Desc)
	END;
GO
CREATE PROC SUDO.NuevoEstadoCuentaDesc @Desc VARCHAR(25) AS
	BEGIN
		INSERT INTO SUDO.EstadoCuenta(descripcion)
			VALUES(@Desc)
	END;
GO
CREATE PROC SUDO.AgregarFuncionalidadNombre(@Nombre VARCHAR(40)) AS
	BEGIN
		INSERT INTO SUDO.Funcionalidad(nombre)
			VALUES(@Nombre)
	END;
GO
CREATE PROC SUDO.NuevoTipoCuenta(@Nombre VARCHAR(50), @Duracion SMALLINT, @Costo NUMERIC(10,2)) AS
	BEGIN
		INSERT INTO SUDO.TipoCuenta(nombre, duracionEnDias, costo)
			VALUES(@Nombre, @Duracion, @Costo)
	END;
GO
CREATE PROCEDURE SUDO.NuevoRol(@Nombre VARCHAR(255), @Estado BIT) AS
	BEGIN
		INSERT INTO SUDO.Rol(nombreRol, estado)
			VALUES(@Nombre, @Estado)
	END;
GO
CREATE PROCEDURE SUDO.NuevoUsuario(@UserName VARCHAR(255), @Password VARCHAR(255), @FechaCreacion datetime, @FechaDeUltimaModificacion datetime,
									@PreguntaSecreta VARCHAR(255), @RespuestaSecreta VARCHAR(255), @CantIntentosFallidos TINYINT, @Estado BIT) AS
	BEGIN
		INSERT INTO SUDO.Usuario(userName, userPassword, fechaCreacion, fechaDeUltimaModificacion, preguntaSecreta, respuestaSecreta, cantIntentosFallidos, estado)
		VALUES(@UserName, ISNULL (@Password , '5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c='),
			   ISNULL (@FechaCreacion , GETDATE()), ISNULL (@FechaDeUltimaModificacion , GETDATE()),@PreguntaSecreta, @RespuestaSecreta, @CantIntentosFallidos, @Estado)
	END;
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
EXEC SUDO.NuevoTipoCuenta @Nombre = 'Gratuita', @Duracion = 364 , @Costo = 0  --1 AÑO

PRINT 'Tabla SUDO.TipoCuenta creacion de los 4 TipoCuenta'
GO

-----------Creacion de los Usuarios-----------
EXEC SUDO.NuevoUsuario @UserName= 'admin', @Password= NULL, @FechaCreacion= NULL, @FechaDeUltimaModificacion= NULL,@PreguntaSecreta='quien?', @RespuestaSecreta='yo', @CantIntentosFallidos= 0, @Estado= 1

EXEC SUDO.AsociarUsuarioXRol @NombreRol = 'Administrador', @UserName= 'admin'

PRINT 'Tabla SUDO.Usuario creacion de Usuarios'
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

SET IDENTITY_INSERT SUDO.TipoDoc OFF

PRINT 'Tabla SUDO.TipoDoc Migrada'
GO

-- select DISTINCT COUNT(*)  FROM gd_esquema.Maestra -- 502494
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

-----------Migracion Item-----------
INSERT INTO SUDO.Item(numeroFactura, importe, descripcion)
	SELECT DISTINCT f.numero, Item_Factura_Importe, Item_Factura_Descr
	  FROM gd_esquema.Maestra m 
	  JOIN SUDO.Factura f ON f.numero = m.Factura_Numero
	 WHERE Item_Factura_Importe IS NOT NULL
--- 220873
PRINT 'Tabla SUDO.Item Migrada'
GO


-----------Migracion Emisor Tarjeta -----------
INSERT INTO SUDO.Emisor (descripcion)
	SELECT DISTINCT Tarjeta_Emisor_Descripcion
	  FROM gd_esquema.Maestra m 
	 WHERE Tarjeta_Emisor_Descripcion IS NOT NULL

PRINT 'Tabla SUDO.Emisor Migrada'
GO

-----------Migracion Tarjeta-----------
INSERT INTO SUDO.Tarjeta(numero, fechaEmision, fechaVencimiento, codigoSeguridad, idEmisor, idCliente)
	SELECT DISTINCT Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Codigo_Seg, idEmisor, idCliente
	  FROM (SELECT DISTINCT Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Codigo_Seg, Tarjeta_Emisor_Descripcion, c.idCliente
			  FROM gd_esquema.Maestra m 
			  JOIN SUDO.Cliente c ON m.Cli_Nro_Doc = c.nroDoc AND m.Cli_Tipo_Doc_Cod = c.idTipoDoc
			 WHERE Tarjeta_Numero IS NOT NULL
			) m
	  JOIN SUDO.Emisor e ON e.descripcion = Tarjeta_Emisor_Descripcion

PRINT 'Tabla SUDO.Tarjeta Migrada'
GO

-----------Migracion Cuenta-----------
SET IDENTITY_INSERT SUDO.Cuenta ON

INSERT INTO SUDO.Cuenta(nroCuenta, fechaCreacion, fechaCierre, idPais, idEstadoCuenta, idCliente)
	SELECT DISTINCT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, idPais, idEstadoCuenta, idCliente
	  FROM ( SELECT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, descEstadoCuenta, idPais, idCliente
			   FROM ( SELECT DISTINCT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, Cuenta_Pais_Codigo, 
							 (ISNULL ( m.Cuenta_Estado , 'Inhabilitada')) descEstadoCuenta, idCliente
		  				FROM gd_esquema.Maestra m 
						JOIN SUDO.Cliente c ON ((m.Cli_Nro_Doc = c.nroDoc) AND (m.Cli_Tipo_Doc_Cod = c.idTipoDoc))
		  			) m_c 
			   JOIN SUDO.Pais p ON (m_c.Cuenta_Pais_Codigo = p.idPais)
			) m_c_p 
	  JOIN SUDO.EstadoCuenta ec ON (m_c_p.descEstadoCuenta = ec.descripcion)

SET IDENTITY_INSERT SUDO.Cuenta OFF

UPDATE SUDO.Cuenta SET idTipoCuenta = (SELECT idTipoCuenta
										FROM SUDO.TipoCuenta
										WHERE (nombre = 'Gratuita')),
						idMoneda = (SELECT idMoneda
									FROM SUDO.Moneda
									WHERE (descripcion = 'Dolar'))

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

-----------Migracion Cheque-----------
SET IDENTITY_INSERT SUDO.Cheque ON

	INSERT INTO SUDO.Cheque(idCheque, fecha, importe, codigoBanco)
		SELECT DISTINCT Cheque_Numero, Cheque_Fecha, Cheque_Importe, Banco_Cogido 
		  FROM gd_esquema.Maestra 
		 WHERE Cheque_Numero IS NOT NULL

SET IDENTITY_INSERT SUDO.Cheque OFF

-- SELECT * FROM SUDO.Cheque 
PRINT 'Tabla SUDO.Cheque Migrada'
GO


-----------Migracion Retiro-----------
SET IDENTITY_INSERT SUDO.Retiro ON

	INSERT INTO SUDO.Retiro(codigo, idCheque, fecha, importe, idCuenta)
		SELECT DISTINCT Retiro_Codigo, Cheque_Numero, Retiro_Fecha, Retiro_Importe, nroCuenta
		  FROM gd_esquema.Maestra m 
		  JOIN SUDO.Cuenta c ON m.Cuenta_Numero = c.nroCuenta
		 WHERE Retiro_Codigo IS NOT NULL

SET IDENTITY_INSERT SUDO.Retiro OFF

-- SELECT * FROM SUDO.Retiro 
PRINT 'Tabla SUDO.Retiro Migrada'
GO


-----------Migracion Deposito-----------
SET IDENTITY_INSERT SUDO.Deposito ON

-- SELECT INTO @MONEDA SELECT idMoneda FROM SUDO.Moneda WHERE descripcion = 'Dolar';

	INSERT INTO SUDO.Deposito(codigo, fecha, importe, nroCuenta, idTarjeta)
		SELECT Deposito_Codigo, Deposito_Fecha, Deposito_Importe, nroCuenta, idTarjeta
		  FROM (SELECT DISTINCT Deposito_Codigo, Deposito_Fecha, Deposito_Importe, nroCuenta ,Tarjeta_Numero
				  FROM gd_esquema.Maestra m 
				  JOIN SUDO.Cuenta c on m.Cuenta_Numero = c.nroCuenta
				) m_c 
		  JOIN SUDO.Tarjeta t on m_c.Tarjeta_Numero = t.numero

SET IDENTITY_INSERT SUDO.Deposito OFF

UPDATE SUDO.Deposito SET idMoneda = (SELECT idMoneda
									FROM SUDO.Moneda
									WHERE (descripcion = 'Dolar'))

-- SELECT * FROM SUDO.Deposito -- 25.285
PRINT 'Tabla SUDO.Deposito Migrada'
GO

-----------Migracion Transferencia-----------
INSERT INTO SUDO.Transferencia(fecha, importe, costo, nroCuentaOrigen, nroCuentaDest)
	SELECT Transf_Fecha, Trans_Importe, Trans_Costo_Trans, m_c.nroCuenta, c2.nroCuenta
	FROM(SELECT DISTINCT Cuenta_Dest_Numero, Transf_Fecha, Trans_Importe, Trans_Costo_Trans, Cuenta_Dest_Estado, Cuenta_Dest_Fecha_Cierre, Cuenta_Dest_Fecha_Creacion, Cuenta_Dest_Pais_Codigo, nroCuenta
		 FROM gd_esquema.Maestra m join SUDO.Cuenta c on (m.Cuenta_Numero = c.nroCuenta)
	)m_c join SUDO.Cuenta c2 on ((m_c.Cuenta_Dest_Numero = c2.nroCuenta)AND(m_c.Cuenta_Dest_Fecha_Creacion = c2.fechaCreacion)AND(m_c.Cuenta_Dest_Pais_Codigo = c2.idPais))


PRINT 'Tabla SUDO.Transferencia Migrada'
GO

-----------Creacion de Usuarios y creacion de la relacion con los clientes-----------
DECLARE @idUsuario numeric(18,0)
DECLARE @mail varchar(255)

DECLARE CursorCli CURSOR FOR (SELECT mail, idUsuario
							  FROM SUDO.Cliente)
OPEN CursorCli FETCH NEXT FROM CursorCli INTO @mail, @idUsuario
WHILE (@@FETCH_STATUS = 0)
	BEGIN
		EXEC SUDO.NuevoUsuario @UserName= @Mail, @Password= NULL, @FechaCreacion= NULL, @FechaDeUltimaModificacion= NULL,
							   @PreguntaSecreta='quien?', @RespuestaSecreta='yo', @CantIntentosFallidos= 0, @Estado= 1
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
