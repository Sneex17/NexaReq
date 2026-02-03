create database GestionNexaReqDB
go
use  GestionNexaReqDB
go


--tablas de empleados, cargos y departamentos
GO
create table Departamentos(
IdDepartamento int primary key identity not null,
Departamento varchar(30) not null
)

create table Cargos (
IdCargo int primary key identity not null,
Cargo varchar(30) not null,
Salario decimal(10,2) not null
)

create table Empleados(
IdEmpleado int primary key identity not null,
Nombre varchar(100) not null,
IdDepartamento int not null,
IdCargo int not null,
Correo varchar(50) not null,
FechaIngreso date not null

constraint FK_DepartamentoEmpleado foreign key (IdDepartamento) references Departamentos(IdDepartamento),
constraint FK_CargoEmpleado foreign key (IdCargo) references Cargos(IdCargo)
)
GO


insert into Departamentos (Departamento) values 
('Recursos Humanos'),
('Comunicaciones'),
('Tecnología')

insert into Cargos (Cargo, Salario) values
('Gerente', 150000.00),
('Administrador', 130000.00),
('Desarrollador TI', 140000.00)
GO

insert into Empleados (Nombre, IdDepartamento, IdCargo, Correo, FechaIngreso) values
('Jose Miguel', 1,3,'JM-1@sistema.com', GETDATE()),
('Cristal Ramirez', 2,2,'CR-2@sistema.com', GETDATE()),
('Maria Liz', 3,4,'ML-3@sistema.com', GETDATE())
GO


select * from Departamentos
select * from Cargos
select * from Empleados

-- Tablas de usuario y roles
create table Roles(
IdRol int primary key identity,
Rol varchar(30) not null,
)

create table Usuarios(
IdUsuario int primary key identity,
IdEmpleado int not null,
Username varchar(50) not null,
PasswordHash varchar(256) not null,
IdRol int not null,
FechaCreacion date not null,
UltimoAccceso date not null

constraint FK_UsarioEmpleado foreign key (IdEmpleado) references Empleados(IdEmpleado),
constraint FK_UsuarioRol foreign key (IdRol) references Roles(IdRol)
)
GO

select * from Roles
select * from Usuarios
select * from Empleados
insert into Roles(Rol) values 
('Solicitante'),
('Aprobador')
GO
insert into Usuarios(IdEmpleado, Username, PasswordHash, IdRol, FechaCreacion, UltimoAccceso) values
(2, 'abi','sa',1, GETDATE(), GETDATE()),
(3, 'luz','as',2, GETDATE(), GETDATE())
GO

update Usuarios set PasswordHash =
'4cf6829aa93728e8f3c97df913fb1bfa95fe5810e2933a05943f8312a98d9cf2'
where IdUsuario = 1

update Usuarios set PasswordHash =
'f4bf9f7fcbedaba0392f108c59d8f4a38b3838efb64877380171b54475c2ade8'
where IdUsuario = 2

-- procedimientos de usuarios

alter proc pa_ValidacioUsuario
(
@Username varchar(50),
@PasswordHash varchar(256)
)
as
select COUNT(1) from Usuarios where Username = @Username and PasswordHash = @PasswordHash

select * from Departamentos
select * from Empleados