create database GrifindoToys
Use GrifindoToys
create table Logintb(loginid varchar(10) primary key, username varchar(255), upassword varchar(255))
insert into Logintb values ('L001','Admin','Admin@123')
Select * from Logintb

create table Setting_Com(SettingID int identity (201,1) primary key, Salaryrange varchar (255), Absentcount int ,Holidaycount int, overtime int)
select * from Setting_Com
--drop table Settingtb

create table Employeecomponent(EmployeeID int identity (201,1) primary key, Empname varchar (255),DOB datetime, Age int, EmpAddress varchar (255),Phonenumber int , monthlysalary int,overtime int,Allowance int)
--drop table Employeecomponent
select * from Employeecomponent
 
create table SalaryComponent(SalaryID int identity (201,1) primary key, StarDate datetime, EndDate  datetime, NoOfAbsuntdays int, NoOfHolidays int, overtime Float)
select * from SalaryComponent

Create table Calculate(NPayvalue float, GPayvalue float, BPayvalue float)
select * from Calculate
drop table Calculate