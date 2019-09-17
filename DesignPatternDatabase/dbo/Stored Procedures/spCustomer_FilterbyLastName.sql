﻿CREATE PROCEDURE [dbo].[spCustomer_FilterbyLastName]
	@LastName nvarchar(50)
AS
begin
	select [Id], [FirstName], [MiddleName], [LastName]
	from dbo.Customer
	where LastName = @LastName
end

