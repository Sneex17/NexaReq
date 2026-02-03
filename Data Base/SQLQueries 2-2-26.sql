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
select * from Cargos

--empleados
INSERT INTO Empleados (Nombre, IdDepartamento, IdCargo, Correo, FechaIngreso)
VALUES
('Juan Carlos Pérez', 1, 2, 'juan.perez@sistema.com', '2026-02-01'),
('María Fernanda Gómez', 2, 3, 'maria.gomez@sistema.com', '2026-02-01'),
('Luis Alberto Rodríguez', 3, 4, 'luis.rodriguez@sistema.com', '2026-02-01'),
('Ana Carolina Martínez', 1, 3, 'ana.martinez@sistema.com', '2026-02-01'),
('Pedro Antonio Sánchez', 2, 4, 'pedro.sanchez@sistema.com', '2026-02-01'),
('Laura Isabel Ramírez', 3, 2, 'laura.ramirez@sistema.com', '2026-02-01'),
('José Manuel Castillo', 1, 4, 'jose.castillo@sistema.com', '2026-02-01'),
('Diana Paola Núñez', 2, 2, 'diana.nunez@sistema.com', '2026-02-01'),
('Carlos Eduardo Mejía', 3, 3, 'carlos.mejia@sistema.com', '2026-02-01'),
('Rosa Elena Vargas', 1, 2, 'rosa.vargas@sistema.com', '2026-02-01'),

('Miguel Ángel Herrera', 2, 3, 'miguel.herrera@sistema.com', '2026-02-02'),
('Patricia Lorena Cruz', 3, 4, 'patricia.cruz@sistema.com', '2026-02-02'),
('Andrés Felipe Morales', 1, 3, 'andres.morales@sistema.com', '2026-02-02'),
('Karla Vanessa Peña', 2, 4, 'karla.pena@sistema.com', '2026-02-02'),
('Ricardo José Torres', 3, 2, 'ricardo.torres@sistema.com', '2026-02-02'),
('Natalia Sofía Jiménez', 1, 4, 'natalia.jimenez@sistema.com', '2026-02-02'),
('Fernando Luis Ortiz', 2, 2, 'fernando.ortiz@sistema.com', '2026-02-02'),
('Gabriela Alejandra Reyes', 3, 3, 'gabriela.reyes@sistema.com', '2026-02-02'),
('Óscar Daniel Cabrera', 1, 2, 'oscar.cabrera@sistema.com', '2026-02-02'),
('Paola Cristina Molina', 2, 3, 'paola.molina@sistema.com', '2026-02-02'),

('Héctor Rafael Aquino', 3, 4, 'hector.aquino@sistema.com', '2026-02-03'),
('Yessica Maribel Paredes', 1, 3, 'yessica.paredes@sistema.com', '2026-02-03'),
('Kevin Alejandro Rivas', 2, 4, 'kevin.rivas@sistema.com', '2026-02-03'),
('Daniela Lisbeth Santana', 3, 2, 'daniela.santana@sistema.com', '2026-02-03'),
('Francisco Javier León', 1, 4, 'francisco.leon@sistema.com', '2026-02-03'),
('Melissa Andrea Valdez', 2, 2, 'melissa.valdez@sistema.com', '2026-02-03'),
('Jonathan Enrique Guzmán', 3, 3, 'jonathan.guzman@sistema.com', '2026-02-03'),
('Cynthia Michelle Soto', 1, 2, 'cynthia.soto@sistema.com', '2026-02-03'),
('Ángel David Polanco', 2, 3, 'angel.polanco@sistema.com', '2026-02-03'),
('Rocío Estefanía Méndez', 3, 4, 'rocio.mendez@sistema.com', '2026-02-03'),

('Eduardo Ramón De León', 1, 3, 'eduardo.deleon@sistema.com', '2026-02-04'),
('Lina Maritza Rosario', 2, 4, 'lina.rosario@sistema.com', '2026-02-04'),
('Wilmer José Batista', 3, 2, 'wilmer.batista@sistema.com', '2026-02-04'),
('Sandra Milagros Peralta', 1, 4, 'sandra.peralta@sistema.com', '2026-02-04'),
('Raúl Esteban Cuevas', 2, 2, 'raul.cuevas@sistema.com', '2026-02-04'),
('Marcos Antonio Lora', 3, 3, 'marcos.lora@sistema.com', '2026-02-04'),
('Yesenia Karina Taveras', 1, 2, 'yesenia.taveras@sistema.com', '2026-02-04'),
('Brayan Joel Familia', 2, 3, 'brayan.familia@sistema.com', '2026-02-04'),
('Nathaly Judith Peña', 3, 4, 'nathaly.pena@sistema.com', '2026-02-04'),
('Roberto Emilio Suero', 1, 3, 'roberto.suero@sistema.com', '2026-02-04');


