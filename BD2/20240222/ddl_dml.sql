/*
drop table dependente;
drop table cliente;
drop table produto;
*/
create table cliente(IdClie numeric(9) primary key, NmClie varchar(25) null,UfClie char(2) null, DtNasc date);
--select sysdate from dual;
insert into cliente(IdClie,NmClie,UfClie,DtNasc) values (1,'Vitor','SP','23-FEB-24');
insert into cliente(IdClie,NmClie,UfClie,DtNasc) values (2,'Maria','SP','23-FEB-24');
insert into cliente(IdClie,NmClie,UfClie,DtNasc) values (3,'João','RJ','23-FEB-98');
insert into cliente(IdClie,NmClie,UfClie,DtNasc) values (4,'João','RJ','23-FEB-2098');
--select c.IdClie,c.NmClie,c.UfClie,to_char(c.DtNasc,'YYYY-MM-DD') as DtNasc from cliente c;

--create table dependente(IdDep numeric(9) primary key,NmDep varchar(30),fk_cliente references cliente);
create table dependente(IdDep numeric(9) primary key,NmDep varchar(30),IdClie numeric(9));
alter table dependente add constraint fk_dependente_cliente_IdCli foreign key (IdClie) references cliente(IdClie);

insert into dependente values (1,'Pedro',2);
insert into dependente values (2,'Francisco',2);
insert into dependente values (3,'Manoel',4);
--select IdDep,NmDep,IdClie from dependente;

update cliente set NmClie = 'Vitor Moreira' where IdClie = 1;

create table produto(id_prod numeric(9) primary key, ds_prod varchar(50) null,preco numeric(8,2) null, quant numeric(8,2));
insert into produto(id_prod,ds_prod,preco,quant) values (1,'Pneu',500.00,2.00);
insert into produto(id_prod,ds_prod,preco,quant) values (2,'Multimidia',6500.00,6.00);
insert into produto(id_prod,ds_prod,preco,quant) values (3,'Banco Xz',250.50,4.00);
insert into produto(id_prod,ds_prod,preco,quant) values (4,'Lanterna',160.00,1.00);
--update produto set preco = 0.50 where id_prod = 2;
--update produto set preco = 6500.50,quant = 20 where id_prod = 2;
--select id_prod,ds_prod,preco,quant from produto;

/*Exercicios
Atualize o preço para R$250,00 dos produtos de código 2 e 4;
Atualize a quantidade para zero do produto Banco Xz;
Atualize em 25% o preço do produto Multimidia;*/
update produto set preco = 250.00 where id_prod in (2,4);
update produto set quant = 0 where ds_prod like 'Banco Xz%';
update produto set preco = preco * 1.25 where ds_prod like 'Multimidia%';
