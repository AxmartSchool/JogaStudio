--create database jogastudio;
--use jogastudio;

--create table tagok(
--id int primary key identity, 
--nev varchar(50),
--mester bit);

--create table pozok(
--id int primary key identity, 
--nev varchar(50));


--create table beosztas(
--id int primary key identity, 
--idopont datetime,
--instruktor int foreign key references tagok(id),
--diakok varchar(50) null,
--tananyag int foreign key references pozok(id)
--);