select * from Empleados

create view ListaEmpleados
with schemabinding
as
select e.IdEmpleado, e.Nombre, d.Departamento, c.Cargo, e.Correo
from dbo.Empleados as e
inner join dbo.Cargos as c on e.IdCargo = c.IdCargo
inner join dbo.Departamentos as d on e.IdDepartamento = d.IdDepartamento

create proc pa_VerTablaEmpleados
as
begin
select * from ListaEmpleados
end 
go
-- tabla de productos y categoria
create table Categorias(
IdCategoria int primary key identity,
Categoria varchar(50) not null

)


create table Productos(
IdProducto int primary key identity,
Producto varchar(50) not null unique,
IdCategoria int not null,
Precio decimal(10,2) not null,
ITBS decimal(10,2) not null,
constraint FK_CategoriaProducto foreign key (IdCategoria) references Categorias(IdCategoria)
)
go

INSERT INTO Categorias (Categoria) VALUES
('Tecnología'),
('Papelería'),
('Limpieza'),
('Alimentos y Bebidas'),
('Servicios Profesionales'),
('Mantenimiento'),
('Publicidad y Marketing'),
('Transporte'),
('Seguridad'),
('Salud y Bienestar');

select * from Categorias
go

INSERT INTO Productos (Producto, IdCategoria, Precio, ITBS) VALUES
-- Tecnología (18%)
('Laptop Empresarial', 1, 55000.00, 55000.00 * 0.18),
('Impresora Multifuncional', 1, 18000.00, 18000.00 * 0.18),
('Licencia Microsoft Office', 1, 7500.00, 7500.00 * 0.18),

-- Papelería (18%)
('Resma de Papel A4', 2, 350.00, 350.00 * 0.18),
('Bolígrafos Corporativos', 2, 120.00, 120.00 * 0.18),
('Carpetas Archivadoras', 2, 250.00, 250.00 * 0.18),

-- Limpieza (18%)
('Detergente Industrial', 3, 950.00, 950.00 * 0.18),
('Servicio de Limpieza Mensual', 3, 12000.00, 12000.00 * 0.18),
('Desinfectante Multiuso', 3, 600.00, 600.00 * 0.18),

-- Alimentos y Bebidas (16%)
('Café para Oficina', 4, 850.00, 850.00 * 0.16),
('Botellones de Agua', 4, 400.00, 400.00 * 0.16),
('Snack Empresarial', 4, 300.00, 300.00 * 0.16),

-- Servicios Profesionales (16%)
('Servicio Contable', 5, 15000.00, 15000.00 * 0.16),
('Asesoría Legal', 5, 20000.00, 20000.00 * 0.16),
('Consultoría Empresarial', 5, 25000.00, 25000.00 * 0.16),

-- Mantenimiento (18%)
('Mantenimiento de Aire Acondicionado', 6, 5000.00, 5000.00 * 0.18),
('Reparación Eléctrica', 6, 3500.00, 3500.00 * 0.18),
('Mantenimiento de Equipos', 6, 8000.00, 8000.00 * 0.18),

-- Publicidad y Marketing (18%)
('Diseño de Logo', 7, 10000.00, 10000.00 * 0.18),
('Gestión de Redes Sociales', 7, 15000.00, 15000.00 * 0.18),
('Impresión de Banners', 7, 6000.00, 6000.00 * 0.18),

-- Transporte (16%)
('Servicio de Mensajería', 8, 1200.00, 1200.00 * 0.16),
('Transporte Corporativo', 8, 18000.00, 18000.00 * 0.16),
('Alquiler de Vehículo', 8, 25000.00, 25000.00 * 0.16),

-- Seguridad (18%)
('Servicio de Vigilancia', 9, 30000.00, 30000.00 * 0.18),
('Cámaras de Seguridad', 9, 22000.00, 22000.00 * 0.18),
('Sistema de Control de Acceso', 9, 18000.00, 18000.00 * 0.18),

-- Salud y Bienestar (16%)
('Botiquín Empresarial', 10, 4500.00, 4500.00 * 0.16),
('Chequeo Médico Ocupacional', 10, 7000.00, 7000.00 * 0.16),
('Servicio de Fumigación', 10, 9000.00, 9000.00 * 0.16);
go

select * from Productos


alter view ListaProductos
with schemabinding
as
select p.IdProducto, p.Producto, c.Categoria, p.Precio, p.ITBIS
from dbo.Productos as p
inner join dbo.Categorias as c on p.IdCategoria = c.IdCategoria
go

create proc pa_VerTablaProductos
as
begin
select * from ListaProductos
end 
go

select * from pa_VerTablaProductos
go
use GestionNexaReqDB
select * from sys.procedures


