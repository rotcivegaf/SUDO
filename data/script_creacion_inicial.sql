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
IF OBJECT_ID ('SUDO.UsuarioXRol') IS NOT NULL DROP TABLE SUDO.UsuarioXRol
IF OBJECT_ID ('SUDO.PermisoXRol') IS NOT NULL DROP TABLE SUDO.PermisoXRol
IF OBJECT_ID ('SUDO.Deposito') IS NOT NULL DROP TABLE SUDO.Deposito
IF OBJECT_ID ('SUDO.Transferencia') IS NOT NULL DROP TABLE SUDO.Transferencia
IF OBJECT_ID ('SUDO.Tarjeta') IS NOT NULL DROP TABLE SUDO.Tarjeta
IF OBJECT_ID ('SUDO.Cliente') IS NOT NULL DROP TABLE SUDO.Cliente
IF OBJECT_ID ('SUDO.Domicilio') IS NOT NULL DROP TABLE SUDO.Domicilio
IF OBJECT_ID ('SUDO.HistorialLogin') IS NOT NULL DROP TABLE SUDO.HistorialLogin
IF OBJECT_ID ('SUDO.Rol') IS NOT NULL DROP TABLE SUDO.Rol
IF OBJECT_ID ('SUDO.Permiso') IS NOT NULL DROP TABLE SUDO.Permiso
IF OBJECT_ID ('SUDO.TipoDoc') IS NOT NULL DROP TABLE SUDO.TipoDoc
IF OBJECT_ID ('SUDO.Cuenta') IS NOT NULL DROP TABLE SUDO.Cuenta
IF OBJECT_ID ('SUDO.Moneda') IS NOT NULL DROP TABLE SUDO.Moneda
IF OBJECT_ID ('SUDO.TipoCuenta') IS NOT NULL DROP TABLE SUDO.TipoCuenta
IF OBJECT_ID ('SUDO.EstadoCuenta') IS NOT NULL DROP TABLE SUDO.EstadoCuenta
IF OBJECT_ID ('SUDO.Retiro') IS NOT NULL DROP TABLE SUDO.Retiro
IF OBJECT_ID ('SUDO.Cheque') IS NOT NULL DROP TABLE SUDO.Cheque
IF OBJECT_ID ('SUDO.Banco') IS NOT NULL DROP TABLE SUDO.Banco
IF OBJECT_ID ('SUDO.Usuario') IS NOT NULL DROP TABLE SUDO.Usuario
IF OBJECT_ID ('SUDO.Pais') IS NOT NULL DROP TABLE SUDO.Pais
PRINT 'Tablas borradas'
GO


---------------------------------------------------------------------------
			--  	Drop procedures
---------------------------------------------------------------------------
IF OBJECT_ID ('SUDO.NuevaMonedaDesc') IS NOT NULL DROP PROCEDURE SUDO.NuevaMonedaDesc
IF OBJECT_ID ('SUDO.NuevoEstadoCuentaDesc') IS NOT NULL DROP PROCEDURE SUDO.NuevoEstadoCuentaDesc
IF OBJECT_ID ('SUDO.AgregarPermisoNombre') IS NOT NULL DROP PROCEDURE SUDO.AgregarPermisoNombre
IF OBJECT_ID ('SUDO.NuevoTipoCuenta') IS NOT NULL DROP PROCEDURE SUDO.NuevoTipoCuenta

PRINT 'Procesos borrados'
GO

---------------------------------------------------------------------------
			--  	Creacion de tablas
---------------------------------------------------------------------------
-----------Tabla Banco-----------
CREATE TABLE SUDO.Banco ( 
	codigo		integer IDENTITY(1,1) PRIMARY KEY,
	nombre 		varchar(255),
	direccion 	varchar(255)
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
	codigoPais 		integer IDENTITY(1,1) PRIMARY KEY,
	descripcion 	varchar(255),	
);

