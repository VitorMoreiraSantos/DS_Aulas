/*
drop table item_pedido;

drop table pedido;

drop table cliente;

drop table vendedor;

drop table produto;
*/
create table cliente 
( 
    cod_clie            numeric(4,0) primary key, 
    nome_clie           varchar(20) not null, 
    endereco            varchar(30), 
    cidade              varchar(20), 
    cep                 char(8), 
    uf                  char(2), 
    cnpj                char(16), 
    ie                  char(12) 
);

create table vendedor 
( 
    cod_ven             numeric(4,0) primary key, 
    nome_ven            varchar(20) not null, 
    salario_fixo        numeric(10,2), 
    comissao            char(1) 
);

create table produto 
( 
    cod_prod            numeric(4,0) primary key, 
    unidade             varchar(3), 
    descricao           varchar(20), 
    val_unit            numeric(8,2) 
);

create table pedido 
( 
    num_pedido          numeric(4,0) primary key, 
    pr_entrega          numeric(3,0) not null, 
    cod_clie			numeric(4,0), 
    cod_ven				numeric(4,0) 
);

alter table pedido add constraint fk_pedido_cliente_cod_clie 
    foreign key (cod_clie) references cliente(cod_clie);

alter table pedido add constraint fk_pedido_vendedor_cod_ven 
    foreign key (cod_ven) references vendedor(cod_ven);

create table item_pedido 
( 
    cod_item_ped        numeric(4,0) primary key, 
    quant               numeric(8,2), 
    num_pedido			numeric(4,0), 
    cod_prod			numeric(4,0) 
);

alter table item_pedido add constraint fk_item_pedido_pedido_num_pedido 
    foreign key (num_pedido) references pedido(num_pedido);

alter table item_pedido add constraint fk_item_pedido_produto_cod_prod 
    foreign key (cod_prod) references produto(cod_prod);

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (720, 'Ana', 'Rua 17 n.19', 'Niteroi', '24385310', 'RJ', '11213310000134', '2134');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (870, 'Flavio', 'Av. Pres. Vargas, 10', 'São Paulo', '22769301', 'SP', '2253412693879', '4631');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (110, 'Jorge', 'Rua Caiapó, 13', 'Curitiba', '30078500', 'PR', '1451276498349', null);

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (222, 'Lucia', 'Rua Itabira, 123', 'Belo Horizonte', '22124391', 'MG', '2831512239348', '2985');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (830, 'Mauricio', 'Av. Paulista, 1236', 'São Paulo', '3012683', 'SP', '3281609857465', '9343');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (130, 'Edmar', 'Rua da Praia, s/n', 'Salvador', '30079300', 'BA', '23463284349', '7121');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (410, 'Rodolfo', 'Largo da Lapa, 27', 'Rio de Janeiro', '30078900', 'RJ', '1283512823469', '7431');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (20, 'Beth', 'Av Climério', 'São Paulo', '25679300', 'SP', '3248512673268', '9280');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (157, 'Paulo', 'Trav. Moraes, casa 3', 'Londrina', null, 'PR', '328482233242', '1923');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (180, 'Lívio', 'Av. Beira Mar, 1256', 'Florianópolis', '30077500', 'SC', '1273657123474', '1111');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (260, 'Susana', 'Rua Lopes Mandes, 12', 'Niterói', '30046500', 'RJ', '217635712329', '2530');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (290, 'Renato', 'Rua Meireles, 123', 'São Paulo', '30225900', 'SP', '1327657112314', '1820');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (390, 'Sebastião', 'Rua da Igreja, 10', 'Uberaba', '30438700', 'MG', '321765472133', '9071');

insert into cliente (cod_clie, nome_clie, endereco, cidade, cep, uf, cnpj, ie) values (234, 'José', 'Quadra 3, Bl. 3, sl. 1003', 'Brasília', '22841650', 'DF', '2176357612323', '2931');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (209,'José',1800,'C');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (111,'Carlos',2490,'A');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (11,'João',2780,'C');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (240,'Antônio',9500,'C');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (720,'Felipe',4600,'A');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (213,'Jonas',2300,'A');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (101,'João',2650,'C');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (310,'Josias',870,'B');

