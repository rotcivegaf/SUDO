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
PRINT 'Tablas borradas'
GO


---------------------------------------------------------------------------
			--  	Drop procedures
---------------------------------------------------------------------------
IF OBJECT_ID ('SUDO.NuevaMonedaDesc') IS NOT NULL DROP PROCEDURE SUDO.NuevaMonedaDesc
IF OBJECT_ID ('SUDO.NuevoEstadoCuentaDesc') IS NOT NULL DROP PROCEDURE SUDO.NuevoEstadoCuentaDesc
IF OBJECT_ID ('SUDO.AgregarFuncionalidadNombre') IS NOT NULL DROP PROCEDURE SUDO.AgregarFuncionalidadNombre
IF OBJECT_ID ('SUDO.NuevoTipoCuenta') IS NOT NULL DROP PROCEDURE SUDO.NuevoTipoCuenta
IF OBJECT_ID ('SUDO.NuevoRol') IS NOT NULL DROP PROCEDURE SUDO.NuevoRol
IF OBJECT_ID ('SUDO.AsociarFuncionalidadXRol') IS NOT NULL DROP PROCEDURE SUDO.AsociarFuncionalidadXRol
IF OBJECT_ID ('SUDO.AsociarUsuarioXRol') IS NOT NULL DROP PROCEDURE SUDO.AsociarUsuarioXRol
IF OBJECT_ID ('SUDO.NuevoUsuario') IS NOT NULL DROP PROCEDURE SUDO.NuevoUsuario

PRINT 'Procesos borrados'
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
	codigoPais 		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
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
	password 					varchar(255) NOT NULL,
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
	nombre 		varchar(255),
);

-----------Tabla Rol-----------
CREATE TABLE SUDO.Rol ( 
	idRol 		integer IDENTITY(1,1) PRIMARY KEY,
	nombreRol 	varchar(255),
	estado 		BIT DEFAULT 1,
);

-----------Tabla Funcionalidad X Rol-----------
CREATE TABLE SUDO.FuncionalidadXRol ( 
	idRol 		integer FOREIGN KEY REFERENCES SUDO.Rol,
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
	idUsuario 				integer FOREIGN KEY REFERENCES SUDO.Usuario,
	fechaHora 				datetime,
	estado 					BIT DEFAULT 0,
	numeroIntentoFallido 	TINYINT DEFAULT 0,
);

-----------Tabla Cliente-----------
CREATE TABLE SUDO.Cliente ( 
	idCliente 		numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	idUsuario 		integer DEFAULT NULL,
	idTipoDoc		numeric(18,0) FOREIGN KEY REFERENCES SUDO.TipoDoc,
	codigoPais 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Pais,
	nombre 			varchar(255) NOT NULL,
	apellido 		varchar(255) NOT NULL,
	mail 			varchar(255) NOT NULL,
	fechaDeNac 		datetime,
	nroDoc			numeric(18,0) NOT NULL,
	estado 			BIT DEFAULT 1,
	dirNumero 		numeric(18,0),
	dirCalle 		varchar(255),
	dirPiso 		numeric(18,0),
	dirDepto 		varchar(10),
	nacionalidad	varchar(255) DEFAULT 'Argentino',
);

-----------Tabla Factura-----------
CREATE TABLE SUDO.Factura ( 
	numero		numeric(18,0) PRIMARY KEY,
	idCliente	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cliente,
	fecha 		datetime,
);

-----------Tabla Item (Factura)-----------
CREATE TABLE SUDO.Item ( 
	idItem			integer IDENTITY(1,1) PRIMARY KEY,
	importe 		numeric(18,2) NOT NULL,
	descripcion 	varchar(255),
	numeroFactura	numeric(18,0) FOREIGN KEY REFERENCES SUDO.Factura,
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
	idCliente 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cliente,
	codigoPais 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Pais,
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
	idCliente 			numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cliente,
	numero 				numeric(16) NOT NULL UNIQUE,
	descEmisor 			varchar(255),
	fechaEmisor 		datetime NOT NULL,
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
	importe 		numeric(18,2),  /*mayor o igual a uno  TODO*/
	fecha 			datetime,
);