-----------Tabla TipoDoc-----------
CREATE TABLE SUDO.TipoDoc ( 
	idTipoIdentintificacion		integer IDENTITY(1,1) PRIMARY KEY,
	descripcion 				varchar(255),	
);

-----------Tabla Usuario-----------
CREATE TABLE SUDO.Usuario ( 
	idUsuario 					integer IDENTITY(1,1) PRIMARY KEY,
	userName 					varchar(255) NOT NULL UNIQUE,
	password 					varchar(255) NOT NULL,
	fechaCreacion 				datetime NOT NULL,
	fechaDeUltimaModificacion 	datetime,
	preguntaSecreta 			varchar(255) NOT NULL,
	respuestaSecreta 			varchar(255) NOT NULL,
	contIntentosFallidos 		TINYINT DEFAULT 0,
	estado 						BIT DEFAULT 1,
);

-----------Tabla Permiso-----------
CREATE TABLE SUDO.Permiso ( 
	idPermiso 	integer IDENTITY(1,1) PRIMARY KEY,
	nombre 		varchar(255),
);

-----------Tabla Rol-----------
CREATE TABLE SUDO.Rol ( 
	idRol 		integer IDENTITY(1,1) PRIMARY KEY,
	nombreRol 	varchar(255),
	estado 		BIT DEFAULT 1,
);

-----------Tabla Permiso X Rol-----------
CREATE TABLE SUDO.PermisoXRol ( 
	idRol 		integer FOREIGN KEY REFERENCES SUDO.Rol,
	idPermiso 	integer FOREIGN KEY REFERENCES SUDO.Permiso,
);

-----------Tabla Usuario X Rol-----------
CREATE TABLE SUDO.UsuarioXRol ( 
	idRol 		integer FOREIGN KEY REFERENCES SUDO.Rol,
	idUsuario 	integer FOREIGN KEY REFERENCES SUDO.Usuario,
);

-----------Tabla HistorialLogin-----------
CREATE TABLE SUDO.HistorialLogin ( 
	idHistorialLogin 		integer IDENTITY(1,1) PRIMARY KEY,
	idUsuario 				integer FOREIGN KEY REFERENCES SUDO.Usuario,
	fechaHora 				datetime,
	estado 					BIT DEFAULT 0,
	numeroIntentoFallido 	TINYINT DEFAULT 0,
);

-----------Tabla Domicilio-----------
CREATE TABLE SUDO.Domicilio ( 
	idDomicilio 	integer IDENTITY(1,1) PRIMARY KEY,
	codigoPais 			integer FOREIGN KEY REFERENCES SUDO.Pais,
	numero 			integer,
	calle 			varchar(255),
	piso 			varchar(255),
	depto 			varchar(255),
);

-----------Tabla Cliente-----------
CREATE TABLE SUDO.Cliente ( 
	idCliente 					integer IDENTITY(1,1) PRIMARY KEY,
	idUsuario 					integer FOREIGN KEY REFERENCES SUDO.Usuario,
	idDomicilio 				integer FOREIGN KEY REFERENCES SUDO.Domicilio,
	idTipoIdentintificacion 	integer FOREIGN KEY REFERENCES SUDO.TipoDoc,
	nombre 						varchar(255) NOT NULL,
	apellido 					varchar(255) NOT NULL,
	mail 						varchar(255) NOT NULL,
	fechaDeNac 					datetime,
	numeroIdentintificacion 	numeric(18,0) NOT NULL,
	estado 						BIT DEFAULT 1,
);

-----------Tabla Cheque-----------
CREATE TABLE SUDO.Cheque ( 
	idCheque 		integer IDENTITY(1,1) PRIMARY KEY,
	codigoBanco 	integer FOREIGN KEY REFERENCES SUDO.Banco,
	fecha 			datetime,
	importe 		numeric(18,2) NOT NULL,
);

