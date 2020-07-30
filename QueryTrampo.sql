-- favor  mudar a string de conexão do banco de dados no Visual Studio

create database db_empresa;
use db_empresa;

create table pedidos
(
idPedido int identity,
prato varchar(45),
bebida varchar(45) primary key,
quantidade char(5),
mesa int,
nomeCliente varchar (45)

)


create table copa
(
idPedido int identity,
Bebida varchar(45),
CONSTRAINT FK_copa FOREIGN KEY (Bebida)
   REFERENCES pedidos(bebida) 
)


insert into pedidos values ('kkkkk','coca',2,34,'heron');
select * from pedidos;