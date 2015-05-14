











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
CREATE TABLE SUDO.PermisoXRol ( 
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
	nroCuenta integer NOT NULL UNIQUE,
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