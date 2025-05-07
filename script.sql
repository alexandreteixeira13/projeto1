-- criando banco de dados

create database bdExemplo;

-- usando banco de dados

use bdExemplo;

-- criando as tabelas

create table Usuarios(
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null
)

-- consultando os dados do banco

select * from Usuarios;