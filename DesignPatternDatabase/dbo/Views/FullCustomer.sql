CREATE VIEW [dbo].[FullCustomer]
	AS 
	SELECT [c].[Id] as CustomerId, [c].[FirstName], [c].[MiddleName], 
	[c].[LastName], [a].[Id] as AddressId, [a].[StreetAddress], [a].[City], [a].[State], [a].[ZipCode]
	FROM dbo.Customer c
	left join dbo.Address a 
	 on c.Id = a.CustomerId
