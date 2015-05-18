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
IF OBJECT_ID ('SUDO.Deposito') IS NOT NULL DROP TABLE SUDO.Deposito
IF OBJECT_ID ('SUDO.Tarjeta') IS NOT NULL DROP TABLE SUDO.Tarjeta
IF OBJECT_ID ('SUDO.Cuenta') IS NOT NULL DROP TABLE SUDO.Cuenta
IF OBJECT_ID ('SUDO.Retiro') IS NOT NULL DROP TABLE SUDO.Retiro
IF OBJECT_ID ('SUDO.Cheque') IS NOT NULL DROP TABLE SUDO.Cheque
IF OBJECT_ID ('SUDO.Cliente') IS NOT NULL DROP TABLE SUDO.Cliente
IF OBJECT_ID ('SUDO.Domicilio') IS NOT NULL DROP TABLE SUDO.Domicilio
IF OBJECT_ID ('SUDO.HistorialLogin') IS NOT NULL DROP TABLE SUDO.HistorialLogin
IF OBJECT_ID ('SUDO.UsuarioXRol') IS NOT NULL DROP TABLE SUDO.UsuarioXRol
IF OBJECT_ID ('SUDO.PermisoXRol') IS NOT NULL DROP TABLE SUDO.PermisoXRol
IF OBJECT_ID ('SUDO.Rol') IS NOT NULL DROP TABLE SUDO.Rol
IF OBJECT_ID ('SUDO.Permiso') IS NOT NULL DROP TABLE SUDO.Permiso
IF OBJECT_ID ('SUDO.Usuario') IS NOT NULL DROP TABLE SUDO.Usuario
IF OBJECT_ID ('SUDO.TipoDoc') IS NOT NULL DROP TABLE SUDO.TipoDoc
IF OBJECT_ID ('SUDO.Pais') IS NOT NULL DROP TABLE SUDO.Pais
IF OBJECT_ID ('SUDO.Moneda') IS NOT NULL DROP TABLE SUDO.Moneda
IF OBJECT_ID ('SUDO.TipoCuenta') IS NOT NULL DROP TABLE SUDO.TipoCuenta
IF OBJECT_ID ('SUDO.EstadoCuenta') IS NOT NULL DROP TABLE SUDO.EstadoCuenta
IF OBJECT_ID ('SUDO.Banco') IS NOT NULL DROP TABLE SUDO.Banco

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
	codigo		integer IDENTITY(1,1),
	nombre 		varchar(255),
	direccion 	varchar(255),
	
	primary key (codigo)
);

-----------Tabla EstadoCuenta-----------
CREATE TABLE SUDO.EstadoCuenta ( 
	idEstadoCuenta 	integer IDENTITY(1,1),
	descripcion 	varchar(255),
	
	primary key (idEstadoCuenta)
);

-----------Tabla TipoCuenta-----------
CREATE TABLE SUDO.TipoCuenta ( 
	idTipoCuenta 	integer IDENTITY(1,1),
	nombre 		varchar(255),
	duracionEnDias 	SMALLINT NOT NULL,
	costo 		numeric(18,2) NOT NULL, 
	
	primary key (idTipoCuenta)
);

-----------Tabla Moneda-----------
CREATE TABLE SUDO.Moneda ( 
	idMoneda 	integer IDENTITY(1,1),
	descripcion 	varchar(255),
	
	primary key (idMoneda)
);

-----------Tabla Pais-----------
CREATE TABLE SUDO.Pais ( 
	codigoPais 	integer IDENTITY(1,1),
	descripcion 	varchar(255),
	
	primary key (codigoPais)
);

-----------Tabla TipoDoc-----------
CREATE TABLE SUDO.TipoDoc ( 
	idTipoIdentintificacion		integer IDENTITY(1,1),
	descripcion 			varchar(255),
	
	primary key (idTipoIdentintificacion)
);

-----------Tabla Usuario-----------
CREATE TABLE SUDO.Usuario ( 
	idUsuario 			integer IDENTITY(1,1),
	userName 			varchar(255) NOT NULL UNIQUE,
	password 			varchar(255) NOT NULL,
	fechaCreacion 			datetime NOT NULL,
	fechaDeUltimaModificacion 	datetime,
	preguntaSecreta 		varchar(255) NOT NULL,
	respuestaSecreta 		varchar(255) NOT NULL,
	contIntentosFallidos 		TINYINT DEFAULT 0,
	estado 				BIT DEFAULT 1,
	
	primary key (idUsuario)
);

-----------Tabla Permiso-----------
CREATE TABLE SUDO.Permiso ( 
	idPermiso 	integer IDENTITY(1,1),
	nombre 		varchar(255),
	
	primary key (idPermiso)
);

