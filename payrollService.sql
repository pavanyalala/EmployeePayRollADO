create database EmployeePayrollADO

Create Table employee_payroll (
Id int not null identity (1,1)primary key,
Name varchar(20),
Gender char (1),
Department varchar(10),
Salary varchar(20),
StartDate varchar(20),
BasicPay float(20),
Deduction float(20),
TaxablePay float(20),
IncomeTax float(20),
NetPay float(20)
)
select * from employee_payroll

insert into employee_payroll (Name, Gender, Department, Salary, StartDate, BasicPay, Deduction, TaxablePay, IncomeTax,NetPay)
values ('Pavan','M','Developer','40000','2020-03-11',40000,5000,3000,2000,35000)
 
Create or Alter procedure spGetAllEmployeeDetails
as 
begin try
select * from employee_payroll
End Try
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_STATE() AS ErrorState,
    ERROR_PROCEDURE() AS ErrorProcedure,
    ERROR_LINE() AS ErrorLine,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH      