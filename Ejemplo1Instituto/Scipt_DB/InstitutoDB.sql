drop table Carreras
create table Carreras(
Expediente int identity,
Nombre varchar(80) not null,
Modalidad varchar(20),
HorasTotales int,
EstadoDeLaCarrera bit,
primary key (Expediente)
)
drop table Materias
create table Materias(
IdMateria int identity,
Nombre varchar(40),
Horas int,
primary key (IdMateria)
)

drop table CursosConMaterias
create table CursosConMaterias(
IdCurso int,
IdMateria int,
foreign key (IdCurso) references Cursos(IdCurso),
foreign key (IdMateria) references Materias(IdMateria)
)

drop table Cursos
create table Cursos(
IdCurso int identity,
Nombre varchar(20),
ExpedienteCarrera int,
primary key (IdCurso),
foreign key (ExpedienteCarrera) references Carreras(Expediente)
)
alter table Cursos
add Caracteristica varchar(50)


insert into Carreras
Values('Tecnicatura Superior en Análisis, Desarrollo y Programación de Aplicaciones','Presencial',1620,0)

select Expediente, Nombre, Modalidad, HorasTotales , EstadoDeLaCarrera from Carreras 

insert into Materias
Values('Programacion I', 80)

select * from Materias

select * from Carreras

insert into Cursos
Values('1ro Sistemas',1)

select * from Cursos



insert into CursosConMaterias
Values(1,4)

select  M.nombre from Materias M
inner join CursosConMaterias CM
on CM.IdMateria = M.IdMateria 
inner join Cursos C
on C.IdCurso = CM.IdCurso