-----------Tabla Rol-----------
CREATE TABLE SUDO.Rol ( 
	idRol 		integer IDENTITY(1,1),
	nombreRol 	varchar(255),
	estado 		BIT DEFAULT 1,
	
	primary key (idRol)
);

-----------Tabla Permiso X Rol-----------
CREATE TABLE SUDO.PermisoXRol ( 
	idRol 		integer,
	idPermiso 	integer,
	
	foreign key (idRol) references SUDO.Rol,
	foreign key (idPermiso) references SUDO.Permiso
);

-----------Tabla Usuario X Rol-----------
CREATE TABLE SUDO.UsuarioXRol ( 
	idRol 		integer,
	idUsuario 	integer,
	
	foreign key (idRol) references SUDO.Rol,
	foreign key (idUsuario) references SUDO.Usuario
);

-----------Tabla HistorialLogin-----------
CREATE TABLE SUDO.HistorialLogin ( 
	idHistorialLogin 		integer IDENTITY(1,1),
	idUsuario 			integer,
	
	fechaHora 			datetime,
	estado 				BIT DEFAULT 0,
	numeroIntentoFallido 		TINYINT DEFAULT 0,
	
	primary key (idHistorialLogin),
	foreign key (idUsuario) references SUDO.Usuario
);

-----------Tabla Domicilio-----------
CREATE TABLE SUDO.Domicilio ( 
	idDomicilio 	integer IDENTITY(1,1),
	codigoPais 	integer,
	
	numero 		integer,
	calle 		varchar(255),
	piso 		varchar(255),
	depto 		varchar(255),
	
	primary key (idDomicilio),
	foreign key (codigoPais) references SUDO.Pais
);

-----------Tabla Cliente-----------
CREATE TABLE SUDO.Cliente ( 
	idCliente 			integer IDENTITY(1,1),
	idUsuario 			integer,
	idDomicilio 			integer,
	idTipoIdentintificacion 	integer,
	
	nombre 				varchar(255) NOT NULL,
	apellido 			varchar(255) NOT NULL,
	mail 				varchar(255) NOT NULL,
	fechaDeNac 			datetime,
	numeroIdentintificacion 	integer,
	estado 				BIT DEFAULT 1,
	
	primary key (idCliente),
	foreign key (idUsuario) references SUDO.Usuario,
	foreign key (idDomicilio) references SUDO.Domicilio,
	foreign key (idTipoIdentintificacion) references SUDO.TipoDoc
);

-----------Tabla Cheque-----------
CREATE TABLE SUDO.Cheque ( 
	idCheque 	integer IDENTITY(1,1),
	codigoBanco 	integer,
	
	fecha 		datetime,
	importe 	numeric(18,2) NOT NULL,
	
	primary key (idCheque),
	foreign key (codigoBanco) references SUDO.Banco
);

-----------Tabla Retiro-----------
CREATE TABLE SUDO.Retiro ( 
	codigo 		integer IDENTITY(1,1),
	idCheque 	integer,
	
	fecha 		datetime NOT NULL,
	importe 	numeric(18,2) NOT NULL,
	
	primary key (codigo),
	foreign key (idCheque) references SUDO.Cheque
);

-----------Tabla Cuenta-----------
CREATE TABLE SUDO.Cuenta ( 
	idCuenta 	integer IDENTITY(1,1),
	idUsuario 	integer,
	codigoPais 	integer,
	idMoneda 	integer,
	idTipoCuenta 	integer,
	idEstadoCuenta 	integer,
	idRetiro 	integer,
	
	nroCuenta 	integer NOT NULL UNIQUE,
	fechaCreacion 	datetime NOT NULL,
	fechaCierre 	datetime,
	estado 		BIT DEFAULT 1,
	
	primary key (idCuenta),
	foreign key (idUsuario) references SUDO.Usuario,
	foreign key (codigoPais) references SUDO.Pais,
	foreign key (idMoneda) references SUDO.Moneda,
	foreign key (idTipoCuenta) references SUDO.TipoCuenta,
	foreign key (idEstadoCuenta) references SUDO.EstadoCuenta,
	foreign key (idRetiro) references SUDO.Retiro
);


