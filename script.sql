-- criando banco de dados

create database DBSISTEMA;
drop database DBSISTEMA;
-- usando banco de dados

use DBSISTEMA;

-- criando as tabelas

create table usuario(
Id int primary key,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null
);

insert into usuario values(
1,
"ShadowMilk Cookie",
"shadowmilkcookie@gmail.com",
"gamer1234");

-- consultando os dados do banco

select * from usuario;