-----------Tabla Retiro-----------
CREATE TABLE SUDO.Retiro ( 
	codigo 		integer IDENTITY(1,1) PRIMARY KEY,
	idCheque 	integer FOREIGN KEY REFERENCES SUDO.Cheque,
	fecha 		datetime NOT NULL,
	importe 	numeric(18,2) NOT NULL,
);

-----------Tabla Cuenta-----------
CREATE TABLE SUDO.Cuenta ( 
	idCuenta 		integer IDENTITY(1,1) PRIMARY KEY,
	idUsuario 		integer FOREIGN KEY REFERENCES SUDO.Usuario,
	codigoPais 		integer FOREIGN KEY REFERENCES SUDO.Pais,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda,
	idTipoCuenta 	integer FOREIGN KEY REFERENCES SUDO.TipoCuenta,
	idEstadoCuenta 	integer FOREIGN KEY REFERENCES SUDO.EstadoCuenta,
	idRetiro 		integer FOREIGN KEY REFERENCES SUDO.Retiro,
	saldo 			integer	DEFAULT 0,
	nroCuenta 		integer NOT NULL UNIQUE,
	fechaCreacion 	datetime NOT NULL,
	fechaCierre 	datetime,
	estado 			BIT DEFAULT 1,
);


-----------Tabla Tarjeta-----------
CREATE TABLE SUDO.Tarjeta ( 
	idTarjeta 			integer IDENTITY(1,1) PRIMARY KEY,
	idCliente 			integer FOREIGN KEY REFERENCES SUDO.Cliente,
	numero 				numeric(16) NOT NULL UNIQUE,
	emisorDesc 			varchar(255),
	fechaEmision 		datetime NOT NULL,
	fechaVencimiento 	datetime NOT NULL,
	codigoSeguridad 	varchar(3) NOT NULL,
	estado 				BIT DEFAULT 1,	
);

-----------Tabla Transferencia-----------
CREATE TABLE SUDO.Transferencia ( 
	idTrans 		integer IDENTITY(1,1) PRIMARY KEY,
	idCuentaDest 	integer FOREIGN KEY REFERENCES SUDO.Cuenta,
	idCuentaOrigen 	integer FOREIGN KEY REFERENCES SUDO.Cuenta,
	costo 			numeric(18,2),
	importe 		numeric(18,2),  /*mayor o igual a uno  TODO*/
	fecha 			datetime,
);

-----------Tabla Deposito-----------
CREATE TABLE SUDO.Deposito ( 
	idDeposito 		integer IDENTITY(1,1) PRIMARY KEY,
	idCuenta 		integer FOREIGN KEY REFERENCES SUDO.Cuenta,
	idTarjeta 		integer FOREIGN KEY REFERENCES SUDO.tarjeta,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda,
	importe 		numeric(18,2),  /*mayor o igual a uno  TODO*/
	fecha 			datetime,
);

-----------Tabla Comprobante-----------
CREATE TABLE SUDO.Comprobante ( 
	numOperacion 	integer IDENTITY(1,1) PRIMARY KEY,
	idDeposito 		integer FOREIGN KEY REFERENCES SUDO.Deposito,
	fechaIngreso 	datetime,
);


PRINT 'Tablas creadas'
GO

---------------------------------------------------------------------------
			--  	Creacion Funciones, Stored Procedures y Triggers
---------------------------------------------------------------------------
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
CREATE PROC SUDO.AgregarPermisoNombre(@Nombre VARCHAR(40)) AS
	BEGIN
		INSERT INTO SUDO.Permiso(nombre)
		VALUES(@Nombre)
	END;
GO
CREATE PROC SUDO.NuevoTipoCuenta(@Nombre VARCHAR(50), @Duracion SMALLINT, @Costo NUMERIC(10,2)) AS
	BEGIN
		INSERT INTO SUDO.TipoCuenta(nombre, duracionEnDias, costo)
		VALUES(@Nombre, @Duracion, @Costo)
	END;
GO