-----------Tabla Tarjeta-----------
CREATE TABLE SUDO.Tarjeta ( 
	idTarjeta 		integer IDENTITY(1,1),
	idCliente 		integer,

	numero 			numeric(16) NOT NULL UNIQUE,
	emisorDesc 		varchar(255),
	fechaEmision 		datetime NOT NULL,
	fechaVencimiento 	datetime NOT NULL,
	codigoSeguridad 	varchar(3) NOT NULL,
	estado 			BIT DEFAULT 1,	
	
	primary key (idTarjeta),
	foreign key (idCliente) references SUDO.Cliente
);
-----------Tabla Deposito-----------
CREATE TABLE SUDO.Deposito ( 
	idDeposito 		integer IDENTITY(1,1),
	idCuenta 		integer,
	idTarjeta 		integer,
	idMoneda 		integer,
	
	importe 		numeric(18,2),
	fecha 			datetime,
	
	primary key (idDeposito),
	foreign key (idCuenta) references SUDO.Cuenta,
	foreign key (idTarjeta) references SUDO.Tarjeta,
	foreign key (idMoneda) references SUDO.Tarjeta
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


---------------------------------------------------------------------------
			--  	Migracion de datos
---------------------------------------------------------------------------

-----------Creacion de los 11 nombres de Permiso-----------

EXEC SUDO.AgregarPermisoNombre @Nombre = 'ABM de rol'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'ABM de usuario'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'ABM de cliente'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'ABM de cuenta'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'asociar/desasociar tarjetas de credito'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'depositos'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'retiro'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'transferencias'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'facturacion'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'consulta saldos'
EXEC SUDO.AgregarPermisoNombre @Nombre = 'listado estadistico'

PRINT 'Tabla SUDO.Permiso de los 11 nombres de Permiso'
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

PRINT 'Tabla SUDO.EstadoCuenta los 4 EstadoCuenta creados'
GO

-----------Creacion de los 4 TipoCuenta-----------

EXEC SUDO.NuevoTipoCuenta @Nombre = 'ORO', @Duracion = 1456, @Costo = 300     --4 AÑOS
EXEC SUDO.NuevoTipoCuenta @Nombre = 'PLATA', @Duracion = 1092, @Costo = 200   --3 AÑOS
EXEC SUDO.NuevoTipoCuenta @Nombre = 'BRONCE', @Duracion = 728, @Costo = 100   --2 AÑOS
EXEC SUDO.NuevoTipoCuenta @Nombre = 'GRATUITA', @Duracion = 364 , @Costo = 0  --1 AÑO

PRINT 'Tabla SUDO.TipoCuenta de los 4 TipoCuenta'
GO

-----------Migracion Pais-----------
SET IDENTITY_INSERT SUDO.Pais ON

	INSERT INTO SUDO.Pais(codigoPais, descripcion)
		SELECT * 
		FROM (SELECT DISTINCT Cli_Pais_Codigo, Cli_Pais_Desc 
			  FROM gd_esquema.Maestra 
			  WHERE Cli_Pais_Codigo IS NOT NULL
			  	UNION
			  		SELECT DISTINCT Cuenta_Pais_Codigo, Cuenta_Pais_Desc 
			  		FROM gd_esquema.Maestra
			  		WHERE Cuenta_Pais_Codigo IS NOT NULL)
	AS P /*TODO no entiendo por que P */

SET IDENTITY_INSERT SUDO.Pais OFF

PRINT 'Tabla SUDO.Pais Migrada'
GO

-----------Migracion TipoDoc-----------
SET IDENTITY_INSERT SUDO.TipoDoc ON

	INSERT INTO SUDO.TipoDoc(idTipoIdentintificacion, descripcion)
		SELECT DISTINCT Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc 
		FROM gd_esquema.Maestra

SET IDENTITY_INSERT SUDO.TipoDoc OFF

PRINT 'Tabla SUDO.TipoDoc Migrada'
GO

-----------Migracion Banco-----------
SET IDENTITY_INSERT SUDO.Banco ON

	INSERT INTO SUDO.Banco(codigo, nombre, direccion)
		SELECT DISTINCT Banco_Cogido, Banco_Nombre, Banco_Direccion 
		FROM gd_esquema.Maestra 
		WHERE Banco_Cogido IS NOT NULL
		
SET IDENTITY_INSERT SUDO.Banco OFF

PRINT 'Tabla SUDO.Banco Migrada'
GO

-----------Migracion Cheque-----------

SET IDENTITY_INSERT SUDO.Cheque ON

	INSERT INTO SUDO.Cheque(idCheque, fecha, importe, codigoBanco)
		SELECT DISTINCT Cheque_Numero, Cheque_Fecha, Cheque_Importe, Banco_Cogido 
		FROM gd_esquema.Maestra 
		WHERE Cheque_Numero IS NOT NULL

SET IDENTITY_INSERT SUDO.Cheque OFF

PRINT 'Tabla SUDO.Cheque Migrada'

GO

-----------Migracion Domicilio-----------
INSERT INTO SUDO.Domicilio(calle, numero, piso, depto, codigoPais)
	SELECT DISTINCT Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Pais_Codigo
	FROM gd_esquema.Maestra 
	WHERE Cheque_Numero IS NOT NULL

GO
