use swabhav

create table bankMaster(name varchar(20) primary key,balance float, pwd varchar(20));
select * from bankMaster 
select name from bankMaster where name='Ratnesh';
create table bankTransaction(name varchar(20) foreign key (name) references bankMaster(name), amount float,types char,date date )
 select * from bankTransaction