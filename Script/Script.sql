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
/*---------Definiciones de FK-------*/


ALTER TABLE LPB.RolesxUsuarios ADD
            FOREIGN KEY (Roles_id) references LPB.Roles,
            FOREIGN KEY (Usuarios_id) references LPB.Usuarios;
GO
                                                            
ALTER TABLE LPB.FuncionalidadesxRoles ADD
            FOREIGN KEY (Funcionalidades_id) references LPB.Funcionalidades,
            FOREIGN KEY (Roles_id) references LPB.roles;
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


/*creacion Usuarios -HASH del password w23e: 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0dc9be7'*/
BEGIN TRANSACTION
INSERT INTO LPB.Usuarios (TipoUsuario, username, pass, nuevo) VALUES('Administrador','admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0);
COMMIT;

/* Migracion Usuarios */

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


/* Migracion de RolesxUsuario de los usuarios migrados en el paso anterior */
INSERT INTO LPB.RolesxUsuarios (Usuarios_id, Roles_id)
SELECT Id, CASE [TipoUsuario]
		        WHEN @TipoDeUsuario_Administrador THEN @RolId_Administrador
		        WHEN @TipoDeUsuario_Empresa THEN @RolId_Empresa
		        WHEN @TipoDeUsuario_Cliente THEN @RolId_Cliente
	       END
FROM LPB.Usuarios