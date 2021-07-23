use BluePrint
drop database TIENDA

CREATE DATABASE TIENDA
GO

USE TIENDA

select nombre from Marcas where ID = 

CREATE TABLE Marcas(
ID int  Primary key identity (1,1) not null,
Nombre varchar (40) not null
)


CREATE TABLE Categorias(
ID int  Primary key identity (1,1) not null,
Nombre varchar (40) not null
)


CREATE TABLE Articulos(
ID int  Primary key identity (1,1) not null,
Nombre varchar (40) not null,
Imagen varchar(300)NULL ,
Descripcion varchar (50) NULL,
Idmarca int  foreign key references Marcas (ID) not null ,
Precio money not null ,
Stock int not null default (0),
Estado bit not null default (1),
Idcategoria int foreign key references Categorias (ID) not null 
)


insert into TipoUsuario values (1, 'Usuario')
insert into TipoUsuario values (2, 'Admin')

CREATE TABLE TipoUsuario(
Tipo smallint primary key not null default (1),
Nombre VARCHAR (30) NOT NULL
)


CREATE TABLE Usuario(
Mail varchar (40) primary key ,
Contraseña varchar (15) not null,
tipo smallint foreign key references TipoUsuario (Tipo)
)


CREATE TABLE DetalleUsuarios(
DNI VARCHAR (8) primary key NOT NULL ,
Mail varchar (40) foreign key references Usuario (Mail),
Nombre VARCHAR (30) NOT NULL,
Direccion VARCHAR (40) NOT NULL,
Telefono VARCHAR (20) NOT NULL,
)
delete from DetalleUsuarios
select * from DetalleUsuarios 

select * from DetalleUsuarios u
inner jo


CREATE TABLE Carrito (
ID int primary key identity (1,1) not null,
DNIpersona varchar(8) NOT NULL FOREIGN KEY REFERENCES DetalleUsuarios (DNI),
total  money not null,
)

CREATE TABLE ProductoXcarrito(
IDcarrito int foreign key references Carrito (ID),
IdArticulo int foreign key references Articulos (ID),
sub_total money default (0) not null,
cantidad int default (0) not null
)

CREATE TABLE DETALLE_COMPRA(
OrdenCompra varchar (10) primary key,
Idarticulo int foreign key references Articulos (ID),
Abonado money not null,
Envio varchar (200) not null,
Estado bit not null default (1),
Fecha date not null,
Dni varchar (8) NOT NULL FOREIGN KEY REFERENCES DetalleUsuarios (DNI),
)

insert into Marcas values ('EVO POTENZA')
insert into Categorias values ('Memorias ram')
Insert into Articulos (Nombre, Imagen, Descripcion,Idmarca,Precio,Stock,Idcategoria)
Values ('Memoria GeiL DDR4 8GB EVO POTENZA RED ', 'https://compragamer.net/pga/imagenes_publicadas/compragamer_Imganen_general_17097_Memoria_GeiL_DDR4_8GB_3000MHz_EVO_POTENZA_RED_469a5a9c-grn.jpg',
' 3000MHz',1 , 5950,2 ,1)

insert into Marcas values ('Gigabyte ')
insert into Categorias values ('Mothers')
Insert into Articulos (Nombre, Imagen, Descripcion,Idmarca,Precio,Stock,Idcategoria)
Values ('Mother Gigabyte H310M-H LGA 1151 ', 'https://compragamer.net/pga/imagenes_publicadas/compragamer_Imganen_general_7715_Mother_Gigabyte_H310M-H_LGA_1151_8va_gen__bdf6e65f-grn.jpg',
' Plataforma Intel, Socket 1151 Coffe Lake,  ',2 , 6000,4 ,2)

insert into Usuario  values ('matiinsa@gmail.com', 'mati', 1 )
insert into Usuario  values ('bareaelian@gmail.com', 'elian', 2 )
select * from Usuario
select Mail, Contraseña, tipo from Usuario where Mail = 'bareaelian@gmail.com' or Contraseña = 'elian'
delete Usuario 

go
create view listar_articulo as 
select a.Descripcion, a.Estado, a.ID, a.Idcategoria,
a.Idmarca, a.Imagen, a.Nombre, a.Precio, a.Stock,
m.Nombre MARCA, c.Nombre CATEGORIA

from Articulos a
inner join Marcas m on m.ID = a.Idmarca
inner join Categorias c on C.ID = a.Idcategoria

select * from Categorias

update Marcas set Nombre ='Ryzen ' where id = 3

update Categorias set Nombre ='Mothers ' where id = 1
update Categorias set Nombre ='Procesador ' where id = 2
update Categorias set Nombre ='Gabinete ' where id = 3
update Categorias set Nombre ='Mouse ' where id = 4
update Categorias set Nombre ='Placa de video ' where id = 5
update Categorias set Nombre ='Memoria ram ' where id = 6

---consutlamos si el mail existe y si existe la contra
select * from Usuario where Mail = 'bareaelian@gmail.com' and Contraseña = 'elian'

go
create procedure Mail_Contra 
(@email varchar (40),
@contra varchar (15)
)
as
select * from 
