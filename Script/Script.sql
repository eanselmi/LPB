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
TipoUsuario_id INT NOT NULL,
username VARCHAR(45) NOT NULL,
pass VARCHAR(100) NOT NULL,
habilitado BIT DEFAULT 1,
cantIntentosFallidos INT DEFAULT 0,
nuevo BIT DEFAULT 1,
PRIMARY KEY(id));


CREATE TABLE [LPB].TiposDeUsuario(
id INT NOT NULL IDENTITY(1,1),
descripcion VARCHAR(14) NOT NULL,
PRIMARY KEY(id));


CREATE TABLE [LPB].RolesxUsuarios(
Roles_id INT NOT NULL,
Usuarios_id INT NOT NULL,
PRIMARY KEY(Roles_id, Usuarios_id));


CREATE TABLE [LPB].Roles(
id INT NOT NULL IDENTITY(1,1),
nombre VARCHAR(45) NOT NULL,
habilitado BIT DEFAULT 1,
PRIMARY KEY(id));

CREATE TABLE [LPB].Funcionalidades(
id INT NOT NULL IDENTITY(1,1),
descripcion varchar(45) NOT NULL,
PRIMARY KEY(id));


CREATE TABLE [LPB].FuncionalidadesxRoles(
Funcionalidades_id INT NOT NULL,
Roles_id INT NOT NULL,
PRIMARY KEY(Funcionalidades_id, Roles_id));



/*---------Definiciones de FK-------*/


ALTER TABLE LPB.usuarios ADD
            FOREIGN KEY (TipoUsuario_id) references LPB.TiposDeUsuario;            
                                
ALTER TABLE LPB.RolesxUsuarios ADD
            FOREIGN KEY (Roles_id) references LPB.Roles,
            FOREIGN KEY (Usuarios_id) references LPB.Usuarios;
                                                            
ALTER TABLE LPB.FuncionalidadesxRoles ADD
            FOREIGN KEY (Funcionalidades_id) references LPB.Funcionalidades,
            FOREIGN KEY (Roles_id) references LPB.roles;
                                

/*---------Carga de datos / migracion--------------------*/


/*Tipos de usuario*/
BEGIN TRANSACTION
INSERT INTO LPB.TiposDeUsuario (descripcion) VALUES ('Administrador');
INSERT INTO LPB.TiposDeUsuario (descripcion) VALUES ('Cliente');
INSERT INTO LPB.TiposDeUsuario (descripcion) VALUES ('Empresa');
COMMIT;


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
GO
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
INSERT INTO LPB.Usuarios (TipoUsuario_id, username, pass, nuevo) VALUES(1,'admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0);
COMMIT;


/*Roles Por Usuario*/
BEGIN TRANSACTION
INSERT INTO LPB.RolesxUsuarios(Roles_id, Usuarios_id) VALUES (1,1);
COMMIT;