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
DROP TABLE Cliente;

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
  ci varchar(15) not null,
  nombres varchar(100)not null,
  apellidos varchar(100)not null,
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

CREATE TABLE Venta(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCliente int not null,
  idEmpleado int not null,
  razonSocial varchar(100) NOT NULL,
  CONSTRAINT fk_venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
  CONSTRAINT fk_venta_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
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
  idPlatillo INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_VentaDetalle FOREIGN KEY (idVenta) REFERENCES Venta(id),
  CONSTRAINT fk_PlatilloDetalle FOREIGN KEY (idPlatillo) REFERENCES Platillo(id)
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


create PROC paPlatilloListar @parametro VARCHAR(100)
AS
  SELECT * FROM Platillo
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
alter PROC paClienteListar @parametro VARCHAR(100)
AS
  SELECT * FROM Cliente
  WHERE estado<>-1 and ci+nombres+apellidos LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY estado desc, nombres asc;
GO

alter proc paVentaListar @parametro varchar(100)
as
 select*from Venta
 where estado <>-1 and razonSocial like '%'+REPLACE(@parametro, ' ', '%')+'%'
 order by estado desc;
 go

create proc paVentaDetalleListar @parametro varchar(100)
as
 select*from VentaDetalle
 where estado <>-1
 order by estado desc;
 go

 exec paClienteListar '';
EXEC paPlatillosListar '';
EXEC paEmpleadoListar '';
exec paVentaListar '';
exec paVentaDetalleListar '';

INSERT INTO Platillo(codigo, nombre, precio)
VALUES ('AL001', 'Picante de Pollo',15);

INSERT INTO Platillo(codigo, nombre, precio)
VALUES ('CA002', 'Majadito',15);

INSERT INTO Platillo(codigo, nombre, precio)
VALUES ('PO003', 'Parrillada', 20);

INSERT INTO Platillo(codigo, nombre, precio)
VALUES ('VE004', 'Mondongo', 25);

insert into Cliente(ci,nombres,apellidos,celular)
values('862465','mena','torrico',87656)

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123457', 'Alex', 'Arias', 'L�pez', 'Calle Loa 50', 16767676, 'Limpieza');

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123456', 'Juan', 'Perez', 'Lopez', 'Calle Loa 50', 76767676, 'Cajero');

INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES (1, 'jperez', 'i0hcoO/nssY6WOs9pOp5Xw==');

UPDATE Usuario SET clave='i0hcoO/nssY6WOs9pOp5Xw==' WHERE id=1;
insert into Venta(idCliente,idEmpleado,razonSocial)
values(1,1,'venda medio dia')
insert into VentaDetalle(idVenta,idPlatillo,cantidad,precioUnitario,total)
values(1,1,1,10,10)
select*from Venta;
select*from VentaDetalle;
SELECT * FROM Platillo;
select*from Cliente;
select*from Empleado;
SELECT * FROM Usuario;