-----------Tabla Deposito-----------
CREATE TABLE SUDO.Deposito ( 
	codigo 			numeric(18,0) IDENTITY(1,1) PRIMARY KEY,
	nroCuenta 		numeric(18,0) FOREIGN KEY REFERENCES SUDO.Cuenta,
	idTarjeta 		integer FOREIGN KEY REFERENCES SUDO.tarjeta,
	idMoneda 		integer FOREIGN KEY REFERENCES SUDO.Moneda,
	importe 		numeric(18,2),  /*mayor o igual a uno  TODO*/
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
			--  	Creacion Triggers
---------------------------------------------------------------------------

---------------------------------------------------------------------------
			--  	Creacion Stored Procedures
---------------------------------------------------------------------------
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
/*TODO ENCRIPTAR PASSWORD*/
CREATE PROCEDURE SUDO.NuevoUsuario(@UserName VARCHAR(255), @FechaCreacion datetime, @FechaDeUltimaModificacion datetime,
									@PreguntaSecreta VARCHAR(255), @RespuestaSecreta VARCHAR(255), @CantIntentosFallidos TINYINT, @Estado BIT) AS
	BEGIN
		INSERT INTO SUDO.Usuario(userName, password, fechaCreacion, fechaDeUltimaModificacion, preguntaSecreta, respuestaSecreta, cantIntentosFallidos, estado)
		VALUES(@UserName, 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7' , @FechaCreacion, @FechaDeUltimaModificacion,@PreguntaSecreta, @RespuestaSecreta, @CantIntentosFallidos, @Estado)
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
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'asociar/desasociar tarjetas de credito'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'depositos'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'retiro'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'transferencias'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'facturacion'
EXEC SUDO.AgregarFuncionalidadNombre @Nombre = 'consulta saldos'
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
EXEC SUDO.AsociarFuncionalidadXRol @NombreRol = 'Administrador', @NombreFuncionalidad  = 'asociar/desasociar tarjetas de credito'

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
EXEC SUDO.NuevoUsuario @UserName= 'admin', @FechaCreacion= NULL, @FechaDeUltimaModificacion= NULL,@PreguntaSecreta='quien?', @RespuestaSecreta='yo', @CantIntentosFallidos= 0, @Estado= 1

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
	INSERT INTO SUDO.TipoDoc(idTipoDoc, descripcion)
		SELECT DISTINCT Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc 
		FROM gd_esquema.Maestra
SET IDENTITY_INSERT SUDO.TipoDoc OFF

PRINT 'Tabla SUDO.TipoDoc Migrada'
GO

-----------Migracion Cliente-----------
INSERT INTO SUDO.Cliente(nroDoc, nombre, apellido, mail, fechaDeNac, idTipoDoc, dirCalle, dirNumero, dirPiso, dirDepto, codigoPais)
	SELECT Cli_Nro_Doc, Cli_Nombre, Cli_apellido, Cli_Mail, Cli_Fecha_Nac, idTipoDoc, Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Pais_Codigo
		FROM (SELECT DISTINCT Cli_Nro_Doc, Cli_Nombre, Cli_apellido, Cli_Mail, Cli_Fecha_Nac, idTipoDoc, Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Pais_Codigo
			  FROM gd_esquema.Maestra m JOIN SUDO.TipoDoc d ON (m.Cli_Tipo_Doc_Cod = d.idTipoDoc)
			  WHERE (Cli_Tipo_Doc_Cod IS NOT NULL)
		) MConDoc JOIN SUDO.Pais P ON (MConDoc.Cli_Pais_Codigo = P.codigoPais)

PRINT 'Tabla SUDO.Cliente Migrada'
GO

-----------Migracion Factura-----------
INSERT INTO SUDO.Factura(numero, fecha, idCliente)
	SELECT DISTINCT Factura_Numero, Factura_Fecha, c.idCliente
	FROM gd_esquema.Maestra m join SUDO.Cliente c ON ((m.Cli_Nro_Doc = c.nroDoc)AND(m.Cli_Tipo_Doc_Cod = c.idTipoDoc))
	WHERE Factura_Numero IS NOT NULL

PRINT 'Tabla SUDO.Factura Migrada'
GO

-----------Migracion Item-----------
INSERT INTO SUDO.Item(importe, descripcion, numeroFactura)
	SELECT Item_Factura_Importe, Item_Factura_Descr, f.numero
	FROM gd_esquema.Maestra m join SUDO.Factura f ON (f.numero = m.Factura_Numero)
	WHERE Item_Factura_Importe IS NOT NULL

PRINT 'Tabla SUDO.Item Migrada'
GO

-----------Migracion Tarjeta-----------
INSERT INTO SUDO.Tarjeta(numero, fechaEmisor, fechaVencimiento, codigoSeguridad, descEmisor, idCliente)
	SELECT DISTINCT Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Codigo_Seg, Tarjeta_Emisor_Descripcion, c.idCliente
	FROM gd_esquema.Maestra m join SUDO.Cliente c ON ((m.Cli_Nro_Doc = c.nroDoc)AND(m.Cli_Tipo_Doc_Cod = c.idTipoDoc))
	WHERE Tarjeta_Numero IS NOT NULL

PRINT 'Tabla SUDO.Tarjeta Migrada'
GO

-----------Migracion Cuenta-----------
SET IDENTITY_INSERT SUDO.Cuenta ON
INSERT INTO SUDO.Cuenta(nroCuenta, fechaCreacion, fechaCierre, codigoPais, idEstadoCuenta, idCliente)
	SELECT DISTINCT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, codigoPais, idEstadoCuenta, idCliente
	FROM( SELECT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, descEstadoCuenta, codigoPais, idCliente
	      FROM( SELECT DISTINCT Cuenta_Numero, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre,Cuenta_Pais_Codigo, (ISNULL ( m.Cuenta_Estado , 'Inhabilitada')) descEstadoCuenta, idCliente
		  		FROM gd_esquema.Maestra m join SUDO.Cliente c ON ((m.Cli_Nro_Doc = c.nroDoc)AND(m.Cli_Tipo_Doc_Cod = c.idTipoDoc))
		  		)m_c JOIN SUDO.Pais p ON (m_c.Cuenta_Pais_Codigo = p.codigoPais)
		)m_c_p JOIN SUDO.EstadoCuenta ec ON (m_c_p.descEstadoCuenta = ec.descripcion)
SET IDENTITY_INSERT SUDO.Cuenta OFF

UPDATE SUDO.Cuenta SET idTipoCuenta = (SELECT idTipoCuenta
										FROM SUDO.TipoCuenta
										WHERE (nombre = 'Gratuita')),
						idMoneda = (SELECT idMoneda
									FROM SUDO.Moneda
									WHERE (descripcion = 'Dolar'))

PRINT 'Tabla SUDO.Cuenta Migrada'
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

-----------Migracion Retiro-----------
SET IDENTITY_INSERT SUDO.Retiro ON
	INSERT INTO SUDO.Retiro(codigo, idCheque, fecha, importe, idCuenta)
		SELECT DISTINCT Retiro_Codigo, Cheque_Numero, Retiro_Fecha, Retiro_Importe, nroCuenta
		FROM gd_esquema.Maestra m JOIN SUDO.Cuenta c ON (m.Cuenta_Numero = c.nroCuenta) 
		WHERE Retiro_Codigo IS NOT NULL
SET IDENTITY_INSERT SUDO.Retiro OFF

PRINT 'Tabla SUDO.Retiro Migrada'
GO

-----------Migracion Deposito-----------
SET IDENTITY_INSERT SUDO.Deposito ON
	INSERT INTO SUDO.Deposito(codigo, fecha, importe, nroCuenta, idTarjeta)
		SELECT Deposito_Codigo, Deposito_Fecha, Deposito_Importe, nroCuenta, idTarjeta
		FROM(SELECT DISTINCT Deposito_Codigo, Deposito_Fecha, Deposito_Importe, nroCuenta ,Tarjeta_Numero
			 FROM gd_esquema.Maestra m join SUDO.Cuenta c on (m.Cuenta_Numero = c.nroCuenta)
			)m_c join SUDO.Tarjeta t on (m_c.Tarjeta_Numero = t.numero)
SET IDENTITY_INSERT SUDO.Deposito OFF

UPDATE SUDO.Deposito SET idMoneda = (SELECT idMoneda
									FROM SUDO.Moneda
									WHERE (descripcion = 'Dolar'))

PRINT 'Tabla SUDO.Deposito Migrada'
GO

-----------Migracion Transferencia-----------
INSERT INTO SUDO.Transferencia(fecha, importe, costo, nroCuentaOrigen, nroCuentaDest)
	SELECT Transf_Fecha, Trans_Importe, Trans_Costo_Trans, m_c.nroCuenta, c2.nroCuenta
	FROM(SELECT DISTINCT Cuenta_Dest_Numero, Transf_Fecha, Trans_Importe, Trans_Costo_Trans, Cuenta_Dest_Estado, Cuenta_Dest_Fecha_Cierre, Cuenta_Dest_Fecha_Creacion, Cuenta_Dest_Pais_Codigo, nroCuenta
		 FROM gd_esquema.Maestra m join SUDO.Cuenta c on (m.Cuenta_Numero = c.nroCuenta)
	)m_c join SUDO.Cuenta c2 on ((m_c.Cuenta_Dest_Numero = c2.nroCuenta)AND(m_c.Cuenta_Dest_Fecha_Creacion = c2.fechaCreacion)AND(m_c.Cuenta_Dest_Pais_Codigo = c2.codigoPais))


PRINT 'Tabla SUDO.Transferencia Migrada'
GO

