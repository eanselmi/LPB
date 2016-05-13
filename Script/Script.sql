USE [GD1C2016]

IF NOT EXISTS (
	SELECT  schema_name
	FROM        information_schema.SCHEMATA
	WHERE   schema_name = 'LPB' )
BEGIN
	EXEC sp_executesql N'CREATE SCHEMA LPB '
END
GO

/*---------------Limpieza de Tablas-------------*/
/*---------Si la tabla ya existe la borro-------------*/

BEGIN TRANSACTION
IF OBJECT_ID('LPB.FuncionalidadesPorRol') IS NOT NULL
BEGIN
        DROP TABLE LPB.FuncionalidadesPorRol ;
END;
IF OBJECT_ID('LPB.RolesPorUsuario') IS NOT NULL
BEGIN
        DROP TABLE LPB.RolesPorUsuario ;
END;
IF OBJECT_ID('LPB.Empresas') IS NOT NULL
BEGIN
        DROP TABLE LPB.Empresas ;
END;
IF OBJECT_ID('LPB.Compras') IS NOT NULL
BEGIN
		DROP TABLE LPB.Compras;
END;
IF OBJECT_ID('LPB.Items') IS NOT NULL
BEGIN
        DROP TABLE LPB.Items ;
END;
IF OBJECT_ID('LPB.Facturas') IS NOT NULL
BEGIN
        DROP TABLE LPB.Facturas ;
END;
IF OBJECT_ID('LPB.Ofertas') IS NOT NULL
BEGIN
		DROP TABLE LPB.Ofertas;
END;
IF OBJECT_ID('LPB.FormasDePago') IS NOT NULL
BEGIN
        DROP TABLE LPB.FormasDePago ;
END;
IF OBJECT_ID('LPB.Publicaciones') IS NOT NULL
BEGIN
		DROP TABLE LPB.Publicaciones;
END;
IF OBJECT_ID('LPB.Rubros') IS NOT NULL
BEGIN
		DROP TABLE LPB.Rubros;
END;
IF OBJECT_ID('LPB.EstadosDePublicacion') IS NOT NULL
BEGIN
		DROP TABLE LPB.EstadosDePublicacion;
END;
IF OBJECT_ID('LPB.TiposDePublicacion') IS NOT NULL
BEGIN
		DROP TABLE LPB.TiposDePublicacion;
END;
IF OBJECT_ID('LPB.Clientes') IS NOT NULL
BEGIN
	DROP TABLE LPB.Clientes;
END;
IF OBJECT_ID('LPB.Usuarios') IS NOT NULL
BEGIN
        DROP TABLE LPB.Usuarios ;
END;
IF OBJECT_ID('LPB.Roles') IS NOT NULL
BEGIN
        DROP TABLE LPB.Roles ;
END;
IF OBJECT_ID('LPB.Funcionalidades') IS NOT NULL
BEGIN
        DROP TABLE LPB.Funcionalidades ;
END;
IF OBJECT_ID('LPB.Localidades') IS NOT NULL
BEGIN
        DROP TABLE LPB.Localidades ;
END;
IF OBJECT_ID('LPB.Publicaciones') IS NOT NULL
BEGIN
        DROP TABLE LPB.Publicaciones ;
END;
IF OBJECT_ID('LPB.Calificaciones') IS NOT NULL
BEGIN
        DROP TABLE LPB.Calificaciones ;
END;
IF OBJECT_ID('LPB.Visibilidades') IS NOT NULL
BEGIN
        DROP TABLE LPB.Visibilidades ;
END;
COMMIT;
/*---------Definiciones de Tabla-------------*/

CREATE TABLE [LPB].Usuarios(
id INT NOT NULL IDENTITY(1,1),
TipoUsuario VARCHAR(25) NOT NULL,
username VARCHAR(45) NOT NULL,
pass VARCHAR(100) NOT NULL,
habilitado BIT DEFAULT 1,
cantIntentosFallidos INT DEFAULT 0,
nuevo BIT DEFAULT 1,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].RolesPorUsuario(
Rol_id INT NOT NULL,
Usuario_id INT NOT NULL,
PRIMARY KEY(Rol_id, Usuario_id));
GO

