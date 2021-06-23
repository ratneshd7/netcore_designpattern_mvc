alter table [dbo].[Employee] add DepartmentId int;
alter table [dbo].[Employee] add CONSTRAINT DepartmentId FOREIGN KEY (DepartmentId) REFERENCES [dbo].[Department](Id); 
select * from [dbo].[Employee]

insert into [dbo].[Department] values(1,'HR');
insert into [dbo].[Department] values(2,'CS')
insert into [dbo].[Department] values(3,'IT')
insert into [dbo].[Department] values(4,'DevOps')

insert into [dbo].[Employee] values(1,'Ratnesh','Male','Pune',50000,4);
insert into [dbo].[Employee] values(2,'Onkar','Male','Mumbai',40000,2);
insert into [dbo].[Employee] values(3,'Neha','Female','Banglore',45000,1);
insert into [dbo].[Employee] values(4,'Hiren','Male','Pune',50000,4);
insert into [dbo].[Employee] values(5,'Ravi','Male','Thane',30000,3);
insert into [dbo].[Employee] values(6,'Nelson','Male','London',50000,1);