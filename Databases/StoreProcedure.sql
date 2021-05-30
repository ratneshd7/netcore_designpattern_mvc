use swabhav
select * from EMP
GO
create procedure selectEmp @empNo int,@percent float
as
 
update EMP
set SAL=SAL+SAL*@percent
where EMPNO = @empNo;

select * from EMP where EMPNO = @empNo;
GO

--DROP PROCEDURE dbo.selectEmp;  


EXEC selectEmp @empNo = 7566,@percent=0.2;