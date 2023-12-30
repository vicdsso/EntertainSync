use[BD_Entertain]
 
 drop table Adicionar

 
create table Adicionar(
	id int not null identity(1,1),
	titulo varchar(100) not null,
	link varchar(100),
	
	constraint pk_publicacao primary key (id)
);




