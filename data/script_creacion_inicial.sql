







---------------------------------------------------------------------------
			--  	Drop FK
---------------------------------------------------------------------------
---- PermisoXRol -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.PermisoXRol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Rol DROP CONSTRAINT idRol;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.PermisoXRol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Permiso DROP CONSTRAINT idPermiso;
---- UsuarioXRol -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.UsuarioXRol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Rol DROP CONSTRAINT idRol;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.UsuarioXRol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Usuario DROP CONSTRAINT idUsuario;
---- HistorialLogin -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.HistorialLogin') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Usuario DROP CONSTRAINT idUsuario;
---- Cliente -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cliente') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Usuario DROP CONSTRAINT idUsuario;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cliente') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Domicilio DROP CONSTRAINT idDomicilio;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cliente') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.TipoIdentintificacion DROP CONSTRAINT idTipoIdentintificacion;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cliente') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.TipoIdentintificacion DROP CONSTRAINT idTipoIdentintificacion;
---- Domicilio -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Domicilio') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Pais DROP CONSTRAINT idPais;
---- Cuenta -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cuenta') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Usuario DROP CONSTRAINT idUsuario;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cuenta') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Pais DROP CONSTRAINT idPais;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cuenta') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Moneda DROP CONSTRAINT idMoneda;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cuenta') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.TipoCuenta DROP CONSTRAINT idTipoCuenta;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cuenta') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.EstadoCuenta DROP CONSTRAINT idEstadoCuenta;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cuenta') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Retiro DROP CONSTRAINT idRetiro;
---- Retiro -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Retiro') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Cheque DROP CONSTRAINT idCheque;
---- Cheque -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cheque') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Banco DROP CONSTRAINT idBanco;
---- Deposito -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Deposito') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Cuenta DROP CONSTRAINT idCuenta;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Deposito') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Tarjeta DROP CONSTRAINT idTarjeta;
---- Tarjeta -----
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Tarjeta') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1
)
ALTER TABLE SUDO.Cliente DROP CONSTRAINT idCliente;

---------------------------------------------------------------------------
			--  	Drop tablas
---------------------------------------------------------------------------

IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Permiso') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Permiso
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.PermisoXRol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.PermisoXRol
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Rol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Rol
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.UsuarioXRol') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.UsuarioXRol
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Usuario') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Usuario
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.HistorialLogin') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.HistorialLogin
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cliente') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Cliente
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.TipoDoc') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.TipoDoc
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Domicilio') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Domicilio
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Pais') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Pais
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cuenta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Cuenta
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Retiro') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Retiro
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Cheque') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Cheque
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Banco') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Banco
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.EstadoCuenta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.EstadoCuenta
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.TipoCuenta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.TipoCuenta
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Moneda') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Moneda
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Deposito') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Deposito
;
IF EXISTS (
	SELECT * FROM dbo.sysobjects 
	WHERE id = object_id('SUDO.Tarjeta') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1
)
DROP TABLE SUDO.Tarjeta
;

---------------------------------------------------------------------------
			--  	Creacion de tablas
---------------------------------------------------------------------------

