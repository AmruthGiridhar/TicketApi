create table tbluserDetails(
employeeId int identity(1,1) primary key,
employeeFirstName varchar(50),
employeeLastName varchar(50),
employeeEmail varchar(50),
employeeRole int,
employeePassword varchar(100),
employeeActive bit,
employeeJoinDate datetime,
employeeResignationDate datetime
)
