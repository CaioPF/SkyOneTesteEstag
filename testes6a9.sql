#Resolução do Teste6 abaixo
create database dblancamentodenotas;

use dblancamentodenotas;

create table aluno (
id int auto_increment,
aluno varchar(50),
nota1 decimal(4,2),
nota2 decimal(4,2),
ano int,
media decimal(4,2) generated always as ((nota1 + nota2) / 2) stored,
primary key (id)
);

#Resolução do Teste7 abaixo
insert into aluno (aluno, nota1, nota2, ano)
values
('João', 5, 10, 2022);

insert into aluno (aluno, nota1, nota2, ano)
values
('João', 7, 5, 2023);

insert into aluno (aluno, nota1, nota2, ano)
values
('Carlos', 3, 7, 2022);

insert into aluno (aluno, nota1, nota2, ano)
values
('João', 2, 10, 2023);

insert into aluno (aluno, nota1, nota2, ano)
values
('Vinicius', 4.5, 6, 2022);

insert into aluno (aluno, nota1, nota2, ano)
values
('Vinicius', 3.1, 7.7, 2022);

#Resolução do Teste8 abaixo
alter table aluno
add Status varchar(10) generated always as (case when media >= 6.5 then 'Aprovado' else 'Reprovado' end) stored;

select id as ' ',
aluno as 'Nome do Aluno',
nota1 as 'Nota do Primeiro Semestre',
nota2 as 'Nota do Segundo Semestre',
media as 'Média Anual',
ano as 'Ano',
Status
from aluno;

#Resolução do Teste9 abaixo
select id as ' ',
aluno as 'Nome do Aluno',
nota1 as 'Nota do Primeiro Semestre',
nota2 as 'Nota do Segundo Semestre',
media as 'Média Anual',
ano as 'Ano',
Status
from aluno
where Status = 'Aprovado';