-----------Tabla Permiso-----------
CREATE TABLE SUDO.Permiso ( 
	idPermiso integer IDENTITY(1,1),
	nombre varchar(15),
	
	primary key (idPermiso)
)
;
-----------Tabla Permiso X Rol-----------
CREATE TABLE SUDO.PermisoXRol ( 
	idRol integer,
	idPermiso integer,
	
	foreign key (idRol) references SUDO.Rol,
	foreign key (idPermiso) references SUDO.Permiso
)
;
-----------Tabla Rol-----------
CREATE TABLE SUDO.Rol ( 
	idRol integer IDENTITY(1,1),
	nombreRol varchar(15),
	estado integer DEFAULT 1,
	
	primary key (idRol)
)
;
-----------Tabla Usuario X Rol-----------
CREATE TABLE SUDO.UsuarioXRol ( 
	idRol integer,
	idUsuario integer,
	
	foreign key (idRol) references SUDO.Rol,
	foreign key (idUsuario) references SUDO.Usuario
)
;
-----------Tabla Usuario-----------
CREATE TABLE SUDO.Usuario ( 
	idUsuario integer IDENTITY(1,1),
	userName varchar(50) NOT NULL UNIQUE,
	password varchar(100) NOT NULL,
	fechaCreacion datetime,
	fechaDeUltimaModificacion datetime,
	preguntaSecreta varchar(100) NOT NULL,
	respuestaSecreta varchar(100) NOT NULL,
	contIntentosFallidos integer DEFAULT 0,
	estado integer DEFAULT 1,
	
	primary key (idUsuario)
)
;
-----------TABLA HistorialLogin-----------
CREATE TABLE SUDO.HistorialLogin ( 
	idHistorialLogin integer IDENTITY(1,1),
	idUsuario integer,
	fechaHora datetime,
	estado integer DEFAULT 0,
	numeroIntentoFallido integer DEFAULT 0,
	
	primary key (idHistorialLogin),
	foreign key (idUsuario) references SUDO.Usuario
)
;
-----------Tabla Cliente-----------
CREATE TABLE SUDO.Cliente ( 
	idCliente integer IDENTITY(1,1),
	idUsuario integer,
	idDomicilio integer,
	idTipoIdentintificacion integer,
	nombre varchar(255),
	apellido varchar(255),
	mail varchar(255) NOT NULL,
	fechaDeNac datetime,
	numeroIdentintificacion integer,
	estado integer DEFAULT 1,
	
	primary key (idCliente),
	foreign key (idUsuario) references SUDO.Usuario,
	foreign key (idDomicilio) references SUDO.Domicilio,
	foreign key (idTipoIdentintificacion) references SUDO.TipoDoc
)
;
-----------Tabla TipoDoc-----------
CREATE TABLE SUDO.TipoDoc ( 
	idTipoIdentintificacion integer IDENTITY(1,1),
	descripcion varchar(255),
	
	primary key (idTipoIdentintificacion)
)
;
-----------Tabla Domicilio-----------
CREATE TABLE SUDO.Domicilio ( 
	idDomicilio integer IDENTITY(1,1),
	idPais integer,
	numero integer,
	calle varchar(15),
	piso varchar(5),
	depto varchar(5),
	localidad varchar(15),
	
	primary key (idDomicilio),
	foreign key (idPais) references SUDO.Pais
)
;
-----------Tabla Pais-----------
CREATE TABLE SUDO.Pais ( 
	idPais integer IDENTITY(1,1),
	codigo varchar(5),
	descripcion varchar(255),
	
	primary key (idPais)
)
;
-----------Tabla Cuenta-----------
CREATE TABLE SUDO.Cuenta ( 
	idCuenta integer IDENTITY(1,1),
	idUsuario integer,
	idPais integer,
	nroCuenta integer NOidEstadoCuentaT NULL UNIQUE,
	idMoneda integer,
	fechaCreacion datetime,
	fechaCierre datetime,
	idTipoCuenta integer,
	idEstadoCuenta integer,
	idRetiro integer,
	estado integer DEFAULT 1,
	
	primary key (idCuenta),
	foreign key (idUsuario) references SUDO.Usuario,
	foreign key (idPais) references SUDO.Pais,
	foreign key (idMoneda) references SUDO.Moneda,
	foreign key (idTipoCuenta) references SUDO.TipoCuenta,
	foreign key (idEstadoCuenta) references SUDO.EstadoCuenta,
	foreign key (idRetiro) references SUDO.Retiro
)
;
-----------Tabla Retiro-----------
CREATE TABLE SUDO.Retiro ( 
	codigo integer IDENTITY(1,1),
	fecha datetime,
	importe numeric(18,2),
	idCheque integer,
	
	primary key (codigo),
	foreign key (idCheque) references SUDO.Cheque
)
;
-----------Tabla Cheque-----------
CREATE TABLE SUDO.Cheque ( 
	idCheque integer IDENTITY(1,1),
	fecha datetime,
	importe numeric(18,2),
	idBanco integer,
	
	primary key (idCheque),
	foreign key (idBanco) references SUDO.Banco
)
;
-----------Tabla Banco-----------
CREATE TABLE SUDO.Banco ( 
	idBanco integer IDENTITY(1,1),
	codigo integer,
	nombre varchar(255),
	direccion varchar(255),
	
	primary key (idBanco)
)
;
-----------Tabla EstadoCuenta-----------
CREATE TABLE SUDO.EstadoCuenta ( 
	idEstadoCuenta integer IDENTITY(1,1),
	descripcion varchar(255),
	
	primary key (idEstadoCuenta)
)
;
-----------Tabla TipoCuenta-----------
CREATE TABLE SUDO.TipoCuenta ( 
	idTipoCuenta integer IDENTITY(1,1),
	nombre varchar(255),
	duracion datetime,								//TODO
	costo numeric(18,2), 
	
	primary key (idTipoCuenta)
)
;
-----------Tabla Moneda-----------
CREATE TABLE SUDO.Moneda ( 
	idMoneda integer IDENTITY(1,1),
	descripcion varchar(255),
	
	primary key (idMoneda)
)
;
-----------Tabla Deposito-----------
CREATE TABLE SUDO.Deposito ( 
	idDeposito integer IDENTITY(1,1),
	idCuenta integer,
	importe numeric(18,2),
	fecha datetime,
	idMoneda integer,
	idTarjeta integer,
	
	primary key (idDeposito),
	foreign key (idCuenta) references SUDO.Cuenta
	foreign key (idTarjeta) references SUDO.Tarjeta
)
;
-----------Tabla Tarjeta-----------
CREATE TABLE SUDO.Tarjeta ( 
	idTarjeta integer IDENTITY(1,1),
	numero integer,
	emisorDesc varchar(255),
	fechaEmision datetime,
	idCliente integer,
	fechaVencimiento datetime,
	codigoSeguridad integar,				//TODO
	estado integer DEFAULT 1,	
	
	primary key (idTarjeta),
	foreign key (idCliente) references SUDO.Cliente
)
;