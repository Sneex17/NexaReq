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