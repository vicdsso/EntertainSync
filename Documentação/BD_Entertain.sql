CREATE DATABASE BD_Entertain;

USE BD_Entertain;

CREATE TABLE Adicionar (
    id INT NOT NULL IDENTITY(1,1),
    titulo VARCHAR(100) NOT NULL,
    link VARCHAR(100),
    LinkImagem VARCHAR(MAX) NOT NULL,  
	categoria varchar(10) not null,
    CONSTRAINT pk_publicacao PRIMARY KEY (id)
);

select * from Adicionar

drop table Adicionar


