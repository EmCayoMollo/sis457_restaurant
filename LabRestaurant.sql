CREATE DATABASE LabRestaurant;
GO
USE [master]
GO
CREATE LOGIN [usrrest] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [LabRestaurant],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [LabRestaurant]
GO
CREATE USER [usrrest] FOR LOGIN [usrrest]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrrest]
GO

drop database LabRestaurant
DROP TABLE Platillo;
DROP TABLE Empleado;
DROP TABLE Usuario;
DROP TABLE Proveedor;
DROP TABLE Insumo;
DROP TABLE Compra;
DROP TABLE Venta; 
DROP TABLE CompraDetalle;
DROP TABLE VentaDetalle;

CREATE TABLE Platillo(
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    codigo VARCHAR(10) NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    precio DECIMAL NOT NULL CHECK (precio>0)
);

CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL,
  clave VARCHAR(250) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
);

CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL,
  direccion VARCHAR(250) NULL,
  telefono VARCHAR(30) NOT NULL,
  representante VARCHAR(100) NOT NULL
);

CREATE TABLE Cliente(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  ci varchar not null,
  nombreCompleto varchar(100)not null,
  razonSocial VARCHAR(50) not NULL
);

CREATE TABLE Insumo(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  descripcion VARCHAR(100) NOT NULL,
  cantidad int not null,
  precio DECIMAL NOT NULL CHECK (precio>0)
);

CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProveedor INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);

CREATE TABLE Venta(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPlatillos INT NOT NULL,
  transaccion int NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_venta_Platillos FOREIGN KEY(idPlatillos) REFERENCES Platillos(id)
);

CREATE TABLE CompraDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idInsumo INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_CompreDetalle FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle FOREIGN KEY (idInsumo) REFERENCES Insumo(id)
);

CREATE TABLE VentaDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idVenta INT NOT NULL,
  idPlatillos INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_CompresDetalle FOREIGN KEY (idVenta) REFERENCES Venta(id),
  CONSTRAINT fk_ComprasDetalle FOREIGN KEY (idPlatillos) REFERENCES Platillos(id)
);

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Insumo ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Insumo ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Insumo ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE VentaDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE VentaDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE VentaDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Platillos ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Platillos ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Platillos ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

GO


create PROC paPlatillosListar @parametro VARCHAR(100)
AS
  SELECT * FROM Platillos
  WHERE estado<>-1 and codigo+nombre LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY estado desc, nombre asc;
GO
create PROC paEmpleadoListar @parametro VARCHAR(100)
AS
  SELECT e.*,u.usuario
  FROM Empleado e
  LEFT JOIN Usuario u ON e.id = u.idEmpleado
  WHERE e.estado<>-1 
		AND e.cedulaIdentidad+e.nombres+e.primerApellido+e.segundoApellido LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
		order by e.estado desc,nombres asc, primerApellido asc;
GO
create PROC paClienteListar @parametro VARCHAR(100)
AS
  SELECT * FROM Cliente
  WHERE estado<>-1 and ci+nombreCompleto LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY estado desc, nombreCompleto asc;
GO
EXEC paPlatillosListar '';
EXEC paEmpleadoListar '';

INSERT INTO Platillos(codigo, nombre, precio)
VALUES ('AL001', 'Picante de Pollo',15);

INSERT INTO Platillos(codigo, nombre, precio)
VALUES ('CA002', 'Majadito',15);

INSERT INTO Platillos(codigo, nombre, precio)
VALUES ('PO003', 'Parrillada', 20);

INSERT INTO Platillos(codigo, nombre, precio)
VALUES ('VE004', 'Mondongo', 25);

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123457', 'Alex', 'Arias', 'L�pez', 'Calle Loa 50', 16767676, 'Limpieza');

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123456', 'Juan', 'P�rez', 'L�pez', 'Calle Loa 50', 76767676, 'Cajero');

INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES (1, 'jperez', 'i0hcoO/nssY6WOs9pOp5Xw==');

UPDATE Usuario SET clave='i0hcoO/nssY6WOs9pOp5Xw==' WHERE id=1;

SELECT * FROM Platillos;
SELECT * FROM Usuario;
