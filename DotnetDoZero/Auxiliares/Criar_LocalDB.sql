/*
crate dababase DotNetDoZero
use DotNetDoZero;

create table PRODUTOS(
    ID int Identity primary key,
    NOME varchar(30) not null,
    COR varchar (10)
);

INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 1', 'Azul');
INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 2', 'Vermelho');
INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 3', 'Verde');

INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 4', 'Rosa');

INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 5', 'Marrom');
INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 6', 'Amarelo');
INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 7', 'Roxo');
INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 8', 'Preto');
INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 9', 'Branco');
INSERT INTO PRODUTOS(NOME, COR) VALUEs ('Produto 10', 'Laranja');


DROP TABLE ESTOQUE; 

create TABLE ESTOQUE(
    ID int identity primary key,
    PRODUTO_ID smallint,
    QTDE int
);

INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (1,100);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (2,50);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (3,25);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (4,13);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (5,6);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (7,3);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (6,1);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (8,0);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (9,2);
INSERT INTO ESTOQUE(PRODUTO_ID, QTDE) VALUES (10,4);

select * from PRODUTOS;
select * from ESTOQUE;

UPDATE PRODUTOS SET COR = 'Preto' where NOME = 'Produto 4'; 
select * from PRODUTOS;

delete PRODUTOS where NOME = 'Produto 4'; 
select * from PRODUTOS

insert into ESTOQUE(PRODUTO_ID, QTde) values (100, 2000);
insert into ESTOQUE(PRODUTO_ID, QTde) values (101, 123);

select p.ID, p.Nome, p.COR, e.QTDE from PRODUTOS p 
       INNER JOIN ESTOQUE as "e" on p.id = e.PRODUTO_ID

delete ESTOQUE where ID = 04; 
delete Produtos where ID = 11; 

--  Os campos de identificação da tabela pai, devem ser os mesmos da tabela filho
alter table ESTOQUE add CONSTRAINT FK_PRODUTOS FOREIGN KEY(PRODUTO_ID)
                    REFERENCES PRODUTOS (ID);  

insert into produtos (NOME, COR) VALUES ('Janela', 'Aluninio');
insert into estoque(Produto_id, Qtde) values (13, 2000); 

select * from PRODUTOS;
select * from ESTOQUE;


ALTERAR NOME DE UMA DATAMACE
USE MASTER;
ALTER DATABASE <"OLD NAME">
SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

ALTER DATABASE <"OLD NAME"> MODIFY NAME = <"NEW NAME">;
go

ALTER DATABASE MVCMovieContext
SET MULTI_USER;
GO
*/