CREATE TABLE [LPB].Roles(
id INT NOT NULL IDENTITY(1,1),
nombre VARCHAR(45) NOT NULL,
habilitado BIT DEFAULT 1,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].Funcionalidades(
id INT NOT NULL IDENTITY(1,1),
descripcion varchar(45) NOT NULL,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].FuncionalidadesPorRol(
Funcionalidad_id INT NOT NULL,
Rol_id INT NOT NULL,
PRIMARY KEY(Funcionalidad_id, Rol_id));
GO

CREATE TABLE [LPB].FormasDePago(
id INT NOT NULL IDENTITY(1,1),
descripcion nvarchar(255) NOT NULL,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].Facturas(
numero numeric(18,0) UNIQUE NOT NULL,
fecha DATETIME NOT NULL,
total numeric(18,2) NOT NULL,
FormaDePago_id INT NOT NULL,
PRIMARY KEY(numero));
GO

CREATE TABLE [LPB].Items(
id INT NOT NULL IDENTITY(1,1),
monto numeric(18,2) NOT NULL,
cantidad numeric(18,0) NOT NULL,
Factura_nro	numeric(18,0) NOT NULL,
Publicacion_cod numeric(18,0) NOT NULL,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].Empresas(
id INT NOT NULL IDENTITY(1,1),
razonSocial nvarchar(255) NOT NULL,
cuit nvarchar(50) NOT NULL,
mail nvarchar(50) NOT NULL,
domicilioCalle nvarchar(100) NOT NULL,
nroCalle numeric(18,0) NOT NULL,
piso numeric(18,0),
dpto nvarchar(50),
codPostal nvarchar(50) NOT NULL,
rubro nvarchar(100) NULL,
nombreContacto nvarchar(100),
fechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
Localidad_id INT NULL,
Usuario_id INT NOT NULL,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].Clientes(
id INT NOT NULL IDENTITY(1,1),
dni NUMERIC(18,0) NOT NULL,
apellido NVARCHAR(255) NOT NULL,
nombre NVARCHAR(255) NOT NULL,
fechaNacimiento DATETIME NOT NULL,
mail NVARCHAR(255) NOT NULL,
domicilioCalle nvarchar(255) NOT NULL,
nroCalle NUMERIC(18,0) NOT NULL,
piso NUMERIC(18,0) NOT NULL,
dpto NVARCHAR(50),
codPostal NVARCHAR(50) NOT NULL,
fechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
Localidad_id INT, 
Usuario_id INT NOT NULL,
PRIMARY KEY(ID));
GO

CREATE TABLE [LPB].Localidades(
id INT NOT NULL IDENTITY(1,1),
descripcion varchar(45) NOT NULL,
PRIMARY KEY(id)
)
GO

CREATE TABLE [LPB].Publicaciones(
codigo NUMERIC (18,0) NOT NULL,
Usuario_id INT,
EstadoDePublicacion_id INT,
TipoDePublicacion_id INT,
descripcion NVARCHAR(255),
stock NUMERIC(18,0) NOT NULL,
fechaCreacion DATETIME NOT NULL,
fechaVencimiento DATETIME NOT NULL,
precio NUMERIC(18,2) NOT NULL,
aceptaEnvio BIT,
Visibilidad_codigo NUMERIC(18,0),
Rubro_id INT,
PRIMARY KEY(codigo)
)
GO

CREATE TABLE [LPB].Rubros(
id INT NOT NULL IDENTITY(1,1),
descripcion NVARCHAR(255),
PRIMARY KEY(id)
)
GO

CREATE TABLE [LPB].EstadosDePublicacion(
id INT NOT NULL IDENTITY(1,1),
descripcion NVARCHAR(255),
PRIMARY KEY(id)
)
GO

CREATE TABLE [LPB].TiposDePublicacion(
id INT NOT NULL IDENTITY(1,1),
descripcion NVARCHAR(255),
PRIMARY KEY(id)
)
GO

CREATE TABLE [LPB].Calificaciones(
codigo NUMERIC (18,0) NOT NULL,
descripcion nvarchar(255) NOT NULL,
cantEstrellas NUMERIC (18,0) NOT NULL,
PRIMARY KEY(codigo)
)
GO

