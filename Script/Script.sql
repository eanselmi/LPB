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

IF OBJECT_ID('LPB.FuncionalidadesxRoles') IS NOT NULL
BEGIN
        DROP TABLE LPB.FuncionalidadesxRoles ;
END;
GO

IF OBJECT_ID('LPB.RolesxUsuarios') IS NOT NULL
BEGIN
        DROP TABLE LPB.RolesxUsuarios ;
END;
GO

IF OBJECT_ID('LPB.Empresa') IS NOT NULL
BEGIN
        DROP TABLE LPB.Empresa ;
END;
GO

IF OBJECT_ID('LPB.Clientes') IS NOT NULL
BEGIN
	DROP TABLE LPB.Clientes;
END;
GO

IF OBJECT_ID('LPB.Usuarios') IS NOT NULL
BEGIN
        DROP TABLE LPB.Usuarios ;
END;
GO

IF OBJECT_ID('LPB.TiposDeUsuario') IS NOT NULL
BEGIN
        DROP TABLE LPB.TiposDeUsuario ;
END;
GO

IF OBJECT_ID('LPB.Roles') IS NOT NULL
BEGIN
        DROP TABLE LPB.Roles ;
END;
GO

IF OBJECT_ID('LPB.Funcionalidades') IS NOT NULL
BEGIN
        DROP TABLE LPB.Funcionalidades ;
END;
GO

IF OBJECT_ID('LPB.Factura') IS NOT NULL
BEGIN
        DROP TABLE LPB.Factura ;
END;
GO

IF OBJECT_ID('LPB.FormaDePago') IS NOT NULL
BEGIN
        DROP TABLE LPB.FormaDePago ;
END;
GO


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

CREATE TABLE [LPB].RolesxUsuarios(
Roles_id INT NOT NULL,
Usuarios_id INT NOT NULL,
PRIMARY KEY(Roles_id, Usuarios_id));
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

CREATE TABLE [LPB].FuncionalidadesxRoles(
Funcionalidades_id INT NOT NULL,
Roles_id INT NOT NULL,
PRIMARY KEY(Funcionalidades_id, Roles_id));
GO

CREATE TABLE [LPB].FormaDePago(
id INT NOT NULL IDENTITY(1,1),
descripcion nvarchar(255) NOT NULL,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].Factura(
id INT NOT NULL IDENTITY(1,1),
numero numeric(18,0) NOT NULL,
fecha DATETIME NOT NULL,
total numeric(18,2) NOT NULL,
FormaDePago_id INT NOT NULL,
PRIMARY KEY(id));
GO

CREATE TABLE [LPB].Empresa(
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
dni INT NOT NULL,
apellido VARCHAR(45) NOT NULL,
nombre VARCHAR(45) NOT NULL,
fechaNacimiento DATETIME NOT NULL,
mail VARCHAR(45) NOT NULL,
domicilioCalle varchar(100) NOT NULL,
nroCalle INT NOT NULL,
piso INT NOT NULL,
dpto VARCHAR(2),
codPostal INT NOT NULL,
fechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
-- A MODIFICAR CUANDO SE AGREGE LA TABLA LOCALIDADES
Localidad_id INT, 
-- .
Usuario_id INT NOT NULL,
PRIMARY KEY(ID));
GO

/*---------Definiciones de FK-------*/


ALTER TABLE LPB.RolesxUsuarios ADD
            FOREIGN KEY (Roles_id) references LPB.Roles,
            FOREIGN KEY (Usuarios_id) references LPB.Usuarios;
GO
                                                            
ALTER TABLE LPB.FuncionalidadesxRoles ADD
            FOREIGN KEY (Funcionalidades_id) references LPB.Funcionalidades,
            FOREIGN KEY (Roles_id) references LPB.roles;
GO   
                                                         
ALTER TABLE LPB.Factura ADD
            FOREIGN KEY (FormaDePago_id) references LPB.FormaDePago
GO


ALTER TABLE LPB.Empresa ADD
            FOREIGN KEY (Usuario_id) references LPB.Usuarios;
			--FOREIGN KEY (Localidad_ID) references LPB.Localidades;
GO

ALTER TABLE LPB.Clientes add
	    FOREIGN KEY (Usuario_ID) references LPB.Usuarios;
	    --FOREIGN KEY (Localidad_ID) references LPB.Localidades;
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
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (1, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (2, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (3, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (4, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (10, @ID);

SET @ID = (SELECT id FROM [LPB].Roles WHERE nombre='Cliente');

INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (5, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (6, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (7, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (8, @ID);

SET @ID = (SELECT id FROM [LPB].Roles WHERE nombre='Empresa');

INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (5, @ID);
INSERT INTO LPB.FuncionalidadesxRoles (Funcionalidades_id, Roles_id) VALUES (9, @ID);

COMMIT;

BEGIN TRANSACTION

INSERT INTO LPB.FormaDePago(descripcion) 
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
INSERT INTO LPB.Empresa (razonSocial, cuit, mail, domicilioCalle, nroCalle, dpto, piso, codPostal, fechaCreacion, Usuario_id)	
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
INSERT INTO LPB.RolesxUsuarios (Usuarios_id, Roles_id)
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
select distinct CAST([Publ_Cli_Dni] AS INT),
				[Publ_Cli_Apeliido],
				[Publ_Cli_Nombre],
				[Publ_Cli_Fecha_Nac],
				[Publ_Cli_Mail],
				[Publ_Cli_Dom_Calle],
				CAST([Publ_Cli_Nro_Calle] AS INT),
				CAST([Publ_Cli_Piso] AS INT),
				[Publ_Cli_Depto],
				[Publ_Cli_Cod_Postal],
				NULL,
				(select id from LPB.Usuarios where username=@DocumentoCodigo_Dni+CAST([Publ_Cli_Dni] AS varchar(20)))
FROM [gd_esquema].Maestra
where [Publ_Cli_Dni] IS NOT NULL
UNION
Select DISTINCT CAST([Cli_Dni] AS INT),
				[Cli_Apeliido],
				[Cli_Nombre],
				[Cli_Fecha_Nac],
				[Cli_Mail],
				[Cli_Dom_Calle],
				CAST([Cli_Nro_Calle] AS INT),
				CAST([Cli_Piso] AS INT),
				[Cli_Depto],
				[Cli_Cod_Postal],
				NULL,
				(select id from LPB.Usuarios where username=@DocumentoCodigo_Dni+CAST([Cli_Dni] AS VARCHAR(20)))
FROM [gd_esquema].Maestra
where Cli_Dni is not null
COMMIT;

BEGIN TRANSACTION

INSERT INTO LPB.Factura (numero, fecha, total, FormaDePago_id)	
SELECT DISTINCT [Factura_Nro],
	            [Factura_Fecha],
				[Factura_Total],
				(SELECT id FROM [LPB].FormaDePago WHERE descripcion=[Forma_Pago_Desc])
FROM [gd_esquema].[Maestra]
WHERE [Factura_Nro] IS NOT NULL

COMMIT;