insert into vendedor(cod_ven,nome_ven,salario_fixo,comissao) values (250,'Maurício',2930,'B');

insert into produto(cod_prod,unidade,descricao,val_unit) values (25,'KG','Queijo',0.97);

insert into produto(cod_prod,unidade,descricao,val_unit) values (31,'BAR','Chocolate',0.87);

insert into produto(cod_prod,unidade,descricao,val_unit) values (78,'L','Vinho',2.00);

insert into produto(cod_prod,unidade,descricao,val_unit) values (22,'M','Linho',0.11);

insert into produto(cod_prod,unidade,descricao,val_unit) values (30,'SAC','Açucar',0.30);

insert into produto(cod_prod,unidade,descricao,val_unit) values (53,'M','Linha',1.80);

insert into produto(cod_prod,unidade,descricao,val_unit) values (13,'G','Ouro',6.18);

insert into produto(cod_prod,unidade,descricao,val_unit) values (45,'M','Madeira',0.25);

insert into produto(cod_prod,unidade,descricao,val_unit) values (87,'M','Cano',1.97);

insert into produto(cod_prod,unidade,descricao,val_unit) values (77,'M','Papel',1.05);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (121,20,410,209);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (97,20,720,101);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (101,15,720,101);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (137,20,720,720);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (148,20,720,101);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (189,15,870,213);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (104,30,110,101);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (203,30,830,250);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (98,20,410,209);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (143,30,20,111);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (105,30,180,240);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (111,15,260,240);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (103,20,260,11);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (91,20,260,11);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (138,20,260,11);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (108,15,290,310);

insert into pedido(num_pedido,pr_entrega,cod_clie,cod_ven) values (127,10,410,11);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (1,121,25,10);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (2,121,31,35);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (3,97,77,20);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (4,101,31,9);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (5,101,78,18);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (6,101,13,5);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (7,98,77,5);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (8,148,45,8);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (9,148,31,7);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (10,148,77,3);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (11,148,25,10);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (12,148,78,45);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (13,104,53,32);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (14,203,31,6);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (15,189,78,45);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (16,143,31,20);

insert into item_pedido(cod_item_ped,num_pedido,cod_prod,quant) values (17,143,78,10);

/*Mostre o conteúdo das tabelas:*/
/*Vendedor:*/
select * from vendedor;
/*Pedido:*/
select * from pedido;
/*Produto:*/
select * from produto;
/*Item do pedido:*/
select * from item_pedido;

/*Crie um relatório que mostre os vendedores (nome) com seu salário*/
select nome_ven,salario_fixo from vendedor;

/*Mostre os dados dos produto com código menor que 132*/
select * from produto where cod_prod < 132;

/*Quem são os clientes de código: 130, 290 e 234.*/
select * from cliente where cod_clie in (130,290,234);

/*Mostre os pedidos realizados pelo vendedor de código: 250*/
select * from pedido where cod_ven = 250;

/*Mostre os produtos do pedido: 104*/
select p.* from produto p inner join item_pedido ip on ip.cod_prod = p.cod_prod where ip.num_pedido = 104;

/*Exiba o nome do cliente com código superior a 100 e que não more em São Paulo.*/
select nome_clie from cliente where cod_clie > 100 and cidade <> 'São Paulo';

/*Quais vendedores estão na categoria B com salário menor que R$2.500,00.*/
select * from vendedor where comissao = 'B' and salario_fixo < 2500;

/*Mostre os pedidos com seus produtos, classificados pelo código do pedido e pelo código do produto.*/
select * from produto p inner join item_pedido ip on ip.cod_prod = p.cod_prod order by ip.num_pedido asc, p.cod_prod asc;
