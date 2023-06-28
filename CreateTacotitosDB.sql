use TacotitosDB;

create table Taco(
	Id int not null primary key identity,
	Nombre nvarchar(50) not null
	);

	create table Ingrediente(
	Id int not null primary key identity,
	NombreCargo nvarchar (50) not null,
	);

	create table Empleado(
	Id int not null primary key identity,
	Nombre nvarchar(50) not null,
	Apellido nvarchar(50) not null,
	EmpresaId int not null,
	constraint EmpresaFK foreign key (EmpresaId) references Empresa(Id) on delete cascade
	);

create table CargoEmpleado(
	Id int not null primary key identity,
	EmpleadoId int not null,
	CargoId int not null,
	constraint EmpleadoFK foreign key (EmpleadoId) references Empleado(Id) on delete cascade,
	constraint CargoFK foreign key (CargoId) references Cargo(Id) on delete cascade
	);