CREATE TABLE [LPB].Visibilidades(
codigo NUMERIC (18,0) NOT NULL ,
descripcion nvarchar(255) NOT NULL,
precio NUMERIC(18,2) NOT NULL,
porcentaje NUMERIC(18,2) NOT NULL,
comisionPorEnvio NUMERIC(18,2),
PRIMARY KEY(codigo)
)
GO

CREATE TABLE [LPB].Compras(
id INT NOT NULL IDENTITY(1,1),
fecha DATETIME NOT NULL default getdate(),
cantidad NUMERIC(18,0) NOT NULL,
Cliente_id INT NOT NULL,
Publicacion_cod NUMERIC(18,0) NOT NULL,
Calificacion_cod NUMERIC(18,0),
envio BIT NOT NULL,
primary key (id))
GO

CREATE TABLE [LPB].Ofertas(
id INT NOT NULL IDENTITY(1,1),
fecha DATETIME NOT NULL default getdate(),
monto NUMERIC(18,2) NOT NULL,
Cliente_id INT NOT NULL,
Publicacion_cod NUMERIC(18,0) NOT NULL,
Calificacion_cod NUMERIC(18,0), 
ganadora BIT NOT NULL,
envio BIT NOT NULL,
primary key (id))
GO


/*---------Definiciones de FK-------*/

ALTER TABLE LPB.Publicaciones ADD
            FOREIGN KEY (Usuario_id) references LPB.Usuarios,
            FOREIGN KEY (EstadoDePublicacion_id) references LPB.EstadosDePublicacion,
			FOREIGN KEY (TipoDePublicacion_id) references LPB.TiposDePublicacion,
			FOREIGN KEY (Visibilidad_codigo) references LPB.Visibilidades,
			FOREIGN KEY (Rubro_id) references LPB.Rubros;
GO

ALTER TABLE LPB.RolesPorUsuario ADD
            FOREIGN KEY (Rol_id) references LPB.Roles,
            FOREIGN KEY (Usuario_id) references LPB.Usuarios;
GO
                                                            
ALTER TABLE LPB.FuncionalidadesPorRol ADD
            FOREIGN KEY (Funcionalidad_id) references LPB.Funcionalidades,
            FOREIGN KEY (Rol_id) references LPB.roles;
GO   
                                                         
ALTER TABLE LPB.Facturas ADD
            FOREIGN KEY (FormaDePago_id) references LPB.FormasDePago
GO

ALTER TABLE LPB.Items ADD
            FOREIGN KEY (Factura_nro) references LPB.Facturas,
			FOREIGN KEY (Publicacion_cod) references LPB.Publicaciones;
GO

ALTER TABLE LPB.Empresas ADD
            FOREIGN KEY (Usuario_id) references LPB.Usuarios,
			FOREIGN KEY (Localidad_ID) references LPB.Localidades;
GO

ALTER TABLE LPB.Clientes add
	    FOREIGN KEY (Usuario_id) references LPB.Usuarios,
	    FOREIGN KEY (Localidad_id) references LPB.Localidades;
GO


ALTER TABLE LPB.Compras ADD
		FOREIGN KEY (Cliente_id) references LPB.Clientes,
		FOREIGN KEY (Publicacion_cod) references LPB.Publicaciones,
		FOREIGN KEY (Calificacion_cod) references LPB.Calificaciones;
GO

ALTER TABLE LPB.Ofertas ADD
		FOREIGN KEY (Cliente_id) references LPB.Clientes,
		FOREIGN KEY (Publicacion_cod) references LPB.Publicaciones,
		FOREIGN KEY (Calificacion_cod) references LPB.Calificaciones;
GO

/* Declaración de variables */

DECLARE @DocumentoCodigo_Dni VARCHAR(10) = 'DNI'
DECLARE @DocumentoCodigo_Cuil VARCHAR(10) = 'CUIL'
DECLARE @DocumentoCodigo_Cuit VARCHAR(10) = 'CUIT'

DECLARE @TipoDeUsuario_Cliente VARCHAR(15) = 'Cliente'
DECLARE @TipoDeUsuario_Empresa VARCHAR(15) = 'Empresa'
DECLARE @TipoDeUsuario_Administrador VARCHAR(15) = 'Administrador'

DECLARE @RolId_Administrador INT = 1
DECLARE @RolId_Cliente INT = 2
DECLARE @RolId_Empresa INT = 3

