CREATE DATABASE FinalRestaurant;
GO
USE [master]
GO
CREATE LOGIN [usrrest] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [FinalRestaurant],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [FinalRestaurant]
GO
CREATE USER [usrrest] FOR LOGIN [usrrest]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrrest]
GO

drop database FinalRestaurant
DROP TABLE Platillo;
DROP TABLE Refresco;
DROP TABLE Empleado;
DROP TABLE Usuario;
DROP TABLE Proveedor;
DROP TABLE Insumo;
DROP TABLE Compra;
DROP TABLE CompraDetalle;
DROP TABLE Venta;
DROP TABLE VentaDetalle;
DROP TABLE Cliente;

CREATE TABLE Platillo(
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    codigo VARCHAR(10) NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    precio DECIMAL NOT NULL CHECK (precio>0),
    alertaDisponibilidad DECIMAL NOT NULL DEFAULT 0
);
CREATE TABLE Refresco(
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
  nit varchar(15) not null,
  nombreCompleto varchar(100)not null,
  razonSocial VARCHAR(100) NOT NULL,
  celular bigint not null
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
drop table VentaDetalle;
CREATE TABLE Venta(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCliente int not null,
  tipoServicio varchar(30),
  total decimal NOT NULL,
  efectivo decimal NOT NULL,
  cambio decimal NOT NULL,
  CONSTRAINT fk_venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
);
select * from VentaDetalle;
CREATE TABLE VentaDetalle(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idVenta int not null,
  idPlatillo INT,
  idRefresco INT,
  cantidad int NOT NULL CHECK (cantidad > 0),
  totalVentaDetalle decimal NOT NULL,
  CONSTRAINT fk_Venta_Platillo FOREIGN KEY (idPlatillo) REFERENCES Platillo(id),
  CONSTRAINT fk_Venta FOREIGN KEY (idVenta) REFERENCES Venta(id),
  CONSTRAINT fk_Venta_Refresco FOREIGN KEY (idRefresco) REFERENCES Refresco(id)
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

ALTER TABLE Platillo ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Platillo ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Platillo ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Refresco ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Refresco ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Refresco ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

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
go
select* from Platillo;
alter table Platillo add alertaDisponibilidad decimal not null;
INSERT INTO Refresco(codigo, nombre, precio)
VALUES ('DU003', 'soya',5);

INSERT INTO Platillo(codigo, nombre, precio,alertaDisponibilidad)
VALUES ('CA002', 'Majadito',15,20);

INSERT INTO Platillo(codigo, nombre, precio,alertaDisponibilidad)
VALUES ('PO003', 'Parrillada', 20,20);

INSERT INTO Platillo(codigo, nombre, precio)
VALUES ('VE004', 'Mondongo', 25);

insert into Cliente(nit,nombreCompleto,razonSocial,celular)
values('862465','mena torrico','cliente mensual',87656)

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123457', 'Alex', 'Arias', 'L�pez', 'Calle Loa 50', 16767676, 'Limpieza');

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123456', 'Juan', 'Perez', 'Lopez', 'Calle Loa 50', 76767676, 'Cajero');

INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES (1, 'jperez', 'i0hcoO/nssY6WOs9pOp5Xw==');

UPDATE Usuario SET clave='i0hcoO/nssY6WOs9pOp5Xw==' WHERE id=1;
INSERT INTO Venta(idCliente, tipoServicio)
VALUES (1, 'ALMUERZO ');

select * from Platillo;
insert into VentaDetalle(idVenta,idPlatillo,idRefresco,precioUnitario,cantidad,total,efectivo,cambio)
values(1,1,1,15,2,30,50,20);
SELECT * FROM VentaDetalle;
