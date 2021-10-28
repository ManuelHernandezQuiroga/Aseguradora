CREATE DATABASE MHernandezAseguradora
USE MHernandezAseguradora

CREATE TABLE [Usuario](
	IdUsuario INT PRIMARY KEY IDENTITY(1,1),
	UserName VARCHAR(50) NOT NULL UNIQUE,
	Nombre VARCHAR(50) NOT NULL,
	ApellidoPaterno VARCHAR(50) NOT NULL,
	ApellidoMaterno VARCHAR(50) NULL,
	Email VARCHAR(254) NOT NULL UNIQUE,
	Sexo CHAR(2) NOT NULL,
	Telefono VARCHAR(20) NOT NULL,
	Celular VARCHAR(20) NULL,
	FechaNacimiento DATE NULL,
	CURP VARCHAR(50) NULL
)

GO

ALTER PROCEDURE [UsuarioAdd](
	@UserName VARCHAR(50),
	@Nombre VARCHAR(50),
	@ApellidoPaterno VARCHAR(50),
	@ApellidoMaterno VARCHAR(50),
	@Email VARCHAR(254),
	@Sexo VARCHAR(2),
	@Telefono VARCHAR(20),
	@Celular VARCHAR(20),
	@FechaNacimiento VARCHAR(10),
	@CURP VARCHAR(50)
)
AS
	INSERT INTO [Usuario]([UserName],[Nombre],[ApellidoPaterno],[ApellidoMaterno],[Email],[Sexo],
				[Telefono],[Celular],[FechaNacimiento],[CURP])
	VALUES(@UserName,@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Email,@Sexo,@Telefono,@Celular,CONVERT (DATE,@FechaNacimiento,105),@CURP)
GO
exec [UsuarioAdd] 'Nosaj','Jason','Cerecedo','Ordoñez','nosajorce@gmail.com','M',9750555,2229042845,'','HEQM980703HMCRRN07'
select * from Usuario
GO

ALTER PROCEDURE [UsuarioUpDate]
	@IdUsuario INT,
	@UserName VARCHAR(50),
	@Nombre VARCHAR(50),
	@ApellidoPaterno VARCHAR(50),
	@ApellidoMaterno VARCHAR(50),
	@Email VARCHAR(254),
	@Sexo CHAR(2),
	@Telefono VARCHAR(20),
	@Celular VARCHAR(20),
	@FechaNacimiento VARCHAR(10),
	@CURP VARCHAR(50)

AS
BEGIN
	UPDATE[Usuario]
	SET
	[UserName]=@UserName, [Nombre]= @Nombre,
	[ApellidoPaterno]=@ApellidoPaterno, [ApellidoMaterno]=@ApellidoMaterno,
	[Email]=@Email, [Sexo]=@Sexo, [Telefono]=@Telefono, [Celular]=@Celular,
	[FechaNacimiento]=CONVERT (DATE,@FechaNacimiento,105), [CURP]=@CURP

	WHERE ([IdUsuario] = @IdUsuario)
END;
GO
exec [UsuarioUpDate] 1,'Mane','Manuel','Quiroga','','mhernandez@digis01.com','M',9705555,2216624829,'07/03/1998',''
GO


CREATE PROCEDURE [UsuarioDelete]
	@IdUsuario int

AS
BEGIN
		DELETE FROM [Usuario]

		WHERE ([IdUsuario] = @IdUsuario)
		
END;
exec UsuarioDelete 6
GO
CREATE PROCEDURE [UsuarioGetAll]
		AS
		BEGIN 
			SELECT 
				[IdUsuario],
				[UserName],
				[Nombre],
				[ApellidoPaterno],
				[ApellidoMaterno],
				[Email],
				[Sexo],
				[Telefono],
				[Celular],
				CONVERT (DATE,[FechaNacimiento],105),
				[CURP]
			FROM [Usuario]
		END;

		exec UsuarioGetAll
GO

CREATE PROCEDURE [UsuarioGetById]
		@IdUsuario INT
AS
	BEGIN 
		SELECT
				[IdUsuario],
				[UserName],
				[Nombre],
				[ApellidoPaterno],
				[ApellidoMaterno],
				[Email],
				[Sexo],
				[Telefono],
				[Celular],
				[FechaNacimiento],
				[CURP]
		FROM [Usuario]
		WHERE [IdUsuario] = @IdUsuario
		END;
GO
[UsuarioGetById] 3


CREATE TABLE [Aseguradora](
	IdAseguradora INT PRIMARY KEY IDENTITY (1,1),
	Nombre VARCHAR(50) NOT NULL,
	FechaCreacion DATETIME NOT NULL,
	FechaModificacion DATETIME NOT NULL,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
)
GO

ALTER PROCEDURE AseguradoraAdd(
	@Nombre VARCHAR(50),
	@IdUsuario INT
)
AS
	INSERT INTO Aseguradora(Nombre,FechaCreacion,FechaModificacion,IdUsuario)
	VALUES (@Nombre,GETDATE(),GETDATE(),@IdUsuario)

AseguradoraAdd 'GNP',13
select * from Aseguradora
GO

ALTER PROCEDURE [AseguradoraUpdate](
	@IdAseguradora INT,
	@Nombre VARCHAR(50),
	@IdUsuario INT
)
AS
	UPDATE Aseguradora
	SET
	[Nombre]=@Nombre,
	[FechaModificacion]=GETDATE(),
	[IdUsuario]=@IdUsuario

	WHERE ([IdAseguradora]=@IdAseguradora)
AseguradoraUpdate 3,'MetLife MX',13
GO

ALTER PROCEDURE [AseguradoraDelete](
	@IdAseguradora INT
)
AS
	DELETE FROM Aseguradora
	WHERE ([IdAseguradora]=@IdAseguradora)
GO
AseguradoraDelete 4