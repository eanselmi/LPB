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

IF OBJECT_ID('LPB.RolesxUsuarios') IS NOT NULL
BEGIN
        DROP TABLE LPB.RolesxUsuarios ;
END;
GO

IF OBJECT_ID('LPB.FuncionalidadesxRoles') IS NOT NULL
BEGIN
        DROP TABLE LPB.FuncionalidadesxRoles ;
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
pass VARCHAR(45) NOT NULL,
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
id INT NOT NULL,
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
                                

