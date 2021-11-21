create database 3C1FAEL43;
use 3C1FAEL43;
create table tbl_entrar(
	id int not null auto_increment primary key,
    email varchar(50),
    senha varchar(6)
)engine = InnoDB;
insert into tbl_entrar (id, email, senha) values	(null, 'email', 'senha');

create table Estoque(
	id int not null auto_increment primary key,
    Produto varchar(50),
    Quantidade varchar(6)
)engine = InnoDB;