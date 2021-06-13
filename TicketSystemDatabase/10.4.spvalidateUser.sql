CREATE OR ALTER PROC validateUser
@email varchar(50),
@password varchar(100)
AS
BEGIN

SELECT employeeId as employeeId,employeeRole as employeeRole,employeeActive as employeeAccess FROM tbluserDetails(NOLOCK) WHERE employeeEmail=@email AND employeePassword =@password

END