/*---------Carga de datos / migracion--------------------*/


/*Roles*/
BEGIN TRANSACTION
INSERT INTO LPB.Roles (nombre) VALUES ('Administrador');
INSERT INTO LPB.Roles (nombre) VALUES('Cliente');
INSERT INTO LPB.Roles (nombre) VALUES('Empresa');
COMMIT;


/*Funcionalidades*/
BEGIN TRANSACTION
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('abmRol');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('abmUsuario');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('abmRubro');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('abmVisibilidad');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('generarPublicacion');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('comprar/ofertar');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('historialCliente');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('calificarVendedor');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('consultaFacturas');
INSERT INTO LPB.Funcionalidades (descripcion) VALUES ('listadoEstadistico');
COMMIT;


/*Funcionalidad por rol*/
DECLARE @ID INTEGER;
SET @ID = (SELECT id FROM [LPB].Roles WHERE nombre='Administrador');

BEGIN TRANSACTION
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (1, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (2, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (3, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (4, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (10, @ID);

SET @ID = (SELECT id FROM [LPB].Roles WHERE nombre='Cliente');

INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (5, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (6, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (7, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (8, @ID);

SET @ID = (SELECT id FROM [LPB].Roles WHERE nombre='Empresa');

INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (5, @ID);
INSERT INTO LPB.FuncionalidadesPorRol (Funcionalidad_id, Rol_id) VALUES (9, @ID);

COMMIT;

BEGIN TRANSACTION

INSERT INTO LPB.FormasDePago(descripcion) 
SELECT DISTINCT Forma_Pago_Desc
FROM [gd_esquema].[Maestra]
WHERE Forma_Pago_Desc IS NOT NULL;

COMMIT;


/*creacion Usuarios -HASH del password w23e: 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0dc9be7'*/
BEGIN TRANSACTION
INSERT INTO LPB.Usuarios (TipoUsuario, username, pass, nuevo) VALUES('Administrador','admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0);
COMMIT;

/* Migracion Usuarios */
BEGIN TRANSACTION
INSERT INTO LPB.Usuarios (username, pass,TipoUsuario, nuevo)	
SELECT DISTINCT @DocumentoCodigo_Cuit + REPLACE([Publ_Empresa_Cuit],'-','')
	            ,'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'
              	,@TipoDeUsuario_Empresa
	            ,0	
FROM [gd_esquema].[Maestra]
WHERE [Publ_Empresa_Cuit] IS NOT NULL

UNION ALL

SELECT DISTINCT @DocumentoCodigo_Dni + CAST([Cli_Dni] AS VARCHAR(20))
	            ,'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'	
	            ,@TipoDeUsuario_Cliente
	            ,0
FROM [gd_esquema].[Maestra]
WHERE [Cli_Dni] IS NOT NULL

UNION

SELECT DISTINCT @DocumentoCodigo_Dni + CAST([Publ_Cli_Dni] AS VARCHAR(20))
	            ,'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'	
	            ,@TipoDeUsuario_Cliente
	            ,0
FROM [gd_esquema].[Maestra]
WHERE [Publ_Cli_Dni] IS NOT NULL
COMMIT;

/* Creación/Migración a la par de Empresas */
BEGIN TRANSACTION
INSERT INTO LPB.Empresas (razonSocial, cuit, mail, domicilioCalle, nroCalle, dpto, piso, codPostal, fechaCreacion, Usuario_id)	
SELECT DISTINCT [Publ_Empresa_Razon_Social],
	            [Publ_Empresa_Cuit],
				[Publ_Empresa_Mail],
	            [Publ_Empresa_Dom_Calle],
			    [Publ_Empresa_Nro_Calle],
			    [Publ_Empresa_Depto],
				[Publ_Empresa_Piso],
			    [Publ_Empresa_Cod_Postal],
				[Publ_Empresa_Fecha_Creacion],
				--Usuarios.id
				(select id from LPB.Usuarios where username=@DocumentoCodigo_Cuit + REPLACE([Publ_Empresa_Cuit],'-',''))
FROM [gd_esquema].[Maestra]
--INNER JOIN LPB.Usuarios ON username = @DocumentoCodigo_Cuit + REPLACE([Publ_Empresa_Cuit],'-','') 
/* ralentiza muchisimo la ejecucion */
WHERE [Publ_Empresa_Cuit] IS NOT NULL
COMMIT;

/* Migracion de RolesxUsuario de los usuarios migrados en el paso anterior */
BEGIN TRANSACTION
INSERT INTO LPB.RolesPorUsuario (Usuario_id, Rol_id)
SELECT Id, CASE [TipoUsuario]
		        WHEN @TipoDeUsuario_Administrador THEN @RolId_Administrador
		        WHEN @TipoDeUsuario_Empresa THEN @RolId_Empresa
		        WHEN @TipoDeUsuario_Cliente THEN @RolId_Cliente
	       END
FROM LPB.Usuarios
COMMIT;

/*Migracion de Clientes*/
BEGIN TRANSACTION
INSERT INTO LPB.Clientes (dni,apellido,nombre,fechaNacimiento,mail,domicilioCalle,nroCalle,piso,dpto,codPostal,Localidad_id,Usuario_id)
select distinct [Publ_Cli_Dni],
				[Publ_Cli_Apeliido],
				[Publ_Cli_Nombre],
				[Publ_Cli_Fecha_Nac],
				[Publ_Cli_Mail],
				[Publ_Cli_Dom_Calle],
				[Publ_Cli_Nro_Calle],
				[Publ_Cli_Piso],
				[Publ_Cli_Depto],
				[Publ_Cli_Cod_Postal],
				NULL,
				(select id from LPB.Usuarios where username=@DocumentoCodigo_Dni+CAST([Publ_Cli_Dni] AS varchar(20)))
FROM [gd_esquema].Maestra
where [Publ_Cli_Dni] IS NOT NULL
UNION
Select DISTINCT [Cli_Dni],
				[Cli_Apeliido],
				[Cli_Nombre],
				[Cli_Fecha_Nac],
				[Cli_Mail],
				[Cli_Dom_Calle],
				[Cli_Nro_Calle],
				[Cli_Piso],
				[Cli_Depto],
				[Cli_Cod_Postal],
				NULL,
				(select id from LPB.Usuarios where username=@DocumentoCodigo_Dni+CAST([Cli_Dni] AS VARCHAR(20)))
FROM [gd_esquema].Maestra
where Cli_Dni is not null
COMMIT;

/*Migracion Factura*/

BEGIN TRANSACTION

INSERT INTO LPB.Facturas (numero, fecha, total, FormaDePago_id)	
SELECT DISTINCT [Factura_Nro],
	            [Factura_Fecha],
				[Factura_Total],
				(SELECT id FROM [LPB].FormasDePago WHERE descripcion=[Forma_Pago_Desc])
FROM [gd_esquema].[Maestra]
WHERE [Factura_Nro] IS NOT NULL

COMMIT;

/* Migracion calificaciones */

BEGIN TRANSACTION

INSERT INTO LPB.Calificaciones(codigo,descripcion, cantEstrellas)	
SELECT DISTINCT [Calificacion_Codigo],
	            [Calificacion_Descripcion],
				(CASE WHEN  [Calificacion_Cant_Estrellas] >5 THEN [Calificacion_Cant_Estrellas] - 5 ELSE [Calificacion_Cant_Estrellas] END )
FROM [gd_esquema].[Maestra]
WHERE [Calificacion_Codigo] IS NOT NULL

COMMIT;

/*TiposDePublicacion*/
BEGIN TRANSACTION
INSERT INTO LPB.tiposDePublicacion (descripcion) VALUES ('Compra Inmediata');
INSERT INTO LPB.tiposDePublicacion (descripcion) VALUES ('Subasta');
COMMIT;

/*EstadosDePublcacion*/
BEGIN TRANSACTION
INSERT INTO LPB.EstadosDePublicacion (descripcion) VALUES ('Finalizada');
INSERT INTO LPB.EstadosDePublicacion (descripcion) VALUES ('Activa');
INSERT INTO LPB.EstadosDePublicacion (descripcion) VALUES ('Publicada');
COMMIT;

/*Rubros*/
BEGIN TRANSACTION
INSERT INTO LPB.Rubros (descripcion)	
SELECT DISTINCT [Publicacion_Rubro_Descripcion]	            
FROM [gd_esquema].[Maestra]
COMMIT;


/*Migracion Visibilidades*/

BEGIN TRANSACTION

INSERT INTO LPB.Visibilidades(codigo,descripcion, precio, porcentaje,comisionPorEnvio)	
SELECT DISTINCT [Publicacion_Visibilidad_Cod],
	            [Publicacion_Visibilidad_Desc],
				[Publicacion_Visibilidad_Precio],
				[Publicacion_Visibilidad_Porcentaje],
				98
FROM [gd_esquema].[Maestra]
WHERE [Publicacion_Visibilidad_Cod] IS NOT NULL

COMMIT;

/*Migracion Publicaciones*/

BEGIN TRANSACTION

INSERT INTO [LPB].[Publicaciones] (
	[codigo]
	,[Usuario_Id]
	,[EstadoDePublicacion_Id]
	,[TipoDePublicacion_Id]	
	,[Descripcion]
	,[Stock]
	,[fechaCreacion]
	,[fechaVencimiento]	
	,[precio]
	,[Visibilidad_codigo]	
	,[Rubro_id] 
	)
SELECT DISTINCT [Publicacion_Cod]
	,[Empresas].[Usuario_Id]
	,1
	,[Tipos].[Id]
	,[Publicacion_Descripcion]	
	,[Publicacion_Stock]
	,[Publicacion_Fecha]
	,[Publicacion_Fecha_Venc]	
	,[Publicacion_Precio]
	,[Publicacion_Visibilidad_Cod]	
	,[Rubros].id  
FROM [gd_esquema].[Maestra] AS Maestra
INNER JOIN [LPB].[TiposDePublicacion] AS Tipos ON Maestra.Publicacion_Tipo = Tipos.Descripcion
INNER JOIN [LPB].[Empresas] AS Empresas ON Maestra.Publ_Empresa_Cuit = Empresas.Cuit
INNER JOIN [LPB].[Rubros] AS Rubros ON Maestra.Publicacion_Rubro_Descripcion = Rubros.descripcion
WHERE [Publicacion_Cod] IS NOT NULL
	AND [Publ_Empresa_Cuit] IS NOT NULL

UNION ALL

SELECT DISTINCT [Publicacion_Cod]
	,[Clientes].[Usuario_Id]
	,1
	,[Tipos].[Id]
	,[Publicacion_Descripcion]	
	,[Publicacion_Stock]
	,[Publicacion_Fecha]
	,[Publicacion_Fecha_Venc]	
	,[Publicacion_Precio]
	,[Publicacion_Visibilidad_Cod]	
	,[Rubros].id  
FROM [gd_esquema].[Maestra] AS Maestra
INNER JOIN [LPB].[TiposDePublicacion] AS Tipos ON Maestra.Publicacion_Tipo = Tipos.Descripcion
INNER JOIN [LPB].[Clientes] AS Clientes ON Maestra.Publ_Cli_Dni = Clientes.dni
INNER JOIN [LPB].[Rubros] AS Rubros ON Maestra.Publicacion_Rubro_Descripcion = Rubros.descripcion
WHERE [Publicacion_Cod] IS NOT NULL
	AND [Publ_Cli_Dni] IS NOT NULL
COMMIT;

/*Migracion Compras*/

BEGIN TRANSACTION

INSERT INTO LPB.Compras (fecha,cantidad,Cliente_id,Publicacion_cod,Calificacion_cod,envio)
select distinct [Compra_Fecha],
				[Compra_Cantidad],
				(select id from LPB.Clientes where dni=Cli_Dni),
				Publicacion_Cod, --MODIFICAR CUANDO SE AGREGA LA TABLA PUBLICACIONES
				Calificacion_codigo,
				0 -- Todas sin envio
from gd_esquema.Maestra
where Compra_Fecha IS NOT NULL
and calificacion_codigo is not null
COMMIT;

/*Migracion Items*/

BEGIN TRANSACTION
INSERT INTO LPB.Items(Publicacion_cod,Factura_nro,monto,cantidad)
	select Publicacion_cod, Factura_Nro, Item_Factura_Monto, Item_Factura_Cantidad 
	from gd_esquema.Maestra 
	where Publicacion_Cod IS NOT NULL and Factura_Nro IS NOT NULL
	ORDER BY PUBLICACION_COD 
COMMIT;
