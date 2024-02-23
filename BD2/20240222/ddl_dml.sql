--DROP TABLE dependente;
--DROP TABLE cliente;

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