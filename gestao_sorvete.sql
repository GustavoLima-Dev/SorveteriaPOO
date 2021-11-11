create database gestao_sorvete;
use gestao_sorvete;

create table sorveteria(
id int not null auto_increment,
nome varchar(100) not null,
endereco varchar (100) not null,
primary key (id)
)engine = innodb;

create table cliente(
id int not null auto_increment,
nome varchar(100) not null,
email varchar (100) not null,
primary key (id)
)engine = innodb;

create table transacao(
id int not null auto_increment,
notafiscal varchar(100) not null,
valor double (9,2) not null,
sorveteria_id int,
cliente_id int,
primary key(id),
foreign key (sorveteria_id) references id(sorveteria),
foreign key (cliente_id) references id(cliente)
)engine = innodb;