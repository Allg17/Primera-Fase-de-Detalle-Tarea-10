Create database EjemploCLase
go

create table Estudiantes
(
EstudianteId int primary key identity(1,1),
Nombre varchar(30),
Observaciones varchar(MAX),
FechaActual date

);
 
 go
 CREATE TABLE Cargos
 (
 CargoID int primary key identity(1,1),
 Fecha date,
 EstudianteID int,
 Concepto varchar(MAX),
 Monto decimal,
 Balance int
 );
 go
  CREATE TABLE Pagos
 (
 PagosID int primary key identity(1,1),
 Fecha date,
 EstudianteID int,
 Concepto varchar(MAX),
 Monto decimal

 );
 go
  CREATE TABLE PagosCargos
 (
 ID int primary key identity(1,1),
 PagosID int,
 CargoID int ,
 Monto decimal,
 Saldo float
 );
 go

 CREATE TABLE Articulos
 (
 ArticuloID int primary key identity(1,1),
 Descripcion varchar(max),
 Precio money,
 ArticulosCotizados int null
 
 );


 go
 CREATE TABLE Cotizaciones
 (
 ID int primary key identity(1,1),
 Fecha date,
 Comentario varchar(max),
 Monto money
 
 );
truncate table Cotizaciones;

 go
 CREATE TABLE CotizacionesDetalles
 (
 ID int primary key identity(1,1),
 CotizacionesID int,
 ArticuloID int,
 Cantidad int,
 Precio Money
 
 );


