
create table Carreras(
Expediente int identity,
Nombre varchar(80) not null,
Modalidad varchar(20),
HorasTotales int,
EstadoDeLaCarrera bit,
primary key (Expediente)
)

create table Materias(
IdMateria int identity,
Nombre varchar(40),
Horas int,
primary key (IdMateria)
)



create table Cursos(
IdCurso int identity,
Nombre varchar(20),
ExpedienteCarrera int,
MateriaId int,
primary key (IdCurso),
foreign key (ExpedienteCarrera) references Carreras (Expediente),
foreign key (MateriaId) references Materias(IdMateria)
)

insert into Carreras
Values('Tecnicatura Superior en Administración Contable','Presencial',1620,0)

select Expediente, Nombre, Modalidad, HorasTotales , EstadoDeLaCarrera from Carreras 

insert into Materias
Values('EDI-UX')

select * from Materias


